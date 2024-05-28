<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            height: 30px;
            width: 219px;
        }
        .auto-style2 {
            height: 31px;
        }

        .auto-style3 {
            text-align: left;
        }
        .auto-style4 {
            height: 31px;
            text-align: left;
            width: 128px;
        }
        .auto-style5 {
            height: 30px;
            text-align: left;
            width: 148px;
        }

        .auto-style6 {
            width: 219px;
        }
        .auto-style7 {
            height: 31px;
            width: 219px;
        }
        .auto-style8 {
            text-align: left;
            width: 148px;
        }
        .auto-style9 {
            height: 31px;
            text-align: left;
            width: 148px;
        }
        .auto-style10 {
            text-align: left;
            width: 128px;
        }
        body{
            background-color: #99FFCC;
        }
    </style>
</head>
<body>
 
   <center>
        <form id="form1" runat="server" class="mt-5">
                <h1 style="text-align: center">Web-Based Student Record Management System</h1>
                <table>
                    <tr>
                        <td class="auto-style8">
                            <asp:Label ID="Label1" runat="server" Text="Student No."></asp:Label></td>
                        <td class="auto-style6">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                        <td class="auto-style10">
                            <asp:Label ID="Label2" runat="server" Text="Department"></asp:Label></td>
                        <td class="auto-style3">
                            <asp:DropDownList ID="DeptCb" runat="server" AutoPostBack="True" Height="29px" Width="300px">
                                <asp:ListItem Value="1">Please Select Department</asp:ListItem>
                                <asp:ListItem Value="2">School of Computer Science</asp:ListItem>
                                <asp:ListItem Value="3">School of Business Management</asp:ListItem>
                                <asp:ListItem Value="4">School of Education</asp:ListItem>
                                <asp:ListItem Value="5">School of Hospitality and Tourism Management</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>

                    <tr>
                        <td class="auto-style8">
                            <asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label></td>
                        <td class="auto-style6">
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                        <td class="auto-style10">
                            <asp:Label ID="Label4" runat="server" Text="Course"></asp:Label></td>
                        <td>
                            <asp:DropDownList ID="courseCb" runat="server" AutoPostBack="True" Height="29px" Width="300px"></asp:DropDownList></td>
                    </tr>

                    <tr>
                        <td class="auto-style8"> 
                            <asp:Label ID="Label5" runat="server" Text="First Name"></asp:Label></td>
                        <td class="auto-style6">
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                    </tr>
                    
                    <tr>
                        <td class="auto-style5"> 
                            <asp:Label ID="Label6" runat="server" Text="Middle Name"></asp:Label></td>
                         <td class="auto-style1">
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                    </tr>

                    <tr>
                        <td class="auto-style8">
                            <asp:Label ID="Label7" runat="server" Text="Civil Status"></asp:Label></td>
                        <td class="auto-style6">
                            <asp:DropDownList ID="DropDownList7" runat="server" Height="29px" Width="130px"></asp:DropDownList></td>
                        <td class="auto-style10">
                            <asp:Label ID="Label8" runat="server" Text="Gender"></asp:Label></td>
                        <td class="auto-style3">
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                <asp:ListItem Value="0">Male</asp:ListItem>
                                <asp:ListItem Value="1">Female</asp:ListItem>
                            </asp:RadioButtonList></td>
                    </tr>

                    <tr>
                        <td class="auto-style9">
                            <asp:Label ID="Label9" runat="server" Text="Phone No."></asp:Label></td>
                        <td class="auto-style7">
                            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
                        <td class="auto-style4">
                            <asp:Label ID="Label10" runat="server" Text="Email Address"></asp:Label></td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
                    </tr>

                    <tr>
                        <td class="auto-style8">
                            <asp:Label ID="Label11" runat="server" Text="Region"></asp:Label></td>
                        <td class="auto-style6">
                            <asp:DropDownList ID="DropDownList3" runat="server" Height="29px" Width="188px"></asp:DropDownList></td>
                    </tr>

                    <tr>
                         <td class="auto-style8">
                            <asp:Label ID="Label12" runat="server" Text="Province"></asp:Label></td>
                        <td class="auto-style6">
                           <asp:DropDownList ID="DropDownList4" runat="server" Height="29px" Width="188px"></asp:DropDownList></td>
                    </tr>

                    <tr>
                         <td class="auto-style8">
                            <asp:Label ID="Label13" runat="server" Text="City/Municipality"></asp:Label></td>
                        <td class="auto-style6">
                            <asp:DropDownList ID="DropDownList5" runat="server" Height="29px" Width="188px"></asp:DropDownList></td>
                    </tr>

                    <tr>
                         <td class="auto-style8">
                            <asp:Label ID="Label14" runat="server" Text="Barangay"></asp:Label></td>
                        <td class="auto-style6">
                            <asp:DropDownList ID="DropDownList6" runat="server" Height="29px" Width="188px"></asp:DropDownList></td>
                    </tr>

                    <tr>
                         <td class="auto-style8">
                            <asp:Label ID="Label15" runat="server" Text="Street"></asp:Label></td>
                        <td class="auto-style6">
                            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td>
                    </tr>

                    <tr>
                         <td class="auto-style8">
                            <asp:Label ID="Label16" runat="server" Text="Zip Code"></asp:Label></td>
                        <td class="auto-style6">
                            <asp:TextBox ID="TextBox9" runat="server" Height="29px" Width="100px"></asp:TextBox></td>
                    </tr>

                </table>

        </form>
        </center>
</body>
</html>
