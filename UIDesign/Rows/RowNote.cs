using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Linq;

namespace UIDesign
{
	public class RowNote : UITableViewSource
	{
		protected List<entNote> tableItems;	
		UIDesignController context;
		protected string cellIdentifier = "CallNote";

		public RowNote  (UIDesignController con, List<entNote> items)
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
			return context.CELL_NOTE_HEIGHT + tableItems[indexPath.Row].payments.Count * context.CELL_PAYMENT_HEIGHT;
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
			var cell = (CallNote)tableView.DequeueReusableCell (cellIdentifier);

			// if there are no cells to reuse, create a new one
			if (cell == null) {
				tableView.RegisterNibForCellReuse (UINib.FromName("CallNote",null),cellIdentifier);
				cell =  (CallNote)tableView.DequeueReusableCell (cellIdentifier);
			}

			cell.txtDescr.Text = tableItems[indexPath.Row].txtDescr;
			cell.txtDate.Text = tableItems[indexPath.Row].txtDate;
			cell.imgNoteImage.Image = UIImage.FromBundle(tableItems[indexPath.Row].pathImgNoteImage);

			//clear all views in table
			foreach (UIView sub in cell.viewPayments.Subviews) {
				sub.RemoveFromSuperview ();
			}

			cell.viewPayments.Frame = new RectangleF (cell.viewPayments.Frame.Location,
				new SizeF (cell.viewPayments.Frame.Width, tableItems[indexPath.Row].payments.Count * context.CELL_PAYMENT_HEIGHT));

			var	table = new UITableView (new RectangleF(0, 0, cell.viewPayments.Frame.Width, cell.viewPayments.Frame.Height));

			table.Source = new RowPayment (context, tableItems[indexPath.Row].payments);

			table.SeparatorStyle = UITableViewCellSeparatorStyle.None;

			cell.viewPayments.AddSubview (table);

			return cell;
		}
	}
}

