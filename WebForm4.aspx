<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication3.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link rel="stylesheet" href="style.css"/>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

    <script src="script.js"></script>
</head>
<body>
    <div class="whole">
    <form  id="form1" runat="server" >
         <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <div class="page">
            <div class="contianer1">
                <div class="left">
                    <div class="logos">
                        <div class="logo-slide">
                            <img src="assets/arts.png" />
                            <img src="assets/sbm-logo.png" />
                            <img src="assets/scs-final.png" />
                            <img src="assets/tor.png" />
                        </div>
                        <div class="logo-slide">
                            <img src="assets/arts.png" />
                            <img src="assets/sbm-logo.png" />
                            <img src="assets/scs-final.png" />
                            <img src="assets/tor.png" />
                        </div>

                        <div class="logo-slide">
                            <img src="assets/arts.png" />
                            <img src="assets/sbm-logo.png" />
                            <img src="assets/scs-final.png" />
                            <img src="assets/tor.png" />
                        </div>
                    </div>
                </div>

                <div class="middle">
                </div>

                <div class="right">
                    <div class="header">
                        <p>Web-Based Student Record Management System</p>
                    </div>
                    <div>
                        <table class="TABLE">
                            <tr>
                                <td class="auto-style1">
                                    <asp:Label ID="Label1" runat="server" Text="Student No."></asp:Label></td>
                            
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox CssClass="txt1" ID="TextBox1" runat="server"></asp:TextBox></td>
     
                            </tr>
                             <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox CssClass="txt2" ID="TextBox2" runat="server"></asp:TextBox></td>
                             
                            </tr>
                             <tr>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text="Middle"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox CssClass="txt3" ID="TextBox3" runat="server"></asp:TextBox></td>
                            </tr>
                             <tr>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text="First Name"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox CssClass="txt4" ID="TextBox4" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text="Civil Status"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DropDownList CssClass="drp1" ID="DropDownList1" runat="server"></asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label6" runat="server" Text="Phone"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox CssClass="txt5" ID="TextBox5" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label7" runat="server" Text="Region"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DropDownList CssClass="drp2" ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                                        <asp:ListItem Value="default">Select Color</asp:ListItem>
                                        <asp:ListItem Value="red">Red</asp:ListItem>
                                        <asp:ListItem Value="green">Green</asp:ListItem>
                                        <asp:ListItem Value="blue">Blue</asp:ListItem>
                                    </asp:DropDownList></td>
                            </tr>
                             <tr>
                                <td>
                                    <asp:Label ID="Label8" runat="server" Text="Province"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DropDownList CssClass="drp3" ID="DropDownList3" runat="server"></asp:DropDownList></td>
                            </tr>
                             <tr>
                                <td>
                                    <asp:Label ID="Label9" runat="server" Text="City/Municipality"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DropDownList CssClass="drp4" ID="DropDownList4" runat="server"></asp:DropDownList></td>
                            </tr>
                             <tr>
                                <td>
                                    <asp:Label ID="Label10" runat="server" Text="Barangay"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DropDownList CssClass="drp5" ID="DropDownList5" runat="server"></asp:DropDownList></td>
                            </tr>
                             <tr>
                                <td>
                                    <asp:Label ID="Label11" runat="server" Text="Street"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox CssClass="txt6" ID="TextBox6" runat="server"></asp:TextBox></td>
                            </tr>
                              <tr>
                                <td>
                                    <asp:Label ID="Label12" runat="server" Text="Zip Code"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox CssClass="txt7" ID="TextBox7" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label13" runat="server" Text="Department"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DropDownList CssClass="drp6" ID="DeptCb" runat="server" OnSelectedIndexChanged="DeptCb_SelectedIndexChanged"  onchange="changeBackground(this)"></asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label14" runat="server" Text="Course"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DropDownList CssClass="drp7" ID="courseCb" runat="server"></asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label16" runat="server" Text="Gender"></asp:Label></td>
                            </tr>
                            <tr>
                                  <td>
                                    <asp:RadioButtonList CssClass="radio" ID="RadioButtonList1" runat="server">
                                        <asp:ListItem Value="0">Male</asp:ListItem>
                                        <asp:ListItem Value="1">Female</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                             <tr>
                                 <td>
                                    <asp:Label ID="Label15" runat="server" Text="Email Address"></asp:Label></td>
                            </tr>
                            <tr>
                                 <td>
                                    <asp:TextBox CssClass="txt8" ID="TextBox8" runat="server"></asp:TextBox></td>
                            </tr>
                        </table>
                    </div>
                    <div class="dummy">
                    </div>

                    <div class="btns">
                        <div class="btn">
                            <button class="tooltip-btn" data-tooltip="Scroll down to see the output">Print</button>
                             <button class="tooltip-btn" data-tooltip="Clear all the value">Clear All</button>
                        </div>
                    </div>
                </div>
            </div>


            <div class="content">
                <div class="left-2">

                </div>
                <div class="right-2">
                    
                </div>
            </div>

        </div>
        </form>
    </div>
</body>
</html>
