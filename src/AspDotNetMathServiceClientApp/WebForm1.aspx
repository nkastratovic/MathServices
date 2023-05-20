<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AspDotNetMathServiceClientApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="font-family: Arial">
                <tr>
                    <td>
                        <b>First Number</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstNumber" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Second Number</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSecondNumber" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Add</b>
                    </td>
                    <td>
                        <asp:Label ID="lblAddResult" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Subtract</b>
                    </td>
                    <td>
                        <asp:Label ID="lblSubtractResult" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Multiply</b>
                    </td>
                    <td>
                        <asp:Label ID="lblMultiplyResult" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Divide</b>
                    </td>
                    <td>
                        <asp:Label ID="lblDivideResult" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnCalculate" runat="server" Text="Calculate"
                            OnClick="btnCalculate_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
