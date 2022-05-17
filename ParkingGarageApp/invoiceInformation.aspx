<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="invoiceInformation.aspx.cs" Inherits="ParkingGarageApp.invoiceInformation" UnobtrusiveValidationMode="None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center; background-color: #99CCFF; height: 713px;">
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Names="Candara" Text="Payment Information Needed"></asp:Label>
            <br />
            <br />
            How many hours will you be occupying the spot:&nbsp;
            <asp:ListBox ID="hoursParkingListBox" runat="server" Height="24px" Width="48px">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem Value="8">8+</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:ListBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <br />
            Card Information<br />
            Card Holder Name:&nbsp;
            <asp:TextBox ID="cardHolderNameTxt" runat="server"></asp:TextBox>
            <br />
            <br />
            Credit/Debit Card Number:&nbsp;
            <asp:TextBox ID="cardNumberTxt" runat="server" Width="264px"></asp:TextBox>
            <%--<asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="cardNumberTxt" ErrorMessage= "Error" />--%>
            <br />
            <br />
            Expiration Date (MM/YY):&nbsp;
            <asp:TextBox ID="expirationDateTxt" runat="server" Width="41px"></asp:TextBox>
            <%--<asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="cardNumberTxt" ErrorMessage= "Error" />--%>
&nbsp;<br />
            <br />
            <asp:Button ID="confirmBtn" runat="server" OnClick="confirmBtn_Click" Text="CONFIRM" Height="39px" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
