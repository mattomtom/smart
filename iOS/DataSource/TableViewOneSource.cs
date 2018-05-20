using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace Smart.iOS.DataSource
{   
	public class TableViewOneSource : UITableViewSource
    {
		NSString cellIdentifier = new NSString("TableViewOneCell");
		List<TableOneItem> _tableItems;

		public TableViewOneSource(List<TableOneItem> items)
        {
            _tableItems = items;
        }


		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{			
			TableViewOneCell cell = tableView.DequeueReusableCell(cellIdentifier) as TableViewOneCell;

			if (cell == null)
            {
				cell = new TableViewOneCell(cellIdentifier);
            }

			cell.UpdateCell("Kasza", "Pasza");

			return cell;                        
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return _tableItems.Count;
		}
	}
}
