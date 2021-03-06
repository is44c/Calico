//
//  ProcedureBlocks.cs
//  
//  Author:
//       Mark F. Russo <russomf@gmail.com>
// 
//  Copyright (c) 2013 The Calico Project
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Cairo;
using Microsoft.Scripting.Hosting;

namespace Jigsaw
{
	// -----------------------------------------------------------------------
    public class CProcedureStart : CBlock
    {	// Procedure start block shape class
		
		public CEdge StartEdge = null;
		
		// To hold ordered list of arguments passed to procedure when called
		public List<object> Args = null;
		
		// Private list of argument names
		private List<string> _argnames = new List<string>();
		
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        public CProcedureStart(Double X, Double Y, Widgets.CBlockPalette palette = null) 
			: base(new List<Diagram.CPoint>(new Diagram.CPoint[] { 
				new Diagram.CPoint(X, Y), 
				new Diagram.CPoint(X + CBlock.BlockWidth, Y + 60) }),
				palette) 
		{
			this.LineWidth = 2;
			this.LineColor = Diagram.Colors.Purple;
			this.FillColor = Diagram.Colors.Thistle;
			this.Sizable = false;
			this.Text = "define ...";
			
			double offsetX = 0.5*this.Width + 10.0;
			StartEdge = new CEdge(this, "Start", EdgeType.Out, null, offsetX, 30.0, 20.0, 30.0, this.Width-20.0);

			_textYOffset = 20;							// Block text offset
			
			// Properties
			CVarNameProperty ProcName = new CVarNameProperty("Procedure Name", "MyProc");
			ProcName.PropertyChanged += OnPropertyChanged;
			_properties["Procedure Name"] = ProcName;
			
			// Parameter properties
			for (int i=1; i<=5; i++) {
				string paramname = String.Format ("Param{0}", i);
				CVarNameProperty Par = new CVarNameProperty(paramname, "");
				Par.PropertyChanged += OnPropertyChanged;
				_properties[paramname] = Par;
				_argnames.Add (paramname);
			}

			this.OnPropertyChanged(null, null);
		}
		
		public CProcedureStart(Double X, Double Y) : this(X, Y, null) {}
		
		// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
		public override List<CEdge> Edges 
		{	// Return a list of all edges
			// Procedure start blocks only have an inner start edge
			get {
				return new List<CEdge>() { this.StartEdge };
			}
		}
		
		// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
		internal override CEdge GetEdgeByName(string name)
		{
			// First try base class behavior.
			// If edge not found, look for custom edges.
			string tname = name.ToLower();
			
			CEdge e = base.GetEdgeByName(tname);
			if (e == null) {
				if (tname == "start") {
					e = StartEdge;
				}
			}
			return e;
		}
		
		// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        public override Diagram.CShape HitShape(Diagram.CPoint pt, Diagram.Canvas cvs)
        {	// If this block is hit, return a self reference.
        	
			if (!this.visible) return null;
			
			double X = pt.X;
			double Y = pt.Y;
			double Ymin = this.Top;
			double Xmin = this.Left;
			double Ymax = Ymin + this.Height;
			double Xmax = Xmin + this.Width;
			
			// If point in outer bounding box...
			if (X >= Xmin && X <= Xmax && Y >= Ymin && Y <= Ymax)
			{	// ...and also in inner bounding box
				if (X >= (Xmin + 20) && Y >= (Ymin + 30) && Y <= (Ymax - 30))
				{	// ...then not hit
					return null;
				}
				else
				{	// Otherwise, hit
					return this;
				}
			}
			else
			{	// Not hit if outside outer bounding box
				return null;
			}
        }
		
		// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
		public override void RepositionBlocks(CEdge entryEdge)
		{	// Reposition this block wrt the entry edge

			if (this.StartEdge.IsConnected) {
				CEdge linkedEdge = this.StartEdge.LinkedTo;
				CBlock linkedBlock = linkedEdge.Block;
				linkedBlock.RepositionBlocks(linkedEdge);
				this.Height = linkedBlock.StackHeight + 50.0;
				
			} else {
				this.Height = 60.0;
			}
			
			base.RepositionBlocks(entryEdge);
		}
		
        // - - - Private util to build delimited arg list string - - - - - -
		private string argListString
		{
			get {
				List<String> arglist = new List<String>();
				foreach (string aname in _argnames) {
					if (_properties.ContainsKey(aname) && _properties[aname].Text.Length > 0) 
						arglist.Add (_properties[aname].Text);
				}
				return String.Join (", ", arglist);
			}
		}

		// - - - Get procedure name - - - - - - - - - - - - - - -
		public String ProcedureName 
		{
			get 
			{
				return _properties["Procedure Name"].Text;
			}
		}
		
		// - - - Update label when property changes - - - - - - - - - - - -
		public void OnPropertyChanged(object sender, EventArgs e)
		{
			// Update block text
			this.Text = String.Format("define `{0}` ({1})", this.ProcedureName, argListString);
			RaiseBlockChanged();
		}
		
		// - - - 
		public override bool ToPython (StringBuilder o, int indent)
		{
			try
			{
				string sindent = new string (' ', Constant.SPACES * indent);
				string code = String.Format("def {0}({1}):", this.ProcedureName, this.argListString);
				o.AppendFormat("{0}{1}\n", sindent, code);
				
				if (this.StartEdge.IsConnected) {
					CBlock b = this.StartEdge.LinkedTo.Block;
					b.ToPython(o, indent+1);
				} else {
					string sindent2 = new string (' ', Constant.SPACES * (indent+1));
					o.AppendFormat ("{0}pass\n", sindent2);
				}
				
			} catch (Exception ex){
				Console.WriteLine(ex.Message);
				return false;
			}
			
			return true;
		}
		
		// - - - Execute a procedure - - - - - - - - - - - - - - - - -
		public override IEnumerator<RunnerResponse> Runner(ScriptScope scope, CallStack stack) 
		{
			// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
			// Always place this block of code at the top of all block runners
			this.State = RunningState.Running;				// Indicate that the block is running
			RunnerResponse rr = new RunnerResponse();		// Create and return initial response object
			yield return rr;
			
			if (this.BreakPoint == true) {					// Indicate if breakpoint is set on this block
				rr.Action = EngineAction.Pause;				// so that engine can stop
				//rr.Frame = null;
				yield return rr;
			}
			// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
			
			// Create a new ScriptScope using passed variables
			try
			{
				// If connected, replace this runner with the next runner to the stack.
				if (this.StartEdge.IsConnected) {
					// Assemble dictionary of parameters passed to block as initial local scope
					List<String> arglist = new List<String>();
					foreach (string aname in _argnames) {
						if (_properties.ContainsKey(aname) && _properties[aname].Text.Length > 0) 
							arglist.Add (_properties[aname].Text);
					}
					Dictionary<string, object> locals = new Dictionary<string, object>();
					for (int i=0; i<arglist.Count; i++) locals[arglist[i]] = Args[i];
					
					ChainedDictionary chaining  = new ChainedDictionary(locals, stack.globals);
					scope = scope.Engine.CreateScope(chaining);

					rr.Action = EngineAction.Replace;
					rr.Frame = this.StartEdge.LinkedTo.Block.Frame(scope, stack);
				} else {
					// If not connected, just remove this runner
					rr.Action = EngineAction.Remove;
					rr.Frame = null;
				}
				
			} catch (Exception ex) {
				this["Message"] = ex.Message;
				Console.WriteLine (ex.Message);
				this.State = RunningState.Error;
				rr.Action = EngineAction.Error;
				rr.Frame = null;
			}
			
			// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
			// Go into a loop while block remains in an error state
			while (this.State == RunningState.Error) yield return rr;

			// Clean up
			this.Args = null;
			
			// Indicate that the block is no longer running
			this.State = RunningState.Idle;
			yield return rr;
		}
		
		// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
		protected override void SetPath(Cairo.Context g) 
		{
			double x = this.left;
            double y = this.top;
            double w = this.width;
            double h = this.height;
			double r = 6.0;
			double hpi = 0.5*Math.PI;
			
			g.MoveTo( x, y+10);
			g.Arc(    x+50, y+95, 100, -0.665*Math.PI, -0.324*Math.PI);
			g.LineTo( x+w-r, y+10);
			g.Arc(    x+w-r, y+10+r, r, -hpi, 0.0 );
			
			g.LineTo( x+w, y+30-r );
			g.Arc(    x+w-r, y+30-r, r, 0.0, hpi );
			g.LineTo( x+27+20, y+30 );
			g.LineTo( x+24+20, y+30+4 );
			g.LineTo( x+14+20, y+30+4 );
			g.LineTo( x+11+20, y+30 );
			g.LineTo( x+20+r, y+30 );
			g.ArcNegative( x+20+r, y+30+r, r, -hpi, Math.PI );
			g.LineTo( x+20, y+h-20-r );
			g.ArcNegative( x+20+r, y+h-20-r, r, Math.PI, hpi);
			g.LineTo( x+11+20, y+h-20);
			g.LineTo( x+14+20, y+h-20+4);
			g.LineTo( x+24+20, y+h-20+4);
			g.LineTo( x+27+20, y+h-20);
			g.LineTo( x+w-r, y+h-20 );
			g.Arc(    x+w-r, y+h-20+r, r, -hpi, 0.0);
			g.LineTo( x+w, y+h-r );
			g.Arc(    x+w-r, y+h-r, r, 0.0, hpi);
			g.LineTo( x+11, y+h );
			g.LineTo( x+r, y+h );
			g.Arc(    x+r, y+h-r, r, hpi, Math.PI );
			g.LineTo( x, y+10 );
            g.ClosePath();
		}
    }
	
	// -----------------------------------------------------------------------
    public class CProcedureCall : CBlock
    {	// Procedure call block shape class
		
		// This property gets set to the procedure start block to be called
		private CProcedureStart procStartBlock = null;
		
		// Private list of argument names
		private List<string> _argnames = new List<string>();

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        public CProcedureCall(Double X, Double Y, Widgets.CBlockPalette palette = null) 
			: base(new List<Diagram.CPoint>(new Diagram.CPoint[] { 
				new Diagram.CPoint(X, Y),
				new Diagram.CPoint(X + CBlock.BlockWidth, Y + 20)	}),
				palette ) 
		{
			this.LineWidth = 2;
			this.LineColor = Diagram.Colors.Purple;
			this.FillColor = Diagram.Colors.Thistle;;
			this.Sizable = false;
			
			this.Text = "call ...";
			
			// Properties
			CVarNameProperty VarName  = new CVarNameProperty("Variable", "result");
			VarName.PropertyChanged  += OnPropertyChanged;
			_properties["Variable"] = VarName;
			
			CVarNameProperty ProcName = new CVarNameProperty("Procedure Name", "MyProc");
			ProcName.PropertyChanged += OnPropertyChanged;
			_properties["Procedure Name"] = ProcName;
			
			// Create arguments
			for (int i=1; i<=5; i++) {
				string argname = String.Format ("Arg{0}", i);
				CExpressionProperty Arg = new CExpressionProperty(argname, "");
				Arg.PropertyChanged += OnPropertyChanged;
				_properties[argname] = Arg;
				_argnames.Add (argname);
			}
			this.OnPropertyChanged(null, null);
		}
		
		public CProcedureCall(Double X, Double Y) : this(X, Y, null) {}
		
        // - - - Private util to build delimited arg list string - - - - - -
		private string paramListString
		{
			get {
				List<String> paramlist = new List<String>();
				foreach (string aname in _argnames) {
					if (_properties.ContainsKey(aname) && _properties[aname].Text.Length > 0) 
						paramlist.Add (_properties[aname].Text);
				}
				return String.Join (", ", paramlist);
			}
		}
		
		// - - - Get procedure name - - - - - - - - - - - - - - -
		private String ProcedureName 
		{
			get 
			{
				return _properties["Procedure Name"].Text.Trim();
			}
		}

		// - - - Get return variable name - - - - - - - - - - - - - - -
		private String VariableName 
		{
			get 
			{
				return _properties["Variable"].Text.Trim();
			}
		}
		
        // - - - Update text when property changes - - - - - - - - - - - -
		public void OnPropertyChanged(object sender, EventArgs e)
		{
			if (this.VariableName.Length > 0) {
				this.Text = String.Format("`{0}` = `{1}`({2})", this.VariableName, this.ProcedureName, paramListString);
			} else {
				this.Text = String.Format("`{0}`({1})", this.ProcedureName, paramListString);
			}
			RaiseBlockChanged();
		}
		
		// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
		public override bool Compile( ScriptEngine engine, Jigsaw.Canvas cvs )
		{	// Compile the block code into something that can be executed.
			
			// Look for the procedure block being called and save a reference.
			// If a procedure block with matching signature does not exist, we have a compile error.
			procStartBlock = null;
			string pname = this.ProcedureName;
			foreach (CBlock b in cvs.AllBlocks ())
			{
				if (b is CProcedureStart)
				{
					CProcedureStart tblock = (CProcedureStart)b;
					
					if (pname == tblock.ProcedureName) 
					{	// Found it. Save and break.
						procStartBlock = tblock;
						break;
					}
				}
			}
			
			// Check for compile error. Can't find block.
			if (procStartBlock == null) {
				string errmsg = "Compile error. Cannot find procedure named " + pname;
				_properties["Message"].Text = errmsg;
				Console.WriteLine(errmsg);
				return false;
			}
			
			// Compile all expressions passed to procedure
			foreach (string aname in _argnames) {
				CExpressionProperty Arg = (CExpressionProperty)_properties[aname];
				if (Arg.Text.Length > 0) Arg.Compile(engine);
			}
			
			return true;
		}

		// - - - Generate and return Python procedure call - - - - -
		private string ToPython ()
		{
			string code = String.Format("{0}({1})", this.ProcedureName, this.paramListString);
			if (this.VariableName.Length > 0) 
				code = String.Format("{0} = {1}", this.VariableName, code);
			
			return code;
		}
		
		// - - -
		public override bool ToPython (StringBuilder o, int indent)
		{
			try
			{
				string sindent = new string (' ', Constant.SPACES * indent);
				
				string code = this.ToPython ();
				o.AppendFormat("{0}{1}\n", sindent, code);
				
				if (this.OutEdge.IsConnected) {
					CBlock b = this.OutEdge.LinkedTo.Block;
					b.ToPython(o, indent);
				}
				
			} catch (Exception ex){
				Console.WriteLine("{0} (in CProcedureCall.ToPython)", ex.Message);
				return false;
			}
			
			return true;
		}
		
		// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
		public override IEnumerator<RunnerResponse> Runner(ScriptScope scope, CallStack stack) 
		{	// Execute a procedure call
			
			// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
			// Always place this block of code at the top of all block runners
			this.State = RunningState.Running;				// Indicate that the block is running
			RunnerResponse rr = new RunnerResponse();		// Create and return initial response object
			yield return rr;
			
			if (this.BreakPoint == true) {					// Indicate if breakpoint is set on this block
				rr.Action = EngineAction.Pause;				// so that engine can stop
				yield return rr;
			}
			// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
			
			try 
			{	// Set Args to be passed to start block
				List<object> args = new List<object>();
				
				foreach (string aname in _argnames) {
					CExpressionProperty Arg = (CExpressionProperty)_properties[aname];
					if (Arg.Text.Length > 0) args.Add( Arg.Evaluate(scope) );
				}
				procStartBlock.Args = args;
				
				// Create a new Runner from called procedure start block and push on to this call stack
				rr.Action = EngineAction.Add;
				rr.Frame = procStartBlock.Frame(scope, stack);
				
			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
				this["Message"] = ex.Message;
				
				this.State = RunningState.Error;
				rr.Action = EngineAction.Error;
				rr.Frame = null;
			}
			
			yield return rr;
			
			try
			{	// When continue, grab the returned value and assign to variable in this scope, if specified
				CVarNameProperty VarName = (CVarNameProperty)_properties["Variable"];
				SetVariable(scope, VarName.Text, stack.RetVal);	// Why does this not throw an exception when VarName is a zero-length string?
				//Compiler.ExecAssignment(scope, VarName.Text, stack.RetVal);

			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
				this["Message"] = ex.Message;
				
				this.State = RunningState.Error;
				rr.Action = EngineAction.NoAction;
				rr.Frame = null;
			}
			
			// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
			// Go into a loop while block remains in an error state
			while (this.State == RunningState.Error) yield return rr;

			// If connected, replace this runner with the next runner to the stack.
			if (this.OutEdge.IsConnected) {
				rr.Action = EngineAction.Replace;
				rr.Frame = this.OutEdge.LinkedTo.Block.Frame(scope, stack);
			} else {
				// If not connected, just remove this runner
				rr.Action = EngineAction.Remove;
				rr.Frame = null;
			}
			
			// Indicate that the block is no longer running
			this.State = RunningState.Idle;
			yield return rr;
		}
    }
	
	// -----------------------------------------------------------------------
    public class CProcedureReturn : CBlock
    {	// Procedure return block shape class
		
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        public CProcedureReturn(Double X, Double Y, Widgets.CBlockPalette palette = null) 
			: base(new List<Diagram.CPoint>(new Diagram.CPoint[] { 
				new Diagram.CPoint(X, Y), 
				new Diagram.CPoint(X + CBlock.BlockWidth, Y + 20)}),
				palette) 
		{
			this.LineWidth = 2;
			this.LineColor = Diagram.Colors.Purple;
			this.FillColor = Diagram.Colors.Thistle;
			this.Sizable = false;
			this.Text = "return";
			
			// Properties - Variable to return
			CExpressionProperty Expr = new CExpressionProperty("Expression", "0");
			Expr.PropertyChanged += OnPropertyChanged;
			_properties["Expression"] = Expr;
			this.OnPropertyChanged(null, null);
		}
		
		public CProcedureReturn(Double X, Double Y) : this(X, Y, null) {}
		
		// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
		public override List<CEdge> Edges 
		{	// Return a list of all edges
			// Control end blocks only have an input edge
			get {
				return new List<CEdge>() { this.InEdge };
			}
		}
		
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
		public void OnPropertyChanged(object sender, EventArgs e)
		{	// Update text when property changes
			this.Text = String.Format("return `{0}`", this["Expression"]);
			RaiseBlockChanged();
		}
		
		// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
		public override bool Compile(Microsoft.Scripting.Hosting.ScriptEngine engine, Jigsaw.Canvas cvs)
		{
			// Executing a print involves evaluting the given exression
			CExpressionProperty Expr = (CExpressionProperty)_properties["Expression"];
			try {
				Expr.Compile(engine);
			} catch (Exception ex) {
				Console.WriteLine ("Block {0} failed compilation: {1}", this.Name, ex.Message);
				return false;
			}
			return true;
		}
		
		// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
		public override IEnumerator<RunnerResponse> Runner(ScriptScope scope, CallStack stack) 
		{	// Return a value from a procedure call
			
			// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
			// Always place this block of code at the top of all block runners
			this.State = RunningState.Running;				// Indicate that the block is running
			RunnerResponse rr = new RunnerResponse();		// Create and return initial response object
			yield return rr;
			
			if (this.BreakPoint == true) {					// Indicate if breakpoint is set on this block
				rr.Action = EngineAction.Pause;				// so that engine can stop
				//rr.Frame = null;
				yield return rr;
			}
			
			// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
			
			try
			{	// Evaluate return expression
				CExpressionProperty exp = (CExpressionProperty)_properties["Expression"];
				rr.RetVal = exp.Evaluate(scope);
			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
				this["Message"] = ex.Message;
				
				this.State = RunningState.Error;
				rr.Action = EngineAction.Error;
				rr.Frame = null;
			}
			
			// - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
			// Go into a loop while block remains in an error state
			while (this.State == RunningState.Error) yield return rr;
			
			// Remove this frame from call stack and return value
			
			rr.Action = EngineAction.Return;
			rr.Frame = null;
			this.State = RunningState.Idle;
			yield return rr;
			
//			// If connected, replace this runner with the next runner to the stack.
//			if (this.OutEdge.IsConnected) {
//				rr.Action = EngineAction.Replace;
//				rr.Frame = this.OutEdge.LinkedTo.Block.Frame(scope, stack);
//			} else {
//				// If not connected, just remove this runner
//				rr.Action = EngineAction.Remove;
//				rr.Frame = null;
//			}
//			
//			// Indicate that the block is no longer running
//			this.State = BlockState.Idle;
//			yield return rr;
		}

		// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
		protected override void SetPath(Cairo.Context g) 
		{
			double x = this.left;
            double y = this.top;
			
            double w = this.width;
            double h = this.height;
			double r = 6.0;
			double hpi = 0.5*Math.PI;
			
			g.MoveTo( x, y+r );
			g.Arc(    x+r, y+r, r, Math.PI, -hpi );
			g.LineTo( x+11, y );
			g.LineTo( x+14, y+4 );
			g.LineTo( x+24, y+4 );
			g.LineTo( x+27, y );
			g.LineTo( x+w-r, y );
			g.Arc(    x+w-r, y+r, r, -hpi, 0.0 );
			g.LineTo( x+w, y+h-r );
			g.Arc(    x+w-r, y+h-r, r, 0.0, hpi);
			g.LineTo( x+11, y+h );
			g.LineTo( x+r, y+h );
			g.Arc(    x+r, y+h-r, r, hpi, Math.PI );
			g.LineTo( x, y+r );
            g.ClosePath();
		}

		// - - - Generate and return Python translation of a procedure return - - - - -
		private string ToPython ()
		{
			string code = String.Format ("return {0}", this["Expression"]);
			return code;
		}
		
		public override bool ToPython (StringBuilder o, int indent)
		{
			try
			{
				string sindent = new string (' ', Constant.SPACES * indent);
				o.AppendFormat("{0}{1}\n", sindent, this.ToPython ());
				
			} catch (Exception ex){
				Console.WriteLine(ex.Message);
				return false;
			}
			
			return true;
		}
		
		// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
    }
}
