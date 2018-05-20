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

        public string Text {
            get {
                return label.Text;
            }
            set {
                label.Text = value;
                SetNeedsDisplay();
            }
        }

        [Export("initWithFrame:")]
        CVCellOne(RectangleF frame) : base(frame)
        {
            label = new UILabel(ContentView.Frame)
            {
                BackgroundColor = UIColor.Red,
                TextColor = UIColor.Blue,
                TextAlignment = UITextAlignment.Center
            };

            ContentView.AddSubview(label);
        }
    }
}
