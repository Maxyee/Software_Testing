<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorPage.aspx.cs" Inherits="Calculator.Web.CalculatorPage" %>

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
               <td>Numerator</td>
                <td>
                    <asp:TextBox ID="txtNumerator" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
               <td>Denominator</td>
                <td>
                    <asp:TextBox ID="txtDenominator" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
               <td>Result</td>
                <td>
                    <asp:Button ID="Divide" runat="server" Text="Divide" OnClick="Divide_Click" />
                </td>
            </tr>
            <tr>
                <td>Outpur</td>
                <td>
                    <asp:Label ID="lblResult" runat="server" Text="Outpur"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
