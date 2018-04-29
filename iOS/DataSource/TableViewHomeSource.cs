using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace Smart.iOS.DataSource
{
    public class TableViewHomeSource : UITableViewSource
    {
        IList<string> _itemsInTable;

        public TableViewHomeSource(IList<string> itemsInTable)
        {
            _itemsInTable = itemsInTable;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell("cellInHome");

            if(cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, "cellInHome");
            }

            cell.TextLabel.Text = _itemsInTable[indexPath.Row];

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return _itemsInTable.Count;
        }
	}
}
