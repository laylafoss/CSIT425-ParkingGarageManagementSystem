<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminPage.aspx.cs" Inherits="ParkingGarageApp.adminPage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            text-align: center;
        }
    </style>
</head>
<body style="height: 594px; background-color: #99CCFF;">
    <form id="form1" runat="server">
        <div>
            </div>
        Database Connection and Management<br />
        <br />
        <br />
        <asp:Button ID="btnTestCon" runat="server" OnClick="btnTestCon_Click" Text="Display all spaces" />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Button ID="btnTestRet" runat="server" OnClick="btnTestRet_Click" Text="How many spots are free?" />
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="btnTestWrit" runat="server" OnClick="btnTestWrit_Click" Text="How many daily customers currenty parked?" />
        <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="btnMnthCount" runat="server" OnClick="btnMnthCount_Click" Text="How many monthly customers parked?" />
        <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnEarned" runat="server" OnClick="btnEarned_Click" Text="Total amount earned for current date" />
        &nbsp;
        <asp:Label ID="Label4" runat="server" Text="Label" Visible="False"></asp:Label>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Total amount earned alltime" />
            <asp:Label ID="Label5" runat="server" Text="Label" Visible="False"></asp:Label>
        </p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Generate monthly invoice" />
        <asp:Label ID="Label6" runat="server" Text="Label" Visible="False"></asp:Label>
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        <asp:Label ID="Label7" runat="server" Text="The following customers have had their monthly invoice sent to them" Visible="False"></asp:Label>
    </form>
</body>
</html>
