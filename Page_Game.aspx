<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page_Game.aspx.cs" Inherits="Page_Game" %>

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
        
        <asp:Panel ID="Panel2" runat="server" BorderWidth="4px" style="z-index: 1; left: 299px; top: 113px; position: absolute; height: 134px; width: 259px">
            <asp:Button ID="_11" runat="server" style="z-index: 1; left: 23px; top: 2px; position: absolute" Text="Stone" OnClick="_11_Click" />
            <asp:Button ID="_12" runat="server" OnClick="_12_Click" style="z-index: 1; left: 100px; top: 2px; position: absolute; height: 21px" Text="Stone" />
            <asp:Button ID="_13" runat="server" OnClick="_13_Click" style="z-index: 1; left: 19px; top: 36px; position: absolute; height: 21px;" Text="Stone" />
            <asp:Button ID="_14" runat="server" OnClick="_14_Click" style="z-index: 1; left: 101px; top: 37px; position: absolute" Text="Stone" />
            <asp:Button ID="_15" runat="server" OnClick="_17_Click" style="z-index: 1; left: 100px; top: 68px; position: absolute" Text="Stone" />
            <asp:Button ID="_16" runat="server" OnClick="_16_Click" style="z-index: 1; left: 9px; top: 70px; position: absolute" Text="Stone" />
            <asp:Button ID="_17" runat="server" OnClick="_15_Click" style="z-index: 1; left: 190px; top: 39px; position: absolute" Text="Stone" />
            <asp:Button ID="_18" runat="server" OnClick="_19_Click" style="z-index: 1; left: 12px; top: 102px; position: absolute" Text="Stone" />
            <asp:Button ID="_19" runat="server" OnClick="_18_Click" style="z-index: 1; left: 189px; top: 70px; position: absolute" Text="Stone" />
            <asp:Button ID="_20" runat="server" OnClick="_20_Click" style="z-index: 1; left: 95px; top: 105px; position: absolute" Text="Stone" />
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" BorderWidth="4px" style="z-index: 1; left: 619px; top: 113px; position: absolute; height: 135px; width: 272px">
            <asp:Button ID="_21" runat="server" style="z-index: 1; left: 102px; top: 4px; position: absolute" Text="Stone" OnClick="_21_Click" />
            <asp:Button ID="_22" runat="server" OnClick="_22_Click" style="z-index: 1; left: 198px; top: 5px; position: absolute" Text="Stone" />
            <asp:Button ID="_23" runat="server" OnClick="_24_Click" style="z-index: 1; left: 101px; top: 38px; position: absolute" Text="Stone" />
            <asp:Button ID="_24" runat="server" OnClick="_23_Click" style="z-index: 1; left: 2px; top: 37px; position: absolute; height: 21px" Text="Stone" />
            <asp:Button ID="_25" runat="server" OnClick="_25_Click" style="z-index: 1; left: 195px; top: 39px; position: absolute" Text="Stone" />
            <asp:Button ID="_26" runat="server" OnClick="_26_Click" style="z-index: 1; left: 3px; top: 71px; position: absolute" Text="Stone" />
            <asp:Button ID="_27" runat="server" OnClick="_27_Click" style="z-index: 1; left: 103px; top: 69px; position: absolute" Text="Stone" />
            <asp:Button ID="_28" runat="server" OnClick="_28_Click" style="z-index: 1; left: 197px; top: 69px; position: absolute" Text="Stone" />
            <asp:Button ID="_29" runat="server" OnClick="_29_Click" style="z-index: 1; left: 3px; top: 104px; position: absolute" Text="Stone" />
            <asp:Button ID="_30" runat="server" OnClick="_30_Click" style="z-index: 1; left: 99px; top: 100px; position: absolute" Text="Stone" />
        </asp:Panel>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 818px; top: 62px; position: absolute; width: 65px;" Text="Restart" />
        <p style="margin-left: 160px">
            <asp:Button ID="Finish_Button" runat="server" style="z-index: 1; left: 818px; top: 29px; position: absolute; width: 63px;" Text="Finish" OnClick="Finish_Button_Click1" />
        </p>
        <asp:Panel ID="Panel1" runat="server" BorderWidth="4px" style="z-index: 1; left: 10px; top: 113px; position: absolute; height: 134px; width: 244px">
            <asp:Button ID="_1" runat="server" OnClick="_4_Click" style="z-index: 1; left: 75px; top: 32px; position: absolute; height: 21px;" Text="Stone" />
            <asp:Button ID="_2" runat="server" OnClick="_7_Click" style="z-index: 1; left: 84px; top: 60px; position: absolute; height: 24px; width: 51px;" Text="Stone" />
            <asp:Button ID="_3" runat="server" OnClick="_8_Click" style="z-index: 1; left: 153px; top: 74px; position: absolute; width: 46px; height: 24px;" Text="Stone" />
            <asp:Button ID="_4" runat="server" OnClick="_3_Click" style="z-index: 1; left: 10px; top: 30px; position: absolute; right: 181px;" Text="Stone" />
            <asp:Button ID="_5" runat="server" OnClick="_1_Click" style="z-index: 1; left: 21px; top: 4px; position: absolute" Text="Stone" />
            <asp:Button ID="_6" runat="server" OnClick="_2_Click" style="z-index: 1; left: 89px; top: 5px; position: absolute; height: 24px;" Text="Stone" />
            <asp:Button ID="_7" runat="server" OnClick="_5_Click" style="z-index: 1; left: 153px; top: 30px; position: absolute; height: 21px;" Text="Stone" />
            <asp:Button ID="_8" runat="server" OnClick="_6_Click" style="z-index: 1; left: 15px; top: 61px; position: absolute" Text="Stone" />
            <asp:Button ID="_9" runat="server" OnClick="_10_Click" style="z-index: 1; left: 83px; top: 94px; position: absolute; height: 25px; width: 56px;" Text="Stone" />
            <asp:Button ID="_10" runat="server" OnClick="_9_Click" style="z-index: 1; left: 16px; top: 96px; position: absolute; height: 24px; width: 47px;" Text="Stone" />
        </asp:Panel>
    </form>
</body>
</html>
