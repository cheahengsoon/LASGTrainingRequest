<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Export.aspx.cs" Inherits="TR.UI.Web.Export" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnExport" runat="server" Text="Export" OnClick="btnExport_Click" />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        
    </div>
    </form>
</body>
</html>
