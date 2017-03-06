<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main_Login.aspx.cs" Inherits="Main_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p>
            <asp:Label ID="Welcome" runat="server" style="z-index: 1; left: 204px; top: 46px; position: absolute; height: 27px; width: 222px; text-align: center" Text="Welcome to Game of NIM"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Username1_label" runat="server" style="z-index: 1; left: 155px; top: 98px; position: absolute; height: 5px; width: 52px" Text="Username"></asp:Label>
            <asp:TextBox ID="Username1" runat="server" style="z-index: 1; top: 96px; position: absolute; right: 642px; height: 25px; width: 169px; left: 233px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="Create_Button" runat="server" OnClick="Create_Button_Click" style="z-index: 1; top: 190px; position: absolute; width: 121px; height: 35px; left: 298px" Text="Create an account" />
        <p>
            <asp:Button ID="Login_Button" runat="server" OnClick="Login_Button_Click" style="z-index: 1; left: 154px; top: 191px; position: absolute; height: 36px; width: 87px; right: 720px" Text="Login" />
        </p>
    </form>
</body>
</html>
