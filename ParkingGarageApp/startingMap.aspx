<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="startingMap.aspx.cs" Inherits="ParkingGarageApp.startingMap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Choose which floor you would like to access:<br />
            <br />
        <asp:Button ID="firstFloorBtn" runat="server" Text="FLOOR 1" Height="61px" Width="150px" OnClick="firstFloorBtn_Click" />
        &nbsp;&nbsp;
        <asp:Button ID="secondFloorBtn" runat="server" Text="FLOOR 2" Height="61px" Width="150px" OnClick="secondFloorBtn_Click" />
        &nbsp;&nbsp;
        <asp:Button ID="thirdFloorBtn" runat="server" Text="FLOOR 3" Height="61px" Width="150px" />
        &nbsp;&nbsp;
        <asp:Button ID="fourthFloorBtn" runat="server" Text="FLOOR 4" Height="61px" Width="150px" />
        &nbsp;&nbsp;
        <asp:Button ID="fifthFloorBtn" runat="server" Text="FLOOR 5" Height="61px" Width="150px" />
        </div>
    </form>
</body>
</html>
