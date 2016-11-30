<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApproveReject.aspx.cs" Inherits="TR.UI.Web.ApproveReject" %>

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
                <td>RequestID</td>
                  <td>
                      &nbsp;</td>
                  
                  <td>
                      <asp:Label ID="lblRequestID" runat="server"></asp:Label>
                      <asp:Label ID="lbluserID" runat="server"></asp:Label>
                </td>
                  
                  <td>
                      &nbsp;</td>
                  
            </tr>
            <%--    <tr>
                <td>CorrelationID</td>
                  <td>
                      <asp:Label ID="lblCorrelationID" runat="server"></asp:Label>
                   </td>
                  
            </tr>--%>
               <tr>
                <td>UserName</td>
                  <td>
                      &nbsp;</td>
                  
                  <td>
                      <asp:Label ID="lblUserName" runat="server"></asp:Label>
                   </td>
                  
                  <td>
                      &nbsp;</td>
                  
            </tr>
            <tr>
                <td>Training Name</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:TextBox ID="txtTrainingName" runat="server"></asp:TextBox>
                    <asp:Label ID="lblguid" runat="server" Visible="False"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
               <tr>
                <td>StartDate</td>
                  <td>
                      &nbsp;</td>
                  
                  <td>
                      <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
                   </td>
                  
                  <td>
                      &nbsp;</td>
                  
            </tr>
               <tr>
                <td>EndDate</td>
                  <td>
                      &nbsp;</td>
                  
                  <td>
                      <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
                   </td>
                  
                  <td>
                      &nbsp;</td>
                  
            </tr>
               <tr>
                <td>Request Status</td>
                  <td>
                      &nbsp;</td>
                  
                  <td>
                      <asp:Label ID="lblStatus" runat="server" Text="PENDING"></asp:Label>
                   </td>
                  
                  <td>
                      &nbsp;</td>
                  
            </tr>
            <tr>
                <td>Submit Date</td>
                 <td>
                     &nbsp;</td>
                 <td>
                     <asp:Label ID="lblSubmitDate" runat="server"></asp:Label>
                </td>
                 <td>
                     &nbsp;</td>
            </tr>
            <tr>
                <td></td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit Request Training" OnClick="btnSubmit_Click" /></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel Training" />
                </td>
           
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnApprove" runat="server" Text="Approve Training" OnClick="btnApprove_Click" />
                    <asp:Button ID="btnReject" runat="server" OnClick="btnReject_Click" Text="Reject Training" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateSelectButton="True"    >
           
            
        </asp:GridView>
        <div>
            <asp:Button ID="btnExport" runat="server" Text="ExportData" OnClick="btnExport_Click" />
        </div>
    </div>
    </form>
</body>
</html>