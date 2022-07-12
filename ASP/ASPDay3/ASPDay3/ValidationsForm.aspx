<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationsForm.aspx.cs" Inherits="ASPDay3.ValidationsForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h2 style="text-align:center">Registration Form</h2>
            User Name&nbsp;
            <asp:TextBox ID="Txtname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="User name can not be blank" ForeColor="Red" ControlToValidate="Txtname"></asp:RequiredFieldValidator>
            <br />
            <br />
            Password&nbsp;
            <asp:TextBox ID="Txtpwd" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Password" ForeColor="Red" ControlToValidate="Txtpwd"></asp:RequiredFieldValidator>
            <br />
            <br />
            Conform Password&nbsp;
            <asp:TextBox ID="Txtcpwd" runat="server"></asp:TextBox>
             <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password do Not match" ForeColor="Red" ControlToValidate="Txtcpwd" ControlToCompare="Txtpwd"></asp:CompareValidator>
            <br />
            <br />
            Age&nbsp;
            <asp:TextBox ID="Txtage" runat="server" ></asp:TextBox>
             <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age has to be between 18 and 45" ForeColor="Red" MaximumValue="45" MinimumValue="18" Type="Integer" ControlToValidate="Txtage"></asp:RangeValidator>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Age" ForeColor="Red" ControlToValidate="Txtage"></asp:RequiredFieldValidator>
            <br />
            <br />
            Email&nbsp;
            <asp:TextBox ID="Txtemail" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter Valid Email Id" ControlToValidate="Txtemail" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click"  />
        </div>
    </form>
</body>
</html>
