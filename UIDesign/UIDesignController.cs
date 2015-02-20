
using System;
using System.Drawing;

using MonoTouch.Foundation;
using System.Collections.Generic;
using MonoTouch.UIKit;
using MonoTouch.MapKit;
using MonoTouch.CoreLocation;

namespace UIDesign
{
	public partial class UIDesignController : UIViewController
	{
		public int CELL_PAYMENT_HEIGHT = 70;
		public int CELL_NOTE_HEIGHT = 145;

		public UIDesignController () : base ("UIDesignController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			Init ();

			Refrash(TestItems (), this);
		}

		void Init()
		{
			NavigationController.Add (btnUnlock);
			NavigationController.Add (btnAdd);

			NavigationController.NavigationBar.BarTintColor = UIColor.FromRGB (241, 246, 255);

			searchTransactionNotes.SetBackgroundImage (UIImage.FromBundle ("Search.png"), UIBarMetrics.Default);

			mkMapBillingAddress.AddAnnotation (new MKPointAnnotation (){
				Title="NetLS",
				Coordinate = new CLLocationCoordinate2D (48.921421, 24.695963)
			});
		}

		//refrash your table list
		public static void Refrash(List<entNote> tableItems, UIDesignController context)
		{		
			//clear all views in table
				foreach (UIView sub in context.viewListContainer.Subviews) {
					sub.RemoveFromSuperview ();
				}

		    var	table = new UITableView (new RectangleF(0, 0, context.viewListContainer.Frame.Width, context.viewListContainer.Frame.Height)); // defaults to Plain style

			table.SeparatorStyle = UITableViewCellSeparatorStyle.None;

			table.Source = new RowNote (context, tableItems);

			context.viewListContainer.AddSubview (table);
		}

		//testing mathod
		public static List<entNote> TestItems (){
			List<entNote> result = new List<entNote>();

			var pay1 = new entPayment("Payment1", "dfgdfgdf", "dfdfgdfgfd", "$36.20","", false);
			var pay2 = new entPayment("Payment2", "dfgdfgdf", "dfdfgdfgfd", "$40.00");
			var pay3 = new entPayment("Payment3", "dfgdfgdf", "dfdfgdfgfd", "$250.00", "Overdue by 18 days", true);
			var pay4 = new entPayment("Payment4", "dfgdfgdf", "dfdfgdfgfd", "$76.00");
			var pay5 = new entPayment("Payment5", "dfgdfgdf", "dfdfgdfgfd", "$36.00");
			var pay6 = new entPayment("Payment6", "dfgdfgdf", "dfdfgdfgfd", "$37.00");
			var pay7 = new entPayment("Payment7", "dfgdfgdf", "dfdfgdfgfd", "$387.00", "Overdue by 10 days", true);

			var paymts1 = new List<entPayment> ();
			paymts1.Add (pay1);
			paymts1.Add (pay2);
			var note1 = new entNote("Note1", "testImage1.png", "dfdfgdfgfd", paymts1);

			var paymts2 = new List<entPayment> ();
			paymts2.Add (pay3);
			paymts2.Add (pay4);
			paymts2.Add (pay5);
			paymts2.Add (pay6);
			paymts2.Add (pay7);
			var note2 = new entNote("Note2", "testImage2.png", "dfdfgdfgfd", paymts2);

			result.Add (note1);
			result.Add (note2);

			return result;
		}
	}
}

