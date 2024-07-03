<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication3.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>

       
        .cont{
            display: flex;
            flex-direction: row;
            width: 700px;
            height: 500px;
            align-items: center;
            justify-content: space-evenly;
            background-color: whitesmoke;
        }
        .auto-style1, .auto-style2{
            border: 1px solid black;
        }
        .auto-style1{
            background-color: aqua;
        }
        .auto-style2{
            background-color: wheat;
        }
    </style>
</head>
<body>
    <center>
    <form id="form1" runat="server">
        <div class="cont">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">gfgg</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">gvgnvmvm</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>

            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">ytrtyy</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>gfffjj</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
    </form>
    </center>
</body>
</html>
