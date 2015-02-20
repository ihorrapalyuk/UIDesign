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
	[Register ("CellPayment")]
	partial class CellPayment
	{
		[Outlet]
		public MonoTouch.UIKit.UIImageView imgCheck { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UILabel txtDate { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UILabel txtDescr { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UILabel txtPrice { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UILabel txtTitle { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (txtTitle != null) {
				txtTitle.Dispose ();
				txtTitle = null;
			}

			if (txtDescr != null) {
				txtDescr.Dispose ();
				txtDescr = null;
			}

			if (txtDate != null) {
				txtDate.Dispose ();
				txtDate = null;
			}

			if (txtPrice != null) {
				txtPrice.Dispose ();
				txtPrice = null;
			}

			if (imgCheck != null) {
				imgCheck.Dispose ();
				imgCheck = null;
			}
		}
	}
}
