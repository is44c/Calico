/*
Calico - Scripting Environment

Copyright (c) 2012, Mark F. Russo <mfrusso@brynmawr.edu>

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.

$Id: $
*/

using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using Cairo;
using Gtk;

//p.DashStyle = this.LineStyle;

// ------------------ Shared Constants -----------------------------------
internal enum EllipseMode
{
	CENTER = 0,
	CORNER = 1,
 	RADIUS = 2,
	CORNERS = 3
}

internal enum RectMode
{
	CENTER = 0,
	CORNER = 1,
	RADIUS = 2,
	CORNERS = 3
}

internal enum ImageMode
{
	CENTER = 0,
	CORNER = 1,
	CORNERS = 2
}

internal enum TextAlign
{
	LEFT = 0,
	CENTER = 1,
	RIGHT = 2
}

internal enum TextYAlign
{
	TOP = 0,
	BOTTOM = 1,
	CENTER = 2,
	BASELINE = 3
}

// -------------------------------------------------------------------------
public static class Processing
{
	private static PWindow _p = null;							// Reference to internal window
	private static Random _rand = new Random();					// Random number generation help
	private static PTimer _tmr = null;
	private static int _guiThreadId = -1;						// Thread id of window. -1 means not assigned
	private static Gdk.Pixbuf _pixbuf = null;					// Internal pixbuf used by loadPixels and updatePixels
	private static List<PKnot> _shape = null;					// Cache of points for a shape under construction

	private static int _width;									// Cache of window size
	private static int _height;
	private static double _mouseX = 0.0;						// Mouse coordinates
	private static double _mouseY = 0.0;
	private static double _pmouseX = 0.0;						// Previously saved mouse coordinates
	private static double _pmouseY = 0.0;
	private static bool _mousePressed = false;					// True if the mouse was just pressed
	private static uint _mouseButton = 0;						// 1 for left, 2 for center, 3 for right
	private static bool _keyPressed = false;
	private static Gdk.Key _key;
	private static uint _keyCode = 0;
	private static long _millis;								// The number of milliseconds when the window was created
	private static bool _immediateMode = true;					// True if all drawing commands trigger a queue draw

	public static event ButtonPressEventHandler onMousePressed;	// Mouse events
	public static event ButtonReleaseEventHandler onMouseReleased;
	public static event MotionNotifyEventHandler onMouseMoved;
	public static event MotionNotifyEventHandler onMouseDragged;
	public static event KeyPressEventHandler onKeyPressed;		// Key events
	public static event KeyReleaseEventHandler onKeyReleased;
	public static event EventHandler<PElapsedEventArgs> onLoop;

	private delegate void VoidDelegate ();						// A delegate that takes no args and returns nothing
	private delegate double DoubleDelegate ();					// A delegate that takes no args and returns a double
	public static int _debugLevel = 2;							// 0: verbose, 1: informational, 2: unhandled exceptions

	// Constants
	public static readonly int CENTER = 0;
	public static readonly int CORNER = 1;
	public static readonly int RADIUS = 2;
	public static readonly int CORNERS = 3;
	public static readonly int SQUARE = 4;
	public static readonly int ROUND = 5;
	public static readonly int PROJECT = 6;
	public static readonly int BEVEL = 7;
	public static readonly int MITER = 8;
	public static readonly int RGB = 9;
	public static readonly int ARGB = 10;
	public static readonly int ALPHA = 11;
	public static readonly int RIGHT = 12;
	public static readonly int LEFT = 13;
	public static readonly int TOP = 14;
	public static readonly int BOTTOM = 15;
	public static readonly int BASELINE = 16;
	public static readonly bool CLOSE = true;
	public static readonly double PI = 3.141592653589793238;
	public static readonly double HALF_PI = 0.5*Processing.PI;
	public static readonly double QUARTER_PI = 0.25*Processing.PI;
	public static readonly double TWO_PI = 2.0*Processing.PI;


	// String-constant maps
	private static Dictionary<string, RectMode> _rectModeStr = new Dictionary<string,RectMode> () {
		{"CORNER", RectMode.CORNER}, {"CENTER", RectMode.CENTER}, {"RADIUS", RectMode.RADIUS}, {"CORNERS", RectMode.CORNERS}
	};

	private static Dictionary<string, EllipseMode> _ellipseModeStr = new Dictionary<string,EllipseMode> () {
		{"CORNER", EllipseMode.CORNER}, {"CENTER", EllipseMode.CENTER}, {"RADIUS", EllipseMode.RADIUS}, {"CORNERS", EllipseMode.CORNERS}
	};

	private static Dictionary<string, ImageMode> _imageModeStr = new Dictionary<string,ImageMode> () {
		{"CORNER", ImageMode.CORNER}, {"CENTER", ImageMode.CENTER}, {"CORNERS", ImageMode.CORNERS}
	};

	private static Dictionary<string, Cairo.LineCap> _strokeCapStr = new Dictionary<string,Cairo.LineCap> () {
		{"SQUARE", LineCap.Butt}, {"ROUND", LineCap.Round}, {"PROJECT", LineCap.Square}
	};

	private static Dictionary<string, Cairo.LineJoin> _strokeJoinStr = new Dictionary<string,Cairo.LineJoin> () {
		{"BEVEL", LineJoin.Bevel}, {"ROUND", LineJoin.Round}, {"MITER", LineJoin.Miter}
	};

	private static Dictionary<string, Cairo.Format> _imageFormatStr = new Dictionary<string, Format>() {
		{"RGB", Format.RGB24}, {"ARGB", Format.ARGB32}, {"ALPHA", Format.A8}	//grayscale alpha channel
	};

	// Integer-constant maps
	private static Dictionary<int, RectMode> _rectModeInt = new Dictionary<int,RectMode> () {
		{CORNER, RectMode.CORNER}, {CENTER, RectMode.CENTER}, {RADIUS, RectMode.RADIUS}, {CORNERS, RectMode.CORNERS}
	};

	private static Dictionary<int, EllipseMode> _ellipseModeInt = new Dictionary<int,EllipseMode> () {
		{CORNER, EllipseMode.CORNER}, {CENTER, EllipseMode.CENTER}, {RADIUS, EllipseMode.RADIUS}, {CORNERS, EllipseMode.CORNERS}
	};

	private static Dictionary<int, ImageMode> _imageModeInt = new Dictionary<int,ImageMode> () {
		{CORNER, ImageMode.CORNER}, {CENTER, ImageMode.CENTER}, {CORNERS, ImageMode.CORNERS}
	};

	private static Dictionary<int, Cairo.LineCap> _strokeCapInt = new Dictionary<int,Cairo.LineCap> () {
		{SQUARE, LineCap.Butt}, {ROUND, LineCap.Round}, {PROJECT, LineCap.Square}
	};

	private static Dictionary<int, Cairo.LineJoin> _strokeJoinInt = new Dictionary<int,Cairo.LineJoin> () {
		{BEVEL, LineJoin.Bevel}, {ROUND, LineJoin.Round}, {MITER, LineJoin.Miter}
	};

	private static Dictionary<int, Cairo.Format> _imageFormatInt = new Dictionary<int, Format>() {
		{RGB, Format.RGB24}, {ARGB, Format.ARGB32}, {ALPHA, Format.A8}
	};

	private static Dictionary<string, TextAlign> _textAlignStr = new Dictionary<string, TextAlign>() {
		{"LEFT", TextAlign.LEFT}, {"CENTER", TextAlign.CENTER}, {"RIGHT", TextAlign.RIGHT}
	};

	private static Dictionary<int, TextAlign> _textAlignInt = new Dictionary<int, TextAlign>() {
		{LEFT, TextAlign.LEFT}, {CENTER, TextAlign.CENTER}, {RIGHT, TextAlign.RIGHT}
	};

	private static Dictionary<string, TextYAlign> _textYAlignStr = new Dictionary<string, TextYAlign>() {
		{"TOP", TextYAlign.TOP}, {"CENTER", TextYAlign.CENTER}, {"BOTTOM", TextYAlign.BOTTOM}, {"BASELINE", TextYAlign.BASELINE}
	};

	private static Dictionary<int, TextYAlign> _textYAlignInt = new Dictionary<int, TextYAlign>() {
		{LEFT, TextYAlign.TOP}, {CENTER, TextYAlign.CENTER}, {BOTTOM, TextYAlign.BOTTOM}, {BASELINE, TextYAlign.BASELINE}
	};

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void window(int w, int h) 
	{	// Create window on new thread

		// Destroy existing window, if there is one.
		exit ();

		// Create new window. Do not return until window creation is done.
		ManualResetEvent ev = new ManualResetEvent(false);
		Application.Invoke ( delegate {
			Application.Init ();

			_p = new PWindow(w, h, true);
			_width = w;
			_height = h;
			_guiThreadId = Thread.CurrentThread.ManagedThreadId;
			_p._cvs.ButtonPressEvent += _onButtonPressEvent;
			_p._cvs.ButtonReleaseEvent += _onButtonReleaseEvent;
			_p._cvs.MotionNotifyEvent += _onMotionNotifyEvent;
			_p._cvs.KeyPressEvent += _onKeyPressEvent;
			_p._cvs.KeyReleaseEvent += _onKeyReleaseEvent;
			_p.windowClosed += _onWindowClosed;

			_p.rectMode ( RectMode.CORNER );
			_p.ellipseMode ( EllipseMode.CENTER );
			_p.imageMode ( ImageMode.CORNER );

			_p.ShowAll ();

			ev.Set ();
			Application.Run ();
		} );

		// Set up helper objects
		_tmr = new PTimer();
		_tmr.Elapsed += _onLoop;

		// Reset all internal state variables
		_mouseX = 0.0;
		_mouseY = 0.0;
		_pmouseX = 0.0;
		_pmouseY = 0.0;
		_mousePressed = false;
		_mouseButton = 0;
		_keyPressed = false;
		_key = (Gdk.Key)0;
		_keyCode = 0;
		_immediateMode = true;
		_millis = DateTime.Now.Ticks * 10000;	// Current number of milliseconds since 12:00:00 midnight, January 1, 0001

		// This hangs when used with Jigsaw. Why?	
		ev.WaitOne();
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void window2(int w, int h) 
	{	// Create window on current thread, not a new one. Jigsaw needs this.

		// Destroy existing window, if there is one.
		exit ();

		// Create new window.
		_p = new PWindow(w, h, false);
		_width = w;
		_height = h;
		_p._cvs.ButtonPressEvent += _onButtonPressEvent;
		_p._cvs.ButtonReleaseEvent += _onButtonReleaseEvent;
		_p._cvs.MotionNotifyEvent += _onMotionNotifyEvent;
		_p._cvs.KeyPressEvent += _onKeyPressEvent;
		_p._cvs.KeyReleaseEvent += _onKeyReleaseEvent;
		_p.windowClosed += _onWindowClosed;

		_p.rectMode ( RectMode.CORNER );
		_p.ellipseMode ( EllipseMode.CENTER );
		_p.imageMode ( ImageMode.CORNER );

		_p.ShowAll ();

		// Set up helper objects
		_tmr = new PTimer();
		_tmr.Elapsed += _onLoop;

		// Reset all internal state variables
		_mouseX = 0.0;
		_mouseY = 0.0;
		_pmouseX = 0.0;
		_pmouseY = 0.0;
		_mousePressed = false;
		_mouseButton = 0;
		_keyPressed = false;
		_key = (Gdk.Key)0;
		_keyCode = 0;
		_immediateMode = true;
		_millis = DateTime.Now.Ticks * 10000;	// Current number of milliseconds since 12:00:00 midnight, January 1, 0001
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	private static void _onWindowClosed (object sender, DeleteEventArgs e)
	{	// PWindow was closed on its own. Clean up.
		_cleanup ();
		e.RetVal = false;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	private static void _cleanup ()
	{	// Clean up all the various helper thingys
		if (_tmr != null) {
			_tmr.Stop ();
			_tmr.Elapsed -= _onLoop;
		}
		_tmr = null;

		// Unhook event handlers.
		onLoop = null;
		onMousePressed = null;
		onMouseReleased = null;
		onMouseDragged = null;
		onMouseMoved = null;
		onKeyPressed = null;
		onKeyReleased = null;

		// Reset various other flags and settings
		_guiThreadId = -1;
		_mousePressed = false;
		_mouseButton = 0;
		_keyPressed = false;
		_millis = 0;

		_p = null;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void exit() 
	{	// Try to destroy and clean up the window
		if (_p != null) _p.Destroy ();

		// Quit if window is on its own gui thread
		if (_guiThreadId > 0) { 
			Application.Quit (); 	// Does this need to execute on the gui thread using something like the following?
			//Runtime.DispatchService.GuiDispatch (new StatefulMessageHandler (UpdateGui), n);
		}

		// Clean up all other various do-dads
		_cleanup ();
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	private static void _invoke( VoidDelegate fxn ) 
	{	// Invoke a void delegate on thread if necessary

		if (Thread.CurrentThread.ManagedThreadId != _guiThreadId)
		{
			Application.Invoke ( delegate{ fxn(); } );
		} else {
			fxn();
		}
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	private static void _invokeDouble( DoubleDelegate fxn ) 
	{	// Invoke a double delegate on thread if necessary

		double val = 0.0;
		if (Thread.CurrentThread.ManagedThreadId != _guiThreadId)
		{
			Application.Invoke ( delegate{ val = fxn(); } );
		} else {
			fxn();
		}
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	private static void _onLoop (object o, PElapsedEventArgs e)
	{	// Handle timer elapsed events
		raiseTimerElapsed(o, e);
		resetMatrix();
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	private static void _onMotionNotifyEvent (object o, Gtk.MotionNotifyEventArgs args)
	{	// Handle mouse motion events
		_pmouseX = _mouseX;
		_pmouseY = _mouseY;
		_mouseX = args.Event.X;
		_mouseY = args.Event.Y;
		if (_mousePressed) {
			raiseMouseDragged(args);
		} else {
			raiseMouseMoved(args);
		}
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	private static void _onButtonPressEvent (object o, Gtk.ButtonPressEventArgs args)
	{	// Reraise the event from the main class
		_mousePressed = true;
		_mouseButton = args.Event.Button;
		_pmouseX = _mouseX;
		_pmouseY = _mouseY;
		_mouseX = args.Event.X;
		_mouseY = args.Event.Y;
		raiseMousePressed(args);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	private static void _onButtonReleaseEvent (object o, ButtonReleaseEventArgs args)
	{	// Reraise the event from the main class
		_mousePressed = false;
		_mouseButton = 0;
		_pmouseX = _mouseX;
		_pmouseY = _mouseY;
		_mouseX = args.Event.X;
		_mouseY = args.Event.Y;
		raiseMouseReleased(args);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	private static void _onKeyPressEvent(object o, KeyPressEventArgs args)
	{
		_keyPressed = true;
		_key = args.Event.Key;
		_keyCode = args.Event.KeyValue;
		raiseKeyPressed(args);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	private static void _onKeyReleaseEvent(object o, KeyReleaseEventArgs args)
	{
		_keyPressed = false;
		_key = (Gdk.Key)0;
		_keyCode = 0;
		raiseKeyReleased(args);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	private static void raiseTimerElapsed(object o, PElapsedEventArgs a)
	{
        EventHandler<PElapsedEventArgs> handler = onLoop;

        if (handler != null)
        {
            handler(o, a);
        }
    }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	private static void raiseMouseMoved(MotionNotifyEventArgs e)
    {
        MotionNotifyEventHandler handler = onMouseMoved;

        // Event will be null if there are no subscribers
        if (handler != null)
        {	// Use the () operator to raise the event.
            handler(null, e);
        }
    }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	private static void raiseMouseDragged(MotionNotifyEventArgs e)
    {
		MotionNotifyEventHandler handler = onMouseDragged;

        // Event will be null if there are no subscribers
        if (handler != null)
        {	// Use the () operator to raise the event.
            handler(null, e);
        }
    }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	private static void raiseMousePressed(ButtonPressEventArgs e)
    {
        ButtonPressEventHandler handler = onMousePressed;

        // Event will be null if there are no subscribers
        if (handler != null)
        {	// Use the () operator to raise the event.
            handler(null, e);
        }
    }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	private static void raiseMouseReleased(ButtonReleaseEventArgs e)
    {
        ButtonReleaseEventHandler handler = onMouseReleased;

        // Event will be null if there are no subscribers
        if (handler != null)
        {	// Use the () operator to raise the event.
            handler(null, e);
        }
    }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	private static void raiseKeyPressed(KeyPressEventArgs e)
    {
        KeyPressEventHandler handler = onKeyPressed;
        if (handler != null)
        {
            handler(null, e);
        }
    }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	private static void raiseKeyReleased(KeyReleaseEventArgs e)
    {
        KeyReleaseEventHandler handler = onKeyReleased;
        if (handler != null)
        {
            handler(null, e);
        }
    }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void beginShape() 
	{	// Start a new shape
		_shape = new List<PKnot>();
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void vertex(double x, double y)
	{	// Add a simple vertex to a shape under construction
		_shape.Add(new PKnot(x, y, PKnotType.VERTEX));
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void bezierVertex(double cx1, double cy1, double cx2, double cy2, double x, double y)
	{	// Add a bezier vertex to a shape under construction
		_shape.Add(new PKnot(x, y, cx1, cy1, cx2, cy2, PKnotType.BEZIER));
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void curveVertex(double x, double y)
	{	// Add a curve vertex to the shape
		_shape.Add(new PKnot(x, y, PKnotType.CURVE));
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void curveTightness(double tightness)
	{
		if (_p == null) return;

		_invoke ( delegate { 
			try {
				_p.curveTightness(tightness);
			} catch (Exception e) {
				debug (String.Format ("curveTightness(): {0}", e.Message), 1);
			}
		} );
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void endShape(bool toClose)
	{	// Finish up and render
		if (_p == null) return;

		ManualResetEvent ev = new ManualResetEvent(false);
		_invoke ( delegate { 
			try {
				_p.spline( _shape, toClose );
				if (_immediateMode) _p.redraw ();
				ev.Set ();
			} catch (Exception e) {
				debug (String.Format ("endShape(): {0}", e.Message), 1);
			}
		} );
		ev.WaitOne();
	}
	public static void endShape() { endShape (false); }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static PImage createImage(int width, int height, string format) 
	{	// Create a new PImage object given a string format

		// Validate the format string
		if (!_imageFormatStr.ContainsKey(format)) {
			string[] skeys = new string[_imageFormatStr.Count];
			_imageFormatStr.Keys.CopyTo(skeys, 0);
			string jskeys = String.Join (", ", skeys);
			string msg = String.Format ("Unrecognized image format: '{0}'. Try {1}", format, jskeys);
			debug (msg, 2);
			return null;
		}
		Format frmt = _imageFormatStr[format];

		// Create the image
		return new PImage(width, height, frmt);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static PImage createImage(int width, int height, int format) 
	{	// Create a new PImage object given an integer format

		// Validate the format int
		if (!_imageFormatInt.ContainsKey(format)) {
			string[] skeys = new string[_imageFormatStr.Count];
			_imageFormatStr.Keys.CopyTo(skeys, 0);
			string jskeys = String.Join (", ", skeys);
			string msg = String.Format ("Unrecognized image format: '{0}'. Try {1}", format, jskeys);
			debug (msg, 2);
			return null;
		}
		Format frmt = _imageFormatInt[format];

		// Create the image
		return new PImage(width, height, frmt);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static PImage loadImage(string path) 
	{	// Load an image into the PImage object

		PImage img = null;

		// Make a complete path, if not rooted
		if (!System.IO.Path.IsPathRooted(path)) {
			path = System.IO.Path.Combine ( Directory.GetCurrentDirectory(), path );
		}

		// Check if the file exists
		if (!File.Exists (path) ) {
			println ("Error: Can't find image file at ", path);
			return null;
		}

		// Attempt to open the file
		img = new PImage(path);

		return img;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void image(PImage img, double x, double y, double w, double h) 
	{
		// Draw the image
		if (_p == null) return;
		_invoke ( delegate { 
			try {
				_p.image (img, x, y, w, h);
			} catch (Exception e) {
				debug (String.Format ("image(): {0}", e.Message), 1);
			}
		} );
	}
	public static void image(PImage img, double x, double y) { image (img, x, y, img.width (), img.height ()); }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void keepAbove(bool ku)
	{	// Set flag to tell current window if to remain aboove all others
		if (_p == null) return;
		_invoke ( delegate { 
			try {
				_p.KeepAbove = ku;
			} catch (System.NullReferenceException e){
				debug(String.Format ("keepAbove() ignored extra tick: {0}", e.ToString()), 1);
			}
		});
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static bool focused()
	{	// Check if window has focus
		if (_p == null) return false;
		return _p.focused;			// Should this be invoked on GUI thread?
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static long frameCount()
	{	// Return the number of times the exposed event was fired by the PWindow
		if (_p == null) return 0;
		return _p.frameCount;			// Should this be invoked on GUI thread?
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static double mouseX()
	{	// Get mouse position
		return _mouseX;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static double mouseY()
	{	// Get mouse position
		return _mouseY;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static double pmouseX()
	{	// Get previous mouse position
		return _pmouseX;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static double pmouseY()
	{	// Get previous mouse position
		return _pmouseY;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static bool isMousePressed()
	{	// True if mouse is currently pressed
		return _mousePressed;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static uint mouseButton()
	{	// Number of mouse button currently pressed. 1 for left mouse button, 2 for center mouse button, 3 for right mouse button
		return _mouseButton;
	}
	
	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static bool isKeyPressed()
	{	// True if key is currently pressed
		return _keyPressed;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static Gdk.Key key()
	{	// Return key pressed
		return _key;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static uint keyCode()
	{	// Return integer code of key pressed
		return _keyCode;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void size(int w, int h) 
	{	// Set window size

		// If no window, create one of the proper size
		if (_p == null) {
			window(w, h);
		} else {
			ManualResetEvent ev = new ManualResetEvent(false);
			_invoke ( delegate {
				_p.size(w, h);
				ev.Set ();
			} );
			_width = w;
			_height = h;
			ev.WaitOne();
		}
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static double width() 
	{	// Get the width of the window
		return _width;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static double height() 
	{	// Get the height of the window
		return _height;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void immediateMode( bool value )
	{
		//Application.Invoke ( delegate { _immediateMode = value; } );
		_invoke ( delegate { _immediateMode = value; } );
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void ellipseMode( string mode )
	{
		_invoke ( delegate { _p.ellipseMode (_ellipseModeStr[mode]); } );
	}
	public static void ellipseMode( int mode )
	{
		_invoke ( delegate { _p.ellipseMode (_ellipseModeInt[mode]); } );
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void rectMode( string mode )
	{
		_invoke ( delegate { _p.rectMode (_rectModeStr[mode]); } );
	}
	public static void rectMode( int mode )
	{
		_invoke ( delegate { _p.rectMode (_rectModeInt[mode]); } );
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void imageMode( string mode )
	{
		_invoke ( delegate { _p.imageMode (_imageModeStr[mode]); } );
	}
	public static void imageMode( int mode )
	{
		_invoke ( delegate { _p.imageMode (_imageModeInt[mode]); } );
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void strokeCap( string style )
	{
		_invoke ( delegate { _p.strokeCap (_strokeCapStr[style]); } );
	}
	public static void strokeCap( int style )
	{
		_invoke ( delegate { _p.strokeCap (_strokeCapInt[style]); } );
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void strokeJoin( string style )
	{
		_invoke ( delegate { _p.strokeJoin (_strokeJoinStr[style]); } );
	}
	public static void strokeJoin( int style )
	{
		_invoke ( delegate { _p.strokeJoin (_strokeJoinInt[style]); } );
	}
	
	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void textAlign( string align )
	{
		_invoke ( delegate { _p.textAlign (_textAlignStr[align]); } );
	}
	public static void textAlign( int align )
	{
		_invoke ( delegate { _p.textAlign (_textAlignInt[align]); } );
	}
	public static void textAlign( string align, string yalign )
	{
		_invoke ( delegate { _p.textAlign (_textAlignStr[align], _textYAlignStr[yalign]); } );
	}
	public static void textAlign( int align, int yalign )
	{
		_invoke ( delegate { _p.textAlign (_textAlignInt[align], _textYAlignInt[yalign]); } );
	}
	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void redraw() 
	{	// Try to cause the window to redraw itself by queuing up a draw
		if (_p == null) return;
		_invoke ( delegate { 
			try {
				_p.redraw ();
			} catch (Exception e) {
				debug (String.Format ("redraw: {0}", e.Message), 1);
			}
		} );
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void delay(int millis) 
	{	
		Thread.Sleep (millis);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void doEvents() 
	{	// Process any pending events
		while (Gtk.Application.EventsPending ()) Gtk.Application.RunIteration ();
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void noLoop()
	{
		_tmr.Stop ();
	}
	public static void stopLoop() { noLoop (); }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void loop()
	{
		_tmr.Start ();
	}
	public static void startLoop() { loop (); }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void frameRate(uint fr)
	{	// Sets timer interval
		bool enabled = _tmr.Enabled;
		_tmr.Stop ();
		_tmr.Interval = fr;
		if (enabled) _tmr.Start ();
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static double frameRate()
	{	// Gets timer interval
		return _tmr.Interval;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static long millis()
	{	// Gets the number of milliseconds the window has existed, if there is one
		if (_p == null) return 0;
		return (DateTime.Now.Ticks * 10000 - _millis);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static int second()
	{	// Gets the number of seconds on the system clock [0, 59]
		if (_p == null) return 0;
		return DateTime.Now.Second;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static int minute()
	{	// Gets the number of minutes on the system clock [0, 59]
		if (_p == null) return 0;
		return DateTime.Now.Minute;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static int hour()
	{	// Gets the number of hours on the system clock [0, 24]
		if (_p == null) return 0;
		return DateTime.Now.Hour;
	}
	
	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static int day()
	{	// Gets the number of days on the system clock [1, 31]
		if (_p == null) return 0;
		return DateTime.Now.Day;
	}
	
	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static int month()
	{	// Gets the number of months on the system clock [1, 12]
		if (_p == null) return 0;
		return DateTime.Now.Month;
	}
		
	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static int year()
	{	// Gets the year
		if (_p == null) return 0;
		return DateTime.Now.Year;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static bool toBoolean(object o)
	{	// Try to convert the object to a boolean
		return Convert.ToBoolean (o);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static byte toByte(object o)
	{	// Try to convert the object to a byte
		return Convert.ToByte (o);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static char toChar(object o)
	{
		return Convert.ToChar(o);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static Single toFloat(object o)
	{
		return Convert.ToSingle (o);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static double toDouble(object o)
	{
		return Convert.ToDouble (o);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static Int32 toInt(object o)
	{
		return Convert.ToInt32 (o);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static Int64 toLong(object o)
	{
		return Convert.ToInt64 (o);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static string toString(object o)
	{
		return Convert.ToString (o);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static string toHex(object o)
	{
		int v = Convert.ToInt32(o);
		return String.Format("{0:X}", v);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static string toBinary(object o)
	{
		int v = Convert.ToInt32(o);
		return Convert.ToString (v, 2);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static Int32 fromHex(string hex)
	{
		 return Convert.ToInt32(hex, 16);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static Int32 fromBinary(string bits)
	{
		int bitCount = 8;
		if (bits.Length == bitCount && bits[0] == '1')
            return Convert.ToInt32(bits.PadLeft(32, '1'),2);
        else
            return Convert.ToInt32(bits,2);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void smooth() {
		if (_p == null) return;
		//Application.Invoke ( delegate {
		_invoke ( delegate { 
			try {
				_p.smooth ();
			} catch (System.NullReferenceException e){
				debug(String.Format ("smooth() ignored extra tick: {0}", e.ToString()), 1);
			}
		});
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void noSmooth() {
		if (_p == null) return;
		//Application.Invoke ( delegate { 
		_invoke ( delegate { 
			try {
				_p.noSmooth ();
			} catch (System.NullReferenceException e){
				debug(String.Format ("noSmooth() ignored extra tick: {0}", e.ToString()), 1);
			}
		});
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//	public static void print(params object[] items) 
//	{	// Print a message to the console
//		string[] sitems = new string[items.Length];
//		for (int i=0; i<items.Length; i++) sitems[i] = items[i].ToString ();
//		Console.Write ( String.Join(" ", sitems) );
//	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void println(params object[] items) 
	{	// Print a message to the console
		string[] sitems = new string[items.Length];
		for (int i=0; i<items.Length; i++) sitems[i] = items[i].ToString ();
		Console.WriteLine ( String.Join(" ", sitems) );
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	internal static void debug(string msg, int level) 
	{	// 0: verbose, 1: information, 2: serious exceptions
		if (level >= _debugLevel) Console.WriteLine (msg);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void fill(double r, double g, double b, double a) 
	{	// Set fill color for all drawing moving forward
		if (_p == null) return;
		//Application.Invoke ( delegate {
		_invoke ( delegate { 
			try {
				_p.fill (r, g, b, a);
			} catch (System.NullReferenceException e){
				debug(String.Format ("fill() ignored extra tick: {0}", e.ToString()), 1);
			}
		});
	}
	public static void fill(double r, double g, double b) { fill (r, g, b, 255); }
	public static void fill(double g, double a) { fill (g, g, g, a); }
	public static void fill(double g) { fill (g, g, g, 255); }
	public static void fill( uint c ) { fill ( red (c), green (c), blue (c), alpha (c) ); }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void noFill() 
	{	// Turn off fill color
		if (_p == null) return;
		//Application.Invoke ( delegate {
		_invoke ( delegate { 
			try {
				_p.noFill ();
			} catch (System.NullReferenceException e){
				debug(String.Format ("noFill() ignored extra tick: {0}", e.ToString()), 1);
			}
		});
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void stroke(double r, double g, double b, double a) 
	{	// Set stroke color for all drawing moving forward
		if (_p == null) return;
		//Application.Invoke ( delegate {
		_invoke ( delegate { 
			try {
				_p.stroke (r, g, b, a);
			} catch (System.NullReferenceException e){
				debug(String.Format ("stroke() ignored extra tick: {0}", e.ToString()), 1);
			}
		});
	}
	public static void stroke(double r, double g, double b) { stroke (r, g, b, 255); }
	public static void stroke(double g, double a) { stroke (g, g, g, a); }
	public static void stroke(double g) { stroke (g, g, g, 255); }
	public static void stroke( uint c ) { stroke ( red (c), green (c), blue (c), alpha (c) ); }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void noStroke() 
	{	// Turn off stroke
		if (_p == null) return;
		//Application.Invoke ( delegate {
		_invoke ( delegate { 
			try {
				_p.noStroke ();
			} catch (System.NullReferenceException e){
				debug(String.Format ("noStroke() ignored extra tick: {0}", e.ToString()), 1);
			}
		});
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static double strokeWeight(double w) 
	{	// Set and/or return stroke weight
		if (_p == null) return -1.0;
		ManualResetEvent ev = new ManualResetEvent(false);
		double cw = w;

		_invoke ( delegate { 
			try {
				cw = _p.strokeWeight;			// Copy current value
				if (w >= 0.0) {					// If new value is valid
					_p.strokeWeight = w;		// Set new value
					cw = w;						// Copy new value into current
				}
			} catch (System.NullReferenceException e){
				debug(String.Format ("strokeWeight() ignored extra tick: {0}", e.ToString()), 1);
			}
			ev.Set ();
		});
		ev.WaitOne ();
		return cw;								// Return current value
	}
	
	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void pushMatrix() 
	{
		if (_p == null) return;
		_invoke ( delegate { 
			try {
				_p.pushMatrix ();
			} catch (System.NullReferenceException e){
				debug(String.Format ("pushMatrix() ignored extra tick: {0}", e.ToString()), 1);
			}
		} );
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void popMatrix() 
	{
		if (_p == null) return;
		_invoke ( delegate { 
			try {
				_p.popMatrix ();
			} catch (System.NullReferenceException e){
				debug ( String.Format("popMatrix() ignored extra tick: {0}", e.ToString()), 1);
			}
		} );
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void resetMatrix() 
	{
		if (_p == null) return;
		_invoke ( delegate { 
			try {
				_p.resetMatrix ();
			} catch (System.NullReferenceException e){
				debug ( String.Format("resetMatrix() ignored extra tick: {0}", e.ToString()), 1);
			}
		} );
	}
	
	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void translate(double tx, double ty) 
	{
		if (_p == null) return;
		_invoke ( delegate { 
			try {
				_p.translate (tx, ty);
			} catch (System.NullReferenceException e){
				debug ( String.Format("translate() ignored extra tick: {0}", e.ToString()), 1);
			}
		} );
	}
		
	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void scale(double sx, double sy) 
	{
		if (_p == null) return;
		_invoke ( delegate { 
			try {
				_p.scale (sx, sy);
			} catch (System.NullReferenceException e){
				debug ( String.Format("scale() ignored extra tick: {0}", e.ToString()), 1);
			}
		} );
	}
	public static void scale(double s) { scale (s, s); }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void rotate(double a) 
	{
		if (_p == null) return;
		_invoke ( delegate { 
			try {
				_p.rotate (a);
			} catch (System.NullReferenceException e){
				debug ( String.Format("rotate() ignored extra tick: {0}", e.ToString()), 1);
			}
		} );
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void background(double r, double g, double b, double a) 
	{	// Fill the background of the window
		if (_p == null) return;
		_invoke ( delegate { 
			try {
				_p.background(r, g, b, a);
				if (_immediateMode) _p.redraw ();
			} catch (System.NullReferenceException e){
				debug ( String.Format ("background() ignored extra tick: {0}", e.ToString()), 1);
			}
		} );
	}
	public static void background(double r, double g, double b) { background (r, g, b, 255.0); }
	public static void background(double g, double a) { background (g, g, g, a); }
	public static void background(double g) { background (g, g, g, 255.0); }
	public static void background( uint c ) { background ( red (c), green (c), blue (c), alpha (c) ); }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void point(double x, double y) 
	{	// Draw a point
		if (_p == null) return;
		_invoke ( delegate { 
			try {
				_p.point(x, y);
				if (_immediateMode) _p.redraw ();
			} catch (System.NullReferenceException e){
				debug ( String.Format("point() ignored extra tick: {0}", e.ToString()), 1);
			}
		} );
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void line(double x1, double y1, double x2, double y2) 
	{	// Draw a line
		if (_p == null) return;

		_invoke ( delegate { 
			try {
				_p.line(x1, y1, x2, y2);
				if (_immediateMode) _p.redraw ();
			} catch (System.NullReferenceException e){
				debug ( String.Format("line() ignored extra tick: {0}", e.ToString()), 1);
			}
		} );
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void ellipse(double x, double y, double w, double h) 
	{	// Draw an ellipse
		if (_p == null) return;

		_invoke ( delegate { 
			try {
				_p.ellipse(x, y, w, h);
				if (_immediateMode) _p.redraw ();
			} catch (System.NullReferenceException e){
				debug ( String.Format("ellipse() ignored extra tick: {0}", e.ToString()), 1);
			}
		} );
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void arc(double x, double y, double w, double h, double start, double stop) 
	{	// Draw an ellipse
		if (_p == null) return;
		_invoke ( delegate { 
			try {
				_p.arc(x, y, w, h, start, stop);
				if (_immediateMode) _p.redraw ();
			} catch (System.NullReferenceException e){
				debug ( String.Format("arc() ignored extra tick: {0}", e.ToString()), 1);
			}
		} );
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void rect(double x, double y, double w, double h) 
	{	// Draw a rectangle
		if (_p == null) return;

		_invoke ( delegate { 
			try {
				_p.rect(x, y, w, h);
				if (_immediateMode) _p.redraw ();
			} catch (System.NullReferenceException e){
				debug ( String.Format("rect() ignored extra tick: {0}", e.ToString()), 1);
			}
		} );
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void triangle(double x1, double y1, double x2, double y2, double x3, double y3) 
	{	// Draw a triangle
		if (_p == null) return;
		_invoke ( delegate { 
			try {
				_p.triangle(x1, y1, x2, y2, x3, y3);
				if (_immediateMode) _p.redraw ();
			} catch (System.NullReferenceException e){
				debug ( String.Format("triangle() ignored extra tick: {0}", e.ToString()), 1);
			}
		} );
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void quad(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4) 
	{	// Draw a quad
		if (_p == null) return;
		_invoke ( delegate { 
			try {
				_p.quad(x1, y1, x2, y2, x3, y3, x4, y4);
				if (_immediateMode) _p.redraw ();
			} catch (System.NullReferenceException e){
				debug(String.Format ("quad() ignored extra tick: {0}", e.ToString()), 1);
			}
		} );
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void textSize(double s) 
	{
		if (_p == null) return;
		_invoke ( delegate { 
			try {
				_p.textSize (s);
			} catch (System.NullReferenceException e){
				debug ( String.Format("textSize() ignored extra tick: {0}", e.ToString()), 1);
			}
		} );
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static double textWidth(string txt) 
	{
		if (_p == null) return -1.0;
		ManualResetEvent ev = new ManualResetEvent(false);

		double w = -1.0;
		_invokeDouble ( delegate { 
			try {
				w = _p.textWidth (txt);
			} catch (System.NullReferenceException e){
				debug ( String.Format("textWidth() ignored extra tick: {0}", e.ToString()), 1);
			}
			ev.Set ();
			return w;
		} );
		ev.WaitOne();
		return w;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void text(string txt, double x, double y, double w, double h) 
	{	// Draw text
		if (_p == null) return;
		_invoke ( delegate { 
			try {
				_p.text(txt, x, y, w, h);
				if (_immediateMode) _p.redraw ();
			} catch (System.NullReferenceException e){
				debug(String.Format ("text() ignored extra tick: {0}", e.ToString()), 1);
			}
		} );
	}

	public static void text(string txt, double x, double y) 
	{	// Draw text
		if (_p == null) return;
		_invoke ( delegate { 
			try {
				_p.text(txt, x, y);
				if (_immediateMode) _p.redraw ();
			} catch (System.NullReferenceException e){
				debug(String.Format ("text() ignored extra tick: {0}", e.ToString()), 1);
			}
		} );
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static double random(double min, double max) 
	{	// Generate a random number between min and max
		return map( _rand.NextDouble(), 0.0, 1.0, min, max );
	}
	public static double random(double max) { return random (0.0, max); }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void randomSeed(int seed) {
		_rand = new Random(seed);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static double map(double n, double min1, double max1, double min2, double max2) 
	{	// Map a number from one range to another
		return ((n - min1)/(max1 - min1)) * (max2 - min2) + min2;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static double constrain(double n, double min, double max) 
	{	// Constrain a number to a range
		if (n < min) n = min;
		if (n > max) n = max;
		return n;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static double mag(double x, double y)
	{	// Computes magnitude of a vector
		return Math.Sqrt (x*x + y*y);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static double dist(double x1, double y1, double x2, double y2)
	{	// Computes the distance between two points
		double dx = (x2 - x1);
		double dy = (y2 - y1);
		return mag (dx, dy);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static double max(params double[] vals)
	{	// Compute the maximum value of several numbers
		double tmax = vals[0];
		for (int i=1; i<vals.Length; i++) tmax = Math.Max (tmax, vals[i]);
		return tmax;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static double min(params double[] vals)
	{	// Compute the minimum value of several numbers
		double tmin = vals[0];
		for (int i=1; i<vals.Length; i++) tmin = Math.Min (tmin, vals[i]);
		return tmin;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static int floor(double val)
	{
		return (int)Math.Floor (val);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static int ceil(double val)
	{
		return (int)Math.Ceiling (val);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static double round(double val)
	{
		return round (val, 0);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static double round(double val, int ndigits)
	{
		return Math.Round (val, ndigits);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static double radians(double degrees)
	{
		return degrees * (PI/180.0);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static double degrees(double radians)
	{
		return radians * (180.0/PI);
	}
	
	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static uint color(byte r, byte g, byte b, byte a)
	{	// Create color from color byte components
		 return (uint)( b | (g << 8) | (r << 16) | (a << 24));
	}
	public static uint color(byte r, byte g, byte b) { return color(r, g, b, 255); }
	public static uint color(byte g, byte a) { return color(g, g, g, a); }
	public static uint color(byte g) { return color(g, g, g, 255); }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static byte blue(uint c)
	{	// Extract color byte from a color (unsigned int)
		 return (byte)((c & 0x000000FF));
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static byte green(uint c)
	{	// Extract color byte from a color (unsigned int)
		 return (byte)((c & 0x0000FF00) >> 8);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static byte red(uint c)
	{	// Extract color byte from a color (unsigned int)
		 return (byte)((c & 0x00FF0000) >> 16);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static byte alpha(uint c)
	{	// Extract color byte from a color (unsigned int)
		 return (byte)((c & 0xFF000000) >> 24);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	private static void _HSB2color( float hu, float sa, float br, out uint c)
	{	// Build an RGBA color from hue saturation and brightness

		// Adapted from http://www.unifycommunity.com/wiki/index.php?title=HSBColor
        float r = br;
        float g = br;
        float b = br;

        if (sa != 0)
        {
            float max = br;
            float dif = br * sa;
            float min = br - dif;

            float h = hu * 360f;

            if (h < 60f)
            {
                r = max;
                g = h * dif / 60f + min;
                b = min;
            }
            else if (h < 120f)
            {
                r = -(h - 120f) * dif / 60f + min;
                g = max;
                b = min;
            }
            else if (h < 180f)
            {
                r = min;
                g = max;
                b = (h - 120f) * dif / 60f + min;
            }
            else if (h < 240f)
            {
                r = min;
                g = -(h - 240f) * dif / 60f + min;
                b = max;
            }
            else if (h < 300f)
            {
                r = (h - 240f) * dif / 60f + min;
                g = min;
                b = max;
            }
            else if (h <= 360f)
            {
                r = max;
                g = min;
                b = -(h - 360f) * dif / 60 + min;
            }
            else
            {
                r = 0;
                g = 0;
                b = 0;
            }
        }

		byte rbyte = (byte)(constrain (r, 0.0, 1.0)*255);
		byte gbyte = (byte)(constrain (g, 0.0, 1.0)*255);
		byte bbyte = (byte)(constrain (b, 0.0, 1.0)*255);
		c = color (rbyte, gbyte, bbyte, 255);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	private static void _color2HSB( uint c, out float hu, out float sa, out float br, out float al)
	{	// Extract hue, saturation, brightness and alpha elements from an RGB color

		float r = red (c);
		float g = green (c);
		float b = blue (c);
		float a = alpha (c);

		// Adapted from http://www.unifycommunity.com/wiki/index.php?title=HSBColor

        hu = 0.0f;
		sa = 0.0f;
		br = 0.0f;
		al = a;

        float max = Math.Max(r, Math.Max(g, b));

        if (max <= 0) return;

        float min = Math.Min(r, Math.Min(g, b));
        float dif = max - min;

        if (max > min)
        {
            if (g == max)
            {
                hu = (b - r) / dif * 60f + 120f;
            }
            else if (b == max)
            {
                hu = (r - g) / dif * 60f + 240f;
            }
            else if (b > g)
            {
                hu = (g - b) / dif * 60f + 360f;
            }
            else
            {
                hu = (g - b) / dif * 60f;
            }
            if (hu < 0)
            {
                hu = hu + 360f;
            }
        }
        else
        {
            hu = 0;
        }

        hu *= 1f / 360f;
        sa = (dif / max) * 1f;
        br = max;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static float hue(uint c)
	{	// Extract color byte from a color (unsigned int)
		float hu, sa, br, al;
		_color2HSB(c, out hu, out sa, out br, out al);
        return hu;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static float saturation(uint c)
	{	// Extract color byte from a color (unsigned int)
		float hu, sa, br, al;
		_color2HSB(c, out hu, out sa, out br, out al);
        return sa;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static float brightness(uint c)
	{	// Extract color byte from a color (unsigned int)
		float hu, sa, br, al;
		_color2HSB(c, out hu, out sa, out br, out al);
        return br;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void setPixel(int x, int y, byte r, byte g, byte b, byte a) 
	{	// Set an individual pixel in the pixbuf
		if (_p == null) return;
		if (_pixbuf == null) return;
		System.Runtime.InteropServices.Marshal.WriteByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 0, r);
		System.Runtime.InteropServices.Marshal.WriteByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 1, g);
		System.Runtime.InteropServices.Marshal.WriteByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 2, b);
		System.Runtime.InteropServices.Marshal.WriteByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 3, a);
	}
	public static void setPixel(int x, int y, byte r, byte g, byte b) { setPixel(x, y, r, g, b, 255); }
	public static void setPixel(int x, int y, byte gray, byte a) { setPixel(x, y, gray, gray, gray, a); }
	public static void setPixel(int x, int y, byte gray) { setPixel(x, y, gray, gray, gray, 255); }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void setPixel(int x, int y, uint c) 
	{	// Set an individual pixel in the pixbuf
		if (_p == null) return;
		if (_pixbuf == null) return;
		System.Runtime.InteropServices.Marshal.WriteByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 0, red (c));
		System.Runtime.InteropServices.Marshal.WriteByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 1, green (c));
		System.Runtime.InteropServices.Marshal.WriteByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 2, blue (c));
		System.Runtime.InteropServices.Marshal.WriteByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 3, alpha (c));
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static uint getPixel(int x, int y) 
	{	// Set an individual pixel in the pixbuf
		if (_p == null) return 0;
		if (_pixbuf == null) return 0;
		byte r = System.Runtime.InteropServices.Marshal.ReadByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 0);
		byte g = System.Runtime.InteropServices.Marshal.ReadByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 1);
		byte b = System.Runtime.InteropServices.Marshal.ReadByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 2);
		byte a = System.Runtime.InteropServices.Marshal.ReadByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 3);
		return color (r, g, b, a);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void loadPixels()
	{	// Copy pixels from current image to pixels array
		if (_p == null) return;
		if (_p._img  == null) return;

		ManualResetEvent ev = new ManualResetEvent (false);
		Gdk.Pixbuf pixbuf = null;

		_invoke ( delegate {
			if (_p != null) {
				Context g = null;
				try {
					// Create a new pixmap and context
					Gdk.Pixmap pm = new Gdk.Pixmap(null, _width, _height, _p.GdkWindow.Depth);
					//using (Context ctx = Gdk.CairoHelper.Create(pm)) {
					g = Gdk.CairoHelper.Create(pm);
					// Paint internal Cairo image onto pixmap
					g.SetSourceSurface (_p._img, 0, 0);
					g.Paint ();
					//}
					((IDisposable) g).Dispose();
					 g = null;

					// Convert pixmap to pixbuf
					Gdk.Colormap colormap = pm.Colormap;
					pixbuf = Gdk.Pixbuf.FromDrawable (pm, colormap, 0, 0, 0, 0, _width, _height);

					// Creates a pixbuf from window
		//			Gdk.Drawable drawable = _p.GdkWindow;			// Gets data from window, not internal image. Causes problem when another window on top.
		//			Gdk.Colormap colormap = drawable.Colormap;
		//			int w = 0;
		//			int h = 0;
		//			drawable.GetSize (out w, out h);
		//			pixbuf = Gdk.Pixbuf.FromDrawable (drawable, colormap, 0, 0, 0, 0, w, h);

				} catch (Exception ex) {
					if (g != null) ((IDisposable) g).Dispose();
					g = null;
					debug ("Processing.loadPixels(): " + ex.Message, 2);
				}
			}
			ev.Set ();
		});
		ev.WaitOne ();

		if (pixbuf != null) {
			_pixbuf = pixbuf;
			if (!_pixbuf.HasAlpha) {
				_pixbuf = _pixbuf.AddAlpha (false, 0, 0, 0);
			}
		}
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public static void updatePixels() 
	{	// Copy pixels from pixbuf to image
		try
		{
			if (_p == null) return;
			if (_p._img  == null) return;
			if (_pixbuf == null) return;

			ManualResetEvent ev = new ManualResetEvent (false);
			_invoke ( delegate {
				if (_p != null && _pixbuf != null) {
					Context g = null;
					try {
						//using (Context g = new Cairo.Context(_p._img)) {
						g = new Cairo.Context(_p._img);
						Gdk.CairoHelper.SetSourcePixbuf(g, _pixbuf, 0.0, 0.0);
						g.Paint ();
						//}
						((IDisposable) g).Dispose();
						g = null;
						if (_immediateMode) _p.redraw ();
					} catch (Exception ex) {
						if (g != null) ((IDisposable) g).Dispose();
						g = null;
						debug ( "updatePixels(): " + ex.Message, 2);
					}
				}
				
				ev.Set ();
			});
			ev.WaitOne ();
		} catch (Exception ex) {
			Console.WriteLine ("Processing.updatePixels: " + ex.Message);
		}

//		int nPixels = _width * _height;
//		for (int i=0; i<nPixels; i++) {
//			int n = i*4;
//			byte[] b = BitConverter.GetBytes(_pixels[i]);
//			_p._img.Data[n] = b[0];
//			_p._img.Data[n+1] = b[1];
//			_p._img.Data[n+2] = b[2];
//			_p._img.Data[n+3] = b[3];
//		}
	}
}
// ------------------ PTimer ----------------------------------------------

public class PElapsedEventArgs : EventArgs {
	public long tickCount = 0;
	public PElapsedEventArgs(long tickCount) : base() {
		this.tickCount = tickCount;
	}
}

// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
internal class PTimer
{
	private bool _enabled = false;			// true if timer 
	private uint _timerID = 0;				// ID of currently installed timeout handler
	private uint _timeOut = 0;				// interval in milliseconds
	private bool _inTimeout = false;		// Flag to prevent reentrance
	private long _tickCount = 0;			// Keep count of the number of ticks fired
	public event EventHandler<PElapsedEventArgs> Elapsed = null;
//	public event ElapsedEventHandler Elapsed = null;

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public PTimer()
	{
		_enabled = false;
		_timerID = 0;
		_timeOut = 0;
		_inTimeout = false;
		_tickCount = 0;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public void Start()
	{	// Start Timeout. Remove any existing timeout handler that is running.
		if (_timeOut == 0) return;
		Stop();					// If running, stop first before installing TimeoutHandler
		_timerID = GLib.Timeout.Add(_timeOut, new GLib.TimeoutHandler(_onTimerElapsed));
		_enabled = true;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public void Stop()
	{ 	// Remove any existing timeout handler
		if (_timerID > 0) {
			GLib.Source.Remove(_timerID);
			_timerID = 0;
		}
		_enabled = false;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	private bool _onTimerElapsed()
	{	// Internal timeout handler
		if (_inTimeout) return true;
		_inTimeout = true;

		// Count ticks
		System.Threading.Interlocked.Increment(ref _tickCount);

		// Raise onLoop event
        EventHandler<PElapsedEventArgs> handler = Elapsed;
		PElapsedEventArgs args = new PElapsedEventArgs(_tickCount);
        if (handler != null) handler(this, args);
		
		_inTimeout = false;
		return true;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public uint Interval
	{	// Set/get the timeout interval
		set	{
			// Reset timeout value
			_timeOut = value;

			// If currently enabled, then restart now
			if (_enabled) Start();
		}
		get	{
			return _timeOut;
		}
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public bool Enabled
	{	// Property get/set as alternative interface to Start()/Stop() methods
		set {
			if (value == true) {
				Start();
			} else {
				Stop();
			}
		}
		get{
			return _enabled;
		}
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public long TickCount
	{	// Return internal tick count
		get {
			return _tickCount;
		}
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
}

// ------------------ PImage ----------------------------------------------
public class PImage
{
	// internal cache of loaded image
	internal ImageSurface _img = null;
	private Gdk.Pixbuf _pixbuf = null;					// Internal pixbuf used by loadPixels and updatePixels
	private int _width = 0;
	private int _height = 0;

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public PImage(string path)
	{
		// Check file type
		string ext = System.IO.Path.GetExtension(path).ToLower ();

		// Load from file 
		switch (ext) {
		case ".png":
			_img = new ImageSurface(path);
			_width = _img.Width;
			_height = _img.Height;
			break;
		case ".gif":
		case ".jpg":	// See http://mono.1490590.n4.nabble.com/checking-the-Gdk-Pixbuf-support-for-JPEG-td3747144.html
		case ".jpeg":
		case ".tif":
		case ".tiff":
		case ".xpm":
		case ".xbm":
			Gdk.Pixbuf pb = new Gdk.Pixbuf(path);
			if (!pb.HasAlpha) pb = pb.AddAlpha (false, 0, 0, 0); 
			_img = new ImageSurface(Format.Argb32, pb.Width, pb.Height);
			_width = pb.Width;
			_height = pb.Height;
			using (Context g = new Cairo.Context(_img)) {
				Gdk.CairoHelper.SetSourcePixbuf(g, pb, 0.0, 0.0);
				g.Paint ();
			};
			break;
		default:
			string msg = String.Format ("Don't know how to load an image file with extension {0}", ext);
			throw new Exception(msg);
		}
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public PImage(int width, int height, Cairo.Format format)
	{	// Create a new PImage from a Cairo ImageSurface
		_img = new ImageSurface(format, width, height);
		_width = width;
		_height = height;
	}
	public PImage(int width, int height) : this(width, height, Cairo.Format.ARGB32) { }
	public PImage() : this(300, 300, Cairo.Format.ARGB32) { }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public int width() {
		return _width;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public int height() {
		return _height;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public void loadPixels() 
	{	// Copy pixels from current image to pixbuf
		if (_img  == null) return;

		Gdk.Pixbuf pixbuf = null;

		// Create a new pixmap and context
		Gdk.Pixmap pm = new Gdk.Pixmap(null, _width, _height, 24);
		using (Context g = Gdk.CairoHelper.Create(pm)) {
			// Paint internal Cairo image onto pixmap
			g.SetSourceSurface (_img, 0, 0);
			g.Paint ();
		}

		// Convert pixmap to pixbuf
		Gdk.Colormap colormap = pm.Colormap;
		pixbuf = Gdk.Pixbuf.FromDrawable (pm, colormap, 0, 0, 0, 0, _width, _height);

		if (pixbuf != null) {
			_pixbuf = pixbuf;
			if (!_pixbuf.HasAlpha) _pixbuf = _pixbuf.AddAlpha (false, 0, 0, 0);
		}
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public void updatePixels() 
	{	// Copy pixels from pixbuf to image
		if (_img  == null) return;
		if (_pixbuf == null) return;

		using (Context g = new Cairo.Context(_img)) {
			Gdk.CairoHelper.SetSourcePixbuf(g, _pixbuf, 0.0, 0.0);
			g.Paint ();
		}
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public void setPixel(int x, int y, byte r, byte g, byte b, byte a) 
	{	// Set an individual pixel in the pixbuf
		if (_pixbuf == null) return;
		System.Runtime.InteropServices.Marshal.WriteByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 0, r);
		System.Runtime.InteropServices.Marshal.WriteByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 1, g);
		System.Runtime.InteropServices.Marshal.WriteByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 2, b);
		System.Runtime.InteropServices.Marshal.WriteByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 3, a);
	}
	public void setPixel(int x, int y, byte r, byte g, byte b) { setPixel(x, y, r, g, b, 255); }
	public void setPixel(int x, int y, byte g, byte a) { setPixel(x, y, g, g, g, a); }
	public void setPixel(int x, int y, byte g) { setPixel(x, y, g, g, g, 255); }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public void setPixel(int x, int y, uint c) 
	{	// Set an individual pixel in the pixbuf
		if (_pixbuf == null) return;
		System.Runtime.InteropServices.Marshal.WriteByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 0, red (c));
		System.Runtime.InteropServices.Marshal.WriteByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 1, green (c));
		System.Runtime.InteropServices.Marshal.WriteByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 2, blue (c));
		System.Runtime.InteropServices.Marshal.WriteByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 3, alpha (c));
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public uint getPixel(int x, int y) 
	{	// Set an individual pixel in the pixbuf
		if (_pixbuf == null) return 0;
		byte r = System.Runtime.InteropServices.Marshal.ReadByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 0);
		byte g = System.Runtime.InteropServices.Marshal.ReadByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 1);
		byte b = System.Runtime.InteropServices.Marshal.ReadByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 2);
		byte a = System.Runtime.InteropServices.Marshal.ReadByte (_pixbuf.Pixels, y * _pixbuf.Rowstride + x * _pixbuf.NChannels + 3);
		return color (r, g, b, a);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public byte blue(uint c)
	{	// Extract color byte from a color (unsigned int)
		 return (byte)((c & 0x000000FF));
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public byte green(uint c)
	{	// Extract color byte from a color (unsigned int)
		 return (byte)((c & 0x0000FF00) >> 8);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public byte red(uint c)
	{	// Extract color byte from a color (unsigned int)
		 return (byte)((c & 0x00FF0000) >> 16);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public byte alpha(uint c)
	{	// Extract color byte from a color (unsigned int)
		 return (byte)((c & 0xFF000000) >> 24);
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public uint color(byte r, byte g, byte b, byte a)
	{	// Create color from color byte components
		 return (uint)( b | (g << 8) | (r << 16) | (a << 24));
	}
	public uint color(byte r, byte g, byte b) { return color(r, g, b, 255); }
	public uint color(byte g, byte a) { return color(g, g, g, a); }
	public uint color(byte g) { return color(g, g, g, 255); }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public void resize(int w, int h) 
	{	// reset image size
		if (_img == null) return;
		Cairo.ImageSurface timg = new Cairo.ImageSurface(_img.Format, w, h);

		// TODO: This doesn't do what it is supposed to yet !!!
		// This is supposed to resize the image data.
		// At the moment it just copies 
		// FIX!!!

		// If the internal image already exists, copy to the new one
		using (Context g = new Context(timg)) {
			g.SetSource(_img);
			g.Paint ();
		}
		_img = timg;

		_width = w;
		_height = h;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public void save(string path, bool force) 
	{	// Save image to a file
		if (_img == null) return;

		// Check if exists and not to overwrite.
		if (System.IO.File.Exists(path) == true && force == false) {
			throw new Exception("That path already exists. Use save(path, True) to force the file to be overwritten.");
		}

		// Check extension
		string ext = System.IO.Path.GetExtension(path).ToLower ();
		ext = ext.Replace (".", "");
		if (ext.Length == 0) {
			throw new Exception("Image file must have a valid extension, such as .png or .jpg");
		}

		// Load image data into a pixbuf
		loadPixels();

		// Try to do the save
		_pixbuf.Save (path, ext);

	}
	public void save(string path) { save(path, false); }

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
}

// ------------------ PKnot support ---------------------------------------
internal enum PKnotType {
	VERTEX, CURVE, BEZIER
}

internal class PKnot 
{	// Class to hold knots for splines
	public double x, y;
	public double cx1, cy1, cx2, cy2;		// Control points for bezier and curve vertexes
	public double a;						// Angle of control points, for curve vertexes only
	public double d;						// length of segment from previous knot
	public PKnotType type;

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
	public PKnot(double x, double y, PKnotType type) {
		this.x = x;
		this.y = y;
		this.type = type;
	}
	public PKnot(double x, double y, double cx1, double cy1, double cx2, double cy2, PKnotType type) 
		: this(x, y, type) {
		this.cx1 = cx1;
		this.cy1 = cy1;
		this.cx2 = cx2;
		this.cy2 = cy2;
	}

	// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
}
