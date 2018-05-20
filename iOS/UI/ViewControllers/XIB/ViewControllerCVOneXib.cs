using System;

using UIKit;

namespace Smart.iOS.UI.ViewControllers.XIB
{
    public partial class ViewControllerCVOneXib : UIViewController
    {
        public ViewControllerCVOneXib() : base("ViewControllerCVOneXib", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

