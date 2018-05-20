using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace Smart.iOS
{
    public class CollectionViewOneSourceCode : UICollectionViewSource
    {
        public IList<DataModel> _dataModels;

        public CollectionViewOneSourceCode()
        {
            _dataModels = new List<DataModel>();
        }

        public override nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return _dataModels.Count;
        }

        public override bool ShouldHighlightItem(UICollectionView collectionView, NSIndexPath indexPath)
        {
            return true;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = (CVCellOne)collectionView.DequeueReusableCell(CVCellOne.CellId, indexPath);

            DataModel data = _dataModels[indexPath.Row];

            cell.UpdateRow(data);

            return cell;
        }
    }
}
