using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;

namespace UIDesign
{
	public class entNote
	{
		public string txtDescr{ get; set;}
		public string pathImgNoteImage{ get; set;}
		public string txtDate{ get; set;}
		public List<entPayment> payments{ get; set;}

		public entNote ()
		{
		}

		public entNote (string TxtDescr, string PathImgNoteImage, string TxtDate, List<entPayment> Payments)
		{
			txtDescr = TxtDescr;
			pathImgNoteImage = PathImgNoteImage;
			txtDate = TxtDate;
			payments = Payments;
		}
	}
}

