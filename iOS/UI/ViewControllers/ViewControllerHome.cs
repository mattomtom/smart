using System;
using System.Collections.Generic;
using UIKit;

using Smart.iOS.DataSource;

namespace Smart.iOS.UI.ViewControllers
{
    public class ViewControllerHome : UIViewController
    {
        IList<string> _menuItems;

        public ViewControllerHome()
        {
            _menuItems = new List<string>
            {
                "Test1",
                "Test2",
                "Test3"
            };
        }

		public override void ViewDidLoad()
		{
            base.ViewDidLoad();

            NavigationController.SetNavigationBarHidden(hidden: true, animated: false);

            UITableView tableView = new UITableView(frame: UIScreen.MainScreen.Bounds);
            View.AddSubview(tableView);

            tableView.Source = new TableViewHomeSource(_menuItems);
		}
	}
}
