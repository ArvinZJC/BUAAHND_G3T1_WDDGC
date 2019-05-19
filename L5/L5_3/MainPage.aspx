<!-- main page that practices using ASP.NET built-in objects Response and Request -->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="L5.L5_3.MainPage" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Welcome to ASP.NET!</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <asp:Button ID="BtnStart" Text="Start" runat="server" OnClick="BtnStart_Click" />
            <p></p>
            <b>Name:</b>
            <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
            <br />
            <b>&nbsp;Age:</b>
            <asp:TextBox ID="TxtAge" runat="server"></asp:TextBox>
            <p></p>
            <asp:Button ID="BtnOK" Text="OK" runat="server" OnClick="BtnOK_Click" />
            <p></p>
            <asp:Button ID="BtnClose" Text="Close" runat="server" OnClick="BtnClose_Click" />
        </div>
    </form>
</body>
</html>