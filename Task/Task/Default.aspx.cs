using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		public void BookRoom(object sender, EventArgs e)
		{
			int nAdult = int.Parse(AdultCount.Text);
			int nChildren = int.Parse(ChildrenCount.Text);

			int nTotalGuest = nAdult + nChildren;
			 
			if(nAdult > 0)
			{
				if(nTotalGuest <= 16)
				{
					bookingroom(nTotalGuest, nAdult, nChildren);
				}
				else
				{
					Message.Text = "Only 16 people are Allowed ";
				}

			}
			else
			{
				Message.Text = "Adult must be there while you booking Room ";
			}


		}
		public void bookingroom(int nTotalGuest, int nAdult, int nChildren)
		{
				if(nTotalGuest < 16)
				{
					if(nTotalGuest == 4)
					{
						Message.Text = $"Room 1 : Adult{nAdult} - Children{nChildren}";
					}
					else
					{
						int nRooms = nTotalGuest / 4;
						int nAdulttemp = nAdult - nRooms;
						int nChildrentemp = nChildren - nRooms;

						for(int i = 1; i <= nRooms; i++)
						{


							Message.Text += Message.Text = $"Room{i} : Adult {nAdulttemp} - children{nChildrentemp}";

							nAdult = nAdult - nAdulttemp;
							nChildren = nChildren - nChildrentemp;

							nAdulttemp = nAdult;
							nChildrentemp = nChildren;

						}
					}
				}
			}
		}
	}
}

