<!--2018.10.19, summary page of the web form page that practices using ASP.NET built-in objects Response and Request-->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SummaryPage.aspx.cs" Inherits="L5.L5_3.SummaryPage" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Summary</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <asp:Button ID="btnReturn" Text="Return" runat="server" OnClick="btnReturn_Click" />
        </div>
    </form>
</body>
</html>