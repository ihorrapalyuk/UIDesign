
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace UIDesign
{
	public partial class CallNote : UITableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("CallNote", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("CallNote");

		public CallNote (IntPtr handle) : base (handle)
		{
		}

		public static CallNote Create ()
		{
			return (CallNote)Nib.Instantiate (null, null) [0];
		}
	}
}

