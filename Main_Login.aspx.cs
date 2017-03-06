using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Main_Login : System.Web.UI.Page
{
   
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Create_Button_Click(object sender, EventArgs e)
    {
        Response.Redirect("Page_Registration.aspx", true);
    }
    protected void Login_Button_Click(object sender, EventArgs e)
    {
        String userName_info = Convert.ToString(this.Username1.Text);
        Session.Add("username", userName_info);
        SqlConnection conn_Welcome = new SqlConnection(@"Data Source = EEITAX9QZR6D7JX\SQLEXPRESS; Initial Catalog = UserInformation; uid = sa;pwd = 123456 ");
        conn_Welcome.Open();
        SqlCommand select = new SqlCommand("select * from Table_1 where UserName = '" + userName_info + "'", conn_Welcome);
        SqlDataReader count = select.ExecuteReader();
        if (count.HasRows)
        {
            conn_Welcome.Close();
            Response.Redirect("Page_Game.aspx", true);
        }
        else
        {
            conn_Welcome.Close();
            Response.Write("fail");
        }
    }
   
}