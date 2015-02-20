using System;

namespace UIDesign
{
	public class entPayment
	{
		public string txtTitle{ get; set;}
		public string txtDescr{ get; set;}
		public string txtDate{ get; set;}
		public string txtPrice{ get; set;}
		public string overdueText{ get; set;}
		public bool? isOverdue{get; set;}

		public entPayment ()
		{
		}

		public entPayment (string TxtTitle, string TxtDescr, string TxtDate, string TxtPrice, string OverdueText = "", bool? IsOverdue = null)
		{
			txtTitle = TxtTitle;
			txtDescr = TxtDescr;
			txtDate = TxtDate;
			txtPrice = TxtPrice;
			isOverdue = IsOverdue;
			overdueText =  OverdueText;
		}
	}
}

