<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Day4Webservices_Client.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           Enter Name : <asp:TextBox ID="Txtname" runat="server"></asp:TextBox>
            <br />
        </div>
        <p>
          Enter Number  <asp:TextBox ID="Txtnum" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Btnmsg" runat="server" Text="Display msg button" OnClick="Btnmsg_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btnnum" runat="server" Text="Display square button" OnClick="Btnnum_Click" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
