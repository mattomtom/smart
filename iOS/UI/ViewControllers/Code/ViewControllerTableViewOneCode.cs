using System.Collections.Generic;
using CoreGraphics;
using Smart.iOS.DataSource;
using UIKit;

namespace Smart.iOS
{
	/// <summary>
    /// View controller list view with custom cells.
    /// </summary>
    public class ViewControllerTableViewOneCode : UIViewController
	{
		UITableView _tableView;

        public ViewControllerTableViewOneCode()
        {
        }

		// widok został załadowany
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            
			_tableView = new UITableView();           

            NavigationItem.Title = "List View One";
            View.BackgroundColor = UIColor.DarkGray;
			View.AddSubview(_tableView);

			List<TableOneItem> list = new List<TableOneItem>
			{
				new TableOneItem
				{
					Titile = "Title1",
					Text = "Text1"
				},
				new TableOneItem
                {
                    Titile = "Title2",
                    Text = "Text2"
                },
				new TableOneItem
                {
                    Titile = "Title3",
                    Text = "Text3"
                }
			};

			_tableView.Source = new TableViewOneSource(list);
        }

		// widok zmienił rozmiar ramki
        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();

			_tableView.BackgroundColor = UIColor.Green;
			_tableView.Frame = new CGRect(8, 8, View.Frame.Width - 16, View.Frame.Height - 16);
        }
    }
}