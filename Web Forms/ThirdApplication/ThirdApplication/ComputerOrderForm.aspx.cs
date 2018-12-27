using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ThirdApplication.Models;

namespace ThirdApplication
{
    public partial class ComputerOrderForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            var order = new ComputerOrder();
            order.OrderID = 1123;
            order.OrderName = OrderName.Text;
            order.Customer = Customer.Text;
            order.CustomerEmail = CustomerEmail.Text;
            order.DeliveryDate = DeliveryDate.SelectedDate;
            order.PartNumber = int.Parse(PartNumber.Text);
            order.Rush = RushYes.Checked;
            Session["CurrentOrder"] = order;
            Response.Redirect("ReviewComputerOrder.aspx");
        }
    }
}