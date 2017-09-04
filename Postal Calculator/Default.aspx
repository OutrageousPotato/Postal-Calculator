<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Postal_Calculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Postal Calculator<br />
        <br />
        Width:&nbsp;
        <asp:TextBox ID="WidthTextBox" runat="server" AutoPostBack="True" OnTextChanged="WidthTextBox_TextChanged">1</asp:TextBox>
        <br />
        Height:&nbsp;
        <asp:TextBox ID="HeightTextBox" runat="server" AutoPostBack="True" OnTextChanged="HeightTextBox_TextChanged">1</asp:TextBox>
        <br />
        Length:&nbsp;
        <asp:TextBox ID="LengthTextBox" runat="server" AutoPostBack="True" OnTextChanged="LengthTextBox_TextChanged">1</asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="GroundButton" runat="server" AutoPostBack="True" GroupName="ShippingMethod" OnCheckedChanged="GroundButton_CheckedChanged" Text="Ground" />
        <br />
        <asp:RadioButton ID="AirButton" runat="server" AutoPostBack="True" GroupName="ShippingMethod" OnCheckedChanged="AirButton_CheckedChanged" Text="Air" />
        <br />
        <asp:RadioButton ID="NextDayButton" runat="server" AutoPostBack="True" GroupName="ShippingMethod" OnCheckedChanged="NextDayButton_CheckedChanged" Text="Next Day" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
