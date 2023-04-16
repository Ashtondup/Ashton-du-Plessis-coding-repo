<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConcertBooking.aspx.cs" Inherits="Su3_Act3_34202676.ConcertBooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 59px;
        }
        .auto-style4 {
            width: 182px;
        }
        .auto-style5 {
            width: 26%;
        }
        .auto-style6 {
            width: 141px;
        }
        .auto-style7 {
            width: 52px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="15pt" Text="Concert Booking"></asp:Label>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label3" runat="server" Text="Name and Surname:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtName_Surname" runat="server" AutoPostBack="True"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label4" runat="server" Text="Number of tickerts:"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table class="auto-style5">
            <tr>
                <td class="auto-style2">
                    <asp:RadioButton ID="rb1" runat="server" AutoPostBack="True" GroupName="numTickets" OnCheckedChanged="rb1_CheckedChanged" Text="1" />
                </td>
                <td class="auto-style7">
                    <asp:RadioButton ID="rb2" runat="server" AutoPostBack="True" GroupName="numTickets" OnCheckedChanged="rb1_CheckedChanged" Text="2" />
                </td>
                <td class="auto-style4">
                    <asp:RadioButton ID="rb3" runat="server" AutoPostBack="True" GroupName="numTickets" OnCheckedChanged="rb1_CheckedChanged" Text="3" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style7"></td>
                <td class="auto-style4"></td>
            </tr>
        </table>
        <asp:Label ID="Label5" runat="server" Text="Select show time:"></asp:Label>
        <p>
            <asp:Button ID="btn11oclock" runat="server" OnClick="btn11oclock_Click" Text="11:00" />
            <asp:Button ID="btn2oclock" runat="server" OnClick="btn2oclock_Click" Text="14:00" />
            <asp:Button ID="btn5oclock" runat="server" OnClick="btn5oclock_Click" Text="17:00" />
        </p>
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnBook" runat="server" Height="33px" OnClick="btnBook_Click" Text="Book" Width="255px" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Label ID="lblDisplay" runat="server"></asp:Label>
    </form>
</body>
</html>
