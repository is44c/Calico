// Relfection.Utils
// D.S. Blank <dblank@cs.brynmawr.edu>
// GPL, version 2

using System; // Type
using System.Reflection; // Method...
using System.Collections.Generic; // List
using System.Collections; // List
using System.Threading;// Thread
using System.Xml;


/*
  To get all types in an assembly:
  >>> Reflection.Utils.getTypeNames("Myro")
  ['AudioManager', 'AudioSpecCallbackDelegate', 'Computer', 'Extensions', 
   'Gamepads', 'MessageDialog', 'Myro', 'MyTexView', 'Randomizer', 'Robot', 
   'Scribbler', 'SimScribbler', 'Simulation']

  To get parameter names of those types:
  >>> type = Reflection.Utils.getType("Myro", "Scribbler")
  >>> Reflection.Utils.getConstructorParameterNames(type)
  [['serial'], ['port'], ['port', 'baud']]

  To get types of those parameters:
  >>> type = Reflection.Utils.getType("Myro", "Scribbler")
  >>> Reflection.Utils.getConstructorParameterTypes(type)
  [[<System.IO.Ports.SerialPort>], 
   [<System.String>], [<System.String>, <System.Int32>]]

  To get static methods of Assembly:
  >>> Reflection.Utils.getStaticMethodNames("Myro")
  ['CreateQualifiedName', 'GetAssembly', 'GetCallingAssembly', 
   'GetEntryAssembly', 'GetExecutingAssembly', 'Load', 'Load', 'Load', 'Load', 
   'Load', 'Load', 'Load', 'LoadFile', 'LoadFile', 'LoadFrom', 'LoadFrom', 
   'LoadFrom', 'LoadWithPartialName', 'LoadWithPartialName', 
   'ReflectionOnlyLoad', 'ReflectionOnlyLoad', 'ReflectionOnlyLoadFrom']

  To get static methods of Assembly Class:
  >>> Reflection.Utils.getStaticMethodNames("Myro", "Myro")
  ['ask', 'ask', 'ask', 'askQuestion', 'askQuestion', 'askQuestion', 
   'backward', 'backward', 'beep', 'beep', 'beep', 'beep', 'beep', 'beep', 
   'close_module', 'Color', 'Color', 'Contains', 'copyPicture', 
   'currentTime', ...]

  #NOTE: there is a name for each different signature.

  To get the parameters for an Assembly Class method:
  >>> Reflection.Utils.getParameterNames("Myro", "Myro", "beep")
  [['duration', 'frequency'], ['duration', 'frequency', 'frequency2'], 
   ['duration', 'frequency'], ['duration', 'frequency', 'frequency2'], 
   ['duration', 'frequency'], ['duration', 'frequency', 'frequency2']]

  #NOTE: there is a list for each set of types
  >>> Reflection.Utils.getParameterTypes("Myro", "Myro", "beep")
  [[<System.Double>, <System.Double>], ...]

  Finally, to call a method from a type:
  func = Reflection.Utils.getMethodFromArgValues(Myro, "beep", 1, 440)
  func.Invoke(Myro, new object [] {1, 440});

 */

namespace Reflection
{
	public class Utils
	{

		public class Mapping {
			public string assembly_name;
			public Assembly assembly;
			string fullPath;
			string directory;
			string dllname;
			string mapfile;
			public Dictionary<string,bool> signatures;
			public Dictionary<string,bool> types;
			public Dictionary<string,string> defaults;
			string map;

			public Mapping(string assembly_name) : this(assembly_name, null) {
			}

			public Mapping(string assembly_name, string map) {
				signatures = new Dictionary<string,bool>();
				types = new Dictionary<string,bool>();
				defaults = new Dictionary<string,string>();
				this.assembly_name = assembly_name;
				this.map = map;
                if (this.assembly_name != null) {
    				assembly = getAssembly(assembly_name);
    				if (assembly != null) {
                        fullPath = assembly.Location;
                        directory = System.IO.Path.GetDirectoryName( fullPath );
                        dllname = System.IO.Path.GetFileNameWithoutExtension(fullPath);
                        if (this.map != null) {
    					    mapfile = System.IO.Path.Combine(directory, String.Format("{0}.dll.{1}", dllname, this.map));
    					    Load();
                        }
    				} else {
    					Console.Error.WriteLine("Assembly not found: '{0}'", assembly_name);
    				}
                }
			}

			private void Load() {
				if (System.IO.File.Exists(mapfile)) {
                    string type_name = "";
                    string method_name = "";
					List<string> parameters = new List<string>();
					XmlReader xr = new XmlTextReader(mapfile);
                    while (xr.Read()) {
                        switch (xr.NodeType) {
                        case XmlNodeType.Element:
                            string name = xr.Name.ToLower();
                            switch (name) {
                            case "map":
                                break;
                            case "parameter":
                                string parameter_name = xr.GetAttribute("name");
                                string parameter_type = xr.GetAttribute("type");
                                string parameter_default = xr.GetAttribute("default");
								parameters.Add(parameter_type);
                                string default_key = String.Format("{0}.{1}-{2}", 
									type_name, method_name, parameter_name);
								defaults[default_key] = parameter_default;
                                break;
                            case "method":
                                type_name = xr.GetAttribute("type_name");
                                method_name = xr.GetAttribute("method_name");
                                string types_key = String.Format("{0}.{1}", type_name, method_name);
                                types[types_key] = true;
								parameters = new List<string>();
                                break;
                            }
                            break;
						case XmlNodeType.EndElement:
							name = xr.Name.ToLower();
							switch (name) {
                            case "method":
                                string key = String.Format("{0}.{1}({2})", 
									type_name, method_name, ListToString(parameters));
								signatures[key] = true;
								break;
							}
							break;							
                        }
                    }
                    xr.Close();
				} else {
					signatures = null;
					types = null;
				}
			}

			public void Save(string map) {
				// This will make a full map file from a DLL
				this.map = map;
				mapfile = System.IO.Path.Combine(directory, String.Format("{0}.dll.{1}", dllname, this.map));
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = ("    ");
                using (XmlWriter xw = XmlWriter.Create(mapfile, settings)) {
    				xw.WriteStartElement("map");
    				foreach (string type_name in getTypeNames(assembly)) {
    					Type type = getType(assembly, type_name);
    					foreach (MethodInfo mi in getStaticMethods(type)) {
    						// write it
    						xw.WriteStartElement("method");
    				  	    xw.WriteAttributeString("assembly_name", assembly_name);
    					    xw.WriteAttributeString("type_name", type_name);
    					    xw.WriteAttributeString("method_name", mi.Name);
    					    foreach (ParameterInfo pi in mi.GetParameters()) {
    					      xw.WriteStartElement("parameter");
    					      xw.WriteAttributeString("name", pi.Name);
    					      xw.WriteAttributeString("type", pi.ParameterType.FullName);
    					      xw.WriteAttributeString("default", pi.DefaultValue.ToString());
    					      xw.WriteEndElement();
    					    }
    					  	xw.WriteEndElement();
    					}
    				}
       		        xw.WriteEndElement();
                }
			}

			public void SaveAsCSharp (string filename)
			{
			  	// This will make a CSharp file from a DLL
				string indent = "    ";
				System.IO.StreamWriter sw = new System.IO.StreamWriter (filename);
				sw.WriteLine("public class {");
				foreach (string type_name in getTypeNames(assembly)) {
					Type type = getType (assembly, type_name);
					foreach (MethodInfo mi in getStaticMethods(type)) {
						string parameters = "";
						string arguments = "";
					    foreach (ParameterInfo pi in mi.GetParameters()) {
							if (parameters != "")
								parameters += ", ";
							parameters += String.Format("{0} {1}", pi.ParameterType.Name, pi.Name);
							if (arguments != "")
								arguments += ", ";
							arguments += pi.Name;
					    }
						sw.WriteLine ("{0}public static {1} {2} ({3}) {{", indent, mi.ReturnType.ToString(), mi.Name, parameters);
						sw.WriteLine ("{0}{0}return {1}.{2}({3});", indent, type_name, mi.Name, arguments);
						sw.Write ("{0}", indent);
						sw.WriteLine("}");
					}
				}
				sw.WriteLine("}");
				sw.Close ();
			}
					
			public bool CheckSignature(string type_name, string method_name, List<Type> types) {
				string key = String.Format("{0}.{1}({2})", type_name, method_name, ListToString(types));
				if (signatures == null) { // no map file
					return true;
				} else {
					return signatures.ContainsKey(key);
				}
			}
			
			public bool CheckType(string type_name, string method_name) {
				if (types == null) { // no map file
					return true;
				} else {
					string key = String.Format("{0}.{1}", type_name, method_name);
					return types.ContainsKey(key);
				}
			}
			public bool GetParameterDefault(string aname, string tname, string mname, string pname,
								out object default_value) {
                string default_key = String.Format("{0}.{1}-{2}", tname, mname, pname);
				if (defaults.ContainsKey(default_key) && defaults[default_key] != "") {
					default_value = defaults[default_key];
					return true;
				} else {
					default_value = null;
					return false;
				}
			}
		}
		
		public static List<string> getAssemblyNames ()
		{
			return getAssemblyNames (Assembly.GetExecutingAssembly ());
		}

		public static List<string> getAssemblyNames (Assembly assembly)
		{
			// Get all the referenced assemblies
			List<string > retval = new List<string> ();
			foreach (AssemblyName an in assembly.GetReferencedAssemblies()) {
				retval.Add (an.Name);
			}
			retval.Sort ();
			return retval;
		}

		public static Assembly getAssembly ()
		{
			return Assembly.GetExecutingAssembly ();
		}

		public static Assembly getAssembly (String name)
		{
			try {
				return getAssembly (name, Thread.GetDomain ().GetAssemblies ());
			} catch {
				return null;
			}
		}

		public static Assembly getAssembly (String name, Assembly [] assemblies)
		{
			// given a name and set of assemblies, return the named assembly
			for (int i = 0; i < assemblies.Length; i++) {
				if (String.Compare (assemblies [i].GetName ().Name, name) == 0)
					return assemblies [i];
			}      
			// else, try to load it:
			Assembly assembly = null;
			try {
				assembly = Assembly.LoadFrom (name);
			} catch { //(System.IO.FileNotFoundException) {
#pragma warning disable 612
				assembly = Assembly.LoadWithPartialName (name);
#pragma warning restore 612
			}
			return assembly;
		}

		public static List<string> getTypeNames (Assembly assembly)
		{
			List<string > retval = new List<string> ();
			if (assembly != null) {
				foreach (Type type in assembly.GetExportedTypes()) {
					if (!retval.Contains (type.Name))
						retval.Add (type.Name);
				}
				retval.Sort ();
			}
			return retval;
		}

		public static List<string> getTypeNames (string assembly_name)
		{
			Assembly assembly = getAssembly (assembly_name);
			return getTypeNames (assembly);
		}

		public static List<string> getTypeNames ()
		{
			return getTypeNames (Assembly.GetExecutingAssembly ());
		}

		public static Type getType (string assembly_name, string type_name)
		{
			Assembly assembly = getAssembly (assembly_name);
			if (assembly != null)
				return getType (assembly, type_name);
			else {
				return null;
			}
		}

		public static Type getType (Assembly assembly, string type_name)
		{
			foreach (Type t in assembly.GetExportedTypes()) {
				if (String.Compare (t.Name, type_name) == 0) {
					return t;
				}
			}
			return null;
		}

		public static Type[] getTypesOfArgs (object [] objects)
		{
			Type [] retval = new Type[objects.Length];
			int count = 0;
			foreach (object obj in objects) {
				retval [count] = obj.GetType ();
				count++;
			}
			return retval;
		}

		public static MethodInfo getMethodFromArgValues (Type type,
						    string methodName, 
						    params object [] args)
		{
			// get a method given arg values
			return type.GetMethod (methodName, getTypesOfArgs (args));
		}

		public static MethodInfo getMethodFromArgValues (object cls, 
						    string methodName, 
						    params object [] args)
		{
			// get a method given arg values
			Type type = cls.GetType ();
			return type.GetMethod (methodName, getTypesOfArgs (args));
		}

		public static MethodInfo getMethodFromArgTypes (Type type,
						   string methodName, 
						   Type [] args)
		{
			// get a method given types
			return type.GetMethod (methodName, args);
		}

		public static MethodInfo getMethodFromArgTypes (object cls, 
						   string methodName, 
						   Type [] args)
		{
			// get a method given types
			Type type = cls.GetType ();
			return type.GetMethod (methodName, args);
		}

		public static List<string> getMemberNames (Type type)
		{
			List<string > retval = new List<string> ();
			foreach (MemberInfo mi in type.GetMembers()) {
				retval.Add (mi.Name);
			}
			retval.Sort ();
			return retval;
		}

		public static List<string> getStaticMethodNames (string aname)
		{
			Assembly assembly = getAssembly (aname);
			List<string > retval = new List<string> ();
			foreach (MethodInfo mi in 
	       assembly.GetType().GetMethods(BindingFlags.Public |
					     BindingFlags.Static)) {
				retval.Add (mi.Name);
			}
			retval.Sort ();
			return retval;
		}

		public static List<string> getStaticMethodNames (string aname, string tname, Mapping mapping)
		{
			Type type = getType (aname, tname);
			// first see if there is a map file of particular name
			// now load:
			List<string > retval = new List<string> ();
			foreach (MethodInfo mi in type.GetMethods(BindingFlags.Public |
						BindingFlags.Static)) {
				if (!retval.Contains (mi.Name))
					if (mapping.CheckType(tname, mi.Name)) {
						retval.Add (mi.Name);
				}
			}
			retval.Sort ();
			return retval;
		}

		public static List<string> getStaticMethodNames (string aname, string tname)
		{
			Type type = getType (aname, tname);
			List<string > retval = new List<string> ();
			foreach (MethodInfo mi in type.GetMethods(BindingFlags.Public |
						BindingFlags.Static)) {
				if (!retval.Contains (mi.Name))
					retval.Add (mi.Name);
			}
			retval.Sort ();
			return retval;
		}
		
		public static List<string> getConstructorNames (string aname)
		{
			Assembly assembly = getAssembly (aname);
			List<string > retval = new List<string> ();
			foreach (ConstructorInfo ci in 
	       			assembly.GetType().GetConstructors()) {
				retval.Add (ci.Name);
			}
			retval.Sort ();
			return retval;
		}

		public static List<string> getConstructorNames (string aname, string tname, Mapping mapping)
		{
			Type type = getType (aname, tname);
			// first see if there is a map file of particular name
			// now load:
			List<string > retval = new List<string> ();
			foreach (ConstructorInfo ci in type.GetConstructors()) {
				if (!retval.Contains (ci.Name))
					if (mapping.CheckType(tname, ci.Name)) {
						retval.Add (ci.Name);
				}
			}
			retval.Sort ();
			return retval;
		}

		public static List<string> getConstructorNames (string aname, string tname)
		{
			Type type = getType (aname, tname);
			List<string > retval = new List<string> ();
			foreach (ConstructorInfo ci in type.GetConstructors()) {
				if (!retval.Contains (ci.Name))
					retval.Add (ci.Name);
			}
			retval.Sort ();
			return retval;
		}

		public static string ListToString(IList args) {
			string retval = "";
			int count = args.Count;
			for (int i = 0; i < count; i++) {
			    if (retval != "")
				retval += ", ";
			    retval += args[i];
			}
			return retval;
		}
		
	        public static string getSigatureString(MethodInfo mi) {
		    List<string > parameters = new List<string> ();
		    foreach (ParameterInfo pi in mi.GetParameters()) {
			parameters.Add (pi.Name);
		    } 
		    return String.Format("{0}({1})", mi.Name, ListToString(parameters));
		}
	    
	        public static List<MethodInfo> getStaticMethods (Type type)
	        {
		    // get the methods of a Class (cls) given these flags:
		    MethodInfo[] methodInfos = type.GetMethods (BindingFlags.Public |
								BindingFlags.Static);
		    // sort methods by name:
		    Array.Sort (methodInfos,
				delegate(MethodInfo methodInfo1, MethodInfo methodInfo2)
				{
				    string s1 = getSigatureString(methodInfo1);
				    string s2 = getSigatureString(methodInfo2);
				    return s1.CompareTo (s2); 
				});
		    
		    // remove duplicates
		    List<MethodInfo> methodList = new List<MethodInfo>();
		    string lastMethod = "";
		    foreach(MethodInfo methodInfo in methodInfos) {
			string sig = getSigatureString(methodInfo);
			if (lastMethod != sig) { 
			    methodList.Add(methodInfo);
			    lastMethod = sig;
			}
		    }
		    return methodList;
		}
	    
		public static List<string> getMethodNames (string aname, string tname)
		{
			Type type = getType (aname, tname);
			return getMethodNames (type);
		}

		public static List<string> getMethodNames (Type type)
		{
			List<string > retval = new List<string> ();
			foreach (MemberInfo mi in type.GetMembers()) {
				if (mi.MemberType == MemberTypes.Method) {
					retval.Add (mi.Name);
				}
			}
			retval.Sort ();
			return retval;
		}


		public static ConstructorInfo[] getConstructors (Type type)
		{
			// get the constructors of a Class (cls) given these flags:
			ConstructorInfo[] constructorInfos = type.GetConstructors();
			// sort methods by name:
			Array.Sort (constructorInfos,
		 		delegate(ConstructorInfo constructorInfo1, ConstructorInfo constructorInfo2)
				{
				return constructorInfo1.Name.CompareTo (constructorInfo2.Name); });
			return constructorInfos;
		}
		
		public static MemberInfo getMemberInfo (Type type, string mname)
		{
			foreach (MemberInfo mi in type.GetMembers()) {
				if (String.Compare (mi.Name, mname) == 0) {
					return mi;
				}
			}
			return null;
		}

		public static List<ConstructorInfo> getConstructorInfos (Type type)
		{
			List<ConstructorInfo > infos = new List<ConstructorInfo> ();
			foreach (ConstructorInfo ci in type.GetConstructors()) {
				infos.Add (ci);
			}
			return infos;
		}

		public static List<MethodInfo> getMethodInfos (Type type, string mname)
		{
			List<MethodInfo > methodinfos = new List<MethodInfo> ();
			foreach (MethodInfo mi in type.GetMethods()) {
				if (String.Compare (mi.Name, mname) == 0) {
					methodinfos.Add (mi);
				}
			}
			return methodinfos;
		}

		public static Type getMethodReturnType (Type type, string mname)
		{
			foreach (MethodInfo mi in type.GetMethods()) {
				if (String.Compare (mi.Name, mname) == 0) {
					return mi.ReturnType;
				}
			}
			return null;
		}

		public static Type getMethodReturnType (string aname, 
					   string tname, 
					   string mname)
		{
			Type type = getType (aname, tname);
			foreach (MethodInfo mi in getMethodInfos(type, mname)) {
				if (String.Compare (mi.Name, mname) == 0) {
					try {
					return mi.ReturnType;
					} catch {
						return null;
					}
				}
			}
			return null;
		}

		public static List<string> getPropertyNames (Type type, string mname)
		{
			List<string > retval = new List<string> ();
			MemberInfo mi = getMemberInfo (type, mname);
			foreach (MethodInfo am in ((PropertyInfo) mi).GetAccessors()) {
				retval.Add (am.Name);
			}
			retval.Sort ();
			return retval;
		}

		public static List<List<string>> getConstructorParameterNames (Type type)
		{
			List<List<string >> retval = new List<List<string>> ();
			foreach (ConstructorInfo mi in getConstructorInfos(type)) {
				List<string > parameters = new List<string> ();
				foreach (ParameterInfo pi in mi.GetParameters()) {
					parameters.Add (pi.Name);
				}
				retval.Add (parameters);
			}
			return retval;
		}

		public static List<List<Type>> getConstructorParameterTypes (Type type)
		{
			List<List<Type >> retval = new List<List<Type>> ();
			foreach (ConstructorInfo mi in getConstructorInfos(type)) {
				List<Type > parameters = new List<Type> ();
				foreach (ParameterInfo pi in mi.GetParameters()) {
					parameters.Add (pi.ParameterType);
				}
				retval.Add (parameters);
			}
			return retval;
		}

		public static List<List<string>> getParameterNames (string aname, 
						 string tname, 
						 string mname)
		{
			List<List<string >> retval = new List<List<string>> ();
			Type type = getType (aname, tname);
			foreach (MethodInfo mi in getMethodInfos(type, mname)) {
				List<string > parameters = new List<string> ();
				try {
				foreach (ParameterInfo pi in mi.GetParameters()) {
					parameters.Add (pi.Name);
				}
				} catch {
					continue;
				}
				retval.Add (parameters);
			}
			return retval;
		}

		public static List<List<Type>> getParameterTypes (string aname, string tname, string mname)
		{
			List<List<Type >> retval = new List<List<Type>> ();
			Type type = getType (aname, tname);
			foreach (MethodInfo mi in getMethodInfos(type, mname)) {
				List<Type > types = new List<Type> ();
				try {
				foreach (ParameterInfo pi in mi.GetParameters()) {
					types.Add (pi.ParameterType);
				}
				} catch {
					continue;
				}
				retval.Add (types);
			}
			return retval;
		}

		public static List<List<object>> getParameterDefaults (string aname, 
						 string tname, 
						 string mname)
		{
			List<List<object >> retval = new List<List<object>> ();
			Type type = getType (aname, tname);
			foreach (MethodInfo mi in getMethodInfos(type, mname)) {
				List<object > parameters = new List<object> ();
				foreach (ParameterInfo pi in mi.GetParameters()) {
					parameters.Add (pi.DefaultValue);
				}
				retval.Add (parameters);
			}
			return retval;
		}
		
		public static List<List<object>> getParameterDefaults (string aname, 
						 string tname, 
						 string mname,
						 Mapping mapping)
		{
			List<List<object >> retval = new List<List<object>> ();
			Type type = getType (aname, tname);
			foreach (MethodInfo mi in getMethodInfos(type, mname)) {
				List<object > parameters = new List<object> ();
				try {
				foreach (ParameterInfo pi in mi.GetParameters()) {
					object default_value;
					bool found = mapping.GetParameterDefault(aname, tname, mname, pi.Name, 
							out default_value);
					if (found)
						parameters.Add(default_value);
					else
						if (pi.ParameterType != null && pi.ParameterType.ToString().CompareTo("System.String") == 0)
							parameters.Add(String.Format("'{0}'", pi.DefaultValue));
						else
							parameters.Add(pi.DefaultValue);
				}
				} catch {
					continue;
				}
				retval.Add (parameters);
			}
			return retval;
		}

		public static int add1 (int i)
		{
			return i + 1;
		}
	}
}

