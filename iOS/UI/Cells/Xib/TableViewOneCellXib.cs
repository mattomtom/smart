using System;

using Foundation;
using UIKit;

namespace Smart.iOS
{
    public partial class TableViewOneCellXib : UITableViewCell
    {
        public static readonly NSString Key = new NSString("TableViewOneCellXib");
        public static readonly UINib Nib;

        static TableViewOneCellXib()
        {
            Nib = UINib.FromName("TableViewOneCellXib", NSBundle.MainBundle);
        }

        protected TableViewOneCellXib(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public void UpdateData(TableOneItem item)
        {
            _titleLabel.Text = item.Titile;
            _textLabel.Text = item.Text;
        }
    }
}
