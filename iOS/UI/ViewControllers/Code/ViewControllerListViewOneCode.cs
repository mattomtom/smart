using System;
using UIKit;

namespace Smart.iOS.UI.ViewControllers.Code
{
    public class ViewControllerListViewOneCode : UIViewController
    {
        public ViewControllerListViewOneCode()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NavigationItem.Title = "List View One";
            View.BackgroundColor = UIColor.DarkGray;
        }
    }
}
