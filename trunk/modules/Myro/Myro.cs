using System;
using System.IO.Ports;
using System.Threading;
using IronPython.Runtime;
using System.Collections.Generic; // IList

public static class Myro {
  public static Robot robot;
  public static string REVISION = "$Revision: $";
  
  public static void init(string port, int baud=38400) {
	robot = new Scribbler(port, baud);
  }
  
  public static void forward(double power=1, double? time=null) {
	robot.forward(power, time);
  }
  
  public static void backward(double power=1, double? time=null) {
	robot.backward(power, time);
  }

  public static void stop() {
	robot.stop();
  }
  
  public static void beep(double duration, double? frequency=null, 
	  double? frequency2=null) {
	robot.beep(duration, frequency, frequency2);
  }

  public class Robot {

	public Object myLock = new Object();

    public virtual void move(double translate, double rotate) {
	  // Override in subclassed robots
	}

    public virtual void beep(double duration, double? frequency=null, 
		double? frequency2=null) {
	  // Override in subclassed robots
	}

	public void stop() {
	  move(0, 0);
	}

	public void forward(double speed, double? interval) {
	  move(speed, 0);
	  if (interval != null) {
		Thread.Sleep((int)(interval * 1000)); 
		stop();
	  }
	}
	
	public void backward(double speed, double? interval) {
	  move(-speed, 0);
	  if (interval != null) {
		Thread.Sleep((int)(interval * 1000)); 
		stop();
	  }
	}
	
  }

  public static bool Contains(object item, params object[] items) {
	return ((IList<object>)items).Contains(item);
  }
  
  [Serializable()]
  public class Scribbler: Robot {
	public string port;
	public SerialPort serial;
	public string dongle;
	public int volume;
	public string startsong;

	private double _lastTranslate;
	private double _lastRotate;
	private byte [] _lastSensors;

    static byte SOFT_RESET=33;
    static byte GET_ALL=65 ;
    static byte GET_ALL_BINARY=66  ;
    static byte GET_LIGHT_LEFT=67  ;
    static byte GET_LIGHT_CENTER=68  ;
    static byte GET_LIGHT_RIGHT=69  ;
    static byte GET_LIGHT_ALL=70  ;
    static byte GET_IR_LEFT=71  ;
    static byte GET_IR_RIGHT=72  ;
    static byte GET_IR_ALL=73  ;
    static byte GET_LINE_LEFT=74  ;
    static byte GET_LINE_RIGHT=75  ;
    static byte GET_LINE_ALL=76  ;
    static byte GET_STATE=77  ;
    static byte GET_NAME1=78;
    static byte GET_NAME2=64;
    static byte GET_STALL=79  ;
    static byte GET_INFO=80  ;
    static byte GET_DATA=81  ;

    static byte GET_PASS1=50;
    static byte GET_PASS2=51;

    static byte GET_RLE=82 ; // a segmented and run-length encoded image
    static byte GET_IMAGE=83 ; // the entire 256 x 192 image in YUYV format
    static byte GET_WINDOW=84 ; // the windowed image (followed by which window)
    static byte GET_DONGLE_L_IR=85 ; // number of returned pulses when
									// left emitter is turned on
    static byte GET_DONGLE_C_IR=86 ; // number of returned pulses when
									// center emitter is turned on
    static byte GET_DONGLE_R_IR=87 ; // number of returned pulses when
									// right emitter is turned on
    static byte GET_WINDOW_LIGHT=88   ; // average intensity in the
									   // user defined region
    static byte GET_BATTERY=89 ; // battery voltage
    static byte GET_SERIAL_MEM=90 ; // with the address returns the
								   // value in serial memory
    static byte GET_SCRIB_PROGRAM=91 ; // with offset, returns the
									  // scribbler program buffer
    static byte GET_CAM_PARAM=92; // with address, returns the camera parameter at that address

    static byte GET_BLOB=95;

    static byte SET_PASS1=55;
    static byte SET_PASS2=56;
    static byte SET_SINGLE_DATA=96;
    static byte SET_DATA=97;
    static byte SET_ECHO_MODE=98;
    static byte SET_LED_LEFT_ON=99 ;
    static byte SET_LED_LEFT_OFF=100;
    static byte SET_LED_CENTER_ON=101;
    static byte SET_LED_CENTER_OFF=102;
    static byte SET_LED_RIGHT_ON=103;
    static byte SET_LED_RIGHT_OFF=104;
    static byte SET_LED_ALL_ON=105;
    static byte SET_LED_ALL_OFF=106;
    static byte SET_LED_ALL=107 ;
    static byte SET_MOTORS_OFF=108;
    static byte SET_MOTORS=109 ;
    static byte SET_NAME1=110 ;
    static byte SET_NAME2=119;           // set name2 byte
	static byte SET_LOUD=111;
    static byte SET_QUIET=112;
    static byte SET_SPEAKER=113;
    static byte SET_SPEAKER_2=114;

    static byte SET_DONGLE_LED_ON=116;   // turn binary dongle led on
    static byte SET_DONGLE_LED_OFF=117;  // turn binary dongle led off
    static byte SET_RLE=118;             // set rle parameters 
    static byte SET_DONGLE_IR=120;       // set dongle IR power
    static byte SET_SERIAL_MEM=121;      // set serial memory byte
    static byte SET_SCRIB_PROGRAM=122;   // set scribbler program memory byte
    static byte SET_START_PROGRAM=123;   // initiate scribbler
										// programming process 
    static byte SET_RESET_SCRIBBLER=124; // hard reset scribbler
    static byte SET_SERIAL_ERASE=125;    // erase serial memory
    static byte SET_DIMMER_LED=126;      // set dimmer led
    static byte SET_WINDOW=127;          // set user defined window
    static byte SET_FORWARDNESS=128;     // set direction of scribbler
    static byte SET_WHITE_BALANCE=129;   // turn on white balance on camera 
    static byte SET_NO_WHITE_BALANCE=130; // diable white balance on
										 // camera (default)
    static byte SET_CAM_PARAM=131;       // with address and value, 
	                                    // sets the camera parameter
	                                    // at that address

    static byte GET_JPEG_GRAY_HEADER=135;
	static byte GET_JPEG_GRAY_SCAN=136;
    static byte GET_JPEG_COLOR_HEADER=137;
    static byte GET_JPEG_COLOR_SCAN=138;

    static byte SET_PASS_N_BYTES=139;
    static byte GET_PASS_N_BYTES=140;
    static byte GET_PASS_BYTES_UNTIL=141;

    static byte GET_VERSION=142;

    static byte GET_IR_MESSAGE = 150;
    static byte SEND_IR_MESSAGE = 151;
    static byte SET_IR_EMITTERS = 152;

    static byte PACKET_LENGTH     =  9;
    	
	// #### Camera Addresses ####
	static byte CAM_PID=0x0A;
	static byte CAM_PID_DEFAULT=0x76;
	static int	CAM_VER=0x0B;
	static byte CAM_VER_DEFAULT=0x48;
	static byte CAM_BRT=0x06;
	static byte CAM_BRT_DEFAULT=0x80;
	static byte CAM_EXP=0x10;
	static byte CAM_EXP_DEFAULT=0x41;
	static byte CAM_COMA=0x12;
	static byte CAM_COMA_DEFAULT=0x14;
	static byte CAM_COMA_WHITE_BALANCE_ON= (byte)(CAM_COMA_DEFAULT |  (1 << 2));
	static byte CAM_COMA_WHITE_BALANCE_OFF=(byte)(CAM_COMA_DEFAULT & ~(1 << 2));
	static byte CAM_COMB=0x13;
	static byte CAM_COMB_DEFAULT=0xA3;
	static byte CAM_COMB_GAIN_CONTROL_ON= (byte)(CAM_COMB_DEFAULT |  (1 << 1));
	static byte CAM_COMB_GAIN_CONTROL_OFF=(byte)(CAM_COMB_DEFAULT & ~(1 << 1));
	static byte CAM_COMB_EXPOSURE_CONTROL_ON= (byte)(CAM_COMB_DEFAULT |  (1 << 0));
	static byte CAM_COMB_EXPOSURE_CONTROL_OFF=(byte)(CAM_COMB_DEFAULT & ~(1 << 0));

	public Scribbler(string port, int baud) {
	  PythonDictionary info = null;
	  this.port = port;
	  if (Myro.robot is Scribbler) {
		if (((Scribbler)(Myro.robot)).serial is SerialPort) {
		  if (((Scribbler)(Myro.robot)).serial.IsOpen) {
			((Scribbler)(Myro.robot)).serial.Close();
		  }
		}
	  }
	  serial = new SerialPort(this.port, baud);
	  serial.ReadTimeout = 100; // milliseconds
	  try {
		serial.Open();
	  } catch {
		Console.WriteLine(String.Format("ERROR: unable to open '{0}'", 
				this.port));
		return;
	  }
	  try {
		info = getInfo();
	  } catch {
		Console.WriteLine("ERROR: unable to talk to Scribbler");
	  }
	  if (info.Contains("fluke")) {
		dongle = (string)info["fluke"];
		Console.WriteLine("You are using fluke firmware {0}", info["fluke"]);
	  } else if (info.Contains("dongle")) {
		dongle = (string)info["dongle"];
		Console.WriteLine("You are using fluke firmware {0}", info["dongle"]);
	  } else {
		dongle = null;
		Console.WriteLine("You are using the scribbler without the fluke");
	  }
	  stop();
	  Set("led", "all", "off");
	  beep(.03, 784);
	  beep(.03, 880);
	  beep(.03, 698);
	  beep(.03, 349);
	  beep(.03, 523);
	  string name = (string)Get("name");
	  Console.WriteLine("Hello, I'm {0}!", name);
	}

	// ------------------------------------------------------------
	// Data structures:
	public PythonDictionary dict(params object [] list) {
	  // make a dictionary from a list
	  PythonDictionary retval = new PythonDictionary();
	  for (int i = 0; i < list.Length; i += 2) {
		retval[list[i]] = list[i+1];
	  }
	  return retval;
	}

	public List list(params object [] items) {
	  // make a list from an array
	  List retval = new List();
	  for (int i = 0; i < items.Length; i++) {
		retval.append(items[i]);
	  }
	  return retval;
	}
	// ------------------------------------------------------------

    public byte [] GetBytes(byte value, int bytes=1) {
	  byte [] retval = null;
	  lock(myLock) {
		write_packet(value);
		read(Scribbler.PACKET_LENGTH); // read the echo
		retval = read(bytes);
	  }
	  return retval;
	}

    public List GetWord(byte value, int bytes=1) {
	  List retval = new List();
	  lock(myLock) {
		write_packet(value);
		read(Scribbler.PACKET_LENGTH); // read the echo
		byte [] retvalBytes = read(bytes);
		for (int p = 0; p < retvalBytes.Length; p += 2) {
		  retval.append(retvalBytes[p] << 8 | retvalBytes[p + 1]);
		}
	  }
	  return retval;
	}

    public object Get(string sensor="all") {
	  return Get(sensor, null);
	}

    public object Get(string sensor="all", params object [] position) {
	  object retval = null;
	  sensor = sensor.ToLower();
	  if (sensor == "config") {
		if (dongle == null) {
		  return dict("ir", 2, "line", 2, "stall", 1, "light", 3);
		} else {
		  return dict("ir", 2, "line", 2, "stall", 1, "light", 3,
			  "battery", 1, "obstacle", 3, "bright", 3);
		}
	  } else if (sensor == "stall") {
		// lastSensors are the single byte sensors
		_lastSensors = GetBytes(Scribbler.GET_ALL, 11); 
		// returned as bytes
		return (object)(_lastSensors[10]);
	  } else if (sensor == "forwardness") {
		if (read_mem(0, 0) != 0xDF) {
		  retval = "fluke-forward";
		} else {
		  retval = "scribbler-forward";
		}
		return retval;
	  } else if (sensor == "startsong") {
		//TODO: need to get this from flash memory
		return "tada";
	  } else if (sensor == "version") {
		//TODO: just return this version for now; get from flash
		return REVISION.Split()[1];
	  } else if (sensor == "data") {
		//return getData(position);
	  } else if (sensor == "info") {
		return getInfo();
	  } else if (sensor == "name") {
		string s = "";
		byte [] c1 = GetBytes(Scribbler.GET_NAME1, 8);
		byte [] c2 = GetBytes(Scribbler.GET_NAME2, 8);
		foreach (char c in c1)
		  if ((int)c >= (int)'0' & (int)c <= 'z')
			s += c;
		foreach (char c in c2)
		  if ((int)c >= (int)'0' & (int)c <= 'z')
			s += c;
		//c = string.join([chr(x) for x in c if "0" <= chr(x) <= "z"], '').strip();
		return s;
	  } else if (sensor == "password") {
		string c = "Scribby";
		byte [] c1 = GetBytes(Scribbler.GET_PASS1, 8);
		byte [] c2 = GetBytes(Scribbler.GET_PASS2, 8);
		//c = string.join([chr(x) for x in c if "0" <= chr(x) <= "z"], '').strip();
		return c;
	  } else if (sensor == "volume") {
		return volume;
	  } else if (sensor == "battery") {
		//return getBattery();
	  } else if (sensor == "blob") {
		//return getBlob();
	  } else {
		if (position.Length == 0) {
		  if (sensor == "light") {
			return GetWord(Scribbler.GET_LIGHT_ALL, 6);
		  } else if (sensor == "line") {
			return GetBytes(Scribbler.GET_LINE_ALL, 2);
		  } else if (sensor == "ir") {
			return GetBytes(Scribbler.GET_IR_ALL, 2);
		  } else if (sensor == "obstacle") {
			return list(getObstacle("left"), 
				getObstacle("center"), 
				getObstacle("right"));
		  } else if (sensor == "bright") {
			return list(getBright("left"), 
				getBright("middle"), 
				getBright("right"));
		  } else if (sensor == "all") {
			_lastSensors = GetBytes(Scribbler.GET_ALL, 11); 
			// returned as bytes
			// single bit sensors
			if (dongle == null) {
			  return dict(
				  "light", list(_lastSensors[2] << 8 | _lastSensors[3], 
					  _lastSensors[4] << 8 | _lastSensors[5], 
					 _lastSensors[6] << 8 |_lastSensors[7]),
				  "ir", list(_lastSensors[0],_lastSensors[1]), 
				  "line", list(_lastSensors[8],_lastSensors[9]), 
				  "stall",_lastSensors[10]);
			} else {
			  return dict(
				  "light", list(_lastSensors[2] << 8 |_lastSensors[3], 
					 _lastSensors[4] << 8 |_lastSensors[5], 
					 _lastSensors[6] << 8 |_lastSensors[7]),
				  "ir", list(_lastSensors[0],_lastSensors[1]), 
				  "line", list(_lastSensors[8],_lastSensors[9]), 
				  "stall",_lastSensors[10],
				  "obstacle", list(getObstacle("left"), 
					  getObstacle("center"), 
					  getObstacle("right")),
				  "bright", list(getBright("left"), 
					  getBright("middle"), 
					  getBright("right")),
				  "blob", getBlob(),
				  "battery", getBattery()
						  );
			}
		  } else {
			throw new Exception(String.Format("invalid sensor name: '{0}'", 
					sensor));
		  }
		}
		List retvals = list();
		foreach (object pos in position) {
		  if (sensor == "light") {
			List values = GetWord(Scribbler.GET_LIGHT_ALL, 6);
			if (Contains(pos, 0, "left")) {
			  retvals.append((int)values[0]);
			} else if (Contains(pos, 1, "middle", "center")) {
			  retvals.append((int)values[1]);
			} else if (Contains(pos, 2, "right")) {
			  retvals.append((int)values[2]);
			} else if (pos == null | (string)pos == "all") {
			  retvals.append(values);
			}
		  } else if (sensor == "ir") {
			byte [] values = GetBytes(Scribbler.GET_IR_ALL, 2);
			if (Contains(pos, 0, "left")) {
			  retvals.append((int)values[0]);
			} else if (Contains(pos, 1, "right")) {
			  retvals.append((int)values[1]);
			} else if (pos == null | (string)pos == "all") {
			  retvals.append(values);
			}
		  } else if (sensor == "line") {
			byte [] values = GetBytes(Scribbler.GET_LINE_ALL, 2);
			if (Contains(pos, 0, "left")) {
			  retvals.append((int)values[0]);
			} else if (Contains(pos, 1, "right")) {
			  retvals.append((int)values[1]);
			}
		  } else if (sensor == "obstacle") {
			return getObstacle(pos);
		  } else if (sensor == "bright") {
			return getBright(pos);
		  } else if (sensor == "picture") {
			return takePicture(pos);
		  } else {
			throw new Exception(String.Format("invalid sensor name: '{0}'",
					sensor));
		  }
		}
		if (retvals.__len__() == 0) {
		  return null;
		} else if (retvals.__len__() == 1) {
		  return retvals[0];
		} else {
		  return retvals;
		}
	  }
	  return null;
	}
	/*
        sensor = sensor.lower()
        if sensor == "config":
            if dongle == null:
                return {"ir": 2, "line": 2, "stall": 1, "light": 3}
            else:
                return {"ir": 2, "line": 2, "stall": 1, "light": 3,
                        "battery": 1, "obstacle": 3, "bright": 3}
        elif sensor == "stall":
            retval = GetBytes(Scribbler.GET_ALL, 11) // returned as bytes
           _lastSensors = retval // single bit sensors
            return retval[10]
        elif sensor == "forwardness":
            if read_mem(ser, 0, 0) != 0xDF:
                retval = "fluke-forward"
            else:
                retval = "scribbler-forward"
            return retval
        elif sensor == "startsong":
            //TODO: need to get this from flash memory
            return "tada"
        elif sensor == "version":
            //TODO: just return this version for now; get from flash
            return __REVISION__.split()[1]
        elif sensor == "data":
            return getData(*position)
        elif sensor == "info":
            return getInfo(*position)
        elif sensor == "name":
            c = GetBytes(Scribbler.GET_NAME1, 8)
            c += GetBytes(Scribbler.GET_NAME2, 8)
            c = string.join([chr(x) for x in c if "0" <= chr(x) <= "z"], '').strip()
            return c
        elif sensor == "password":
            c = GetBytes(Scribbler.GET_PASS1, 8)
            c += GetBytes(Scribbler.GET_PASS2, 8)
            c = string.join([chr(x) for x in c if "0" <= chr(x) <= "z"], '').strip()
            return c
        elif sensor == "volume":
            return volume
        elif sensor == "battery":
            return getBattery()
        elif sensor == "blob":
            return getBlob()
        else:
            if position.Length == 0:
                if sensor == "light":
                    return GetWord(Scribbler.GET_LIGHT_ALL, 6)
                elif sensor == "line":
                    return GetBytes(Scribbler.GET_LINE_ALL, 2)
                elif sensor == "ir":
                    return GetBytes(Scribbler.GET_IR_ALL, 2)
                elif sensor == "obstacle":
                    return [getObstacle("left"), getObstacle("center"), getObstacle("right")]
                elif sensor == "bright":
                    return [getBright("left"), getBright("middle"), getBright("right") ]
                elif sensor == "all":
                    retval = GetBytes(Scribbler.GET_ALL, 11) // returned as bytes
                   _lastSensors = retval // single bit sensors
                    if dongle == null:
                        return {"light": [retval[2] << 8 | retval[3], retval[4] << 8 | retval[5], retval[6] << 8 | retval[7]],
                                "ir": [retval[0], retval[1]], "line": [retval[8], retval[9]], "stall": retval[10]}
                    else:
                        return {"light": [retval[2] << 8 | retval[3], retval[4] << 8 | retval[5], retval[6] << 8 | retval[7]],
                                "ir": [retval[0], retval[1]], "line": [retval[8], retval[9]], "stall": retval[10],
                                "obstacle": [getObstacle("left"), getObstacle("center"), getObstacle("right")],
                                "bright": [getBright("left"), getBright("middle"), getBright("right")],
                                "blob": getBlob(),
                                "battery": getBattery(),
                                }
                else:                
                    raise ("invalid sensor name: '%s'" % sensor)
            retvals = []
            for pos in position:
                if sensor == "light":
                    values = GetWord(Scribbler.GET_LIGHT_ALL, 6)
                    if pos in [0, "left"]:
                        retvals.append(values[0])
                    elif pos in [1, "middle", "center"]:
                        retvals.append(values[1])
                    elif pos in [2, "right"]:
                        retvals.append(values[2])
                    elif pos == null | pos == "all":
                        retvals.append(values)
                elif sensor == "ir":
                    values = GetBytes(Scribbler.GET_IR_ALL, 2)                    
                    if pos in [0, "left"]:
                        retvals.append(values[0])
                    elif pos in [1, "right"]:
                        retvals.append(values[1])
                    elif pos == null | pos == "all":
                        retvals.append(values)
                elif sensor == "line":
                    values = GetBytes(Scribbler.GET_LINE_ALL, 2)
                    if pos in [0, "left"]:
                        retvals.append(values[0])
                    elif pos in [1, "right"]:
                        retvals.append(values[1])
                elif sensor == "obstacle":
                    return getObstacle(pos)
                elif sensor == "bright":
                    return getBright(pos)
                elif sensor == "picture":
                    return takePicture(pos)
                else:
                    raise ("invalid sensor name: '%s'" % sensor)
            if retvals.Length == 0:
                return null;
            elif retvals.Length == 1:
                return retvals[0]
            else:
                return retvals

    def getData(self, *position):
        if len(position) == 0: 
            return GetBytes(Scribbler.GET_DATA, 8)
        else:   
            retval = []               
            for p in position:
                retval.append(GetBytes(Scribbler.GET_DATA, 8)[p])
            if len(retval) == 1:
                return retval[0]
            else:
                return retval
	*/

	public object setLEDFront(string value) {
	  return 0;
	}
	public object setLEDBack(string value) {
	  return 0;
	}
	public object setWhiteBalance(string position) {
	  return 0;
	}
	public object setIRPower(string position) {
	  return 0;
	}
	public object setEchoMode(string position) {
	  return 0;
	}
	public object setData(string position, string value) {
	  return 0;
	}
	public object setPassword(string position) {
	  return 0;
	}
	public object setForwardness(string position) {
	  return 0;
	}

	public bool isTrue(string value) {
	  return (value == "on");
	}

    public object Set(params byte [] values) {
	  lock(myLock) {
		write_packet(values);
		read(Scribbler.PACKET_LENGTH); // read echo
		_lastSensors = read(11); // single bit sensors
		/* 
		if (requestStop) {
		  requestStop = false;
		  stop();
		  lock.Release();
		} 
		*/
	  }
	  return "ok";
	}

    public object Set(string item, string position, string value) {
	  if (item == "led") {
		if (position == "center") {
		  if (isTrue(value))
			return Set(Scribbler.SET_LED_CENTER_ON);
		  else
			return Set(Scribbler.SET_LED_CENTER_OFF);
		} else if (position == "left") {
		  if (isTrue(value)) 
			return Set(Scribbler.SET_LED_LEFT_ON);
		  else             
			return Set(Scribbler.SET_LED_LEFT_OFF);
		} else if (position == "right") {
		  if (isTrue(value)) 
			return Set(Scribbler.SET_LED_RIGHT_ON);
		  else
			return Set(Scribbler.SET_LED_RIGHT_OFF);
		} else if (position == "front") {
		  return setLEDFront(value);
		} else if (position == "back") {
		  return setLEDBack(value);
		} else if (position == "all") {
		  if (isTrue(value)) 
			return Set(Scribbler.SET_LED_ALL_ON);
		  else
			return Set(Scribbler.SET_LED_ALL_OFF);
		} else {
		  throw new Exception(String.Format("no such LED: '{0}'", position));
		}
	  } else if (item == "name") {
		//position = position + (" " * 16);
		//name1 = position[:8].strip();
		//name1_raw = map(lambda x:  ord(x), name1);
		//name2 = position[8:16].strip();
		//name2_raw = map(lambda x:  ord(x), name2);
		//Set(*([Scribbler.SET_NAME1] + name1_raw));
		//Set(*([Scribbler.SET_NAME2] + name2_raw));
		return "ok";
	  } else if (item == "password") {
		//position = position + (" " * 16);
		//pass1 = position[:8].strip();
		//pass1_raw = map(lambda x:  ord(x), pass1);
		//pass2 = position[8:16].strip();
		//pass2_raw = map(lambda x:  ord(x), pass2);
		//Set(*([Scribbler.SET_PASS1] + pass1_raw));
		//Set(*([Scribbler.SET_PASS2] + pass2_raw));
		return "ok";
	  } else if (item == "whitebalance") {
		return setWhiteBalance(position);
	  } else if (item == "irpower") {
		return setIRPower(position);
	  } else if (item == "volume") {
		if (isTrue(position)){
		  volume = 1;
		  return Set(Scribbler.SET_LOUD);
		} else {
		  volume = 0;
		  return Set(Scribbler.SET_QUIET);
		}
	  } else if (item == "startsong") {
		startsong = position;
		return "ok";
	  } else if (item == "echomode") {
		return setEchoMode(position);
	  } else if (item == "data") {
		return setData(position, value);
	  } else if (item == "password") {
		return setPassword(position);
	  } else if (item == "forwardness") {
		return setForwardness(position);
	  } else {
		throw new Exception(String.Format("invalid set item name: '{0}'", item));
	  }
	}

	public int getObstacle(object position) {
	  return 0;
	}

	public int getBright(object position) {
	  return 0;
	}

	public int getBlob() {
	  return 0;
	}

	public int getBattery() {
	  return 0;
	}

	public int takePicture(object position) {
	  return 0;
	}

	public PythonDictionary getInfo() {
	  PythonDictionary retDict = new PythonDictionary();
	  int old = serial.ReadTimeout; // milliseconds
	  string retval;
	  // serial.setTimeout(4)
	  serial.ReadTimeout = 4000; // milliseconds
      
	  manual_flush();
	  // have to do this twice since sometime the first echo isn't
	  // echoed correctly (spaces) from the scribbler
	  write_packet(Scribbler.GET_INFO, 32, 32, 32, 32, 32, 32, 32, 32);
	  try {
		retval = serial.ReadLine();
	  } catch {
		serial.ReadTimeout = old;
		return retDict;
	  }
	  //#print "Got", retval

	  Thread.Sleep(100); 
	  //time.sleep(.1)
        
	  write_packet(Scribbler.GET_INFO, 32, 32, 32, 32, 32, 32, 32, 32);
	  try {
		retval = serial.ReadLine();
	  } catch {
		serial.ReadTimeout = old;
		return retDict;
	  }
	  //#print "Got", retval
        
	  //# remove echoes
	  if (retval.Length == 0) {
		serial.ReadTimeout = old;
		return retDict;
	  }
        
	  if (retval[0] == 'P' | retval[0] == 'p') {
		retval = retval.Substring(1);
	  }
        
	  if (retval[0] == 'P' | retval[0] == 'p') {
		retval = retval.Substring(1);
	  }

	  foreach (string pair in retval.Split(',')) {
		if (pair.Contains(":")) {
		  string [] split_pair = pair.Split(':');
		  string it = split_pair[0]; string value = split_pair[1];
		  retDict[it.ToLower().Trim()] = value.Trim();
		}
	  }
	  serial.ReadTimeout = old;
	  return retDict;
	}
	
    public override void move(double translate, double rotate) {
	  _lastTranslate = translate;
	  _lastRotate = rotate;
	  adjustSpeed();
	}

    public void adjustSpeed() {
	  double left  = Math.Min(Math.Max(_lastTranslate - _lastRotate, -1), 1);
	  double right  = Math.Min(Math.Max(_lastTranslate + _lastRotate, -1), 1);
	  byte leftPower = (byte)((left + 1.0) * 100.0);
	  byte rightPower = (byte)((right + 1.0) * 100.0);
	  Set(Scribbler.SET_MOTORS, rightPower, leftPower);
	}

    public override void beep(double duration, double? frequency=null, 
		double? frequency2=null) {
	  lock(myLock) {
		int old = serial.ReadTimeout; // milliseconds
		serial.ReadTimeout = (int)(duration * 1000 + 2000); // milliseconds
		if (frequency2 == null) {
		  set_speaker((int)frequency, (int)(duration * 1000));
		} else {
		  set_speaker_2((int)frequency, (int)frequency2, (int)(duration * 1000));
		}
        read(Scribbler.PACKET_LENGTH + 11);
		serial.ReadTimeout = old; // milliseconds
	  }
	}

    public void set_speaker(int frequency, int duration) {
	  write_packet(Scribbler.SET_SPEAKER, 
		  (byte)(duration >> 8),
		  (byte)(duration % 256),
		  (byte)(frequency >> 8),
		  (byte)(frequency % 256));
	}
        
    public void set_speaker_2(int freq1, int freq2, int duration) {
        write_packet(Scribbler.SET_SPEAKER_2, 
			(byte)(duration >> 8),
			(byte)(duration % 256),
			(byte)(freq1 >> 8),
			(byte)(freq1 % 256),
			(byte)(freq2 >> 8),
			(byte)(freq2 % 256));
	}
	
	public byte [] read(int bytes) {
	  byte[] buffer = new byte[bytes];
	  int len = 0;
	  try {
		len = serial.Read(buffer, 0, (int)buffer.Length);
	  } catch {
		// pass
	  }
	  if (len != bytes) 
		Console.WriteLine("read: Wrong number of bytes read");
	  //sp.BaseStream.Read(buffer, 0, (int)buffer.Length);
	  if (dongle == null) {
		// HACK! THIS SEEMS TO NEED TO BE HERE!
		Thread.Sleep(10); 
	  }
	  return buffer;
	}

	public string read() {
	  //byte[] buffer = new byte[256];
	  //len = _serial.Read(buffer, 0, (int)buffer.Length);
	  //sp.BaseStream.Read(buffer, 0, (int)buffer.Length);
	  byte tmpByte;
	  string rxString = "";
	  try {
		tmpByte = (byte) serial.ReadByte();
		while (tmpByte != 255) {
		  rxString += ((char) tmpByte);
		  try {
			tmpByte = (byte) serial.ReadByte();			
		  } catch {
			// pass
		  }
		}
	  } catch {
	  }
	  return rxString;
	}
	
	public int read_mem(int page, int offset) {
	  write_byte(Scribbler.GET_SERIAL_MEM);
	  write_bytes(page);
	  write_bytes(offset);
	  return read(1)[0];
	}

	public void write_byte(params byte [] b) {
	  serial.Write(b, 0, 1);
	}

	public void write_bytes(int value) {
	  write_byte((byte)((value >> 8) & 0xFF));
	  write_byte((byte)(value & 0xFF));
	}

	public void write_packet(params byte [] data) {
	  // serial.Write(System.Array[System.Byte]([109, 100, 100, 0, 0,
	  // 0, 0, 0, 0]), 0, 9)	  
	  byte [] buffer = new byte [Scribbler.PACKET_LENGTH]; 
	  try {
		serial.Write(data, 0, data.Length);
	  } catch {
		Console.WriteLine("ERROR: in write");
	  }
	  if (Scribbler.PACKET_LENGTH - data.Length > 0) {
		try {
		  serial.Write(buffer, 0, Scribbler.PACKET_LENGTH - data.Length);
		} catch {
		  Console.WriteLine("ERROR: in write");
		}
	  } 
	  Console.Write("[");
	  for (int i = 0; i < data.Length; i++) {
		Console.Write("'0x{0:x}', ", data[i]);
	  }
	  for (int i = 0; i < Scribbler.PACKET_LENGTH - data.Length; i++) {
		Console.Write("'0x{0:x}', ", 0);
	  }
	  Console.WriteLine("]");
	}

	public void manual_flush() {
	  int old = serial.ReadTimeout; // milliseconds
	  //old = ser.timeout
	  //ser.setTimeout(.5)
	  serial.ReadTimeout = 500; // milliseconds
	  string l = "a";
	  int count = 0;
	  while (l.Length != 0 & count < 50000) {
		l = read();
		count += l.Length;
	  }
	  serial.ReadTimeout = old;
	}

  }
}

