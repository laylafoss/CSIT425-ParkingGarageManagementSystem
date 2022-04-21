<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="map.aspx.cs" Inherits="ParkingGarageApp.app" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="firstFloorBtn" runat="server" Text="FLOOR 1" Height="61px" Width="150px" OnClick="firstFloorBtn_Click" />
        <p>
        <asp:Button ID="secondFloorBtn" runat="server" Text="FLOOR 2" Height="61px" Width="150px" />
        </p>
        <p>
        <asp:Button ID="thirdFloorBtn" runat="server" Text="FLOOR 3" Height="61px" Width="150px" />
        </p>
        <p>
        <asp:Button ID="fourthFloorBtn" runat="server" Text="FLOOR 4" Height="61px" Width="150px" />
        </p>
        <p>
        <asp:Button ID="fifthFloorBtn" runat="server" Text="FLOOR 5" Height="61px" Width="150px" />
        </p>
    </form>
</body>
</html>
