<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

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
            <td>Enter First Name</td>
            <td><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>Enter Last Name</td>
            <td><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>Email</td>
            <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>License Number</td>
            <td><asp:TextBox ID="txtLicense" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>Vehicle Make</td>
            <td><asp:TextBox ID="txtMake" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>Enter vehicle Year</td>
            <td>
                <asp:DropDownList ID="ddYears" runat="server"></asp:DropDownList>
            </td>
        </tr>
         <tr>
            <td>Enter password</td>
            <td><asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>Confirm Password</td>
            <td><asp:TextBox ID="txtConfirm" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
            <td>
                <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
