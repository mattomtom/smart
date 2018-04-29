using System;
using UIKit;

namespace Smart.iOS.UI.ViewControllers
{
    public class ViewControllerHome : UIViewController
    {
        public ViewControllerHome()
        {
        }

		public override void ViewDidLoad()
		{
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.DarkGray;
		}
	}
}
