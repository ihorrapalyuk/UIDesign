
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace UIDesign
{
	public partial class CellPayment : UITableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("CellPayment", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("CellPayment");

		public CellPayment (IntPtr handle) : base (handle)
		{
		}

		public static CellPayment Create ()
		{
			return (CellPayment)Nib.Instantiate (null, null) [0];
		}
	}
}

