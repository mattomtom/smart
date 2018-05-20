using System;
using Foundation;
using UIKit;

namespace Smart.iOS
{
    public class CollectionViewOneSourceCode : UICollectionViewSource
    {
        string[] data = { "One", "Two", "Three" };

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return data.Length;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = (CVCellOne)collectionView.DequeueReusableCell(CVCellOne.CellId, indexPath);

            cell.Text = data[indexPath.Row];

            return cell;
        }

        public override void ItemSelected(UICollectionView collectionView, NSIndexPath indexPath)
        {
            Console.WriteLine("Row {0} selected", indexPath.Row);
        }

        public override bool ShouldSelectItem(UICollectionView collectionView, NSIndexPath indexPath)
        {
            return true;
        }

    }
}
