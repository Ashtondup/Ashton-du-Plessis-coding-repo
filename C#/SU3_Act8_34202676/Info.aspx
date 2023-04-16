<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Info.aspx.cs" Inherits="SU3_Act8.Info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #FFFFCC">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:Label ID="lblInfo" runat="server" Font-Size="XX-Large" Text="Info"></asp:Label>
			<br />
			<br />
			<asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
			<br />
			<br />
			<asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label>
			<br />
			<br />
			<asp:Calendar ID="cldOut" runat="server"></asp:Calendar>
			<br />
			<asp:HyperLink ID="HyperLink1" runat="server" Font-Underline="True" NavigateUrl="~/Default.aspx">Back</asp:HyperLink>
        </div>
    </form>
</body>
</html>
