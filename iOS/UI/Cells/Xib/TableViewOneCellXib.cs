using System;

using Foundation;
using UIKit;

namespace Smart.iOS.UI.Cells.Xib
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
    }
}
