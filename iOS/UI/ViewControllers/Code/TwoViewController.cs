using System;
using System.Drawing;
using Foundation;
using UIKit;

namespace Smart.iOS
{
    public class TwoViewController : UIViewController 
    {
        UICollectionView _collectionView;
        UICollectionViewFlowLayout _layout;

        public TwoViewController()
        {

            _layout = new UICollectionViewFlowLayout
            {
                SectionInset = new UIEdgeInsets(20, 5, 5, 5),
                MinimumInteritemSpacing = 5,
                MinimumLineSpacing = 5,
                ItemSize = new SizeF(100, 100)
            };

            _collectionView = new UICollectionView(UIScreen.MainScreen.Bounds, layout);
            _collectionView.ContentSize = View.Frame.Size;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

        }
    }
}
