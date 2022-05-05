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
            <br />
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
