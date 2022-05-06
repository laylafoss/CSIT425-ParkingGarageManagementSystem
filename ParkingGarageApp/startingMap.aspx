<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="startingMap.aspx.cs" Inherits="ParkingGarageApp.startingMap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center; height: 747px; background-color: #99CCFF;">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Names="Candara" Font-Size="Large" ForeColor="#3333FF" Text="Choose which floor you would like to access:"></asp:Label>
            <br />
            <br />
        <asp:Button ID="firstFloorBtn" runat="server" Text="FLOOR 1" Height="61px" Width="150px" OnClick="firstFloorBtn_Click" BorderColor="#3333FF" />
        &nbsp;&nbsp;
        <asp:Button ID="secondFloorBtn" runat="server" Text="FLOOR 2" Height="61px" Width="150px" OnClick="secondFloorBtn_Click" BorderColor="#3333FF" />
        &nbsp;&nbsp;
        <asp:Button ID="thirdFloorBtn" runat="server" Text="FLOOR 3" Height="61px" Width="150px" OnClick="thirdFloorBtn_Click" BorderColor="#3333FF" />
        &nbsp;&nbsp;
        <asp:Button ID="fourthFloorBtn" runat="server" Text="FLOOR 4" Height="61px" Width="150px" OnClick="fourthFloorBtn_Click" BorderColor="#3333FF" />
        &nbsp;&nbsp;
        <asp:Button ID="fifthFloorBtn" runat="server" Text="FLOOR 5" Height="61px" Width="150px" OnClick="fifthFloorBtn_Click" BorderColor="#3333FF" />
        </div>
    </form>
</body>
</html>
