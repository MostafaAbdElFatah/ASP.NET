using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        
        if (Session["name"] != null)
        {
            Name.Text = Session["name"].ToString();
            int y = int.Parse(Session["year"].ToString());
            int m = int.Parse(Session["month"].ToString()); 
            int d = int.Parse(Session["day"].ToString()); 
            y -= 2016;
            y = Math.Abs(y);
            m -= 12;
            m = Math.Abs(m);
            d -= 28;
            d = Math.Abs(d);
            age.Text = y + " Years " + m + " Months " + d + " Days";
        }
        else
        {
            Label1.Text = "Not Allowed";
            Name.Text = "Can't Acess this Page";
            Label2.Text = "";
        }
        /****************************Cookies******************************/
        //HttpCookie oldCookie = Request.Cookies["Birth"];
        //if(oldCookie !=null){
        //    Name.Text = oldCookie.Values["name"];
        //    int y = int.Parse(oldCookie.Values["year"]);
        //    int m = int.Parse(oldCookie.Values["month"]); ;
        //    int d = int.Parse(oldCookie.Values["day"]); ;
        //    y -= 2016;
        //    y = Math.Abs(y);
        //    m -= 12;
        //    m = Math.Abs(m);
        //    d -= 28;
        //    d = Math.Abs(d);
        //    age.Text = y + " Years " + m + " Months " + d + " Days";
        //}else {
        //    Label1.Text = "Not Allowed";
        //    Name.Text = "Can't Acess this Page";
        //    Label2.Text = "";
        //}
        /***********************QueryString***************************************/
        //if (Request.QueryString["name"] != null)
        //{
        //    Name.Text = Request.QueryString["name"].ToString();
        //    int y = int.Parse(Request.QueryString["year"].ToString());
        //    int m = int.Parse(Request.QueryString["month"].ToString()); ;
        //    int d = int.Parse(Request.QueryString["day"].ToString()); ;
        //    y -= 2016;
        //    y = Math.Abs(y);
        //    m -= 12;
        //    m = Math.Abs(m);
        //    d -= 28;
        //    d = Math.Abs(d);
        //    age.Text = y + " Years " + m + " Months " + d + " Days";
        //}else {
        //    Label1.Text = "Not Allowed";
        //    Name.Text = "Can't Acess this Page";
        //    Label2.Text = "";
        //}
        /**********************************PreviousPage*********************************************/
        //if (Page.PreviousPage != null)
        //{
        //    Name.Text = ((TextBox)Page.PreviousPage.FindControl("TextBox1")).Text;
        //    int y = int.Parse(((DropDownList)Page.PreviousPage.FindControl("DropDownList1")).Text);
        //    int m = int.Parse(((DropDownList)Page.PreviousPage.FindControl("DropDownList2")).Text);
        //    int d = int.Parse(((DropDownList)Page.PreviousPage.FindControl("DropDownList3")).Text);
        //    y -= 2016;
        //    y = Math.Abs(y);
        //    m -= 12;
        //    m = Math.Abs(m);
        //    d -= 28;
        //    d = Math.Abs(d);
        //    age.Text = y + " Years " + m + " Months " + d + " Days";
        //}
        //else {
        //    Label1.Text = "Not Allowed";
        //    Name.Text = "Can't Acess this Page";
        //    Label2.Text = "";
        //}
    }
}