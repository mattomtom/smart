using System;
using System.Drawing;
using Foundation;
using UIKit;

namespace Smart.iOS
{
    public class CVCellOne : UICollectionViewCell
    {
        UILabel label;

        public static readonly NSString CellId = new NSString("CVCellOne");

        [Export("initWithFrame:")]
        public CVCellOne(RectangleF frame)
        : base(frame)
        {
            TitleLabel = new UILabel();
            TitleLabel.BackgroundColor = UIColor.Clear;
            TitleLabel.TextColor = UIColor.DarkGray;
            TitleLabel.TextAlignment = UITextAlignment.Center;

            ContentView.AddSubview(TitleLabel);
        }

        public UILabel TitleLabel { get; private set; }

        public void UpdateRow(DataModel element)
        {
            TitleLabel.Text = element.Title;

            TitleLabel.Font = UIFont.FromName("HelveticaNeue-Bold", 20);

            TitleLabel.Frame = new RectangleF(0,50, 100, 100);
        }
    }
}
