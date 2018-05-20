using System;
using System.Collections.Generic;
using UIKit;

namespace Smart.iOS
{
    public partial class ViewControllerTableViewOneXib : UIViewController
    {
        IList<TableOneItem> list;
        
        public ViewControllerTableViewOneXib() : base("ViewControllerTableViewOneXib", null)
        {
            list = new List<TableOneItem>
            {
                new TableOneItem
                {
                    Titile = "1",
                    Text = "Text1"
                },
                new TableOneItem
                {
                    Titile = "2",
                    Text = "Text2"
                }, new TableOneItem
                {
                    Titile = "3",
                    Text = "Text3"
                }
            };
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            _tableView.Source = new TableViewOneSourceXib(list);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

