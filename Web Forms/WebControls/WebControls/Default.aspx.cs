using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebControls
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool ssd = SSD.Checked;
            bool ram = SixteenGB.Checked;
            bool dual = DualMonitor.Checked;

            Message.Text = "You selected ";
            Message.Text += ssd ? "SSD Drive" : "No SSD";
            Message.Text += ram ? SixteenGB.Text : "No Ram";
            Message.Text += dual ? DualMonitor.Text : "No Dual Monitor";

            foreach (ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                    Message.Text += li.Value.ToString();
                }
            }

            Message.Text += "<br/>The customer is ";
            Message.Text += Male.Checked ? "Male" : "Female";
            Message.Text += "<br/>Your age group is ";

            foreach (ListItem li in RadioButtonList1.Items)
            {
                if (li.Selected)
                {
                    Message.Text += li.Value.ToString() + ". ";
                }
            }

            Message.Text += "You selected item  ";
            Message.Text += DropDownList1.SelectedValue.ToString();

        }
    }
}