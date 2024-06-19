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
     <script src="https://ajax.aspnetcdn.com/ajax/4.5.2/1/MicrosoftAjax.js" type="text/javascript"></script>
    <script type="text/javascript">
        function validateForm() {
            var isValid = true;
            
            // Validate TextBox
            var textBox = document.getElementById('<%= TextBox1.ClientID %>');
            var textBoxError = document.getElementById('TextBoxError');
            if (textBox.value.trim() === "") {
                textBoxError.style.display = 'block';
                isValid = false;
            } else {
                textBoxError.style.display = 'none';
            }

            // Validate DropDownList
            var dropDownList = document.getElementById('<%= regionCb.ClientID %>');
            var dropDownListError = document.getElementById('DropDownListError');
            if (dropDownList.value === "") {
                dropDownListError.style.display = 'block';
                isValid = false;
            } else {
                dropDownListError.style.display = 'none';
            }

            return isValid;
        }

    </script>
    <style type="text/css">
        .auto-style2 {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            width: 630px;
            height: 550px;
            background-color: #EDF1D6;
            overflow: hidden;
            overflow-y: scroll;
            position: relative;
            border-radius: 6px;
            left: 0px;
            top: 0px;
        }
    </style>
</head>
<body>
    <div class="whole">
        <form id="form1" runat="server" onsubmit="return validateForm();">
            <asp:ScriptManager ID="ScriptManager1" runat="server" />
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

                <div class="auto-style2">
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
                                <td> <span id="TextBoxError" style="display:none; color:Red;">Textbox is required!</span></td>
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
                                    <asp:DropDownList CssClass="drp1" ID="civilCb" runat="server">
                                         <asp:ListItem Value="0">Single</asp:ListItem>
                                <asp:ListItem Value="1">Married</asp:ListItem>
                                <asp:ListItem Value="2">Widow</asp:ListItem>
                                <asp:ListItem Value="4">Seperated</asp:ListItem>
                                    </asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label6" runat="server" Text="Phone"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox CssClass="txt5" ID="TextBox5" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label7" runat="server" Text="Region"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DropDownList CssClass="drp2" ID="regionCb" runat="server"  AutoPostBack="True">
                                    
                                    </asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label8" runat="server" Text="Province"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DropDownList CssClass="drp3" ID="provinceCb" runat="server" AutoPostBack="True" ></asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label9" runat="server" Text="City/Municipality"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DropDownList CssClass="drp4" ID="city_muniCb" runat="server" AutoPostBack="True"></asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label10" runat="server" Text="Barangay"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></td>
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
                                    <asp:DropDownList CssClass="drp6" ID="DeptCb" runat="server"   AutoPostBack="True" OnSelectedIndexChanged="DeptCb_SelectedIndexChanged"></asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label14" runat="server" Text="Course"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DropDownList CssClass="drp7"  ID="courseCb" runat="server" AutoPostBack="True" ></asp:DropDownList></td>
                                   
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
                            <asp:Button CssClass="btn1" ID="Button1" runat="server" Text="Print" BackColor="#40513B" BorderStyle="None" BorderColor="#40513B" Width="100px" Height="32px" BorderWidth="6px" ForeColor="White" Font-Size="15px" Font-Names="Times New Roman" ToolTip="Scroll down to see the output" OnClick="Page_Load" />
                             <asp:Button CssClass="btn1" ID="Button2" runat="server" Text="Clear All" BackColor="#40513B" BorderStyle="None" BorderColor="#40513B" Width="100px" Height="32px" BorderWidth="6px" ForeColor="White" Font-Size="15px" Font-Names="Times New Roman" ToolTip="Clear all the value" />
                        </div>
                    </div>
                </div>
            </div>

            <div class="haha">
                <div class="content"  style="background-color: #FFFFFF;">
                    <div class="header-content"  style="background-color: #FFFFFF;">
                        <div class="header-left">
                            <img class="cct-img" src="assets/cctL.png" alt="fgf" />
                        </div>
                        <div class="header-texts">
                            <div>Republic of the Philippines</div>
                            <div>City of Tagaytay</div>
                            <div class="title">CITY COLLEGE OF TAGAYTAY</div>
                            <div class="add">Akle St., Kaybagal South, Tagaytay City</div>
                        </div>
                        <div class="header-right">
                           <%-- <img class="scs-img" src="assets/scs-final.png" alt="fgf" />--%>
                            <asp:Image class="scs-img" ID="Image1" runat="server"  ImageUrl="~/assets/nonepng.png" />
                        </div>
                    </div>
                    <hr />
                    <div class="left-2" style="background-color: #FFFFFF;">
                        <div class="content-output">
                            <div class="output">
                                <div class="left-label">
                                    <asp:Label ID="Label17" runat="server" Text="Student No."></asp:Label>
                                    <asp:Label ID="Label18" runat="server" Text="Student Name"></asp:Label>
                                    <asp:Label ID="Label19" runat="server" Text="Gender"></asp:Label>
                                    <asp:Label ID="Label20" runat="server" Text="Civil Status"></asp:Label>
                                    <asp:Label ID="Label21" runat="server" Text="Course"></asp:Label>
                                    <asp:Label ID="Label22" runat="server" Text="Department"></asp:Label>
                                    <asp:Label ID="Label23" runat="server" Text="Phone No."></asp:Label>
                                    <asp:Label ID="Label24" runat="server" Text="Email Address"></asp:Label>
                                    <asp:Label ID="Label25" runat="server" Text="Address"></asp:Label>
                                </div>
                                <div class="left-txtbox">
                                    <asp:Label ID="Label26" runat="server" Text="Label"></asp:Label>
                                    <asp:Label ID="Label27" runat="server" Text="Label"></asp:Label>
                                    <asp:Label ID="Label28" runat="server" Text="Label"></asp:Label>
                                    <asp:Label ID="Label29" runat="server" Text="Label"></asp:Label>
                                    <asp:Label ID="Label30" runat="server" Text="Label"></asp:Label>
                                    <asp:Label ID="Label31" runat="server" Text="Label"></asp:Label>
                                    <asp:Label ID="Label32" runat="server" Text="Label"></asp:Label>
                                    <asp:Label ID="Label33" runat="server" Text="Label"></asp:Label>
                                    <asp:Label ID="Label34" runat="server" Text="Label"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
    </form>
    </div>
</body>
</html>
