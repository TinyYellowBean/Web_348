using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class Page_Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Back_Button_Click(object sender, EventArgs e)
    {
        Response.Redirect("Main_Login.aspx", true);
    }
    protected void Create_Button_Click(object sender, EventArgs e)
    {
        String userName = Convert.ToString(this.Username2.Text);
        SqlConnection conn_Reg = new SqlConnection(@"Data Source = EEITAX9QZR6D7JX\SQLEXPRESS; Initial Catalog = UserInformation; uid = sa;pwd = 123456 ");
        conn_Reg.Open();
        SqlCommand cmdInsert1 = new SqlCommand("insert into Table_1(UserName) values( '" + userName + "')", conn_Reg);
        cmdInsert1.ExecuteNonQuery();
        conn_Reg.Close();
    }
}