<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Su3_Act1_34202676._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #808080">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Overline="False" Font-Underline="True" style="text-align: center" Text="GROCERY LIST CREATER" Font-Size="Larger" ForeColor="White"></asp:Label>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Font-Overline="False" Font-Underline="False" Text="Enter your name to create your own personalized GROCERY list!!!!!!!" ForeColor="Aqua"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Font-Overline="False" Font-Underline="False" Text="Name:" ForeColor="White"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Font-Overline="False" Font-Underline="False" Text="Item needed from the store:" ForeColor="Aqua"></asp:Label>
            <asp:TextBox ID="txtItem" runat="server"></asp:TextBox>
            <asp:Button ID="btnAdd" runat="server" style="text-align: right" Text="Add to list" OnClick="btnAdd_Click" />
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Font-Overline="False" Font-Underline="False" Text="CROCORY LIST" ForeColor="Lime"></asp:Label>
        </p>
        <p>
            <asp:ListBox ID="lbGrosoryList" runat="server" Height="120px" Width="286px" AutoPostBack="True"></asp:ListBox>
            <asp:Label ID="Label6" runat="server" Font-Overline="False" Font-Underline="False" ForeColor="#FF0066" style="text-align: right" Text="Select item from the list to remove"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblMessage" runat="server" Font-Overline="False" Font-Underline="False" Text="[Message]" ForeColor="White"></asp:Label>
        </p>
    </form>
</body>
</html>
