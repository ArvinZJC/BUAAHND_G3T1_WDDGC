<!--2018.10.19, main page of the web form page that practices using ASP.NET built-in objects Response and Request-->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="L5.L5_3.MainPage" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Welcome to ASP.NET!</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <asp:Button ID="btnStart" Text="Start" runat="server" OnClick="btnStart_Click" />
            <p></p>
            <b>Name:</b>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <b>&nbsp;Age:</b>
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <p></p>
            <asp:Button ID="btnOK" Text="OK" runat="server" OnClick="btnOK_Click" />
            <p></p>
            <asp:Button ID="btnClose" Text="Close" runat="server" OnClick="btnClose_Click" />
        </div>
    </form>
</body>
</html>