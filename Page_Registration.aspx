<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page_Registration.aspx.cs" Inherits="Page_Registration" %>

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
        <asp:Label ID="Registration_label" runat="server" style="z-index: 1; left: 254px; top: 57px; position: absolute; height: 36px; width: 168px; text-align: center" Text="Welcome to Register"></asp:Label>
        <p>
            <asp:Label ID="Username2_lable" runat="server" style="z-index: 1; left: 42px; top: 113px; position: absolute; height: 23px; width: 145px" Text="Enter the username"></asp:Label>
        </p>
        <asp:TextBox ID="Username2" runat="server" style="z-index: 1; left: 216px; top: 109px; position: absolute; width: 228px; height: 24px"></asp:TextBox>
        <asp:Button ID="Back_Button" runat="server" OnClick="Back_Button_Click" style="z-index: 1; left: 360px; top: 183px; position: absolute; height: 34px; width: 108px" Text="Back to login" />
        <p>
            &nbsp;</p>
        <asp:Button ID="Create_Button" runat="server" OnClick="Create_Button_Click" style="z-index: 1; left: 198px; top: 185px; position: absolute; height: 34px; width: 98px" Text="Create" />
    </form>
</body>
</html>
