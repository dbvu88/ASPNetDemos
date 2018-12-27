using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ThirdApplication.Models;

namespace ThirdApplication
{
    public partial class ReviewComputerOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ComputerOrder order = Session["CurrentOrder"] as ComputerOrder;
            OrderId.Text = order.OrderID.ToString();
            OrderName.Text = order.OrderName;
            Customer.Text = order.Customer;
            CustomerEmail.Text = order.CustomerEmail;
            DeliveryDate.Text = order.DeliveryDate.ToShortDateString();
            PartNumber.Text = order.PartNumber.ToString();
            Rush.Text = order.Rush == true ? "Yes" : "No";
        }
    }
}