
// This file has been generated by the GUI designer. Do not modify.
namespace Stetic
{
	internal class Gui
	{
		private static bool initialized;
		
		internal static void Initialize (Gtk.Widget iconRenderer)
		{
			if ((Stetic.Gui.initialized == false)) {
				Stetic.Gui.initialized = true;
			}
		}
	}
	
	internal class ActionGroups
	{
		public static Gtk.ActionGroup GetActionGroup (System.Type type)
		{
			return Stetic.ActionGroups.GetActionGroup (type.FullName);
		}
		
		public static Gtk.ActionGroup GetActionGroup (string name)
		{
			return null;
		}
	}
}
