<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication3.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web-Based Student Record Management System</title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
     <script src="https://ajax.aspnetcdn.com/ajax/4.5.2/1/MicrosoftAjax.js" type="text/javascript"></script>
    <script type="text/javascript">

        function getScrollPosition() {
            var scrollPosition = document.documentElement.scrollTop || document.body.scrollTop;
            document.getElementById('<%= hiddenFieldScrollPosition.ClientID %>').value = scrollPosition;
        }

        function setScrollPosition() {
            var scrollPosition = document.getElementById('<%= hiddenFieldScrollPosition.ClientID %>').value;
            if (scrollPosition) {
                window.scrollTo(0, scrollPosition);
            }
        }

        window.onload = setScrollPosition;
        window.onbeforeunload = getScrollPosition;
      

    </script>
    <style type="text/css">

        *{
    padding: 0px;
    margin: 0px;
    box-sizing: border-box;
    font-family: 'Times New Roman';
}

.whole {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: space-between;
    height: 1500px;
    width: 100%;
    padding-top: .5rem;
    font-family: Roboto;
    background-color: #EDF1D6;
}
.contianer1{
    background-color: #40513B;
    width: 1500px;
    height: 700px;
    display: flex;
    align-items: center;
    justify-content: space-evenly;
    margin-bottom: 8rem;
    border: none;
    border-radius: 6px;
     background-image: url('assets/bg1.jpg');
    background-position: center;
    background-size: cover;
}
.haha {
/*    background-color: blue;*/
    width: 1500px;
    height: 600px;
    display: flex;
    align-items: center;
    justify-content: center;
    border: none;
    border-radius: 6px;
}
.content {
    background-color: #FFFFFF;
    width: 750px;
    height: 700px;
    display: flex;
    flex-direction: column;
    border: none;
    border-radius: 6px;
}
.header-content {
   /* background-color: #FFFFFF;*/
    display: flex;
    flex-direction: row;
    align-items: center;
    justify-content: space-evenly;
    width: 750px;
    height: 120px;
    border: none;
    border-radius: 6px;
    font-family: 'Times New Roman';
}
.header-texts{
    text-align: center;
    display: flex;
    flex-direction: column;

}
.title{
    font-weight: 600;
    
}
.add{
    font-size: 9px;
}
.header-content .scs-img {
    width: 85px;
    height: 80px;
}
.header-content .cct-img{
    width: 80px;
    height: 85px;
}
.left-2 {
    display: flex;
    width: 680px;
    height: 550px;
    position: relative;
    border: none;
    border-radius: 6px;
}
.content-output{
    display: flex;
    align-items: center;
    justify-content: center;
    flex-direction: column;
    width: 730px;
    height: 550px;
    padding-left: 2rem;
}
.output{
    display: flex;  
    flex-direction: row;
    column-gap: 2rem;
    width: 730px;
    height: 550px;
}
.left-label{
    display: flex;
    flex-direction: column;
    margin-bottom: .5rem;
    font-family: 'Times New Roman';

}
.left-txtbox{
    display: flex;
    flex-direction: column;
    margin-bottom: .5rem;
    font-family: 'Times New Roman';
}
html {
    scroll-behavior: smooth;
}

.right-img{
    position: absolute;
    top: 30px;
    right: 0px;
}
.middle{
    width: .5px;    
    height: 100%;
   background-color: black;
}
.right{
    width: 700px;
    height: 600px;
    background-color: #EDF1D6;
    overflow: hidden;
    overflow-y: scroll;
    position: relative;
    border: none;
    border-radius: 6px;
}
.try{
    display: flex;
    flex-direction: column;
    width: 130px;
    margin-top: 2rem;
    margin-left: 2rem;
    background-color: green;  
}
.txt1, .txt2 , .txt3, .txt4, .txt5, .txt6, .txt7, .txt8, .txt9, .txt10, .txt11, .txt12, .txt13 , .txt14, .txt15, .drpc{
     width: 400px;
    height: 25px;
    padding-left: 1rem;
    margin-bottom: .5rem;
    border: none;
    border-radius: 6px;

}
.drp1, .drp5 {
    width: 500px;
    height: 25px;
    margin-bottom: .5rem;
    border: none;
    border-radius: 6px;
     padding-left: 1rem;
}
.drp2, .drp3, .drp4 {
    height: 25px;
    width: 500px;
    margin-bottom: .5rem;
    border: none;
    border-radius: 6px;
     padding-left: 1rem;
}
.drp6, .drp7 {
    height: 25px;
    width: 350px;
    margin-bottom: .5rem;
    border: none;
    border-radius: 6px;
     padding-left: 1rem;
}

.dropdown{
    display: flex;
    flex-direction: column;
    width: 130px; 
}
.radio{
    margin-bottom: .5rem;
}
.TABLE{
   margin-left: 2rem;
   margin-top: 1rem;
}
.header {
  /*  position: sticky;
    top: 0px;*/
   /* background-color: #6B8A7A;*/
     width: 1035px;
    height: 85px;
    z-index: 1000;
}
.header p {
    display: flex;
    padding-top: 1.2rem;
    align-items: center;
    justify-content: center;
    font-size: 35px;
    font-weight: 600;
    color: black;
}
.dummy{
    color: #40513B;
    margin-top: 1rem;
    padding-left: 1rem;
    padding-right: 1rem;
}
.btns {
    position: sticky;
    bottom: 0px;
   /* background-color: #EDF1D6;*/
   width: 1035px;
    height: 48px;
    display: flex;
    flex-direction: row;
    align-items: center;
    justify-content: center;
}
.btn{
    display: flex;
    flex-direction: row;
    align-items: center;
    justify-content: center;
    gap: 2rem;
}


@keyframes slide {
    from{
        transform: translate(0);
    }
    to{
        transform: translate(-100%);
    }
}

.logos{
    overflow: hidden;
    width: 300px;
    height: 300px;
   /* background-color: #40513B;*/
    white-space: nowrap;
    display: flex;
    align-items: center;
    position: relative;
}
/*.logos::before{
    position: absolute;
    top: 0;
    left: 0;
    width: 50px;
    height: 100%;
    background: linear-gradient(to left, rgba(255, 255, 255, 0),#40513B);
    content: "";
    z-index: 2;
}
.logos::after{
    position: absolute;
    top: 0;
    right: 0;
    width: 50px;
    height: 100%;
    background: linear-gradient(to right, rgba(255, 255, 255, 0),#40513B);
    content: "";
    z-index: 2;
}*/
.logos:hover  .logo-slide{
    animation-play-state: paused;
}
.logo-slide{
    display: inline-block;  
   animation:  35s slide infinite linear;
}  
.logo-slide img {
    height: 250px;
    margin: 0 10px;
}
/* styles.css */
/*body.default-bg {
    background-color: white;
}

body.green-bg {
    background-color: green;
}

body.yellow-bg {
    background-color: yellow;
}

body.blue-bg {
    background-color: blue;
}*/

.auto-style1 {
            height: 26px;
}
.auto-style2 {
    border-style: none;
    border-color: inherit;
    border-width: medium;
    width: 1000px;
    height: 680px;
    background-color: rgba(255, 255, 255, 0.6);
    overflow: hidden;
    overflow-y: scroll;
    position: relative;
    border-radius: 6px;
    left: 0px;
    top: 0px;
}
.auto-style2:hover {
   background-color:  rgba(255, 255, 255, 0.6);
    
}
table {
            border-collapse: collapse;
        }
        td {
            margin-right: 5px; /* Adjust as needed */
            padding: 3px;
           /* border: 1px solid black;*/
        }
        .auto-style3 {
            height: 36px;
        }
        table-output{
            padding: 1rem;
            border: 1px solid black;
        }
    </style>
</head>
<body>
    <div class="whole">
        <form id="form1" runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server" />
            <asp:HiddenField ID="hiddenFieldScrollPosition" runat="server" />

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

                <div class="auto-style2" >
                    <div class="header">
                        <p>Web-Based Student Record Management System</p>
                    </div>
                    <div>
                        <table class="TABLE">
                            <tr>
                                <td class="auto-style1">
                                    <asp:Label ID="Label1" runat="server" Text="Student No."></asp:Label></td>
                                <td>
                                    <asp:Label ID="Label35" runat="server" Text="Region"></asp:Label></td>

                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox CssClass="txt1" ID="TextBox1" runat="server"></asp:TextBox></td>
                                <td>
                                    <asp:DropDownList CssClass="drp1" ID="regionCb" runat="server" AutoPostBack="true" OnSelectedIndexChanged="regionCb_SelectedIndexChanged"></asp:DropDownList></td>
                            </tr>
                           
                            <tr>
                                <td class="auto-style3">
                                    <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label></td>
                                <td class="auto-style3">
                                    <asp:Label ID="Label7" runat="server" Text="Province"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox CssClass="txt2" ID="TextBox2" runat="server"></asp:TextBox></td>
                                <td>
                                    <asp:DropDownList CssClass="drp3" ID="provinceCb" runat="server" AutoPostBack="true" OnSelectedIndexChanged="provinceCb_SelectedIndexChanged"></asp:DropDownList></td>

                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text="First Name"></asp:Label></td>
                                <td>
                                    <asp:Label ID="Label8" runat="server" Text="City/Municipality"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox CssClass="txt3" ID="TextBox3" runat="server"></asp:TextBox></td>
                                 <td>
                                    <asp:DropDownList CssClass="drp4" ID="city_muniCb" runat="server" AutoPostBack="True"></asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text="Middle Name"></asp:Label></td>
                                 <td>
                                    <asp:Label ID="Label9" runat="server" Text="Department"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox CssClass="txt4" ID="TextBox4" runat="server"></asp:TextBox></td>
                                  <td>
                                <asp:DropDownList CssClass="drp6" ID="DeptCb" runat="server" AutoPostBack="True"  OnSelectedIndexChanged="DeptCb_SelectedIndexChanged">
                                <asp:ListItem Value="1">Please Select Department</asp:ListItem>
                                <asp:ListItem Value="2">School of Computer Science</asp:ListItem>
                                <asp:ListItem Value="3">School of Business Management</asp:ListItem>
                                <asp:ListItem Value="4">School of Education</asp:ListItem>
                                <asp:ListItem Value="5">School of Hospitality and Tourism Management</asp:ListItem>
                            </asp:DropDownList></td>
                               
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text="Civil Status"></asp:Label></td>
                                 <td>
                                    <asp:Label ID="Label13" runat="server" Text="Course"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DropDownList CssClass="drpc" ID="civilCb" runat="server">
                                         <asp:ListItem Value="0">Single</asp:ListItem>
                                <asp:ListItem Value="1">Married</asp:ListItem>
                                <asp:ListItem Value="2">Widow</asp:ListItem>
                                <asp:ListItem Value="4">Seperated</asp:ListItem>
                                    </asp:DropDownList></td>
                                 <td>
                                   <asp:DropDownList CssClass="drp7" ID="courseCb" runat="server" AutoPostBack="True" ></asp:DropDownList></td>
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
                                    <asp:Label ID="Label14" runat="server" Text="Gender"></asp:Label></td>
                            </tr>
                             <tr>
                                <td>
                                    <asp:RadioButtonList CssClass="radio" ID="RadioButtonList2" runat="server">
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
                            
                            <tr>
                                <td>
                                    <asp:Label ID="Label10" runat="server" Text="Barangay"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox CssClass="txt9" ID="TextBox9" runat="server"></asp:TextBox></td>
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
                        </table>
                    </div>
                    <div class="dummy">
                    </div>

                    <div class="btns">
                        <div class="btn">
                            <asp:Button CssClass="btn1" ID="Button1" runat="server" Text="Print" BackColor="#40513B" BorderStyle="None" BorderColor="#40513B" Width="100px" Height="32px" BorderWidth="6px" ForeColor="White" Font-Size="15px" Font-Names="Times New Roman" ToolTip="Scroll down to see the output" OnClick="Button1_Click" />
                             <asp:Button CssClass="btn1" ID="Button2" runat="server" Text="Clear All" BackColor="#40513B" BorderStyle="None" BorderColor="#40513B" Width="100px" Height="32px" BorderWidth="6px" ForeColor="White" Font-Size="15px" Font-Names="Times New Roman" ToolTip="Clear all the value" OnClick="Button2_Click" />
                        </div>
                    </div>
                </div>
            </div>
            
            <div class="haha">
                <div class="content" style="background-color: #FFFFFF;">
                    <div class="header-content" style="background-color: #FFFFFF;">
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
                            <asp:Image class="scs-img" ID="Image1" runat="server" ImageUrl="~/assets/nonepng.png" />
                        </div>
                    </div>
                    <hr />
                    <div class="left-2" style="background-color: #FFFFFF;">
                        <div class="content-output">
                            <div class="output">
                               <%-- <div class="left-label">
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
                                    <asp:Label ID="Label34" style="word-wrap: break-word;" runat="server" Text="Label"></asp:Label>
                                </div>--%>

                                <table class="table-output">
                                    <tr>
                                        <td>Student No.</td>
                                        <td> <asp:Label ID="Label26" runat="server" Text="Label"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Student Name</td>
                                        <td> <asp:Label ID="Label27" runat="server" Text="Label"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Gender</td>
                                        <td> <asp:Label ID="Label28" runat="server" Text="Label"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Civil Status</td>
                                        <td><asp:Label ID="Label29" runat="server" Text="Label"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Course</td>
                                        <td> <asp:Label ID="Label30" runat="server" Text="Label"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Department</td>
                                        <td><asp:Label ID="Label31" runat="server" Text="Label"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Phone No.</td>
                                        <td><asp:Label ID="Label32" runat="server" Text="Label"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Email Address</td>
                                        <td> <asp:Label ID="Label33" runat="server" Text="Label"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Address</td>
                                        <td> <asp:Label ID="Label34" style="word-wrap: break-word;" runat="server" Text="Label"></asp:Label></td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        
            <div style="margin-top: 3rem;">
                <asp:DropDownList Height="80px" Width="200px" ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                <asp:DropDownList  Height="80px" Width="200px"  ID="DropDownList2" runat="server" AutoPostBack="True"></asp:DropDownList>
            </div>



            <div class="modal fade" id="errorModal" tabindex="-1" role="dialog" aria-labelledby="errorModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="errorModalLabel">Error</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body" id="errorModalBody">
        <!-- Error message will go here -->
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
      </div>
    </div>
  </div>
</div>

    </form>
    </div>
</body>
</html>
