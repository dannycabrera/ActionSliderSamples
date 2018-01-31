// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace iOSActionSlider
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		ActionComponents.ACSlider brightnessSlider { get; set; }

		[Outlet]
		UIKit.UILabel percentLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (brightnessSlider != null) {
				brightnessSlider.Dispose ();
				brightnessSlider = null;
			}

			if (percentLabel != null) {
				percentLabel.Dispose ();
				percentLabel = null;
			}
		}
	}
}
