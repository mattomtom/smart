using System;
using System.Collections.Generic;
using UIKit;

using Foundation;

namespace Smart.iOS
{
    public class NavViewItem
    {
        public string Title { get; set; }
        public string Descrition { get; set; }
        public UIViewController ViewControllerCode { get; set; }
        public UIViewController ViewControllerXib { get; set; }
    }
    
    public class ViewControllerHome : UITableViewController
    {
        IList<NavViewItem> _menuItems;

        public ViewControllerHome()
        {
            SetupViewControllers();
        }

		public override void ViewDidLoad()
		{
            base.ViewDidLoad();

            NavigationItem.Title = "Home";
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell("cellInHome");

            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Subtitle, "cellInHome");
            }
            cell.TextLabel.Text = _menuItems[indexPath.Row].Title;
            cell.DetailTextLabel.Text = _menuItems[indexPath.Row].Descrition;

            return cell;
        }


		public override nint RowsInSection(UITableView tableview, nint section)
        {			
            return _menuItems.Count;
        }

        public override UIView GetViewForFooter(UITableView tableView, nint section)
        {
            // clear empty cells
            return new UIView();
        }

		public override UITableViewCellEditingStyle EditingStyleForRow(UITableView tableView, NSIndexPath indexPath)
		{
            // hide delete action
            return UITableViewCellEditingStyle.None;
		}

		public override UISwipeActionsConfiguration GetLeadingSwipeActionsConfiguration(UITableView tableView, NSIndexPath indexPath)
        {
            UIContextualAction codeAction = ContextualCodeAction(indexPath.Row);
            UIContextualAction xibAction = ContextualXibAction(indexPath.Row);
            UISwipeActionsConfiguration leadingSwipe = UISwipeActionsConfiguration
                .FromActions(new UIContextualAction[] { codeAction, xibAction });

            leadingSwipe.PerformsFirstActionWithFullSwipe = false;

            return leadingSwipe;
        }

        private UIContextualAction ContextualCodeAction(int row)
        {
            UIContextualAction action = UIContextualAction.FromContextualActionStyle(
                UIContextualActionStyle.Normal,
                "Code",
                (ReadLaterAction, view, success) => {
                    NavigationController.PushViewController(_menuItems[row].ViewControllerCode, false);
                });

            action.BackgroundColor = UIColor.Orange;

            return action;
        }

        private UIContextualAction ContextualXibAction(int row)
        {
            UIContextualAction action = UIContextualAction.FromContextualActionStyle(
                UIContextualActionStyle.Normal,
                "XIB",
                (ReadLaterAction, view, success) => {
                    NavigationController.PushViewController(_menuItems[row].ViewControllerXib, false);

                    success(true);
                });

            action.BackgroundColor = UIColor.Blue;

            return action;
        }

        private void SetupViewControllers()
        {
            _menuItems = new List<NavViewItem>
            {
                new NavViewItem
                {
                    Title = "List View I",
                    Descrition = "List View with custom cell.",
                    ViewControllerCode = new ViewControllerTableViewOneCode(),
                    ViewControllerXib = new ViewControllerTableViewOneXib()
                },
				new NavViewItem
                {
                    Title = "Collection View I",
                    Descrition = "Collection View",
                    ViewControllerCode = new ViewControllerCollectionViewOneCode(),
                    ViewControllerXib = new ViewControllerTableViewOneCode()
                }
            };
        }
	}
}