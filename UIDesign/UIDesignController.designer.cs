// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace UIDesign
{
	[Register ("UIDesignController")]
	partial class UIDesignController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnAdd { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnUnlock { get; set; }

		[Outlet]
		MonoTouch.MapKit.MKMapView mkMapBillingAddress { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISearchBar searchTransactionNotes { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView viewListContainer { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (mkMapBillingAddress != null) {
				mkMapBillingAddress.Dispose ();
				mkMapBillingAddress = null;
			}

			if (searchTransactionNotes != null) {
				searchTransactionNotes.Dispose ();
				searchTransactionNotes = null;
			}

			if (viewListContainer != null) {
				viewListContainer.Dispose ();
				viewListContainer = null;
			}

			if (btnUnlock != null) {
				btnUnlock.Dispose ();
				btnUnlock = null;
			}

			if (btnAdd != null) {
				btnAdd.Dispose ();
				btnAdd = null;
			}
		}
	}
}
