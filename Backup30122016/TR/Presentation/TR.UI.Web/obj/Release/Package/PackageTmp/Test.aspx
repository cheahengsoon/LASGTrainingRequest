<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="TR.UI.Web.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
        <tr>
            <td>Username</td>
            <td>
                <asp:TextBox ID="txtusername" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td></td>
            <td>
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /></td>
        </tr>
    </table>
    </div>
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>

        </div>
    </form>
</body>
</html>
