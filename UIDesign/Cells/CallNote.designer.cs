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
	[Register ("CallNote")]
	partial class CallNote
	{
		[Outlet]
		public MonoTouch.UIKit.UIImageView imgNoteImage { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UILabel txtDate { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UILabel txtDescr { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UIView viewPayments { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (imgNoteImage != null) {
				imgNoteImage.Dispose ();
				imgNoteImage = null;
			}

			if (txtDate != null) {
				txtDate.Dispose ();
				txtDate = null;
			}

			if (txtDescr != null) {
				txtDescr.Dispose ();
				txtDescr = null;
			}

			if (viewPayments != null) {
				viewPayments.Dispose ();
				viewPayments = null;
			}
		}
	}
}
