using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Text;
using System.Data.SqlClient;
using System.Data;


public partial class Page_Game : System.Web.UI.Page
{
    static int[] symbol = new int[] { 1, 0, 3, 0, 5, 0, 7, 0, 9, 0, 11, 0, 13, 0, 
                                      15, 0, 17, 0, 19, 0, 21, 0, 23, 0, 25, 0, 27, 0, 29, 0,31,0,33,0,35,0,37,0,39,0,
                                      41,0,43,0,45,0,47,0,49,0,51,0,53,0,55,0,57,0,59,0};
    static int[] bagStatus = new int[] { 1, 2, 3, 4, 5, 6, 7 };
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void _1_Click(object sender, EventArgs e)
    {
        _5.Visible = false;
        symbol[8] = 0;
        statue_Game();
    }
    protected void _2_Click(object sender, EventArgs e)
    {
        _6.Visible = false;
        symbol[10] = 0;
        statue_Game();
    }
    protected void _3_Click(object sender, EventArgs e)
    {
        _4.Visible = false;
        symbol[6] = 0;
        statue_Game();
    }
    protected void _4_Click(object sender, EventArgs e)
    {
        _1.Visible = false;
        symbol[0] = 0;
        statue_Game();
    }
    protected void _5_Click(object sender, EventArgs e)
    {
        _7.Visible = false;
        symbol[12] = 0;
        statue_Game();
    }
    protected void _6_Click(object sender, EventArgs e)
    {
        _8.Visible = false;
        symbol[14] = 0;
        statue_Game();
    }
    protected void _7_Click(object sender, EventArgs e)
    {
        _2.Visible = false;
        symbol[2] = 0;
        statue_Game();
    }
    protected void _8_Click(object sender, EventArgs e)
    {
        _3.Visible = false;
        symbol[4] = 0;
        statue_Game();
    }
    protected void _9_Click(object sender, EventArgs e)
    {
        _10.Visible = false;
        symbol[18] = 0;
        statue_Game();
    }
    protected void _10_Click(object sender, EventArgs e)
    {
        _9.Visible = false;
        symbol[16] = 0;
        statue_Game();
    }
    protected void _11_Click(object sender, EventArgs e)
    {
        _11.Visible = false;
        symbol[20] = 0;
        statue_Game();
    }
    protected void _12_Click(object sender, EventArgs e)
    {
        _12.Visible = false;
        symbol[22] = 0;
        statue_Game();
    }
    protected void _13_Click(object sender, EventArgs e)
    {
        _13.Visible = false;
        symbol[24] = 0;
        statue_Game();
    }
    protected void _14_Click(object sender, EventArgs e)
    {
        _14.Visible = false;
        symbol[26] = 0;
        statue_Game();
    }
    protected void _15_Click(object sender, EventArgs e)
    {
        _17.Visible = false;
        symbol[32] = 0;
        statue_Game();
    }
    protected void _16_Click(object sender, EventArgs e)
    {
        _16.Visible = false;
        symbol[30] = 0;
        statue_Game();
    }
    protected void _17_Click(object sender, EventArgs e)
    {
        _15.Visible = false;
        symbol[28] = 0;
        statue_Game();
    }
    protected void _18_Click(object sender, EventArgs e)
    {
        _19.Visible = false;
        symbol[36] = 0;
        statue_Game();
    }
    protected void _19_Click(object sender, EventArgs e)
    {
        _18.Visible = false;
        symbol[34] = 0;
        statue_Game();
    }
    protected void _20_Click(object sender, EventArgs e)
    {
        _20.Visible = false;
        symbol[38] = 0;
        statue_Game();
    }
    protected void _21_Click(object sender, EventArgs e)
    {
        _21.Visible = false;
        symbol[40] = 0;
        statue_Game();
    }
    protected void _22_Click(object sender, EventArgs e)
    {
        _22.Visible = false;
        symbol[42] = 0;
        statue_Game();
    }
    protected void _23_Click(object sender, EventArgs e)
    {
        _24.Visible = false;
        symbol[46] = 0;
        statue_Game();
    }
    protected void _24_Click(object sender, EventArgs e)
    {
        _23.Visible = false;
        symbol[44] = 0;
        statue_Game();
    }
    protected void _25_Click(object sender, EventArgs e)
    {
        _25.Visible = false;
        symbol[48] = 0;
        statue_Game();
    }
    protected void _26_Click(object sender, EventArgs e)
    {
        _26.Visible = false;
        symbol[50] = 0;
        statue_Game();
    }
    protected void _27_Click(object sender, EventArgs e)
    {
        _27.Visible = false;
        symbol[52] = 0;
        statue_Game();
    }
    protected void _28_Click(object sender, EventArgs e)
    {
        _28.Visible = false;
        symbol[54] = 0;
        statue_Game();
    }
    protected void _29_Click(object sender, EventArgs e)
    {
        _29.Visible = false;
        symbol[56] = 0;
        statue_Game();
    }
    protected void _30_Click(object sender, EventArgs e)
    {
        _30.Visible = false;
        symbol[58] = 0;
        statue_Game();
    }
    public void statue_Game()
    {
        int count = 0;
        for (int i = 0; i < 60; i = i + 2)
        {
            if (symbol[i] == 0)
                count++;
        }
        if (count == 30)
        {
            Response.Write("Human win!");
            SqlConnection conn = new SqlConnection(@"Data Source = EEITAX9QZR6D7JX\SQLEXPRESS; Initial Catalog = GameHistory; uid = sa;pwd = 123456 ");
            conn.Open();
            String username = Session["username"].ToString();
            SqlCommand findUser = new SqlCommand("select count(*) from Table_2 where UserName = '" + username + "'", conn);
            int num = Convert.ToInt32(findUser.ExecuteScalar());
            if (num >= 1)
            {
                SqlCommand add = new SqlCommand("update Table_2 set Played = Played+1 where UserName = '"+username+"'", conn);
                add.ExecuteNonQuery();
            }
            else
            {
                SqlCommand insert = new SqlCommand("insert into Table_2(UserName,Won,Lost,Played) values( '" + username + "',1,0,1)", conn);
                insert.ExecuteNonQuery();
            }

            conn.Close();
        }
    }
    public int count_Bag1()
    {
        int count1 = 0;
        for (int i = 0; i < 20; i = i + 2)
        {
            if (symbol[i] != 0)
                count1++;
        }
        return count1;

    }
    public int count_Bag2()
    {
        int count2 = 0;
        for (int i = 20; i < 40; i = i + 2)
        {
            if (symbol[i] != 0)
                count2++;
        }
        return count2;

    }
    public int count_Bag3()
    {
        int count3 = 0;
        for (int i = 40; i < 60; i = i + 2)
        {
            if (symbol[i] != 0)
                count3++;
        }
        return count3;

    }
    public int jungle_Bag(int i, int j, int k, int z)
    {
        if (i >= z && j >= z && k >= z)
        {
            return bagStatus[0];
        }
        else if (i >= z && j >= z && k <= z)
        {
            return bagStatus[1];
        }
        else if (i >= z && j <= z && k >= z)
        {
            return bagStatus[2];
        }
        else if (i <= z && j >= z && k >= z)
        {
            return bagStatus[3];
        }
        else if (i >= z && j <= z && k <= z)
        {
            return bagStatus[4];
        }
        else if (i <= z && j >= z && k <= z)
        {
            return bagStatus[5];
        }
        else if (i <= z && j <= z && k >= z)
        {
            return bagStatus[6];
        }

        return 0;
    }

    protected void Finish_Button_Click1(object sender, EventArgs e)
    {
       // Panel3.Controls[17].Visible = false;
        Random ran = new Random();
        int ranKey = ran.Next(1, 5);
        int count1_Bag1 = count_Bag1();
        int count2_Bag2 = count_Bag2();
        int count3_Bag3 = count_Bag3();
        int[] area_bag = new int[] { 1, 3 };
        int ranBag = ran.Next(1, 3);
        int statue_bag = jungle_Bag(count1_Bag1, count2_Bag2, count3_Bag3, ranKey);
        if (statue_bag != 0)
        {
            if (statue_bag == 1)
            {
                ranBag = ran.Next(1, 3);
                Response.Write(ranBag);
                Response.Write(ranKey);
                operaStone_1(ranBag, ranKey);

            }
            else if (statue_bag == 2)
            {
                ranBag = ran.Next(1, 2);
                Response.Write(ranBag);
                Response.Write(ranKey);
                operaStone_1(ranBag, ranKey);

            }
            else if (statue_bag == 3)
            {
                ranBag = 3;
                Response.Write(ranBag);
                Response.Write(ranKey);
                operaStone_1(ranBag, ranKey);

            }
            else if (statue_bag == 4)
            {
                ranBag = ran.Next(2, 3);
                Response.Write(ranBag);
                Response.Write(ranKey);
                operaStone_1(ranBag, ranKey);

            }
            else if (statue_bag == 5)
            {
                ranBag = 1;
                Response.Write(ranBag);
                Response.Write(ranKey);
                operaStone_2(ranBag, ranKey);

            }
            else if (statue_bag == 6)
            {
                ranBag = 2;
                Response.Write(ranBag);
                Response.Write(ranKey);
                operaStone_2(ranBag, ranKey);

            }
            else if (statue_bag == 7)
            {
                ranBag = 3;
                Response.Write(ranBag);
                Response.Write(ranKey);
                operaStone_2(ranBag, ranKey);

            }

        }
        else
        {
            do
            {
                ranKey = ran.Next(1, 5);
            } while (jungle_Bag(count1_Bag1, count2_Bag2, count3_Bag3, ranKey) == 0);
            statue_bag = jungle_Bag(count1_Bag1, count2_Bag2, count3_Bag3, ranKey);
            if (statue_bag == 1)
            {
                ranBag = ran.Next(1, 3);
                Response.Write(ranBag);
                Response.Write(ranKey);
                operaStone_1(ranBag, ranKey);

            }
            else if (statue_bag == 2)
            {
                ranBag = ran.Next(1, 2);
                Response.Write(ranBag);
                Response.Write(ranKey);
                operaStone_1(ranBag, ranKey);

            }
            else if (statue_bag == 3)
            {
                ranBag = 3;
                Response.Write(ranBag);
                Response.Write(ranKey);
                operaStone_1(ranBag, ranKey);

            }
            else if (statue_bag == 4)
            {
                ranBag = ran.Next(2, 3);
                Response.Write(ranBag);
                Response.Write(ranKey);
                operaStone_1(ranBag, ranKey);

            }
            else if (statue_bag == 5)
            {
                ranBag = 1;
                Response.Write(ranBag);
                Response.Write(ranKey);
                operaStone_2(ranBag, ranKey);

            }
            else if (statue_bag == 6)
            {
                ranBag = 2;
                Response.Write(ranBag);
                Response.Write(ranKey);
                operaStone_2(ranBag, ranKey);

            }
            else if (statue_bag == 7)
            {
                ranBag = 3;
                Response.Write(ranBag);
                Response.Write(ranKey);
                operaStone_2(ranBag, ranKey);

            }

        }


    }
    public void operaStone_1(int ranBag, int ranKey)
    {
        if (ranBag == 1)
        {
            for (int j = 0; j < (ranKey * 2); j = j + 2)
            {
                if (symbol[j] != 0)
                {
                    symbol[j] = 0;
                    Panel1.Controls[j+1].Visible = false;
                    Response.Write(j);
                }

                else if (symbol[j] == 0)
                {
                    int k = j;
                    do
                    {
                        k = k + 2;
                    } while (symbol[k] == 0);
                    symbol[k] = 0;
                    Panel1.Controls[k+1].Visible = false;
                    Response.Write(k);
                }
            }
        }
        else if (ranBag == 2)
        {
            for (int j = 20; j < (20 + (ranKey * 2)); j = j + 2)
            {
                if (symbol[j] != 0)
                {
                    symbol[j] = 0;
                    Panel2.Controls[j - 19].Visible = false;
                    Response.Write(j);
                }
                else if (symbol[j] == 0)
                {
                    int k = j;
                    do
                    {
                        k = k + 2;
                    } while (symbol[k] == 0);
                    symbol[k] = 0;
                    Panel2.Controls[k - 19].Visible = false;
                    Response.Write(k);
                }
            }
        }
        else if (ranBag == 3)
        {
            for (int j = 40; j < (40 + (ranKey * 2)); j = j + 2)
            {
                if (symbol[j] != 0)
                {
                    symbol[j] = 0;
                    Panel3.Controls[j - 39].Visible = false;
                    Response.Write(j);
                }
                else if (symbol[j] == 0)
                {
                    int k = j;
                    do
                    {
                        k = k + 2;
                    } while (symbol[k] == 0);
                    symbol[k] = 0;
                    Panel3.Controls[k - 39].Visible = false;
                    Response.Write(k);
                }
            }
        }
    }
    public void operaStone_2(int ranBag, int ranKey)
    {
       
        if (ranBag == 1)
        {
            int count1 = 0;
            for(int i = 0;i<20;i=i+2)
            {
                if (symbol[i] != 0)
                    count1++;
            }
            if (count1 > ranKey)
            {
                for (int j = 0; j < (ranKey * 2); j = j + 2)
                {
                    if (symbol[j] != 0)
                    {
                        symbol[j] = 0;
                        Panel1.Controls[j+1].Visible = false;
                        Response.Write(j);
                    }

                    else if (symbol[j] == 0)
                    {
                        int k = j;
                        do
                        {
                            k = k + 2;
                        } while (symbol[k] == 0);
                        symbol[k] = 0;
                        Panel1.Controls[k+1].Visible = false;
                        Response.Write(k);
                    }
                }
            }
            else if (count1 <= ranKey)
            {
                Response.Write(count1);
                //Panel1.Controls.Clear();
                Response.Write("Computer Win");
                SqlConnection conn = new SqlConnection(@"Data Source = EEITAX9QZR6D7JX\SQLEXPRESS; Initial Catalog = GameHistory; uid = sa;pwd = 123456 ");
                conn.Open();
                String username = Session["username"].ToString();
                SqlCommand findUser = new SqlCommand("select count(*) from Table_2 where UserName = '" + username + "'", conn);
                int count = Convert.ToInt32(findUser.ExecuteScalar());
                if (count >= 1)
                {
                    SqlCommand add = new SqlCommand("update Table_2 set Played = Played+1 where UserName = '"+username+"'", conn);
                    add.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand insert = new SqlCommand("insert into Table_2(UserName,Won,Lost,Played) values( '" + username + "',0,1,1)", conn);
                    insert.ExecuteNonQuery();
                }

                conn.Close();
            }
        }
        if (ranBag == 2)
        {
            int count2 = 0;
            for (int i = 20; i < 40; i = i + 2)
            {
                if (symbol[i] != 0)
                    count2++;
            }
            if (count2 > ranKey)
            {
                for (int j = 20; j < (20+(ranKey * 2)); j = j + 2)
                {
                    if (symbol[j] != 0)
                    {
                        symbol[j] = 0;
                        Panel2.Controls[j -19].Visible = false;
                        Response.Write(j);
                    }

                    else if (symbol[j] == 0)
                    {
                        int k = j;
                        do
                        {
                            k = k + 2;
                        } while (symbol[k] == 0);
                        symbol[k] = 0;
                        Panel2.Controls[k - 19].Visible = false;
                        Response.Write(k);
                    }
                }
            }
            else if (count2 <= ranKey)
            {
                Response.Write(count2);
                //Panel2.Controls.Clear();
                Response.Write("Computer Win");
                SqlConnection conn = new SqlConnection(@"Data Source = EEITAX9QZR6D7JX\SQLEXPRESS; Initial Catalog = GameHistory; uid = sa;pwd = 123456 ");
                conn.Open();
                String username = Session["username"].ToString();
                SqlCommand findUser = new SqlCommand("select count(*) from Table_2 where UserName = '" + username + "'", conn);
                int count = Convert.ToInt32(findUser.ExecuteScalar());
                if (count >= 1)
                {
                    SqlCommand add = new SqlCommand("update Table_2 set Played = Played+1 where UserName = '"+username+"'", conn);
                    add.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand insert = new SqlCommand("insert into Table_2(UserName,Won,Lost,Played) values( '" + username + "',0,1,1)", conn);
                    insert.ExecuteNonQuery();
                }

                conn.Close();
            }
        }
        if (ranBag == 3)
        {
            int count3 = 0;
            for (int i = 40; i < 60; i = i + 2)
            {
                if (symbol[i] != 0)
                    count3++;
            }
            if (count3 > ranKey)
            {
                for (int j = 40; j < (40+(ranKey * 2)); j = j + 2)
                {
                    if (symbol[j] != 0)
                    {
                        symbol[j] = 0;
                        Panel3.Controls[j - 39].Visible = false;
                        Response.Write(j);
                    }

                    else if (symbol[j] == 0)
                    {
                        int k = j;
                        do
                        {
                            k = k + 2;
                        } while (symbol[k] == 0);
                        symbol[k] = 0;
                        Panel3.Controls[k - 39].Visible = false;
                        Response.Write(k);
                    }
                }
            }
            else if (count3 <= ranKey)
            {
                Response.Write(count3);
                //Panel3.Controls.Clear();
                Response.Write("Computer Win");
                SqlConnection conn = new SqlConnection(@"Data Source = EEITAX9QZR6D7JX\SQLEXPRESS; Initial Catalog = GameHistory; uid = sa;pwd = 123456 ");
                conn.Open();
                String username = Session["username"].ToString();
                SqlCommand findUser = new SqlCommand("select count(*) from Table_2 where UserName = '"+ username +"'", conn);
                int count = Convert.ToInt32(findUser.ExecuteScalar());
                if (count >= 1)
                {
                    SqlCommand add = new SqlCommand("update Table_2 set Played = Played+1 where UserName = '"+username+"'", conn);
                    add.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand insert = new SqlCommand("insert into Table_2(UserName,Won,Lost,Played) values( '" + username + "',0,1,1)", conn);
                    insert.ExecuteNonQuery();
                }
                    
                conn.Close();
            }
        }
 
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        symbol = new int[] { 1, 0, 3, 0, 5, 0, 7, 0, 9, 0, 11, 0, 13, 0, 
                                      15, 0, 17, 0, 19, 0, 21, 0, 23, 0, 25, 0, 27, 0, 29, 0,31,0,33,0,35,0,37,0,39,0,
                                      41,0,43,0,45,0,47,0,49,0,51,0,53,0,55,0,57,0,59,0};
        Response.Redirect("Page_Game.aspx", true);
    }
}