// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Smart.iOS
{
    [Register ("TableViewOneCellXib")]
    partial class TableViewOneCellXib
    {
        [Outlet]
        UIKit.UILabel _textLabel { get; set; }


        [Outlet]
        UIKit.UILabel _titleLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (_textLabel != null) {
                _textLabel.Dispose ();
                _textLabel = null;
            }

            if (_titleLabel != null) {
                _titleLabel.Dispose ();
                _titleLabel = null;
            }
        }
    }
}