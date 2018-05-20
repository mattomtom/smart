using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Smart.iOS
{
	public class TableViewOneCell : UITableViewCell
	{
		UILabel headingLabel, subheadingLabel;
		public TableViewOneCell(NSString cellId) : base(UITableViewCellStyle.Default, cellId)
		{
			SelectionStyle = UITableViewCellSelectionStyle.Gray;
			ContentView.BackgroundColor = UIColor.FromRGB(218, 255, 127);
			headingLabel = new UILabel()
			{
				Font = UIFont.FromName("Cochin-BoldItalic", 22f),
				TextColor = UIColor.FromRGB(127, 51, 0),
				BackgroundColor = UIColor.Clear
			};
			subheadingLabel = new UILabel()
			{
				Font = UIFont.FromName("AmericanTypewriter", 12f),
				TextColor = UIColor.FromRGB(38, 127, 0),
				TextAlignment = UITextAlignment.Center,
				BackgroundColor = UIColor.Clear
			};
			ContentView.AddSubviews(new UIView[] { headingLabel, subheadingLabel });
		}

		public void UpdateCell(string caption, string subtitle)
        {
            headingLabel.Text = caption;
            subheadingLabel.Text = subtitle;
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            headingLabel.Frame = new CGRect(5, 4, ContentView.Bounds.Width - 63, 25);
            subheadingLabel.Frame = new CGRect(100, 18, 100, 20);
        }
	}
}