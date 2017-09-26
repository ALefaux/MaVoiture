using System;
using System.Collections.Generic;
using Foundation;
using MaVoiture.DAL;
using MaVoiture.Model;
using UIKit;

namespace MaVoiture.iOS
{
    public partial class ViewController : UIViewController, IUICollectionViewDataSource, IUICollectionViewDelegate
    {
        //int count = 1;
        private List<Voiture> _listeVoiture;
        private string _cellIdentifier = "VoitureCollectionCell";

        public ViewController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            //Button.AccessibilityIdentifier = "myButton";
            //Button.TouchUpInside += delegate
            //{
            //    var title = string.Format("{0} clicks!", count++);
            //    Button.SetTitle(title, UIControlState.Normal);
            //};
        }

        public override void ViewWillAppear(Boolean animated)
        {
            _listeVoiture = VoitureDAL.GetVoitures();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }

        public nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return _listeVoiture.Count;
        }

        public UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            UICollectionViewCell cell = collectionView.DequeueReusableCell(_cellIdentifier, indexPath) as UICollectionViewCell;
            string nomVoiture = _listeVoiture[indexPath.Row].Nom;

            if (cell == null)
            {
                cell = new UICollectionViewCell();
            }

            //cell.

            return cell;
        }
    }
}
