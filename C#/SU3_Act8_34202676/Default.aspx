<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SU3_Act8.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #CCFFFF">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:Label ID="lblHeading" runat="server" Font-Size="XX-Large" Text="University info"></asp:Label>
			<br />
			<br />
			<asp:Label ID="lblDeets" runat="server" Text="Please enter your details:"></asp:Label>
			<br />
			<br />
			<asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
			&nbsp;&nbsp;
			<asp:TextBox ID="txtName" runat="server" OnTextChanged="txtName_TextChanged"></asp:TextBox>
			<br />
			<br />
			<asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
			&nbsp;&nbsp;&nbsp;
			<asp:TextBox ID="txtEmail" runat="server" OnTextChanged="txtEmail_TextChanged"></asp:TextBox>
			<br />
			<br />
			<asp:Panel ID="Panel1" runat="server" GroupingText="Universities" Height="156px" Width="178px">
				<asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
					<asp:ListItem Value="North-West University">NWU</asp:ListItem>
					<asp:ListItem Value="University of Johannesburg">UJ</asp:ListItem>
					<asp:ListItem Value="University of Cape Town">UCT</asp:ListItem>
					<asp:ListItem Value="University of Pretoria">UP</asp:ListItem>
					<asp:ListItem Value="University of Free State">UOFS</asp:ListItem>
				</asp:RadioButtonList>
			</asp:Panel>
			<br />
			<asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" Width="69px" />
			<br />
        </div>
    </form>
</body>
</html>
