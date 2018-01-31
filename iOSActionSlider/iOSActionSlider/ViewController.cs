using System;
using UIKit;
using ActionComponents;

namespace iOSActionSlider
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

			// Set icon
			brightnessSlider.Icon = UIImage.FromBundle("IconBrightness");

			// Wireup events
			brightnessSlider.ValueChanged += (fillPercent) => {
				percentLabel.Text = $"{fillPercent}%";
			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
