<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="invoiceInformation.aspx.cs" Inherits="ParkingGarageApp.invoiceInformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Payment Information Needed<br />
            How many hours will you be occupying the spot:&nbsp;
            <asp:ListBox ID="hoursParkingListBox" runat="server" Height="24px" Width="48px">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8+</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <br />
            Card Information<br />
            Card Holder Name:&nbsp;
            <asp:TextBox ID="cardHolderNameTxt" runat="server"></asp:TextBox>
            <br />
            <br />
            Credit/Debit Card Number:&nbsp;
            <asp:TextBox ID="cardNumberTxt" runat="server" Width="264px"></asp:TextBox>
            <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="cardNumberTxt" ErrorMessage= "Error" />
            <br />
            <br />
            Expiration Date (MM/YY):&nbsp;
            <asp:TextBox ID="expirationDateTxt" runat="server" Width="41px"></asp:TextBox>
            <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="cardNumberTxt" ErrorMessage= "Error" />
&nbsp;</div>
        <p>
            <asp:Button ID="confirmBtn" runat="server" OnClick="confirmBtn_Click" Text="Confirm" />
        </p>
    </form>
</body>
</html>
