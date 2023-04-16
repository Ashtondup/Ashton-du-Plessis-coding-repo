<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="deafalt.aspx.cs" Inherits="Su3_Act2_34202676.deafalt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #808080">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Art Club Pen Order Form" Font-Size="20pt" ForeColor="#0066FF"></asp:Label>
        <div>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="First Name:"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Last Name:"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLastName" ErrorMessage="Required!"></asp:RequiredFieldValidator>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Phone Number:"></asp:Label>
            <asp:TextBox ID="txtPhoneNum" runat="server"></asp:TextBox>
            <asp:Label ID="Label5" runat="server" Text="Email Address:"></asp:Label>
            <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmailAddress" ErrorMessage="Invalid email adderss" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Pen Selections for order:"></asp:Label>
            <asp:Button ID="btnOrder" runat="server" OnClick="btnOrder_Click" style="text-align: center" Text="Place Order" />
        </p>
        <p>
            <asp:Label ID="Label7" runat="server" Text="Colour:"></asp:Label>
            <asp:ListBox ID="lbColour" runat="server" Height="42px" Width="101px">
                <asp:ListItem>Red</asp:ListItem>
                <asp:ListItem>Black</asp:ListItem>
                <asp:ListItem>Blue</asp:ListItem>
                <asp:ListItem>Green</asp:ListItem>
                <asp:ListItem>Rainbow</asp:ListItem>
            </asp:ListBox>
            <asp:Label ID="Label8" runat="server" Text="Amount:"></asp:Label>
            <asp:TextBox ID="txtAmount" runat="server" OnTextChanged="txtAmount_TextChanged"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtAmount" ErrorMessage="Amount is not valid" MaximumValue="101" MinimumValue="9" Type="Integer"></asp:RangeValidator>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblResult" runat="server" Font-Bold="False" ForeColor="Black"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblAmount" runat="server" Font-Italic="True"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblTax" runat="server" Font-Italic="True"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblTotal" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        </p>
    </form>
</body>
</html>
