using System;
using System.Collections.Generic;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Smart.iOS
{
    public class TableViewOneSourceXib : UITableViewSource
    {
        IList<TableOneItem> _listItems;

        public TableViewOneSourceXib(IList<TableOneItem> items)
        {
            _listItems = items;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            TableOneItem itemByIndex = _listItems[indexPath.Row];

            TableViewOneCellXib cell = tableView.DequeueReusableCell(TableViewOneCellXib.Key) as TableViewOneCellXib;

            if (cell == null)
            {
                var view = NSBundle.MainBundle.LoadNib(TableViewOneCellXib.Key, cell, null);
                cell = Runtime.GetNSObject(view.ValueAt(0)) as TableViewOneCellXib;
            }

            cell.UpdateData(itemByIndex);

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return _listItems.Count;
        }
    }
}   
