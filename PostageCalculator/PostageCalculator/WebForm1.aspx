<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PostageCalculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>



            Postage Calculator<br />
            <br />
            Width:&nbsp;
            <asp:TextBox ID="WidthTxt" runat="server" AutoPostBack="True" OnTextChanged="WidthTxt_TextChanged"></asp:TextBox>
            <br />
            Height:&nbsp;
            <asp:TextBox ID="HeightTxt" runat="server" AutoPostBack="True" OnTextChanged="HeightTxt_TextChanged"></asp:TextBox>
            <br />
            Length:&nbsp;
            <asp:TextBox ID="LengthTxt" runat="server" AutoPostBack="True" OnTextChanged="LengthTxt_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="GroundBtn" runat="server" AutoPostBack="True" GroupName="ShippingType" OnCheckedChanged="GroundBtn_CheckedChanged" Text="Ground" />
            <br />
            <asp:RadioButton ID="AirBtn" runat="server" AutoPostBack="True" Checked="True" GroupName="ShippingType" OnCheckedChanged="AirBtn_CheckedChanged" Text="Air" />
            <br />
            <asp:RadioButton ID="NextDayBtn" runat="server" AutoPostBack="True" GroupName="ShippingType" OnCheckedChanged="NextDayBtn_CheckedChanged" Text="Next Day" />
            <br />
            <br />
            <asp:Label ID="OutputLbl" runat="server"></asp:Label>



        </div>
    </form>
</body>
</html>
