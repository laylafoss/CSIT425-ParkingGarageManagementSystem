<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customerChoice.aspx.cs" Inherits="ParkingGarageApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome!<br />
            <br />
            <asp:Button ID="dailyBtn" runat="server" Text="DAILY" Height="47px" OnClick="dailyBtn_Click" Width="142px" />
            <br />
            <br />
        </div>
        <asp:Button ID="monthlyBtn" runat="server" Text="MONTHLY" Height="45px" OnClick="monthlyBtn_Click" Width="140px" />
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/adminPage.aspx">Administrator Access</asp:HyperLink>
        </p>
    </form>
    </body>
</html>
