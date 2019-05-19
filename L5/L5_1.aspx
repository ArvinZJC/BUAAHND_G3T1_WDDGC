<!-- web form page that practices using "</% (code block) /%>" -->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="L5_1.aspx.cs" Inherits="L5.L5_1" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Show Greetings</title>
</head>
<body>
    <form id="form1" runat="server">
        <% if (DateTime.Now.Hour < 12)
            {
        %>
        Good morning!
        <%  }
           else
            {
        %>
        Good afternoon!
        <%  } %>
    </form>
</body>
</html>