using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) {
            for (int i = 1990; i <= 2030;i++ )
            {
                DropDownList1.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 12; i++)
            {
                DropDownList2.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 31; i++)
            {
                DropDownList3.Items.Add(i.ToString());
            }
            
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        /**************************************Session**************************************/
        Session.Add("name",TextBox1.Text);
        Session.Add("year", DropDownList1.Text);
        Session.Add("month", DropDownList2.Text);
        Session.Add("day", DropDownList3.Text);
        Response.Redirect("Default2.aspx");
        /********************************URL**********************************************/
        //Response.Redirect("Default2.aspx?name="+TextBox1.Text+"&year="+DropDownList1.Text
        //    + "&month=" + DropDownList2.Text + "&day=" + DropDownList3.Text);
        /*****************************Cookies*********************************************/
        //HttpCookie newCookie = new HttpCookie("Birth");
        //newCookie.Values.Add("name",TextBox1.Text);
        //newCookie.Values.Add("year",DropDownList1.Text);
        //newCookie.Values.Add("month", DropDownList2.Text);
        //newCookie.Values.Add("day", DropDownList3.Text);
        //Response.Cookies.Add(newCookie);
        ////newCookie.Expires = DateTime.Now.AddDays(20);
        //Response.Redirect("Default2.aspx");
    }
}