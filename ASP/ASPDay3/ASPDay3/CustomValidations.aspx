﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomValidations.aspx.cs" Inherits="ASPDay3.CustomValidations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function IsEven(source, args) {
            if (args.Value == '') {
                args.IsValid = false;
            }
            else {
                if ((args.Value > 0) && (args.Value % 2 == 0)) {
                    args.IsValid = true;
                }
                else {
                    args.IsValid = false;
                }
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Enter a Positive and an Even Number :&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Number has to be positive and Even" ForeColor="Red" 
                OnServerValidate="CustomValidator1_ServerValidate" ValidateEmptyText="True" ControlToValidate="TextBox1" ClientValidationFunction="IsEven"></asp:CustomValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
