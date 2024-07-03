<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication3.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<link href="css/css2/Style.css" rel="stylesheet" />
<body>
    <body = bgcolor ="#B76E79" text="white">
    <form id="form2" runat="server">
        <div>
            <h2><center><u><b>Web-Based Student Record Management System</b></u></center></h2>
            <table align ="center" style ="width: 524px" >
                <tr>
                    <td>
                        <asp:Label ID="studid" runat="server" Text="Student ID"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="studid1" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="department" runat="server" Text="Department"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="dept1" runat="server" AutoPostBack="True" Width ="170">
                            <asp:ListItem>Please Select Department</asp:ListItem>
                            <asp:ListItem>School Of Computer Studies</asp:ListItem>
                            <asp:ListItem>School of Business Management</asp:ListItem>
                            <asp:ListItem>School of Hospitality and Tourism Management</asp:ListItem>
                            <asp:ListItem>School of Education</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lname" runat="server" Text="Last Name: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="lname1" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="course" runat="server" Text="Course: "></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="course1" runat="server" AutoPostBack="True" Width ="170"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="fname" runat="server" Text="First Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="fname1" runat="server"></asp:TextBox>
                    </td>          
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="mname" runat="server" Text="Middle Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="mname1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="civ" runat="server" Text="Civil Status"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="civstat" runat="server" Width="170">
                            <asp:ListItem>*</asp:ListItem>
                            <asp:ListItem>Married</asp:ListItem>
                            <asp:ListItem>Single</asp:ListItem>
                            <asp:ListItem>Widower</asp:ListItem>
                            <asp:ListItem>Widowed</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Label ID="gender" runat="server" Text="Gender"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>                    
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="cp" runat="server" Text="Cellphone Number"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="cp1" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="email" runat="server" Text="Email Address"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="email1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                       <asp:Label ID="region" runat="server" Text="Region"></asp:Label>
                    </td>
                    <td>
                       <asp:DropDownList ID="regionI" runat="server" AutoPostBack="True" Width ="170">
                       <asp:ListItem>Please Select Region</asp:ListItem>
                       <asp:ListItem>Region I - Ilocos Region</asp:ListItem>
                       <asp:ListItem>Region II - Cagayan Valley</asp:ListItem>
                       <asp:ListItem>Region III - Central Luzon</asp:ListItem>
                       <asp:ListItem>Region 1V-A - CALABARZON</asp:ListItem>
                       <asp:ListItem>MIMAROPA Region</asp:ListItem>
                       <asp:ListItem>Region V - Bicol Region</asp:ListItem>
                       <asp:ListItem>Region VI - Western Visayas</asp:ListItem>
                       <asp:ListItem>Region VII - Central Visayas</asp:ListItem>
                       <asp:ListItem>Region VIII - Eastern Visayas</asp:ListItem>
                       <asp:ListItem>Region IX- Zamboanga Peninsula</asp:ListItem>
                       <asp:ListItem>Region X - Northern Mindanao</asp:ListItem>
                       <asp:ListItem>Region XI - Davao Region</asp:ListItem>
                       <asp:ListItem>Region XII - SOCCSKARGEN</asp:ListItem>
                       <asp:ListItem>Region X -Caraga</asp:ListItem>
                       <asp:ListItem>NCR - National Capital Region</asp:ListItem>
                       <asp:ListItem>CAR - Cordillera Administrative Region</asp:ListItem>
                       <asp:ListItem>BARMM - BANGSAMORO Autonomous Region</asp:ListItem>
                       </asp:DropDownList>
                  </td>
              </tr>
              <tr>
                  <td>
                      <asp:Label ID="province" runat="server" Text="Province"></asp:Label>
                  </td>
                  <td>
                      <asp:DropDownList ID="province1" runat="server" AutoPostBack="True"  Width ="170"></asp:DropDownList>
                  </td>
             </tr>
             <tr>
                  <td>
                     <asp:Label ID="city" runat="server" Text="Civil/Municipality"></asp:Label>
                 </td>
                 <td>
                    <asp:DropDownList ID="city1" runat="server" AutoPostBack="True" Width ="170"></asp:DropDownList>
                 </td>
            </tr>
            <tr>
                 <td>
                    <asp:Label ID="barangay" runat="server" Text="Barangay"></asp:Label>
                 </td>
                 <td>           
                     <asp:TextBox ID="brgy1" runat="server" Width ="170"></asp:TextBox>
                 </td>
           </tr>
                <tr>
                    <td class="auto-style">
                        <asp:Label ID="street" runat="server" Text="Street"></asp:Label>
                    </td>
                    <td class ="auto-style">
                        <asp:TextBox ID="street1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                
                <blocked-overlay><div class="blockedOverlayWrapper" style="position: absolute; top: 0px; left: 0px; width: 1143px; height: 668px; pointer-events: none;"><blocked-overlay-rect height="287.375" width="1143" top="380.625" left="0"><br class="Apple-interchange-newline"><div class="blockedOverlayRect" style="position: absolute; cursor: not-allowed; background-color: rgba(0, 0, 0, 0.3); pointer-events: auto; top: 380.625px; left: 0px; width: 1143px; height: 287.375px;"></div></blocked-overlay-rect></div></blocked-overlay><selector-parent-decorator isvisible=""><div id="elementOutline" style="position: fixed; height: 31.2px; width: 131.113px; top: 344.825px; left: 160.075px; pointer-events: none; display: grid; grid-template-columns: 5px 1fr 5px; grid-template-rows: 5px 1fr 5px;"><div id="outer-top" style="background-image: linear-gradient(to right top, black 10%, white 10%, white 40%, black 40%, black 60%, white 60%, white 90%, black 90%); background-size: 5px 5px; cursor: move; pointer-events: all; grid-area: 1 / 1 / 2 / 3; color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(221, 255, 204); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial;"></div><div id="outer-left" style="background-image: linear-gradient(to right top, black 10%, white 10%, white 40%, black 40%, black 60%, white 60%, white 90%, black 90%); background-size: 5px 5px; cursor: move; pointer-events: all; grid-area: 2 / 1 / 4 / 2; color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(221, 255, 204); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial;"></div><br class="Apple-interchange-newline">
                <tr>
                    <td>
                        <asp:Label ID="zip" runat="server" Text="Zip Code"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="zip1" runat="server"></asp:TextBox>
                    </td>
                </tr> 
                <tr>
                    <td>
                        <asp:Button ID="printbtn" runat="server" Text="Print" Width="162"  />
                    </td>
                    <td>
                        <asp:Button ID="clearbtn" runat="server" Text="Clear" Width="162"  />
                    </td>
                </tr>     
                    
            </table>    
            
                
                <tr>
                   <td>
                     <hr />
                   </td>
                </tr>
            <table>
               <tr>
                   <td>                       
                     <h2>Student Information</h2>
                   </td>
               </tr>
               <tr>
                   <td>                       
                     <asp:Label ID="lblstudid" runat="server" Text="Student ID: "></asp:Label>
                   </td>
                   <td>
                     <asp:Label ID="lblstudid1" runat="server" Text="   "></asp:Label>
                   </td>
               </tr>
               <tr>
                   <td>
                     <asp:Label ID="lblstudname" runat="server" Text="Student Name: "></asp:Label>
                   </td>
                   <td>
                     <asp:Label ID="lblstudname1" runat="server" Text="   "></asp:Label>
                   </td>
               </tr>
               <tr>
                   <td>
                     <asp:Label ID="lblgender" runat="server" Text="Gender: "></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="lblgender1" runat="server" Text="   "></asp:Label>
                   </td>
               </tr>
               <tr>
                   <td>
                     <asp:Label ID="lblcivstat" runat="server" Text="Civil Status: "></asp:Label>
                   </td>
                   <td>
                     <asp:Label ID="lblcivstat1" runat="server" Text="   "></asp:Label>
                   </td>
               </tr>
               <tr>
                   <td>
                     <asp:Label ID="lblcourse" runat="server" Text="Course: "></asp:Label>
                   </td>
                   <td>
                     <asp:Label ID="lblcourse1" runat="server" Text="   "></asp:Label>
                   </td>
               </tr>
               <tr>
                   <td>
                     <asp:Label ID="lbldept" runat="server" Text="Department: "></asp:Label>
                   </td>
                   <td>
                     <asp:Label ID="lbldept1" runat="server" Text="   "></asp:Label>
                   </td>
               </tr>
               <tr>
                   <td>
                     <asp:Label ID="lblphone" runat="server" Text="Phone Number: "></asp:Label>
                   </td>
                   <td>
                     <asp:Label ID="lblphone1" runat="server" Text="  "></asp:Label>
                   </td>
               </tr>
               <tr>
                   <td>
                     <asp:Label ID="lblemailadd" runat="server" Text="Email Address: "></asp:Label>
                   </td>
                   <td>
                     <asp:Label ID="lblemailadd1" runat="server" Text="  "></asp:Label>
                   </td>
               </tr>
               <tr>
                   <td>
                     <asp:Label ID="lbladd" runat="server" Text="Address: "></asp:Label>
                   </td>
                   <td>
                     <asp:Label ID="lbladd1" runat="server" Text="  "></asp:Label>
                   </td>
               </tr>
            </table>
            </div>      
    </form>
</body>
</html>