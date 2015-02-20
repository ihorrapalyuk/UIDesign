using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Linq;

namespace UIDesign
{
	public class RowPayment : UITableViewSource
	{
		protected List<entPayment> tableItems;	
		UIDesignController context;
		protected string cellIdentifier = "CellPayment";

		public RowPayment  (UIDesignController con, List<entPayment> items)
		{			
			tableItems = items;
			context = con;
		}

		/// <summary>
		/// Called by the TableView to determine how many cells to create for that particular section.
		/// </summary>
		public override int RowsInSection (UITableView tableview, int section)
		{
			return tableItems.Count;
		}

		public override float GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			return context.CELL_PAYMENT_HEIGHT;
		}

		/// <summary>
		/// Called when a row is touched
		/// </summary>
		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
		}

		/// <summary>
		/// Called by the TableView to get the actual UITableViewCell to render for the particular row
		/// </summary>
		public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{ 
			// request a recycled cell to save memory
			var cell = (CellPayment)tableView.DequeueReusableCell (cellIdentifier);

			// if there are no cells to reuse, create a new one
			if (cell == null) {
				tableView.RegisterNibForCellReuse (UINib.FromName("CellPayment",null),cellIdentifier);
				cell =  (CellPayment)tableView.DequeueReusableCell (cellIdentifier);
			}

			cell.txtPrice.Text = tableItems[indexPath.Row].txtPrice;
			cell.txtDate.Text = tableItems[indexPath.Row].txtDate;
			cell.txtDescr.Text = tableItems[indexPath.Row].txtDescr;

			var chName = "blueDot.jpg";

			var overdueAttributes = new UIStringAttributes ();

			switch (tableItems [indexPath.Row].isOverdue) {
			case false:
				{
					chName = "Chack.png";
					cell.txtPrice.TextColor = UIColor.FromRGB(90, 168, 79);
					break;
				}
			case true:
				{ 
					chName = "Warning.png";
					cell.txtPrice.TextColor = UIColor.Red;
					overdueAttributes = new UIStringAttributes {
						ForegroundColor = UIColor.Red
					};
					cell.txtPrice.TextColor = UIColor.Red;
					break;
				}
			default :
				{
					break;
				}
			}
			var overdueAttributesBlack = new UIStringAttributes {
				ForegroundColor = UIColor.Black
			};
			var title = tableItems [indexPath.Row].txtTitle +" "+ tableItems [indexPath.Row].overdueText;
			var titleAttString = new NSMutableAttributedString (title);

			titleAttString.SetAttributes (overdueAttributes.Dictionary,
				new NSRange (tableItems[indexPath.Row].txtTitle.Length, tableItems [indexPath.Row].overdueText.Length + 1));

			cell.txtTitle.AttributedText = titleAttString;

			cell.imgCheck.Image = UIImage.FromBundle(chName);

			return cell;
		}
	}
}

