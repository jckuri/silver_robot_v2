using RMC.Core.ReadMe;
using UnityEditor;

namespace Udacity.GameDevelopment.Shared.ReadMe
{
	public static class ReadMeMenuItems
	{
		//  Fields ----------------------------------------
		public const string PathMenuItemWindowCompanyProject = "Window/" + CompanyName + "/" + ProjectName;
		public const string CompanyName = "Udacity";
		public const string ProjectName = "2D Platformer Game";
		public const int PriorityMenuItem_Examples = -1000;
        
		//  Fields ----------------------------------------
		
		[MenuItem( PathMenuItemWindowCompanyProject + "/" + "Open ReadMe", 
			false,
						PriorityMenuItem_Examples)]
		public static void SelectReadmes()
		{
			ReadMeHelper.SelectReadmes();
		}
	}
}
