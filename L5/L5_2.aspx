<!-- web form page that practices using "</%= (expression) /%>" -->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="L5_2.aspx.cs" Inherits="L5.L5_2" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>HELLO WORLD!</title>
</head>
<body>
    <form id="form1" runat="server">
        <% for (int i = 0; i < 7; i++)
            {
        %>
        <p><%= i + 1 %>: Hello World!<br /></p>
        <%  } %>
    </form>
</body>
</html>