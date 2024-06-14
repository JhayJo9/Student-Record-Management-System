<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication3.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
       
        function changeBackground(dropdown) {
            var selectedValue = dropdown.value;
            document.body.className = ''; 

            if (selectedValue === "2") {
                document.body.classList.add('green-bg');
            } else if (selectedValue === '3') {
                document.body.classList.add('yellow-bg');
            } else if (selectedValue === '4') {
                document.body.classList.add('blue-bg');
            } else {
                document.body.classList.add('default-bg');
            }
        }

    </script>
    <style>
        *{
    padding: 0px;
    margin: 0px;
    box-sizing: border-box;
    font-family: Tahoma;
}

body{
    background-color: #EDF1D6;
    display: flex;
    flex-direction: column;
    align-items: center;
    margin-top: 5rem;
    height: 2000px;
}
.contianer1{
    background-color: #40513B;
    width: 1100px;
    height: 600px;
    display: flex;
    align-items: center;
    justify-content: space-evenly;
    margin-bottom: 7rem;
    border: none;
    border-radius: 6px;
    
}
.contianer2{
    background-color: #40513B;
    width: 1100px;
    height: 600px;
    display: flex;
    align-items: center;
    justify-content: space-evenly;
    margin-bottom: 7rem;
    border: none;
    border-radius: 6px;
   position: relative;
}


.right-img{
    position: absolute;
    top: 30px;
    right: 0px;
}
.right-img img{
    width: 620px;
    height: 550px;
    background-position: center;
    background-repeat: no-repeat;
    background-size: cover;
    background-attachment: fixed;
    opacity: 0.2;
}
.middle{
    width: 1px;
    height: 100%;
    background-color: black;
}
.right{
    width: 630px;
    height: 550px;
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
.txt1, .txt2 , .txt3, .txt4, .txt5, .txt6, .txt7, .txt8, .txt9, .txt10, .txt11, .txt12, .txt13 , .txt14, .txt15{
     width: 200px;
    height: 25px;
    padding-left: 1rem;
    margin-bottom: .5rem;
}
.drp1, .drp5{
        width: 200px;
    height: 25px;
    margin-bottom: .5rem;
}
.drp2, .drp3, .drp4{
    height: 25px;
    width: 500px;
    margin-bottom: .5rem;
}
.drp6, .drp7{
    height: 25px;
    width: 350px;
    margin-bottom: .5rem;
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
   margin-top: 2rem;
}
.header {
    position: sticky;
    top: 0px;
    background-color: #6B8A7A;
    width: 613px;
    height: 73px;
    z-index: 1000;
}
.header p {
    display: flex;
    padding-top: 1.2rem;
    align-items: center;
    justify-content: center;
    font-size: 23px;
    font-weight: 600;
    color: white;
}
.dummy{
    color: #40513B;
    margin-top: 1rem;
    padding-left: 1rem;
    padding-right: 1rem;
}
.btns{
    position: sticky;
    bottom: 0px;
    background-color: #EDF1D6;
    width: 613px;
    height: 48px;
}
.btn{
    display: flex;
    align-items: center;
    justify-content: center;
    gap: 2rem;
    padding-top: .5rem;
}
.btn button{
    width: 60px;
    height: 32px;
    border: none;
    color: white;
    background-color: #40513B;
    border-radius: 6px;
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
    background-color: #40513B;
    white-space: nowrap;
    display: flex;
    align-items: center;
    position: relative;
}
.logos::before{
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
}
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
body.default-bg {
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
}

.auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
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
                            <button>Print</button>
                            <button>Clear All</button>
                        </div>
                    </div>
                </div>
            </div>


            <div class="contianer2">
                <div class="left-2">

                </div>
                <div class="right-2">
                    <div class="right-img">
                        <img src="assets/scs-final (1).png" />
                    </div>
                </div>
            </div>

        </div>
        </form>
</body>
</html>
