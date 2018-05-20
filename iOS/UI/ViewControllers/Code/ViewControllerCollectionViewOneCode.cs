using System;
using System.Drawing;
using UIKit;

namespace Smart.iOS
{
    public class ViewControllerCollectionViewOneCode : UIViewController
    {
        CollectionViewOneSourceCode _source;
        UICollectionViewLayout _layout;
        UICollectionView _collectionView;

        public ViewControllerCollectionViewOneCode()
        {
            _layout = new UICollectionViewFlowLayout
            {
                SectionInset = new UIEdgeInsets(20, 5, 5, 5),
                MinimumLineSpacing = 5,
                MinimumInteritemSpacing = 5,
                ItemSize = new SizeF(100, 100)
            };

            _collectionView = new UICollectionView(UIScreen.MainScreen.Bounds, _layout);
            _collectionView.ContentSize = View.Frame.Size;

            _source = new CollectionViewOneSourceCode();

            _collectionView.RegisterClassForCell(typeof(CVCellOne), CVCellOne.CellId);
            _collectionView.Source = _source;
        }

        public override void LoadView()
        {
            base.LoadView();

            _collectionView.BackgroundColor = UIColor.Green;

            View = _collectionView;
        }
    }
}
