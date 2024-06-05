using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getdep();
                Getregion();
               //ScriptManager.RegisterStartupScript(this, this.GetType(), "showModal", "showModal();", true);
            }
        
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "showModal", "showModal();", true);
            
            Label30.Text = "".ToString();
            Label31.Text = "".ToString();
            Label32.Text = "".ToString();
            Label33.Text = "".ToString();
            Label34.Text = "".ToString();
            Label35.Text = "".ToString();
            Label36.Text = "".ToString();
            Label37.Text = "".ToString();
            Label38.Text = "".ToString();


        }

     
        public void getdep()
        {
            DataTable deptTB = new DataTable();
            deptTB.Columns.Add("deptID", typeof(int));
            deptTB.Columns.Add("deptName");
            deptTB.Rows.Add(1, "Please Select Department");
            deptTB.Rows.Add(2, "School of Computer Studies");
            deptTB.Rows.Add(3, "School of Education");
            deptTB.Rows.Add(4, "School of Business Management");
            deptTB.Rows.Add(5, "School of Hospitality and Toursim Management");
            DeptCb.DataSource = deptTB;
            DeptCb.DataTextField = "DeptName";
            DeptCb.DataValueField = "deptID";
            DeptCb.DataBind();
        }
        protected void DeptCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(int.Parse(DeptCb.SelectedValue) > 0)
            {
                DataTable courseTB = new DataTable();
                courseTB.Columns.Add("CourseID", typeof(int));
                courseTB.Columns.Add("DeptID", typeof(int));
                courseTB.Columns.Add("courseName");

                if(DeptCb.SelectedValue == "1")
                {
                    courseTB.Rows.Add(1, 1, "Please Select Course");
                }
                if(DeptCb.SelectedValue == "2")
                {
                    courseTB.Rows.Add(2, 2, "BS. Information Technology");
                    courseTB.Rows.Add(3, 2, "BS. Computer Science");
                }
                if(DeptCb.SelectedValue == "3")
                {
                    courseTB.Rows.Add(4, 3, "BSE. Major in Filipino");
                    courseTB.Rows.Add(5, 3, "BSE. Major in Social Studies");
                    courseTB.Rows.Add(6, 3, "BSE. Major in Mathemathics");
                    courseTB.Rows.Add(7, 3, "BSE. Major in English");
                }
                if(DeptCb.SelectedValue == "4")
                {
                    courseTB.Rows.Add(8, 4, "BS. Office Development");
                    courseTB.Rows.Add(9, 4, "BS. Marketing Management");
                    courseTB.Rows.Add(10, 4, "BS. Human Resource");
                }
                if(DeptCb.SelectedValue=="5")
                {
                    courseTB.Rows.Add(11, 5, "BS. Hotel Management");
                    courseTB.Rows.Add(12, 5, "BS. Toursim Management");
                }
                courseCb.DataSource = courseTB;
                courseCb.DataTextField = "courseName";
                courseCb.DataValueField = "courseID";
                courseCb.DataBind();
            }

        }

        private void Getregion()
        {
            DataTable regionTb = new DataTable();
            regionTb.Columns.Add("regionID", typeof(int));
            regionTb.Columns.Add("regionName");
            regionTb.Rows.Add(1, "Please Select Region");
            regionTb.Rows.Add(2, "Ilocos Region (Region I)");
            regionTb.Rows.Add(3, "Cagayan Valley (Region II)");
            regionTb.Rows.Add(4, "Central Luzon (Region III)");
            regionTb.Rows.Add(5, "Calabarzon (Region IV-A)");
            regionTb.Rows.Add(6, "Mimaropa (Region IV-B)");
            regionTb.Rows.Add(7, "Bicol Region (Region V)");
            regionTb.Rows.Add(8, "Western Visayas (Region VI)");
            regionTb.Rows.Add(9, "Central Visayas (Region VII)");
            regionTb.Rows.Add(10, "Eastern Visayas (Region VIII)");
            regionTb.Rows.Add(11, "Zamboanga Peninsula (Region IX)");
            regionTb.Rows.Add(12, "Northern Mindanao (Region X)");
            regionTb.Rows.Add(13, "Davao Region (Region XI)");
            regionTb.Rows.Add(14, "Soccsksargen (Region XII)");
            regionTb.Rows.Add(15, "Caraga (Region XIII)");
            regionTb.Rows.Add(16, "Bangsamoro Autonomous Region in Muslim Mindanao (BARMM)");
            regionTb.Rows.Add(17, "Cordillera Administrative Region (CAR)");
            regionTb.Rows.Add(18, "National Capital Region (NCR)");
            regionCb.DataSource = regionTb;
            regionCb.DataTextField = "regionName";
            regionCb.DataValueField = "regionID";
            regionCb.DataBind();
        }
        private void Getcity()
        {
            //int cityID = 0;
            if (int.Parse(provinceCb.SelectedValue) > 0)
            {
                DataTable city_muniTb = new DataTable();
                city_muniTb.Columns.Add("city_muniID", typeof(int));
                city_muniTb.Columns.Add("provinceName");
                city_muniTb.Columns.Add("city_muniName");

                if (provinceCb.SelectedValue == "1")
                {
                    city_muniTb.Rows.Add(1, 1, "Please Select City");
                }
                if (provinceCb.SelectedValue == "2")
                {
                    // Region I
                    // Ilocos Norte
                    city_muniTb.Rows.Add(2, 2, "Adams");
                    city_muniTb.Rows.Add(3, 2, "Bacarra");
                    city_muniTb.Rows.Add(4, 2, "Badoc");
                    city_muniTb.Rows.Add(5, 2, "Bangui");
                    city_muniTb.Rows.Add(6, 2, "Banna (Espiritu)");
                    city_muniTb.Rows.Add(7, 2, "Batac City");
                    city_muniTb.Rows.Add(8, 2, "Burgos");
                    city_muniTb.Rows.Add(9, 2, "Carasi");
                    city_muniTb.Rows.Add(10, 2, "Currimao");
                    city_muniTb.Rows.Add(11, 2, "Dingras");
                    city_muniTb.Rows.Add(12, 2, "Dumalneg");
                    city_muniTb.Rows.Add(13, 2, "Laoag City");
                    city_muniTb.Rows.Add(14, 2, "Marcos");
                    city_muniTb.Rows.Add(15, 2, "Nueva Era");
                    city_muniTb.Rows.Add(16, 2, "Pagudpud");
                    city_muniTb.Rows.Add(17, 2, "Paoay");
                    city_muniTb.Rows.Add(18, 2, "Pasuquin");
                    city_muniTb.Rows.Add(19, 2, "Piddig");
                    city_muniTb.Rows.Add(20, 2, "Pinili");
                    city_muniTb.Rows.Add(21, 2, "San Nicolas");
                    city_muniTb.Rows.Add(22, 2, "Sarrat");
                    city_muniTb.Rows.Add(23, 2, "Solsona");
                    city_muniTb.Rows.Add(24, 2, "Vintar");
                }

                if (provinceCb.SelectedValue == "3")
                {
                    // Region I
                    // Ilocos Sur
                    city_muniTb.Rows.Add(25, 3, "Alilem");
                    city_muniTb.Rows.Add(26, 3, "Banayoyo");
                    city_muniTb.Rows.Add(27, 3, "Bantay");
                    city_muniTb.Rows.Add(28, 3, "Burgos");
                    city_muniTb.Rows.Add(29, 3, "Cabugao");
                    city_muniTb.Rows.Add(30, 3, "Candon City");
                    city_muniTb.Rows.Add(31, 3, "Caoayan");
                    city_muniTb.Rows.Add(32, 3, "Cervantes");
                    city_muniTb.Rows.Add(33, 3, "Galimuyod");
                    city_muniTb.Rows.Add(34, 3, "Gregorio Del Pilar (Concepcion)");
                    city_muniTb.Rows.Add(35, 3, "Lidlidda");
                    city_muniTb.Rows.Add(36, 3, "Magsingal");
                    city_muniTb.Rows.Add(37, 3, "Nagbukel");
                    city_muniTb.Rows.Add(38, 3, "Narvacan");
                    city_muniTb.Rows.Add(39, 3, "Quirino (Angkaki)");
                    city_muniTb.Rows.Add(40, 3, "Salcedo (Baugen)");
                    city_muniTb.Rows.Add(41, 3, "San Emilio");
                    city_muniTb.Rows.Add(42, 3, "San Esteban");
                    city_muniTb.Rows.Add(43, 3, "San Ildefonso");
                    city_muniTb.Rows.Add(44, 3, "San Juan (Lapog)");
                    city_muniTb.Rows.Add(45, 3, "San Vicente");
                    city_muniTb.Rows.Add(46, 3, "Santa");
                    city_muniTb.Rows.Add(47, 3, "Santa Catalina");
                    city_muniTb.Rows.Add(48, 3, "Santa Cruz");
                    city_muniTb.Rows.Add(49, 3, "Santa Lucia");
                    city_muniTb.Rows.Add(50, 3, "Santa Maria");
                    city_muniTb.Rows.Add(51, 3, "Santiago");
                    city_muniTb.Rows.Add(52, 3, "Santo Domingo");
                    city_muniTb.Rows.Add(53, 3, "Sigay");
                    city_muniTb.Rows.Add(54, 3, "Sinait");
                    city_muniTb.Rows.Add(55, 3, "Sugpon");
                    city_muniTb.Rows.Add(56, 3, "Suyo");
                    city_muniTb.Rows.Add(57, 3, "Tagudin");
                    city_muniTb.Rows.Add(58, 3, "Vigan City");
                }

                if (provinceCb.SelectedValue == "4")
                {
                    // Region I
                    // La Union
                    city_muniTb.Rows.Add(59, 4, "Agoo");
                    city_muniTb.Rows.Add(60, 4, "Aringay");
                    city_muniTb.Rows.Add(61, 4, "Bacnotan");
                    city_muniTb.Rows.Add(62, 4, "Bagulin");
                    city_muniTb.Rows.Add(63, 4, "Balaoan");
                    city_muniTb.Rows.Add(64, 4, "Bangar");
                    city_muniTb.Rows.Add(65, 4, "Bauang");
                    city_muniTb.Rows.Add(66, 4, "Burgos");
                    city_muniTb.Rows.Add(67, 4, "Caba");
                    city_muniTb.Rows.Add(68, 4, "City Of San Fernando");
                    city_muniTb.Rows.Add(69, 4, "Luna");
                    city_muniTb.Rows.Add(70, 4, "Naguilian");
                    city_muniTb.Rows.Add(71, 4, "Pugo");
                    city_muniTb.Rows.Add(72, 4, "Rosario");
                    city_muniTb.Rows.Add(73, 4, "San Gabriel");
                    city_muniTb.Rows.Add(74, 4, "San Juan");
                    city_muniTb.Rows.Add(75, 4, "Santo Tomas");
                    city_muniTb.Rows.Add(76, 4, "Santol");
                    city_muniTb.Rows.Add(77, 4, "Sudipen");
                    city_muniTb.Rows.Add(78, 4, "Tubao");
                }

                if (provinceCb.SelectedValue == "5")
                {
                    // Region I
                    // Pangasinan
                    city_muniTb.Rows.Add(79, 5, "Agno");
                    city_muniTb.Rows.Add(80, 5, "Aguilar");
                    city_muniTb.Rows.Add(81, 5, "Alaminos City");
                    city_muniTb.Rows.Add(82, 5, "Alcala");
                    city_muniTb.Rows.Add(83, 5, "Anda");
                    city_muniTb.Rows.Add(84, 5, "Asingan");
                    city_muniTb.Rows.Add(85, 5, "Balungao");
                    city_muniTb.Rows.Add(86, 5, "Bani");
                    city_muniTb.Rows.Add(87, 5, "Basista");
                    city_muniTb.Rows.Add(88, 5, "Bautista");
                    city_muniTb.Rows.Add(89, 5, "Bayambang");
                    city_muniTb.Rows.Add(90, 5, "Binalonan");
                    city_muniTb.Rows.Add(91, 5, "Binmaley");
                    city_muniTb.Rows.Add(92, 5, "Bolinao");
                    city_muniTb.Rows.Add(93, 5, "Bugallon");
                    city_muniTb.Rows.Add(94, 5, "Burgos");
                    city_muniTb.Rows.Add(95, 5, "Calasiao");
                    city_muniTb.Rows.Add(96, 5, "Dagupan City");
                    city_muniTb.Rows.Add(97, 5, "Dasol");
                    city_muniTb.Rows.Add(98, 5, "Infanta");
                    city_muniTb.Rows.Add(99, 5, "Labrador");
                    city_muniTb.Rows.Add(100, 5, "Laoac");
                    city_muniTb.Rows.Add(101, 5, "Lingayen");
                    city_muniTb.Rows.Add(102, 5, "Mabini");
                    city_muniTb.Rows.Add(103, 5, "Malasiqui");
                    city_muniTb.Rows.Add(104, 5, "Manaoag");
                    city_muniTb.Rows.Add(105, 5, "Mangaldan");
                    city_muniTb.Rows.Add(106, 5, "Mangatarem");
                    city_muniTb.Rows.Add(107, 5, "Mapandan");
                    city_muniTb.Rows.Add(108, 5, "Natividad");
                    city_muniTb.Rows.Add(109, 5, "Pozorrubio");
                    city_muniTb.Rows.Add(110, 5, "Rosales");
                    city_muniTb.Rows.Add(111, 5, "San Carlos City");
                    city_muniTb.Rows.Add(112, 5, "San Fabian");
                    city_muniTb.Rows.Add(113, 5, "San Jacinto");
                    city_muniTb.Rows.Add(114, 5, "San Manuel");
                    city_muniTb.Rows.Add(115, 5, "San Nicolas");
                    city_muniTb.Rows.Add(116, 5, "San Quintin");
                    city_muniTb.Rows.Add(117, 5, "Santa Barbara");
                    city_muniTb.Rows.Add(118, 5, "Santa Maria");
                    city_muniTb.Rows.Add(119, 5, "Santo Tomas");
                    city_muniTb.Rows.Add(120, 5, "Sison");
                    city_muniTb.Rows.Add(121, 5, "Sual");
                    city_muniTb.Rows.Add(122, 5, "Tayug");
                    city_muniTb.Rows.Add(123, 5, "Umingan");
                    city_muniTb.Rows.Add(124, 5, "Urbiztondo");
                    city_muniTb.Rows.Add(125, 5, "Urdaneta City");
                    city_muniTb.Rows.Add(126, 5, "Villasis");
                }

                if (provinceCb.SelectedValue == "6")
                {
                    // Region Ii
                    // Batanes
                    city_muniTb.Rows.Add(127, 6, "Basco");
                    city_muniTb.Rows.Add(128, 6, "Itbayat");
                    city_muniTb.Rows.Add(129, 6, "Ivana");
                    city_muniTb.Rows.Add(130, 6, "Mahatao");
                    city_muniTb.Rows.Add(131, 6, "Sabtang");
                    city_muniTb.Rows.Add(132, 6, "Uyugan");
                }

                if (provinceCb.SelectedValue == "7")
                {
                    // Region Ii
                    // Cagayan
                    city_muniTb.Rows.Add(133, 7, "Abulug");
                    city_muniTb.Rows.Add(134, 7, "Alcala");
                    city_muniTb.Rows.Add(135, 7, "Allacapan");
                    city_muniTb.Rows.Add(136, 7, "Amulung");
                    city_muniTb.Rows.Add(137, 7, "Aparri");
                    city_muniTb.Rows.Add(138, 7, "Baggao");
                    city_muniTb.Rows.Add(139, 7, "Ballesteros");
                    city_muniTb.Rows.Add(140, 7, "Buguey");
                    city_muniTb.Rows.Add(141, 7, "Calayan");
                    city_muniTb.Rows.Add(142, 7, "Camalaniugan");
                    city_muniTb.Rows.Add(143, 7, "Claveria");
                    city_muniTb.Rows.Add(144, 7, "Enrile");
                    city_muniTb.Rows.Add(145, 7, "Gattaran");
                    city_muniTb.Rows.Add(146, 7, "Gonzaga");
                    city_muniTb.Rows.Add(147, 7, "Iguig");
                    city_muniTb.Rows.Add(148, 7, "Lal-Lo");
                    city_muniTb.Rows.Add(149, 7, "Lasam");
                    city_muniTb.Rows.Add(150, 7, "Pamplona");
                    city_muniTb.Rows.Add(151, 7, "Peñablanca");
                    city_muniTb.Rows.Add(152, 7, "Piat");
                    city_muniTb.Rows.Add(153, 7, "Rizal");
                    city_muniTb.Rows.Add(154, 7, "Sanchez-Mira");
                    city_muniTb.Rows.Add(155, 7, "Santa Ana");
                    city_muniTb.Rows.Add(156, 7, "Santa Praxedes");
                    city_muniTb.Rows.Add(157, 7, "Santa Teresita");
                    city_muniTb.Rows.Add(158, 7, "Santo Niño (Faire)");
                    city_muniTb.Rows.Add(159, 7, "Solana");
                    city_muniTb.Rows.Add(160, 7, "Tuao");
                    city_muniTb.Rows.Add(161, 7, "Tuguegarao City");
                }

                if (provinceCb.SelectedValue == "8")
                {
                    // Region Ii
                    // Isabela
                    city_muniTb.Rows.Add(162, 8, "Alicia");
                    city_muniTb.Rows.Add(163, 8, "Angadanan");
                    city_muniTb.Rows.Add(164, 8, "Aurora");
                    city_muniTb.Rows.Add(165, 8, "Benito Soliven");
                    city_muniTb.Rows.Add(166, 8, "Burgos");
                    city_muniTb.Rows.Add(167, 8, "Cabagan");
                    city_muniTb.Rows.Add(168, 8, "Cabatuan");
                    city_muniTb.Rows.Add(169, 8, "Cauayan City");
                    city_muniTb.Rows.Add(170, 8, "City Of Santiago");
                    city_muniTb.Rows.Add(171, 8, "Cordon");
                    city_muniTb.Rows.Add(172, 8, "Delfin Albano (Magsaysay)");
                    city_muniTb.Rows.Add(173, 8, "Dinapigue");
                    city_muniTb.Rows.Add(174, 8, "Divilacan");
                    city_muniTb.Rows.Add(175, 8, "Echague");
                    city_muniTb.Rows.Add(176, 8, "Gamu");
                    city_muniTb.Rows.Add(177, 8, "Ilagan City");
                    city_muniTb.Rows.Add(178, 8, "Jones");
                    city_muniTb.Rows.Add(179, 8, "Luna");
                    city_muniTb.Rows.Add(180, 8, "Maconacon");
                    city_muniTb.Rows.Add(181, 8, "Mallig");
                    city_muniTb.Rows.Add(182, 8, "Naguilian");
                    city_muniTb.Rows.Add(183, 8, "Palanan");
                    city_muniTb.Rows.Add(184, 8, "Quezon");
                    city_muniTb.Rows.Add(185, 8, "Quirino");
                    city_muniTb.Rows.Add(186, 8, "Ramon");
                    city_muniTb.Rows.Add(187, 8, "Reina Mercedes");
                    city_muniTb.Rows.Add(188, 8, "Roxas");
                    city_muniTb.Rows.Add(189, 8, "San Agustin");
                    city_muniTb.Rows.Add(190, 8, "San Guillermo");
                    city_muniTb.Rows.Add(191, 8, "San Isidro");
                    city_muniTb.Rows.Add(192, 8, "San Manuel");
                    city_muniTb.Rows.Add(193, 8, "San Mariano");
                    city_muniTb.Rows.Add(194, 8, "San Mateo");
                    city_muniTb.Rows.Add(195, 8, "San Pablo");
                    city_muniTb.Rows.Add(196, 8, "Santa Maria");
                    city_muniTb.Rows.Add(197, 8, "Santo Tomas");
                    city_muniTb.Rows.Add(198, 8, "Tumauini");
                }

                if (provinceCb.SelectedValue == "9")
                {
                    // Region Ii
                    // Nueva Vizcaya
                    city_muniTb.Rows.Add(199, 9, "Alfonso Castaneda");
                    city_muniTb.Rows.Add(200, 9, "Ambaguio");
                    city_muniTb.Rows.Add(201, 9, "Aritao");
                    city_muniTb.Rows.Add(202, 9, "Bagabag");
                    city_muniTb.Rows.Add(203, 9, "Bambang");
                    city_muniTb.Rows.Add(204, 9, "Bayombong");
                    city_muniTb.Rows.Add(205, 9, "Diadi");
                    city_muniTb.Rows.Add(206, 9, "Dupax Del Norte");
                    city_muniTb.Rows.Add(207, 9, "Dupax Del Sur");
                    city_muniTb.Rows.Add(208, 9, "Kasibu");
                    city_muniTb.Rows.Add(209, 9, "Kayapa");
                    city_muniTb.Rows.Add(210, 9, "Quezon");
                    city_muniTb.Rows.Add(211, 9, "Santa Fe");
                    city_muniTb.Rows.Add(212, 9, "Solano");
                    city_muniTb.Rows.Add(213, 9, "Villaverde");
                }

                if (provinceCb.SelectedValue == "10")
                {
                    // Region Ii
                    // Quirino
                    city_muniTb.Rows.Add(214, 10, "Aglipay");
                    city_muniTb.Rows.Add(215, 10, "Cabarroguis");
                    city_muniTb.Rows.Add(216, 10, "Diffun");
                    city_muniTb.Rows.Add(217, 10, "Maddela");
                    city_muniTb.Rows.Add(218, 10, "Nagtipunan");
                    city_muniTb.Rows.Add(219, 10, "Saguday");
                }

                if (provinceCb.SelectedValue == "11")
                {
                    // Region Iii
                    // Aurora
                    city_muniTb.Rows.Add(220, 11, "Baler");
                    city_muniTb.Rows.Add(221, 11, "Casiguran");
                    city_muniTb.Rows.Add(222, 11, "Dilasag");
                    city_muniTb.Rows.Add(223, 11, "Dinalungan");
                    city_muniTb.Rows.Add(224, 11, "Dingalan");
                    city_muniTb.Rows.Add(225, 11, "Dipaculao");
                    city_muniTb.Rows.Add(226, 11, "Maria Aurora");
                    city_muniTb.Rows.Add(227, 11, "San Luis");
                }

                if (provinceCb.SelectedValue == "12")
                {
                    // Region Iii
                    // Bataan
                    city_muniTb.Rows.Add(228, 12, "Abucay");
                    city_muniTb.Rows.Add(229, 12, "Bagac");
                    city_muniTb.Rows.Add(230, 12, "Balanga City");
                    city_muniTb.Rows.Add(231, 12, "Dinalupihan");
                    city_muniTb.Rows.Add(232, 12, "Hermosa");
                    city_muniTb.Rows.Add(233, 12, "Limay");
                    city_muniTb.Rows.Add(234, 12, "Mariveles");
                    city_muniTb.Rows.Add(235, 12, "Morong");
                    city_muniTb.Rows.Add(236, 12, "Orani");
                    city_muniTb.Rows.Add(237, 12, "Orion");
                    city_muniTb.Rows.Add(238, 12, "Pilar");
                    city_muniTb.Rows.Add(239, 12, "Samal");
                }

                if (provinceCb.SelectedValue == "13")
                {
                    // Region Iii
                    // Bulacan
                    city_muniTb.Rows.Add(240, 13, "Angat");
                    city_muniTb.Rows.Add(241, 13, "Balagtas (Bigaa)");
                    city_muniTb.Rows.Add(242, 13, "Baliuag");
                    city_muniTb.Rows.Add(243, 13, "Bocaue");
                    city_muniTb.Rows.Add(244, 13, "Bulacan");
                    city_muniTb.Rows.Add(245, 13, "Bustos");
                    city_muniTb.Rows.Add(246, 13, "Calumpit");
                    city_muniTb.Rows.Add(247, 13, "Doña Remedios Trinidad");
                    city_muniTb.Rows.Add(248, 13, "Guiguinto");
                    city_muniTb.Rows.Add(249, 13, "Hagonoy");
                    city_muniTb.Rows.Add(250, 13, "Malolos City");
                    city_muniTb.Rows.Add(251, 13, "Marilao");
                    city_muniTb.Rows.Add(252, 13, "Meycauayan City");
                    city_muniTb.Rows.Add(253, 13, "Norzagaray");
                    city_muniTb.Rows.Add(254, 13, "Obando");
                    city_muniTb.Rows.Add(255, 13, "Pandi");
                    city_muniTb.Rows.Add(256, 13, "Paombong");
                    city_muniTb.Rows.Add(257, 13, "Plaridel");
                    city_muniTb.Rows.Add(258, 13, "Pulilan");
                    city_muniTb.Rows.Add(259, 13, "San Ildefonso");
                    city_muniTb.Rows.Add(260, 13, "San Jose Del Monte City");
                    city_muniTb.Rows.Add(261, 13, "San Miguel");
                    city_muniTb.Rows.Add(262, 13, "San Rafael");
                    city_muniTb.Rows.Add(263, 13, "Santa Maria");
                }

                if (provinceCb.SelectedValue == "14")
                {
                    // Region Iii
                    // Nueva Ecija
                    city_muniTb.Rows.Add(264, 14, "Aliaga");
                    city_muniTb.Rows.Add(265, 14, "Bongabon");
                    city_muniTb.Rows.Add(266, 14, "Cabanatuan City");
                    city_muniTb.Rows.Add(267, 14, "Cabiao");
                    city_muniTb.Rows.Add(268, 14, "Carranglan");
                    city_muniTb.Rows.Add(269, 14, "Cuyapo");
                    city_muniTb.Rows.Add(270, 14, "Gabaldon (Bitulok And Sabani)");
                    city_muniTb.Rows.Add(271, 14, "Gapan City");
                    city_muniTb.Rows.Add(272, 14, "General Mamerto Natividad");
                    city_muniTb.Rows.Add(273, 14, "General Tinio (Papaya)");
                    city_muniTb.Rows.Add(274, 14, "Guimba");
                    city_muniTb.Rows.Add(275, 14, "Jaen");
                    city_muniTb.Rows.Add(276, 14, "Laur");
                    city_muniTb.Rows.Add(277, 14, "Licab");
                    city_muniTb.Rows.Add(278, 14, "Llanera");
                    city_muniTb.Rows.Add(279, 14, "Lupao");
                    city_muniTb.Rows.Add(280, 14, "Nampicuan");
                    city_muniTb.Rows.Add(281, 14, "Palayan City");
                    city_muniTb.Rows.Add(282, 14, "Pantabangan");
                    city_muniTb.Rows.Add(283, 14, "Peñaranda");
                    city_muniTb.Rows.Add(284, 14, "Quezon");
                    city_muniTb.Rows.Add(285, 14, "Rizal");
                    city_muniTb.Rows.Add(286, 14, "San Antonio");
                    city_muniTb.Rows.Add(287, 14, "San Isidro");
                    city_muniTb.Rows.Add(288, 14, "San Jose City");
                    city_muniTb.Rows.Add(289, 14, "San Leonardo");
                    city_muniTb.Rows.Add(290, 14, "Santa Rosa");
                    city_muniTb.Rows.Add(291, 14, "Santo Domingo");
                    city_muniTb.Rows.Add(292, 14, "Science City Of Muñoz");
                    city_muniTb.Rows.Add(293, 14, "Talavera");
                    city_muniTb.Rows.Add(294, 14, "Talugtug");
                    city_muniTb.Rows.Add(295, 14, "Zaragoza");
                }

                if (provinceCb.SelectedValue == "15")
                {
                    // Region Iii
                    // Pampanga
                    city_muniTb.Rows.Add(296, 15, "Angeles City");
                    city_muniTb.Rows.Add(297, 15, "Apalit");
                    city_muniTb.Rows.Add(298, 15, "Arayat");
                    city_muniTb.Rows.Add(299, 15, "Bacolor");
                    city_muniTb.Rows.Add(300, 15, "Candaba");
                    city_muniTb.Rows.Add(301, 15, "Floridablanca");
                    city_muniTb.Rows.Add(302, 15, "Guagua");
                    city_muniTb.Rows.Add(303, 15, "Lubao");
                    city_muniTb.Rows.Add(304, 15, "Mabalacat City");
                    city_muniTb.Rows.Add(305, 15, "Macabebe");
                    city_muniTb.Rows.Add(306, 15, "Magalang");
                    city_muniTb.Rows.Add(307, 15, "Masantol");
                    city_muniTb.Rows.Add(308, 15, "Mexico");
                    city_muniTb.Rows.Add(309, 15, "Minalin");
                    city_muniTb.Rows.Add(310, 15, "Porac");
                    city_muniTb.Rows.Add(311, 15, "San Fernando City");
                    city_muniTb.Rows.Add(312, 15, "San Luis");
                    city_muniTb.Rows.Add(313, 15, "San Simon");
                    city_muniTb.Rows.Add(314, 15, "Santa Ana");
                    city_muniTb.Rows.Add(315, 15, "Santa Rita");
                    city_muniTb.Rows.Add(316, 15, "Santo Tomas");
                    city_muniTb.Rows.Add(317, 15, "Sasmuan (Sexmoan)");
                }

                if (provinceCb.SelectedValue == "16")
                {
                    // Region Iii
                    // Tarlac
                    city_muniTb.Rows.Add(318, 16, "Anao");
                    city_muniTb.Rows.Add(319, 16, "Bamban");
                    city_muniTb.Rows.Add(320, 16, "Camiling");
                    city_muniTb.Rows.Add(321, 16, "Capas");
                    city_muniTb.Rows.Add(322, 16, "City Of Tarlac");
                    city_muniTb.Rows.Add(323, 16, "Concepcion");
                    city_muniTb.Rows.Add(324, 16, "Gerona");
                    city_muniTb.Rows.Add(325, 16, "La Paz");
                    city_muniTb.Rows.Add(326, 16, "Mayantoc");
                    city_muniTb.Rows.Add(327, 16, "Moncada");
                    city_muniTb.Rows.Add(328, 16, "Paniqui");
                    city_muniTb.Rows.Add(329, 16, "Pura");
                    city_muniTb.Rows.Add(330, 16, "Ramos");
                    city_muniTb.Rows.Add(331, 16, "San Clemente");
                    city_muniTb.Rows.Add(332, 16, "San Jose");
                    city_muniTb.Rows.Add(333, 16, "San Manuel");
                    city_muniTb.Rows.Add(334, 16, "Santa Ignacia");
                    city_muniTb.Rows.Add(335, 16, "Victoria");
                }

                if (provinceCb.SelectedValue == "17")
                {
                    // Region Iii
                    // Zambales
                    city_muniTb.Rows.Add(336, 17, "Botolan");
                    city_muniTb.Rows.Add(337, 17, "Cabangan");
                    city_muniTb.Rows.Add(338, 17, "Candelaria");
                    city_muniTb.Rows.Add(339, 17, "Castillejos");
                    city_muniTb.Rows.Add(340, 17, "Iba");
                    city_muniTb.Rows.Add(341, 17, "Masinloc");
                    city_muniTb.Rows.Add(342, 17, "Olongapo City");
                    city_muniTb.Rows.Add(343, 17, "Palauig");
                    city_muniTb.Rows.Add(344, 17, "San Antonio");
                    city_muniTb.Rows.Add(345, 17, "San Felipe");
                    city_muniTb.Rows.Add(346, 17, "San Marcelino");
                    city_muniTb.Rows.Add(347, 17, "San Narciso");
                    city_muniTb.Rows.Add(348, 17, "Santa Cruz");
                    city_muniTb.Rows.Add(349, 17, "Subic");
                }

                if (provinceCb.SelectedValue == "18")
                {
                    // Region Iv-A
                    // Batangas
                    city_muniTb.Rows.Add(350, 18, "Agoncillo");
                    city_muniTb.Rows.Add(351, 18, "Alitagtag");
                    city_muniTb.Rows.Add(352, 18, "Balayan");
                    city_muniTb.Rows.Add(353, 18, "Balete");
                    city_muniTb.Rows.Add(354, 18, "Batangas City");
                    city_muniTb.Rows.Add(355, 18, "Bauan");
                    city_muniTb.Rows.Add(356, 18, "Calaca");
                    city_muniTb.Rows.Add(357, 18, "Calatagan");
                    city_muniTb.Rows.Add(358, 18, "Cuenca");
                    city_muniTb.Rows.Add(359, 18, "Ibaan");
                    city_muniTb.Rows.Add(360, 18, "Laurel");
                    city_muniTb.Rows.Add(361, 18, "Lemery");
                    city_muniTb.Rows.Add(362, 18, "Lian");
                    city_muniTb.Rows.Add(363, 18, "Lipa City");
                    city_muniTb.Rows.Add(364, 18, "Lobo");
                    city_muniTb.Rows.Add(365, 18, "Mabini");
                    city_muniTb.Rows.Add(366, 18, "Malvar");
                    city_muniTb.Rows.Add(367, 18, "Mataas Na Kahoy");
                    city_muniTb.Rows.Add(368, 18, "Nasugbu");
                    city_muniTb.Rows.Add(369, 18, "Padre Garcia");
                    city_muniTb.Rows.Add(370, 18, "Rosario");
                    city_muniTb.Rows.Add(371, 18, "San Jose");
                    city_muniTb.Rows.Add(372, 18, "San Juan");
                    city_muniTb.Rows.Add(373, 18, "San Luis");
                    city_muniTb.Rows.Add(374, 18, "San Nicolas");
                    city_muniTb.Rows.Add(375, 18, "San Pascual");
                    city_muniTb.Rows.Add(376, 18, "Santa Teresita");
                    city_muniTb.Rows.Add(377, 18, "Santo Tomas");
                    city_muniTb.Rows.Add(378, 18, "Taal");
                    city_muniTb.Rows.Add(379, 18, "Talisay");
                    city_muniTb.Rows.Add(380, 18, "Tanauan City");
                    city_muniTb.Rows.Add(381, 18, "Taysan");
                    city_muniTb.Rows.Add(382, 18, "Tingloy");
                    city_muniTb.Rows.Add(383, 18, "Tuy");
                }

                if (provinceCb.SelectedValue == "19")
                {
                    // Region Iv-A
                    // Cavite
                    city_muniTb.Rows.Add(384, 19, "Alfonso");
                    city_muniTb.Rows.Add(385, 19, "Amadeo");
                    city_muniTb.Rows.Add(386, 19, "Bacoor City");
                    city_muniTb.Rows.Add(387, 19, "Carmona");
                    city_muniTb.Rows.Add(388, 19, "Cavite City");
                    city_muniTb.Rows.Add(389, 19, "Dasmariñas City");
                    city_muniTb.Rows.Add(390, 19, "Gen. Mariano Alvarez");
                    city_muniTb.Rows.Add(391, 19, "General Emilio Aguinaldo");
                    city_muniTb.Rows.Add(392, 19, "General Trias City");
                    city_muniTb.Rows.Add(393, 19, "Imus City");
                    city_muniTb.Rows.Add(394, 19, "Indang");
                    city_muniTb.Rows.Add(395, 19, "Kawit");
                    city_muniTb.Rows.Add(396, 19, "Magallanes");
                    city_muniTb.Rows.Add(397, 19, "Maragondon");
                    city_muniTb.Rows.Add(398, 19, "Mendez (Mendez-Nuñez)");
                    city_muniTb.Rows.Add(399, 19, "Naic");
                    city_muniTb.Rows.Add(400, 19, "Noveleta");
                    city_muniTb.Rows.Add(401, 19, "Rosario");
                    city_muniTb.Rows.Add(402, 19, "Silang");
                    city_muniTb.Rows.Add(403, 19, "Tagaytay City");
                    city_muniTb.Rows.Add(404, 19, "Tanza");
                    city_muniTb.Rows.Add(405, 19, "Ternate");
                    city_muniTb.Rows.Add(406, 19, "Trece Martires City");
                }

                if (provinceCb.SelectedValue == "20")
                {
                    // Region Iv-A
                    // Laguna
                    city_muniTb.Rows.Add(407, 20, "Alaminos");
                    city_muniTb.Rows.Add(408, 20, "Bay");
                    city_muniTb.Rows.Add(409, 20, "Cabuyao City");
                    city_muniTb.Rows.Add(410, 20, "Calamba City");
                    city_muniTb.Rows.Add(411, 20, "Calauan");
                    city_muniTb.Rows.Add(412, 20, "Cavinti");
                    city_muniTb.Rows.Add(413, 20, "City Of Biñan");
                    city_muniTb.Rows.Add(414, 20, "Famy");
                    city_muniTb.Rows.Add(415, 20, "Kalayaan");
                    city_muniTb.Rows.Add(416, 20, "Liliw");
                    city_muniTb.Rows.Add(417, 20, "Los Baños");
                    city_muniTb.Rows.Add(418, 20, "Luisiana");
                    city_muniTb.Rows.Add(419, 20, "Lumban");
                    city_muniTb.Rows.Add(420, 20, "Mabitac");
                    city_muniTb.Rows.Add(421, 20, "Magdalena");
                    city_muniTb.Rows.Add(422, 20, "Majayjay");
                    city_muniTb.Rows.Add(423, 20, "Nagcarlan");
                    city_muniTb.Rows.Add(424, 20, "Paete");
                    city_muniTb.Rows.Add(425, 20, "Pagsanjan");
                    city_muniTb.Rows.Add(426, 20, "Pakil");
                    city_muniTb.Rows.Add(427, 20, "Pangil");
                    city_muniTb.Rows.Add(428, 20, "Pila");
                    city_muniTb.Rows.Add(429, 20, "Rizal");
                    city_muniTb.Rows.Add(430, 20, "San Pablo City");
                    city_muniTb.Rows.Add(431, 20, "San Pedro City");
                    city_muniTb.Rows.Add(432, 20, "Santa Cruz");
                    city_muniTb.Rows.Add(433, 20, "Santa Maria");
                    city_muniTb.Rows.Add(434, 20, "Santa Rosa City");
                    city_muniTb.Rows.Add(435, 20, "Siniloan");
                    city_muniTb.Rows.Add(436, 20, "Victoria");
                }

                if (provinceCb.SelectedValue == "21")
                {
                    // Region Iv-A
                    // Quezon
                    city_muniTb.Rows.Add(437, 21, "Agdangan");
                    city_muniTb.Rows.Add(438, 21, "Alabat");
                    city_muniTb.Rows.Add(439, 21, "Atimonan");
                    city_muniTb.Rows.Add(440, 21, "Buenavista");
                    city_muniTb.Rows.Add(441, 21, "Burdeos");
                    city_muniTb.Rows.Add(442, 21, "Calauag");
                    city_muniTb.Rows.Add(443, 21, "Candelaria");
                    city_muniTb.Rows.Add(444, 21, "Catanauan");
                    city_muniTb.Rows.Add(445, 21, "Dolores");
                    city_muniTb.Rows.Add(446, 21, "General Luna");
                    city_muniTb.Rows.Add(447, 21, "General Nakar");
                    city_muniTb.Rows.Add(448, 21, "Guinayangan");
                    city_muniTb.Rows.Add(449, 21, "Gumaca");
                    city_muniTb.Rows.Add(450, 21, "Infanta");
                    city_muniTb.Rows.Add(451, 21, "Jomalig");
                    city_muniTb.Rows.Add(452, 21, "Lopez");
                    city_muniTb.Rows.Add(453, 21, "Lucban");
                    city_muniTb.Rows.Add(454, 21, "Lucena City");
                    city_muniTb.Rows.Add(455, 21, "Macalelon");
                    city_muniTb.Rows.Add(456, 21, "Mauban");
                    city_muniTb.Rows.Add(457, 21, "Mulanay");
                    city_muniTb.Rows.Add(458, 21, "Padre Burgos");
                    city_muniTb.Rows.Add(459, 21, "Pagbilao");
                    city_muniTb.Rows.Add(460, 21, "Panukulan");
                    city_muniTb.Rows.Add(461, 21, "Patnanungan");
                    city_muniTb.Rows.Add(462, 21, "Perez");
                    city_muniTb.Rows.Add(463, 21, "Pitogo");
                    city_muniTb.Rows.Add(464, 21, "Plaridel");
                    city_muniTb.Rows.Add(465, 21, "Polillo");
                    city_muniTb.Rows.Add(466, 21, "Quezon");
                    city_muniTb.Rows.Add(467, 21, "Real");
                    city_muniTb.Rows.Add(468, 21, "Sampaloc");
                    city_muniTb.Rows.Add(469, 21, "San Andres");
                    city_muniTb.Rows.Add(470, 21, "San Antonio");
                    city_muniTb.Rows.Add(471, 21, "San Francisco (Aurora)");
                    city_muniTb.Rows.Add(472, 21, "San Narciso");
                    city_muniTb.Rows.Add(473, 21, "Sariaya");
                    city_muniTb.Rows.Add(474, 21, "Tagkawayan");
                    city_muniTb.Rows.Add(475, 21, "Tayabas City");
                    city_muniTb.Rows.Add(476, 21, "Tiaong");
                    city_muniTb.Rows.Add(477, 21, "Unisan");
                }

                if (provinceCb.SelectedValue == "22")
                {
                    // Region Iv-A
                    // Rizal
                    city_muniTb.Rows.Add(478, 22, "Angono");
                    city_muniTb.Rows.Add(479, 22, "Baras");
                    city_muniTb.Rows.Add(480, 22, "Binangonan");
                    city_muniTb.Rows.Add(481, 22, "Cainta");
                    city_muniTb.Rows.Add(482, 22, "Cardona");
                    city_muniTb.Rows.Add(483, 22, "City Of Antipolo");
                    city_muniTb.Rows.Add(484, 22, "Jala-Jala");
                    city_muniTb.Rows.Add(485, 22, "Morong");
                    city_muniTb.Rows.Add(486, 22, "Pililla");
                    city_muniTb.Rows.Add(487, 22, "Rodriguez (Montalban)");
                    city_muniTb.Rows.Add(488, 22, "San Mateo");
                    city_muniTb.Rows.Add(489, 22, "Tanay");
                    city_muniTb.Rows.Add(490, 22, "Taytay");
                    city_muniTb.Rows.Add(491, 22, "Teresa");
                }

                if (provinceCb.SelectedValue == "23")
                {
                    // Region Iv-B
                    // Marinduque
                    city_muniTb.Rows.Add(492, 23, "Boac");
                    city_muniTb.Rows.Add(493, 23, "Buenavista");
                    city_muniTb.Rows.Add(494, 23, "Gasan");
                    city_muniTb.Rows.Add(495, 23, "Mogpog");
                    city_muniTb.Rows.Add(496, 23, "Santa Cruz");
                    city_muniTb.Rows.Add(497, 23, "Torrijos");
                }

                if (provinceCb.SelectedValue == "24")
                {
                    // Region Iv-B
                    // Occidental Mindoro
                    city_muniTb.Rows.Add(498, 24, "Abra De Ilog");
                    city_muniTb.Rows.Add(499, 24, "Calintaan");
                    city_muniTb.Rows.Add(500, 24, "Looc");
                    city_muniTb.Rows.Add(501, 24, "Lubang");
                    city_muniTb.Rows.Add(502, 24, "Magsaysay");
                    city_muniTb.Rows.Add(503, 24, "Mamburao");
                    city_muniTb.Rows.Add(504, 24, "Paluan");
                    city_muniTb.Rows.Add(505, 24, "Rizal");
                    city_muniTb.Rows.Add(506, 24, "Sablayan");
                    city_muniTb.Rows.Add(507, 24, "San Jose");
                    city_muniTb.Rows.Add(508, 24, "Santa Cruz");
                }

                if (provinceCb.SelectedValue == "25")
                {
                    // Region Iv-B
                    // Oriental Mindoro
                    city_muniTb.Rows.Add(509, 25, "Baco");
                    city_muniTb.Rows.Add(510, 25, "Bansud");
                    city_muniTb.Rows.Add(511, 25, "Bongabong");
                    city_muniTb.Rows.Add(512, 25, "Bulalacao (San Pedro)");
                    city_muniTb.Rows.Add(513, 25, "City Of Calapan");
                    city_muniTb.Rows.Add(514, 25, "Gloria");
                    city_muniTb.Rows.Add(515, 25, "Mansalay");
                    city_muniTb.Rows.Add(516, 25, "Naujan");
                    city_muniTb.Rows.Add(517, 25, "Pinamalayan");
                    city_muniTb.Rows.Add(518, 25, "Pola");
                    city_muniTb.Rows.Add(519, 25, "Puerto Galera");
                    city_muniTb.Rows.Add(520, 25, "Roxas");
                    city_muniTb.Rows.Add(521, 25, "San Teodoro");
                    city_muniTb.Rows.Add(522, 25, "Socorro");
                    city_muniTb.Rows.Add(523, 25, "Victoria");
                }

                if (provinceCb.SelectedValue == "26")
                {
                    // Region Iv-B
                    // Palawan
                    city_muniTb.Rows.Add(524, 26, "Aborlan");
                    city_muniTb.Rows.Add(525, 26, "Agutaya");
                    city_muniTb.Rows.Add(526, 26, "Araceli");
                    city_muniTb.Rows.Add(527, 26, "Balabac");
                    city_muniTb.Rows.Add(528, 26, "Bataraza");
                    city_muniTb.Rows.Add(529, 26, "Brooke'S Point");
                    city_muniTb.Rows.Add(530, 26, "Busuanga");
                    city_muniTb.Rows.Add(531, 26, "Cagayancillo");
                    city_muniTb.Rows.Add(532, 26, "Coron");
                    city_muniTb.Rows.Add(533, 26, "Culion");
                    city_muniTb.Rows.Add(534, 26, "Cuyo");
                    city_muniTb.Rows.Add(535, 26, "Dumaran");
                    city_muniTb.Rows.Add(536, 26, "El Nido (Bacuit)");
                    city_muniTb.Rows.Add(537, 26, "Kalayaan");
                    city_muniTb.Rows.Add(538, 26, "Linapacan");
                    city_muniTb.Rows.Add(539, 26, "Magsaysay");
                    city_muniTb.Rows.Add(540, 26, "Narra");
                    city_muniTb.Rows.Add(541, 26, "Puerto Princesa City");
                    city_muniTb.Rows.Add(542, 26, "Quezon");
                    city_muniTb.Rows.Add(543, 26, "Rizal (Marcos)");
                    city_muniTb.Rows.Add(544, 26, "Roxas");
                    city_muniTb.Rows.Add(545, 26, "San Vicente");
                    city_muniTb.Rows.Add(546, 26, "Sofronio Española");
                    city_muniTb.Rows.Add(547, 26, "Taytay");
                }

                if (provinceCb.SelectedValue == "27")
                {
                    // Region Iv-B
                    // Romblon
                    city_muniTb.Rows.Add(548, 27, "Alcantara");
                    city_muniTb.Rows.Add(549, 27, "Banton");
                    city_muniTb.Rows.Add(550, 27, "Cajidiocan");
                    city_muniTb.Rows.Add(551, 27, "Calatrava");
                    city_muniTb.Rows.Add(552, 27, "Concepcion");
                    city_muniTb.Rows.Add(553, 27, "Corcuera");
                    city_muniTb.Rows.Add(554, 27, "Ferrol");
                    city_muniTb.Rows.Add(555, 27, "Looc");
                    city_muniTb.Rows.Add(556, 27, "Magdiwang");
                    city_muniTb.Rows.Add(557, 27, "Odiongan");
                    city_muniTb.Rows.Add(558, 27, "Romblon");
                    city_muniTb.Rows.Add(559, 27, "San Agustin");
                    city_muniTb.Rows.Add(560, 27, "San Andres");
                    city_muniTb.Rows.Add(561, 27, "San Fernando");
                    city_muniTb.Rows.Add(562, 27, "San Jose");
                    city_muniTb.Rows.Add(563, 27, "Santa Fe");
                    city_muniTb.Rows.Add(564, 27, "Santa Maria (Imelda)");
                }

                if (provinceCb.SelectedValue == "28")
                {
                    // Region V
                    // Albay
                    city_muniTb.Rows.Add(565, 28, "Bacacay");
                    city_muniTb.Rows.Add(566, 28, "Camalig");
                    city_muniTb.Rows.Add(567, 28, "City Of Ligao");
                    city_muniTb.Rows.Add(568, 28, "Daraga (Locsin)");
                    city_muniTb.Rows.Add(569, 28, "Guinobatan");
                    city_muniTb.Rows.Add(570, 28, "Jovellar");
                    city_muniTb.Rows.Add(571, 28, "Legazpi City");
                    city_muniTb.Rows.Add(572, 28, "Libon");
                    city_muniTb.Rows.Add(573, 28, "Malilipot");
                    city_muniTb.Rows.Add(574, 28, "Malinao");
                    city_muniTb.Rows.Add(575, 28, "Manito");
                    city_muniTb.Rows.Add(576, 28, "Oas");
                    city_muniTb.Rows.Add(577, 28, "Pio Duran");
                    city_muniTb.Rows.Add(578, 28, "Polangui");
                    city_muniTb.Rows.Add(579, 28, "Rapu-Rapu");
                    city_muniTb.Rows.Add(580, 28, "Santo Domingo (Libog)");
                    city_muniTb.Rows.Add(581, 28, "Tabaco City");
                    city_muniTb.Rows.Add(582, 28, "Tiwi");
                }

                if (provinceCb.SelectedValue == "29")
                {
                    // Region V
                    // Camarines Norte
                    city_muniTb.Rows.Add(583, 29, "Basud");
                    city_muniTb.Rows.Add(584, 29, "Capalonga");
                    city_muniTb.Rows.Add(585, 29, "Daet");
                    city_muniTb.Rows.Add(586, 29, "Jose Panganiban");
                    city_muniTb.Rows.Add(587, 29, "Labo");
                    city_muniTb.Rows.Add(588, 29, "Mercedes");
                    city_muniTb.Rows.Add(589, 29, "Paracale");
                    city_muniTb.Rows.Add(590, 29, "San Lorenzo Ruiz (Imelda)");
                    city_muniTb.Rows.Add(591, 29, "San Vicente");
                    city_muniTb.Rows.Add(592, 29, "Santa Elena");
                    city_muniTb.Rows.Add(593, 29, "Talisay");
                    city_muniTb.Rows.Add(594, 29, "Vinzons");
                }

                if (provinceCb.SelectedValue == "30")
                {
                    // Region V
                    // Camarines Sur
                    city_muniTb.Rows.Add(595, 30, "Baao");
                    city_muniTb.Rows.Add(596, 30, "Balatan");
                    city_muniTb.Rows.Add(597, 30, "Bato");
                    city_muniTb.Rows.Add(598, 30, "Bombon");
                    city_muniTb.Rows.Add(599, 30, "Buhi");
                    city_muniTb.Rows.Add(600, 30, "Bula");
                    city_muniTb.Rows.Add(601, 30, "Cabusao");
                    city_muniTb.Rows.Add(602, 30, "Calabanga");
                    city_muniTb.Rows.Add(603, 30, "Camaligan");
                    city_muniTb.Rows.Add(604, 30, "Canaman");
                    city_muniTb.Rows.Add(605, 30, "Caramoan");
                    city_muniTb.Rows.Add(606, 30, "Del Gallego");
                    city_muniTb.Rows.Add(607, 30, "Gainza");
                    city_muniTb.Rows.Add(608, 30, "Garchitorena");
                    city_muniTb.Rows.Add(609, 30, "Goa");
                    city_muniTb.Rows.Add(610, 30, "Iriga City");
                    city_muniTb.Rows.Add(611, 30, "Lagonoy");
                    city_muniTb.Rows.Add(612, 30, "Libmanan");
                    city_muniTb.Rows.Add(613, 30, "Lupi");
                    city_muniTb.Rows.Add(614, 30, "Magarao");
                    city_muniTb.Rows.Add(615, 30, "Milaor");
                    city_muniTb.Rows.Add(616, 30, "Minalabac");
                    city_muniTb.Rows.Add(617, 30, "Nabua");
                    city_muniTb.Rows.Add(618, 30, "Naga City");
                    city_muniTb.Rows.Add(619, 30, "Ocampo");
                    city_muniTb.Rows.Add(620, 30, "Pamplona");
                    city_muniTb.Rows.Add(621, 30, "Pasacao");
                    city_muniTb.Rows.Add(622, 30, "Pili");
                    city_muniTb.Rows.Add(623, 30, "Presentacion (Parubcan)");
                    city_muniTb.Rows.Add(624, 30, "Ragay");
                    city_muniTb.Rows.Add(625, 30, "Sagñay");
                    city_muniTb.Rows.Add(626, 30, "San Fernando");
                    city_muniTb.Rows.Add(627, 30, "San Jose");
                    city_muniTb.Rows.Add(628, 30, "Sipocot");
                    city_muniTb.Rows.Add(629, 30, "Siruma");
                    city_muniTb.Rows.Add(630, 30, "Tigaon");
                    city_muniTb.Rows.Add(631, 30, "Tinambac");
                }

                if (provinceCb.SelectedValue == "31")
                {
                    // Region V
                    // Catanduanes
                    city_muniTb.Rows.Add(632, 31, "Bagamanoc");
                    city_muniTb.Rows.Add(633, 31, "Baras");
                    city_muniTb.Rows.Add(634, 31, "Bato");
                    city_muniTb.Rows.Add(635, 31, "Caramoran");
                    city_muniTb.Rows.Add(636, 31, "Gigmoto");
                    city_muniTb.Rows.Add(637, 31, "Pandan");
                    city_muniTb.Rows.Add(638, 31, "Panganiban (Payo)");
                    city_muniTb.Rows.Add(639, 31, "San Andres (Calolbon)");
                    city_muniTb.Rows.Add(640, 31, "San Miguel");
                    city_muniTb.Rows.Add(641, 31, "Viga");
                    city_muniTb.Rows.Add(642, 31, "Virac");
                }

                if (provinceCb.SelectedValue == "32")
                {
                    // Region V
                    // Masbate
                    city_muniTb.Rows.Add(643, 32, "Aroroy");
                    city_muniTb.Rows.Add(644, 32, "Baleno");
                    city_muniTb.Rows.Add(645, 32, "Balud");
                    city_muniTb.Rows.Add(646, 32, "Batuan");
                    city_muniTb.Rows.Add(647, 32, "Cataingan");
                    city_muniTb.Rows.Add(648, 32, "Cawayan");
                    city_muniTb.Rows.Add(649, 32, "Claveria");
                    city_muniTb.Rows.Add(650, 32, "Dimasalang");
                    city_muniTb.Rows.Add(651, 32, "Esperanza");
                    city_muniTb.Rows.Add(652, 32, "Mandaon");
                    city_muniTb.Rows.Add(653, 32, "Masbate City");
                    city_muniTb.Rows.Add(654, 32, "Milagros");
                    city_muniTb.Rows.Add(655, 32, "Mobo");
                    city_muniTb.Rows.Add(656, 32, "Monreal");
                    city_muniTb.Rows.Add(657, 32, "Palanas");
                    city_muniTb.Rows.Add(658, 32, "Pio V. Corpuz (Limbuhan)");
                    city_muniTb.Rows.Add(659, 32, "Placer");
                    city_muniTb.Rows.Add(660, 32, "San Fernando");
                    city_muniTb.Rows.Add(661, 32, "San Jacinto");
                    city_muniTb.Rows.Add(662, 32, "San Pascual");
                    city_muniTb.Rows.Add(663, 32, "Uson");
                }

                if (provinceCb.SelectedValue == "33")
                {
                    // Region V
                    // Sorsogon
                    city_muniTb.Rows.Add(664, 33, "Barcelona");
                    city_muniTb.Rows.Add(665, 33, "Bulan");
                    city_muniTb.Rows.Add(666, 33, "Bulusan");
                    city_muniTb.Rows.Add(667, 33, "Casiguran");
                    city_muniTb.Rows.Add(668, 33, "Castilla");
                    city_muniTb.Rows.Add(669, 33, "Donsol");
                    city_muniTb.Rows.Add(670, 33, "Gubat");
                    city_muniTb.Rows.Add(671, 33, "Irosin");
                    city_muniTb.Rows.Add(672, 33, "Juban");
                    city_muniTb.Rows.Add(673, 33, "Magallanes");
                    city_muniTb.Rows.Add(674, 33, "Matnog");
                    city_muniTb.Rows.Add(675, 33, "Pilar");
                    city_muniTb.Rows.Add(676, 33, "Prieto Diaz");
                    city_muniTb.Rows.Add(677, 33, "Santa Magdalena");
                    city_muniTb.Rows.Add(678, 33, "Sorsogon City");
                }

                if (provinceCb.SelectedValue == "34")
                {
                    // Region Vi
                    // Aklan
                    city_muniTb.Rows.Add(679, 34, "Altavas");
                    city_muniTb.Rows.Add(680, 34, "Balete");
                    city_muniTb.Rows.Add(681, 34, "Banga");
                    city_muniTb.Rows.Add(682, 34, "Batan");
                    city_muniTb.Rows.Add(683, 34, "Buruanga");
                    city_muniTb.Rows.Add(684, 34, "Ibajay");
                    city_muniTb.Rows.Add(685, 34, "Kalibo");
                    city_muniTb.Rows.Add(686, 34, "Lezo");
                    city_muniTb.Rows.Add(687, 34, "Libacao");
                    city_muniTb.Rows.Add(688, 34, "Madalag");
                    city_muniTb.Rows.Add(689, 34, "Makato");
                    city_muniTb.Rows.Add(690, 34, "Malay");
                    city_muniTb.Rows.Add(691, 34, "Malinao");
                    city_muniTb.Rows.Add(692, 34, "Nabas");
                    city_muniTb.Rows.Add(693, 34, "New Washington");
                    city_muniTb.Rows.Add(694, 34, "Numancia");
                    city_muniTb.Rows.Add(695, 34, "Tangalan");
                }

                if (provinceCb.SelectedValue == "35")
                {
                    // Region Vi
                    // Antique
                    city_muniTb.Rows.Add(696, 35, "Anini-Y");
                    city_muniTb.Rows.Add(697, 35, "Barbaza");
                    city_muniTb.Rows.Add(698, 35, "Belison");
                    city_muniTb.Rows.Add(699, 35, "Bugasong");
                    city_muniTb.Rows.Add(700, 35, "Caluya");
                    city_muniTb.Rows.Add(701, 35, "Culasi");
                    city_muniTb.Rows.Add(702, 35, "Hamtic");
                    city_muniTb.Rows.Add(703, 35, "Laua-An");
                    city_muniTb.Rows.Add(704, 35, "Libertad");
                    city_muniTb.Rows.Add(705, 35, "Pandan");
                    city_muniTb.Rows.Add(706, 35, "Patnongon");
                    city_muniTb.Rows.Add(707, 35, "San Jose");
                    city_muniTb.Rows.Add(708, 35, "San Remigio");
                    city_muniTb.Rows.Add(709, 35, "Sebaste");
                    city_muniTb.Rows.Add(710, 35, "Sibalom");
                    city_muniTb.Rows.Add(711, 35, "Tibiao");
                    city_muniTb.Rows.Add(712, 35, "Tobias Fornier (Dao)");
                    city_muniTb.Rows.Add(713, 35, "Valderrama");
                }

                if (provinceCb.SelectedValue == "36")
                {
                    // Region Vi
                    // Capiz
                    city_muniTb.Rows.Add(714, 36, "Cuartero");
                    city_muniTb.Rows.Add(715, 36, "Dao");
                    city_muniTb.Rows.Add(716, 36, "Dumalag");
                    city_muniTb.Rows.Add(717, 36, "Dumarao");
                    city_muniTb.Rows.Add(718, 36, "Ivisan");
                    city_muniTb.Rows.Add(719, 36, "Jamindan");
                    city_muniTb.Rows.Add(720, 36, "Ma-Ayon");
                    city_muniTb.Rows.Add(721, 36, "Mambusao");
                    city_muniTb.Rows.Add(722, 36, "Panay");
                    city_muniTb.Rows.Add(723, 36, "Panitan");
                    city_muniTb.Rows.Add(724, 36, "Pilar");
                    city_muniTb.Rows.Add(725, 36, "Pontevedra");
                    city_muniTb.Rows.Add(726, 36, "President Roxas");
                    city_muniTb.Rows.Add(727, 36, "Roxas City");
                    city_muniTb.Rows.Add(728, 36, "Sapi-An");
                    city_muniTb.Rows.Add(729, 36, "Sigma");
                    city_muniTb.Rows.Add(730, 36, "Tapaz");
                }

                if (provinceCb.SelectedValue == "37")
                {
                    // Region Vi
                    // Guimaras
                    city_muniTb.Rows.Add(731, 37, "Buenavista");
                    city_muniTb.Rows.Add(732, 37, "Jordan");
                    city_muniTb.Rows.Add(733, 37, "Nueva Valencia");
                    city_muniTb.Rows.Add(734, 37, "San Lorenzo");
                    city_muniTb.Rows.Add(735, 37, "Sibunag");
                }

                if (provinceCb.SelectedValue == "38")
                {
                    // Region Vi
                    // Iloilo
                    city_muniTb.Rows.Add(736, 38, "Ajuy");
                    city_muniTb.Rows.Add(737, 38, "Alimodian");
                    city_muniTb.Rows.Add(738, 38, "Anilao");
                    city_muniTb.Rows.Add(739, 38, "Badiangan");
                    city_muniTb.Rows.Add(740, 38, "Balasan");
                    city_muniTb.Rows.Add(741, 38, "Banate");
                    city_muniTb.Rows.Add(742, 38, "Barotac Nuevo");
                    city_muniTb.Rows.Add(743, 38, "Barotac Viejo");
                    city_muniTb.Rows.Add(744, 38, "Batad");
                    city_muniTb.Rows.Add(745, 38, "Bingawan");
                    city_muniTb.Rows.Add(746, 38, "Cabatuan");
                    city_muniTb.Rows.Add(747, 38, "Calinog");
                    city_muniTb.Rows.Add(748, 38, "Carles");
                    city_muniTb.Rows.Add(749, 38, "City Of Passi");
                    city_muniTb.Rows.Add(750, 38, "Concepcion");
                    city_muniTb.Rows.Add(751, 38, "Dingle");
                    city_muniTb.Rows.Add(752, 38, "Dueñas");
                    city_muniTb.Rows.Add(753, 38, "Dumangas");
                    city_muniTb.Rows.Add(754, 38, "Estancia");
                    city_muniTb.Rows.Add(755, 38, "Guimbal");
                    city_muniTb.Rows.Add(756, 38, "Igbaras");
                    city_muniTb.Rows.Add(757, 38, "Iloilo City");
                    city_muniTb.Rows.Add(758, 38, "Janiuay");
                    city_muniTb.Rows.Add(759, 38, "Lambunao");
                    city_muniTb.Rows.Add(760, 38, "Leganes");
                    city_muniTb.Rows.Add(761, 38, "Lemery");
                    city_muniTb.Rows.Add(762, 38, "Leon");
                    city_muniTb.Rows.Add(763, 38, "Maasin");
                    city_muniTb.Rows.Add(764, 38, "Miagao");
                    city_muniTb.Rows.Add(765, 38, "Mina");
                    city_muniTb.Rows.Add(766, 38, "New Lucena");
                    city_muniTb.Rows.Add(767, 38, "Oton");
                    city_muniTb.Rows.Add(768, 38, "Pavia");
                    city_muniTb.Rows.Add(769, 38, "Pototan");
                    city_muniTb.Rows.Add(770, 38, "San Dionisio");
                    city_muniTb.Rows.Add(771, 38, "San Enrique");
                    city_muniTb.Rows.Add(772, 38, "San Joaquin");
                    city_muniTb.Rows.Add(773, 38, "San Miguel");
                    city_muniTb.Rows.Add(774, 38, "San Rafael");
                    city_muniTb.Rows.Add(775, 38, "Santa Barbara");
                    city_muniTb.Rows.Add(776, 38, "Sara");
                    city_muniTb.Rows.Add(777, 38, "Tigbauan");
                    city_muniTb.Rows.Add(778, 38, "Tubungan");
                    city_muniTb.Rows.Add(779, 38, "Zarraga");
                }

                if (provinceCb.SelectedValue == "39")
                {
                    // Region Vi
                    // Negros Occidental
                    city_muniTb.Rows.Add(780, 39, "Bacolod City");
                    city_muniTb.Rows.Add(781, 39, "Bago City");
                    city_muniTb.Rows.Add(782, 39, "Binalbagan");
                    city_muniTb.Rows.Add(783, 39, "Cadiz City");
                    city_muniTb.Rows.Add(784, 39, "Calatrava");
                    city_muniTb.Rows.Add(785, 39, "Candoni");
                    city_muniTb.Rows.Add(786, 39, "Cauayan");
                    city_muniTb.Rows.Add(787, 39, "Enrique B. Magalona (Saravia)");
                    city_muniTb.Rows.Add(788, 39, "Escalante City");
                    city_muniTb.Rows.Add(789, 39, "Himamaylan City");
                    city_muniTb.Rows.Add(790, 39, "Hinigaran");
                    city_muniTb.Rows.Add(791, 39, "Hinoba-An (Asia)");
                    city_muniTb.Rows.Add(792, 39, "Ilog");
                    city_muniTb.Rows.Add(793, 39, "Isabela");
                    city_muniTb.Rows.Add(794, 39, "Kabankalan City");
                    city_muniTb.Rows.Add(795, 39, "La Carlota City");
                    city_muniTb.Rows.Add(796, 39, "La Castellana");
                    city_muniTb.Rows.Add(797, 39, "Manapla");
                    city_muniTb.Rows.Add(798, 39, "Moises Padilla (Magallon)");
                    city_muniTb.Rows.Add(799, 39, "Murcia");
                    city_muniTb.Rows.Add(800, 39, "Pontevedra");
                    city_muniTb.Rows.Add(801, 39, "Pulupandan");
                    city_muniTb.Rows.Add(802, 39, "Sagay City");
                    city_muniTb.Rows.Add(803, 39, "Salvador Benedicto");
                    city_muniTb.Rows.Add(804, 39, "San Carlos City");
                    city_muniTb.Rows.Add(805, 39, "San Enrique");
                    city_muniTb.Rows.Add(806, 39, "Silay City");
                    city_muniTb.Rows.Add(807, 39, "Sipalay City");
                    city_muniTb.Rows.Add(808, 39, "Talisay City");
                    city_muniTb.Rows.Add(809, 39, "Toboso");
                    city_muniTb.Rows.Add(810, 39, "Valladolid");
                    city_muniTb.Rows.Add(811, 39, "Victorias City");
                }

                if (provinceCb.SelectedValue == "40")
                {
                    // Region Vii
                    // Bohol
                    city_muniTb.Rows.Add(812, 40, "Alburquerque");
                    city_muniTb.Rows.Add(813, 40, "Alicia");
                    city_muniTb.Rows.Add(814, 40, "Anda");
                    city_muniTb.Rows.Add(815, 40, "Antequera");
                    city_muniTb.Rows.Add(816, 40, "Baclayon");
                    city_muniTb.Rows.Add(817, 40, "Balilihan");
                    city_muniTb.Rows.Add(818, 40, "Batuan");
                    city_muniTb.Rows.Add(819, 40, "Bien Unido");
                    city_muniTb.Rows.Add(820, 40, "Bilar");
                    city_muniTb.Rows.Add(821, 40, "Buenavista");
                    city_muniTb.Rows.Add(822, 40, "Calape");
                    city_muniTb.Rows.Add(823, 40, "Candijay");
                    city_muniTb.Rows.Add(824, 40, "Carmen");
                    city_muniTb.Rows.Add(825, 40, "Catigbian");
                    city_muniTb.Rows.Add(826, 40, "Clarin");
                    city_muniTb.Rows.Add(827, 40, "Corella");
                    city_muniTb.Rows.Add(828, 40, "Cortes");
                    city_muniTb.Rows.Add(829, 40, "Dagohoy");
                    city_muniTb.Rows.Add(830, 40, "Danao");
                    city_muniTb.Rows.Add(831, 40, "Dauis");
                    city_muniTb.Rows.Add(832, 40, "Dimiao");
                    city_muniTb.Rows.Add(833, 40, "Duero");
                    city_muniTb.Rows.Add(834, 40, "Garcia Hernandez");
                    city_muniTb.Rows.Add(835, 40, "Guindulman");
                    city_muniTb.Rows.Add(836, 40, "Inabanga");
                    city_muniTb.Rows.Add(837, 40, "Jagna");
                    city_muniTb.Rows.Add(838, 40, "Jetafe");
                    city_muniTb.Rows.Add(839, 40, "Lila");
                    city_muniTb.Rows.Add(840, 40, "Loay");
                    city_muniTb.Rows.Add(841, 40, "Loboc");
                    city_muniTb.Rows.Add(842, 40, "Loon");
                    city_muniTb.Rows.Add(843, 40, "Mabini");
                    city_muniTb.Rows.Add(844, 40, "Maribojoc");
                    city_muniTb.Rows.Add(845, 40, "Panglao");
                    city_muniTb.Rows.Add(846, 40, "Pilar");
                    city_muniTb.Rows.Add(847, 40, "Pres. Carlos P. Garcia (Pitogo)");
                    city_muniTb.Rows.Add(848, 40, "Sagbayan (Borja)");
                    city_muniTb.Rows.Add(849, 40, "San Isidro");
                    city_muniTb.Rows.Add(850, 40, "San Miguel");
                    city_muniTb.Rows.Add(851, 40, "Sevilla");
                    city_muniTb.Rows.Add(852, 40, "Sierra Bullones");
                    city_muniTb.Rows.Add(853, 40, "Sikatuna");
                    city_muniTb.Rows.Add(854, 40, "Tagbilaran City");
                    city_muniTb.Rows.Add(855, 40, "Talibon");
                    city_muniTb.Rows.Add(856, 40, "Trinidad");
                    city_muniTb.Rows.Add(857, 40, "Tubigon");
                    city_muniTb.Rows.Add(858, 40, "Ubay");
                    city_muniTb.Rows.Add(859, 40, "Valencia");
                }

                if (provinceCb.SelectedValue == "41")
                {
                    // Region Vii
                    // Cebu
                    city_muniTb.Rows.Add(860, 41, "Alcantara");
                    city_muniTb.Rows.Add(861, 41, "Alcoy");
                    city_muniTb.Rows.Add(862, 41, "Alegria");
                    city_muniTb.Rows.Add(863, 41, "Aloguinsan");
                    city_muniTb.Rows.Add(864, 41, "Argao");
                    city_muniTb.Rows.Add(865, 41, "Asturias");
                    city_muniTb.Rows.Add(866, 41, "Badian");
                    city_muniTb.Rows.Add(867, 41, "Balamban");
                    city_muniTb.Rows.Add(868, 41, "Bantayan");
                    city_muniTb.Rows.Add(869, 41, "Barili");
                    city_muniTb.Rows.Add(870, 41, "Bogo City");
                    city_muniTb.Rows.Add(871, 41, "Boljoon");
                    city_muniTb.Rows.Add(872, 41, "Borbon");
                    city_muniTb.Rows.Add(873, 41, "Carcar City");
                    city_muniTb.Rows.Add(874, 41, "Carmen");
                    city_muniTb.Rows.Add(875, 41, "Catmon");
                    city_muniTb.Rows.Add(876, 41, "Cebu City");
                    city_muniTb.Rows.Add(877, 41, "Compostela");
                    city_muniTb.Rows.Add(878, 41, "Consolacion");
                    city_muniTb.Rows.Add(879, 41, "Cordoba");
                    city_muniTb.Rows.Add(880, 41, "Daanbantayan");
                    city_muniTb.Rows.Add(881, 41, "Dalaguete");
                    city_muniTb.Rows.Add(882, 41, "Danao City");
                    city_muniTb.Rows.Add(883, 41, "Dumanjug");
                    city_muniTb.Rows.Add(884, 41, "Ginatilan");
                    city_muniTb.Rows.Add(885, 41, "Lapu-Lapu City (Opon)");
                    city_muniTb.Rows.Add(886, 41, "Liloan");
                    city_muniTb.Rows.Add(887, 41, "Madridejos");
                    city_muniTb.Rows.Add(888, 41, "Malabuyoc");
                    city_muniTb.Rows.Add(889, 41, "Mandaue City");
                    city_muniTb.Rows.Add(890, 41, "Medellin");
                    city_muniTb.Rows.Add(891, 41, "Minglanilla");
                    city_muniTb.Rows.Add(892, 41, "Moalboal");
                    city_muniTb.Rows.Add(893, 41, "Naga City");
                    city_muniTb.Rows.Add(894, 41, "Oslob");
                    city_muniTb.Rows.Add(895, 41, "Pilar");
                    city_muniTb.Rows.Add(896, 41, "Pinamungahan");
                    city_muniTb.Rows.Add(897, 41, "Poro");
                    city_muniTb.Rows.Add(898, 41, "Ronda");
                    city_muniTb.Rows.Add(899, 41, "Samboan");
                    city_muniTb.Rows.Add(900, 41, "San Fernando");
                    city_muniTb.Rows.Add(901, 41, "San Francisco");
                    city_muniTb.Rows.Add(902, 41, "San Remigio");
                    city_muniTb.Rows.Add(903, 41, "Santa Fe");
                    city_muniTb.Rows.Add(904, 41, "Santander");
                    city_muniTb.Rows.Add(905, 41, "Sibonga");
                    city_muniTb.Rows.Add(906, 41, "Sogod");
                    city_muniTb.Rows.Add(907, 41, "Tabogon");
                    city_muniTb.Rows.Add(908, 41, "Tabuelan");
                    city_muniTb.Rows.Add(909, 41, "Talisay City");
                    city_muniTb.Rows.Add(910, 41, "Toledo City");
                    city_muniTb.Rows.Add(911, 41, "Tuburan");
                    city_muniTb.Rows.Add(912, 41, "Tudela");
                }

                if (provinceCb.SelectedValue == "42")
                {
                    // Region Vii
                    // Negros Oriental
                    city_muniTb.Rows.Add(913, 42, "Amlan (Ayuquitan)");
                    city_muniTb.Rows.Add(914, 42, "Ayungon");
                    city_muniTb.Rows.Add(915, 42, "Bacong");
                    city_muniTb.Rows.Add(916, 42, "Bais City");
                    city_muniTb.Rows.Add(917, 42, "Basay");
                    city_muniTb.Rows.Add(918, 42, "Bayawan City (Tulong)");
                    city_muniTb.Rows.Add(919, 42, "Bindoy (Payabon)");
                    city_muniTb.Rows.Add(920, 42, "Canlaon City");
                    city_muniTb.Rows.Add(921, 42, "Dauin");
                    city_muniTb.Rows.Add(922, 42, "Dumaguete City");
                    city_muniTb.Rows.Add(923, 42, "Guihulngan City");
                    city_muniTb.Rows.Add(924, 42, "Jimalalud");
                    city_muniTb.Rows.Add(925, 42, "La Libertad");
                    city_muniTb.Rows.Add(926, 42, "Mabinay");
                    city_muniTb.Rows.Add(927, 42, "Manjuyod");
                    city_muniTb.Rows.Add(928, 42, "Pamplona");
                    city_muniTb.Rows.Add(929, 42, "San Jose");
                    city_muniTb.Rows.Add(930, 42, "Santa Catalina");
                    city_muniTb.Rows.Add(931, 42, "Siaton");
                    city_muniTb.Rows.Add(932, 42, "Sibulan");
                    city_muniTb.Rows.Add(933, 42, "Tanjay City");
                    city_muniTb.Rows.Add(934, 42, "Tayasan");
                    city_muniTb.Rows.Add(935, 42, "Valencia (Luzurriaga)");
                    city_muniTb.Rows.Add(936, 42, "Vallehermoso");
                    city_muniTb.Rows.Add(937, 42, "Zamboanguita");
                }

                if (provinceCb.SelectedValue == "43")
                {
                    // Region Vii
                    // Siquijor
                    city_muniTb.Rows.Add(938, 43, "Enrique Villanueva");
                    city_muniTb.Rows.Add(939, 43, "Larena");
                    city_muniTb.Rows.Add(940, 43, "Lazi");
                    city_muniTb.Rows.Add(941, 43, "Maria");
                    city_muniTb.Rows.Add(942, 43, "San Juan");
                    city_muniTb.Rows.Add(943, 43, "Siquijor");
                }

                if (provinceCb.SelectedValue == "44")
                {
                    // Region Viii
                    // Biliran
                    city_muniTb.Rows.Add(944, 44, "Almeria");
                    city_muniTb.Rows.Add(945, 44, "Biliran");
                    city_muniTb.Rows.Add(946, 44, "Cabucgayan");
                    city_muniTb.Rows.Add(947, 44, "Caibiran");
                    city_muniTb.Rows.Add(948, 44, "Culaba");
                    city_muniTb.Rows.Add(949, 44, "Kawayan");
                    city_muniTb.Rows.Add(950, 44, "Maripipi");
                    city_muniTb.Rows.Add(951, 44, "Naval");
                }

                if (provinceCb.SelectedValue == "45")
                {
                    // Region Viii
                    // Eastern Samar
                    city_muniTb.Rows.Add(952, 45, "Arteche");
                    city_muniTb.Rows.Add(953, 45, "Balangiga");
                    city_muniTb.Rows.Add(954, 45, "Balangkayan");
                    city_muniTb.Rows.Add(955, 45, "Borongan City");
                    city_muniTb.Rows.Add(956, 45, "Can-Avid");
                    city_muniTb.Rows.Add(957, 45, "Dolores");
                    city_muniTb.Rows.Add(958, 45, "General Macarthur");
                    city_muniTb.Rows.Add(959, 45, "Giporlos");
                    city_muniTb.Rows.Add(960, 45, "Guiuan");
                    city_muniTb.Rows.Add(961, 45, "Hernani");
                    city_muniTb.Rows.Add(962, 45, "Jipapad");
                    city_muniTb.Rows.Add(963, 45, "Lawaan");
                    city_muniTb.Rows.Add(964, 45, "Llorente");
                    city_muniTb.Rows.Add(965, 45, "Maslog");
                    city_muniTb.Rows.Add(966, 45, "Maydolong");
                    city_muniTb.Rows.Add(967, 45, "Mercedes");
                    city_muniTb.Rows.Add(968, 45, "Oras");
                    city_muniTb.Rows.Add(969, 45, "Quinapondan");
                    city_muniTb.Rows.Add(970, 45, "Salcedo");
                    city_muniTb.Rows.Add(971, 45, "San Julian");
                    city_muniTb.Rows.Add(972, 45, "San Policarpo");
                    city_muniTb.Rows.Add(973, 45, "Sulat");
                    city_muniTb.Rows.Add(974, 45, "Taft");
                }

                if (provinceCb.SelectedValue == "46")
                {
                    // Region Viii
                    // Leyte
                    city_muniTb.Rows.Add(975, 46, "Abuyog");
                    city_muniTb.Rows.Add(976, 46, "Alangalang");
                    city_muniTb.Rows.Add(977, 46, "Albuera");
                    city_muniTb.Rows.Add(978, 46, "Babatngon");
                    city_muniTb.Rows.Add(979, 46, "Barugo");
                    city_muniTb.Rows.Add(980, 46, "Bato");
                    city_muniTb.Rows.Add(981, 46, "Baybay City");
                    city_muniTb.Rows.Add(982, 46, "Burauen");
                    city_muniTb.Rows.Add(983, 46, "Calubian");
                    city_muniTb.Rows.Add(984, 46, "Capoocan");
                    city_muniTb.Rows.Add(985, 46, "Carigara");
                    city_muniTb.Rows.Add(986, 46, "Dagami");
                    city_muniTb.Rows.Add(987, 46, "Dulag");
                    city_muniTb.Rows.Add(988, 46, "Hilongos");
                    city_muniTb.Rows.Add(989, 46, "Hindang");
                    city_muniTb.Rows.Add(990, 46, "Inopacan");
                    city_muniTb.Rows.Add(991, 46, "Isabel");
                    city_muniTb.Rows.Add(992, 46, "Jaro");
                    city_muniTb.Rows.Add(993, 46, "Javier (Bugho)");
                    city_muniTb.Rows.Add(994, 46, "Julita");
                    city_muniTb.Rows.Add(995, 46, "Kananga");
                    city_muniTb.Rows.Add(996, 46, "La Paz");
                    city_muniTb.Rows.Add(997, 46, "Leyte");
                    city_muniTb.Rows.Add(998, 46, "Macarthur");
                    city_muniTb.Rows.Add(999, 46, "Mahaplag");
                    city_muniTb.Rows.Add(1000, 46, "Matag-Ob");
                    city_muniTb.Rows.Add(1001, 46, "Matalom");
                    city_muniTb.Rows.Add(1002, 46, "Mayorga");
                    city_muniTb.Rows.Add(1003, 46, "Merida");
                    city_muniTb.Rows.Add(1004, 46, "Ormoc City");
                    city_muniTb.Rows.Add(1005, 46, "Palo");
                    city_muniTb.Rows.Add(1006, 46, "Palompon");
                    city_muniTb.Rows.Add(1007, 46, "Pastrana");
                    city_muniTb.Rows.Add(1008, 46, "San Isidro");
                    city_muniTb.Rows.Add(1009, 46, "San Miguel");
                    city_muniTb.Rows.Add(1010, 46, "Santa Fe");
                    city_muniTb.Rows.Add(1011, 46, "Tabango");
                    city_muniTb.Rows.Add(1012, 46, "Tabontabon");
                    city_muniTb.Rows.Add(1013, 46, "Tacloban City");
                    city_muniTb.Rows.Add(1014, 46, "Tanauan");
                    city_muniTb.Rows.Add(1015, 46, "Tolosa");
                    city_muniTb.Rows.Add(1016, 46, "Tunga");
                    city_muniTb.Rows.Add(1017, 46, "Villaba");
                }

                if (provinceCb.SelectedValue == "47")
                {
                    // Region Viii
                    // Northern Samar
                    city_muniTb.Rows.Add(1018, 47, "Allen");
                    city_muniTb.Rows.Add(1019, 47, "Biri");
                    city_muniTb.Rows.Add(1020, 47, "Bobon");
                    city_muniTb.Rows.Add(1021, 47, "Capul");
                    city_muniTb.Rows.Add(1022, 47, "Catarman");
                    city_muniTb.Rows.Add(1023, 47, "Catubig");
                    city_muniTb.Rows.Add(1024, 47, "Gamay");
                    city_muniTb.Rows.Add(1025, 47, "Laoang");
                    city_muniTb.Rows.Add(1026, 47, "Lapinig");
                    city_muniTb.Rows.Add(1027, 47, "Las Navas");
                    city_muniTb.Rows.Add(1028, 47, "Lavezares");
                    city_muniTb.Rows.Add(1029, 47, "Lope De Vega");
                    city_muniTb.Rows.Add(1030, 47, "Mapanas");
                    city_muniTb.Rows.Add(1031, 47, "Mondragon");
                    city_muniTb.Rows.Add(1032, 47, "Palapag");
                    city_muniTb.Rows.Add(1033, 47, "Pambujan");
                    city_muniTb.Rows.Add(1034, 47, "Rosario");
                    city_muniTb.Rows.Add(1035, 47, "San Antonio");
                    city_muniTb.Rows.Add(1036, 47, "San Isidro");
                    city_muniTb.Rows.Add(1037, 47, "San Jose");
                    city_muniTb.Rows.Add(1038, 47, "San Roque");
                    city_muniTb.Rows.Add(1039, 47, "San Vicente");
                    city_muniTb.Rows.Add(1040, 47, "Silvino Lobos");
                    city_muniTb.Rows.Add(1041, 47, "Victoria");
                }

                if (provinceCb.SelectedValue == "48")
                {
                    // Region Viii
                    // Samar (Western Samar)
                    city_muniTb.Rows.Add(1042, 48, "Almagro");
                    city_muniTb.Rows.Add(1043, 48, "Basey");
                    city_muniTb.Rows.Add(1044, 48, "Calbayog City");
                    city_muniTb.Rows.Add(1045, 48, "Calbiga");
                    city_muniTb.Rows.Add(1046, 48, "Catbalogan City");
                    city_muniTb.Rows.Add(1047, 48, "Daram");
                    city_muniTb.Rows.Add(1048, 48, "Gandara");
                    city_muniTb.Rows.Add(1049, 48, "Hinabangan");
                    city_muniTb.Rows.Add(1050, 48, "Jiabong");
                    city_muniTb.Rows.Add(1051, 48, "Marabut");
                    city_muniTb.Rows.Add(1052, 48, "Matuguinao");
                    city_muniTb.Rows.Add(1053, 48, "Motiong");
                    city_muniTb.Rows.Add(1054, 48, "Pagsanghan");
                    city_muniTb.Rows.Add(1055, 48, "Paranas (Wright)");
                    city_muniTb.Rows.Add(1056, 48, "Pinabacdao");
                    city_muniTb.Rows.Add(1057, 48, "San Jorge");
                    city_muniTb.Rows.Add(1058, 48, "San Jose De Buan");
                    city_muniTb.Rows.Add(1059, 48, "San Sebastian");
                    city_muniTb.Rows.Add(1060, 48, "Santa Margarita");
                    city_muniTb.Rows.Add(1061, 48, "Santa Rita");
                    city_muniTb.Rows.Add(1062, 48, "Santo Niño");
                    city_muniTb.Rows.Add(1063, 48, "Tagapul-An");
                    city_muniTb.Rows.Add(1064, 48, "Talalora");
                    city_muniTb.Rows.Add(1065, 48, "Tarangnan");
                    city_muniTb.Rows.Add(1066, 48, "Villareal");
                    city_muniTb.Rows.Add(1067, 48, "Zumarraga");
                }

                if (provinceCb.SelectedValue == "49")
                {
                    // Region Viii
                    // Southern Leyte
                    city_muniTb.Rows.Add(1068, 49, "Anahawan");
                    city_muniTb.Rows.Add(1069, 49, "Bontoc");
                    city_muniTb.Rows.Add(1070, 49, "Hinunangan");
                    city_muniTb.Rows.Add(1071, 49, "Hinundayan");
                    city_muniTb.Rows.Add(1072, 49, "Libagon");
                    city_muniTb.Rows.Add(1073, 49, "Liloan");
                    city_muniTb.Rows.Add(1074, 49, "Limasawa");
                    city_muniTb.Rows.Add(1075, 49, "Maasin City");
                    city_muniTb.Rows.Add(1076, 49, "Macrohon");
                    city_muniTb.Rows.Add(1077, 49, "Malitbog");
                    city_muniTb.Rows.Add(1078, 49, "Padre Burgos");
                    city_muniTb.Rows.Add(1079, 49, "Pintuyan");
                    city_muniTb.Rows.Add(1080, 49, "Saint Bernard");
                    city_muniTb.Rows.Add(1081, 49, "San Francisco");
                    city_muniTb.Rows.Add(1082, 49, "San Juan (Cabalian)");
                    city_muniTb.Rows.Add(1083, 49, "San Ricardo");
                    city_muniTb.Rows.Add(1084, 49, "Silago");
                    city_muniTb.Rows.Add(1085, 49, "Sogod");
                    city_muniTb.Rows.Add(1086, 49, "Tomas Oppus");
                }

                if (provinceCb.SelectedValue == "50")
                {
                    // Region Ix
                    // Zamboanga Del Norte
                    city_muniTb.Rows.Add(1087, 50, "Bacungan (Leon T. Postigo)");
                    city_muniTb.Rows.Add(1088, 50, "Baliguian");
                    city_muniTb.Rows.Add(1089, 50, "Dapitan City");
                    city_muniTb.Rows.Add(1090, 50, "Dipolog City");
                    city_muniTb.Rows.Add(1091, 50, "Godod");
                    city_muniTb.Rows.Add(1092, 50, "Gutalac");
                    city_muniTb.Rows.Add(1093, 50, "Jose Dalman (Ponot)");
                    city_muniTb.Rows.Add(1094, 50, "Kalawit");
                    city_muniTb.Rows.Add(1095, 50, "Katipunan");
                    city_muniTb.Rows.Add(1096, 50, "La Libertad");
                    city_muniTb.Rows.Add(1097, 50, "Labason");
                    city_muniTb.Rows.Add(1098, 50, "Liloy");
                    city_muniTb.Rows.Add(1099, 50, "Manukan");
                    city_muniTb.Rows.Add(1100, 50, "Mutia");
                    city_muniTb.Rows.Add(1101, 50, "Piñan (New Piñan)");
                    city_muniTb.Rows.Add(1102, 50, "Polanco");
                    city_muniTb.Rows.Add(1103, 50, "Pres. Manuel A. Roxas");
                    city_muniTb.Rows.Add(1104, 50, "Rizal");
                    city_muniTb.Rows.Add(1105, 50, "Salug");
                    city_muniTb.Rows.Add(1106, 50, "Sergio Osmeña Sr.");
                    city_muniTb.Rows.Add(1107, 50, "Siayan");
                    city_muniTb.Rows.Add(1108, 50, "Sibuco");
                    city_muniTb.Rows.Add(1109, 50, "Sibutad");
                    city_muniTb.Rows.Add(1110, 50, "Sindangan");
                    city_muniTb.Rows.Add(1111, 50, "Siocon");
                    city_muniTb.Rows.Add(1112, 50, "Sirawai");
                    city_muniTb.Rows.Add(1113, 50, "Tampilisan");
                }

                if (provinceCb.SelectedValue == "51")
                {
                    // Region Ix
                    // Zamboanga Del Sur
                    city_muniTb.Rows.Add(1114, 51, "Aurora");
                    city_muniTb.Rows.Add(1115, 51, "Bayog");
                    city_muniTb.Rows.Add(1116, 51, "Dimataling");
                    city_muniTb.Rows.Add(1117, 51, "Dinas");
                    city_muniTb.Rows.Add(1118, 51, "Dumalinao");
                    city_muniTb.Rows.Add(1119, 51, "Dumingag");
                    city_muniTb.Rows.Add(1120, 51, "Guipos");
                    city_muniTb.Rows.Add(1121, 51, "Josefina");
                    city_muniTb.Rows.Add(1122, 51, "Kumalarang");
                    city_muniTb.Rows.Add(1123, 51, "Labangan");
                    city_muniTb.Rows.Add(1124, 51, "Lakewood");
                    city_muniTb.Rows.Add(1125, 51, "Lapuyan");
                    city_muniTb.Rows.Add(1126, 51, "Mahayag");
                    city_muniTb.Rows.Add(1127, 51, "Margosatubig");
                    city_muniTb.Rows.Add(1128, 51, "Midsalip");
                    city_muniTb.Rows.Add(1129, 51, "Molave");
                    city_muniTb.Rows.Add(1130, 51, "Pagadian City");
                    city_muniTb.Rows.Add(1131, 51, "Pitogo");
                    city_muniTb.Rows.Add(1132, 51, "Ramon Magsaysay (Liargo)");
                    city_muniTb.Rows.Add(1133, 51, "San Miguel");
                    city_muniTb.Rows.Add(1134, 51, "San Pablo");
                    city_muniTb.Rows.Add(1135, 51, "Sominot (Don Mariano Marcos)");
                    city_muniTb.Rows.Add(1136, 51, "Tabina");
                    city_muniTb.Rows.Add(1137, 51, "Tambulig");
                    city_muniTb.Rows.Add(1138, 51, "Tigbao");
                    city_muniTb.Rows.Add(1139, 51, "Tukuran");
                    city_muniTb.Rows.Add(1140, 51, "Vincenzo A. Sagun");
                    city_muniTb.Rows.Add(1141, 51, "Zamboanga City");
                }

                if (provinceCb.SelectedValue == "52")
                {
                    // Region Ix
                    // Zamboanga Sibugay
                    city_muniTb.Rows.Add(1142, 52, "Alicia");
                    city_muniTb.Rows.Add(1143, 52, "Buug");
                    city_muniTb.Rows.Add(1144, 52, "Diplahan");
                    city_muniTb.Rows.Add(1145, 52, "Imelda");
                    city_muniTb.Rows.Add(1146, 52, "Ipil");
                    city_muniTb.Rows.Add(1147, 52, "Kabasalan");
                    city_muniTb.Rows.Add(1148, 52, "Mabuhay");
                    city_muniTb.Rows.Add(1149, 52, "Malangas");
                    city_muniTb.Rows.Add(1150, 52, "Naga");
                    city_muniTb.Rows.Add(1151, 52, "Olutanga");
                    city_muniTb.Rows.Add(1152, 52, "Payao");
                    city_muniTb.Rows.Add(1153, 52, "Roseller Lim");
                    city_muniTb.Rows.Add(1154, 52, "Siay");
                    city_muniTb.Rows.Add(1155, 52, "Talusan");
                    city_muniTb.Rows.Add(1156, 52, "Titay");
                    city_muniTb.Rows.Add(1157, 52, "Tungawan");
                }

                if (provinceCb.SelectedValue == "53")
                {
                    // Region X
                    // Bukidnon
                    city_muniTb.Rows.Add(1158, 53, "Baungon");
                    city_muniTb.Rows.Add(1159, 53, "Cabanglasan");
                    city_muniTb.Rows.Add(1160, 53, "City Of Malaybalay");
                    city_muniTb.Rows.Add(1161, 53, "Damulog");
                    city_muniTb.Rows.Add(1162, 53, "Dangcagan");
                    city_muniTb.Rows.Add(1163, 53, "Don Carlos");
                    city_muniTb.Rows.Add(1164, 53, "Impasug-Ong");
                    city_muniTb.Rows.Add(1165, 53, "Kadingilan");
                    city_muniTb.Rows.Add(1166, 53, "Kalilangan");
                    city_muniTb.Rows.Add(1167, 53, "Kibawe");
                    city_muniTb.Rows.Add(1168, 53, "Kitaotao");
                    city_muniTb.Rows.Add(1169, 53, "Lantapan");
                    city_muniTb.Rows.Add(1170, 53, "Libona");
                    city_muniTb.Rows.Add(1171, 53, "Malitbog");
                    city_muniTb.Rows.Add(1172, 53, "Manolo Fortich");
                    city_muniTb.Rows.Add(1173, 53, "Maramag");
                    city_muniTb.Rows.Add(1174, 53, "Pangantucan");
                    city_muniTb.Rows.Add(1175, 53, "Quezon");
                    city_muniTb.Rows.Add(1176, 53, "San Fernando");
                    city_muniTb.Rows.Add(1177, 53, "Sumilao");
                    city_muniTb.Rows.Add(1178, 53, "Talakag");
                    city_muniTb.Rows.Add(1179, 53, "Valencia City");
                }

                if (provinceCb.SelectedValue == "54")
                {
                    // Region X
                    // Camiguin
                    city_muniTb.Rows.Add(1180, 54, "Catarman");
                    city_muniTb.Rows.Add(1181, 54, "Guinsiliban");
                    city_muniTb.Rows.Add(1182, 54, "Mahinog");
                    city_muniTb.Rows.Add(1183, 54, "Mambajao");
                    city_muniTb.Rows.Add(1184, 54, "Sagay");
                }

                if (provinceCb.SelectedValue == "55")
                {
                    // Region X
                    // Lanao Del Norte
                    city_muniTb.Rows.Add(1185, 55, "Bacolod");
                    city_muniTb.Rows.Add(1186, 55, "Baloi");
                    city_muniTb.Rows.Add(1187, 55, "Baroy");
                    city_muniTb.Rows.Add(1188, 55, "Iligan City");
                    city_muniTb.Rows.Add(1189, 55, "Kapatagan");
                    city_muniTb.Rows.Add(1190, 55, "Kauswagan");
                    city_muniTb.Rows.Add(1191, 55, "Kolambugan");
                    city_muniTb.Rows.Add(1192, 55, "Lala");
                    city_muniTb.Rows.Add(1193, 55, "Linamon");
                    city_muniTb.Rows.Add(1194, 55, "Magsaysay");
                    city_muniTb.Rows.Add(1195, 55, "Maigo");
                    city_muniTb.Rows.Add(1196, 55, "Matungao");
                    city_muniTb.Rows.Add(1197, 55, "Munai");
                    city_muniTb.Rows.Add(1198, 55, "Nunungan");
                    city_muniTb.Rows.Add(1199, 55, "Pantao Ragat");
                    city_muniTb.Rows.Add(1200, 55, "Pantar");
                    city_muniTb.Rows.Add(1201, 55, "Poona Piagapo");
                    city_muniTb.Rows.Add(1202, 55, "Salvador");
                    city_muniTb.Rows.Add(1203, 55, "Sapad");
                    city_muniTb.Rows.Add(1204, 55, "Sultan Naga Dimaporo (Karomatan)");
                    city_muniTb.Rows.Add(1205, 55, "Tagoloan");
                    city_muniTb.Rows.Add(1206, 55, "Tangcal");
                    city_muniTb.Rows.Add(1207, 55, "Tubod");
                }

                if (provinceCb.SelectedValue == "56")
                {
                    // Region X
                    // Misamis Occidental
                    city_muniTb.Rows.Add(1208, 56, "Aloran");
                    city_muniTb.Rows.Add(1209, 56, "Baliangao");
                    city_muniTb.Rows.Add(1210, 56, "Bonifacio");
                    city_muniTb.Rows.Add(1211, 56, "Calamba");
                    city_muniTb.Rows.Add(1212, 56, "Clarin");
                    city_muniTb.Rows.Add(1213, 56, "Concepcion");
                    city_muniTb.Rows.Add(1214, 56, "Don Victoriano Chiongbian (Don Mariano Marcos)");
                    city_muniTb.Rows.Add(1215, 56, "Jimenez");
                    city_muniTb.Rows.Add(1216, 56, "Lopez Jaena");
                    city_muniTb.Rows.Add(1217, 56, "Oroquieta City");
                    city_muniTb.Rows.Add(1218, 56, "Ozamis City");
                    city_muniTb.Rows.Add(1219, 56, "Panaon");
                    city_muniTb.Rows.Add(1220, 56, "Plaridel");
                    city_muniTb.Rows.Add(1221, 56, "Sapang Dalaga");
                    city_muniTb.Rows.Add(1222, 56, "Sinacaban");
                    city_muniTb.Rows.Add(1223, 56, "Tangub City");
                    city_muniTb.Rows.Add(1224, 56, "Tudela");
                }

                if (provinceCb.SelectedValue == "57")
                {
                    // Region X
                    // Misamis Oriental
                    city_muniTb.Rows.Add(1225, 57, "Alubijid");
                    city_muniTb.Rows.Add(1226, 57, "Balingasag");
                    city_muniTb.Rows.Add(1227, 57, "Balingoan");
                    city_muniTb.Rows.Add(1228, 57, "Binuangan");
                    city_muniTb.Rows.Add(1229, 57, "Cagayan De Oro City");
                    city_muniTb.Rows.Add(1230, 57, "Claveria");
                    city_muniTb.Rows.Add(1231, 57, "El Salvador City");
                    city_muniTb.Rows.Add(1232, 57, "Gingoog City");
                    city_muniTb.Rows.Add(1233, 57, "Gitagum");
                    city_muniTb.Rows.Add(1234, 57, "Initao");
                    city_muniTb.Rows.Add(1235, 57, "Jasaan");
                    city_muniTb.Rows.Add(1236, 57, "Kinoguitan");
                    city_muniTb.Rows.Add(1237, 57, "Lagonglong");
                    city_muniTb.Rows.Add(1238, 57, "Laguindingan");
                    city_muniTb.Rows.Add(1239, 57, "Libertad");
                    city_muniTb.Rows.Add(1240, 57, "Lugait");
                    city_muniTb.Rows.Add(1241, 57, "Magsaysay (Linugos)");
                    city_muniTb.Rows.Add(1242, 57, "Manticao");
                    city_muniTb.Rows.Add(1243, 57, "Medina");
                    city_muniTb.Rows.Add(1244, 57, "Naawan");
                    city_muniTb.Rows.Add(1245, 57, "Opol");
                    city_muniTb.Rows.Add(1246, 57, "Salay");
                    city_muniTb.Rows.Add(1247, 57, "Sugbongcogon");
                    city_muniTb.Rows.Add(1248, 57, "Tagoloan");
                    city_muniTb.Rows.Add(1249, 57, "Talisayan");
                    city_muniTb.Rows.Add(1250, 57, "Villanueva");
                }

                if (provinceCb.SelectedValue == "58")
                {
                    // Region Xi
                    // Compostela Valley
                    city_muniTb.Rows.Add(1251, 58, "Compostela");
                    city_muniTb.Rows.Add(1252, 58, "Laak (San Vicente)");
                    city_muniTb.Rows.Add(1253, 58, "Mabini (Doña Alicia)");
                    city_muniTb.Rows.Add(1254, 58, "Maco");
                    city_muniTb.Rows.Add(1255, 58, "Maragusan (San Mariano)");
                    city_muniTb.Rows.Add(1256, 58, "Mawab");
                    city_muniTb.Rows.Add(1257, 58, "Monkayo");
                    city_muniTb.Rows.Add(1258, 58, "Montevista");
                    city_muniTb.Rows.Add(1259, 58, "Nabunturan");
                    city_muniTb.Rows.Add(1260, 58, "New Bataan");
                    city_muniTb.Rows.Add(1261, 58, "Pantukan");
                }

                if (provinceCb.SelectedValue == "59")
                {
                    // Region Xi
                    // Davao (Davao Del Norte)
                    city_muniTb.Rows.Add(1262, 59, "Asuncion (Saug)");
                    city_muniTb.Rows.Add(1263, 59, "Braulio E. Dujali");
                    city_muniTb.Rows.Add(1264, 59, "Carmen");
                    city_muniTb.Rows.Add(1265, 59, "City Of Tagum");
                    city_muniTb.Rows.Add(1266, 59, "Island Garden City Of Samal");
                    city_muniTb.Rows.Add(1267, 59, "Kapalong");
                    city_muniTb.Rows.Add(1268, 59, "New Corella");
                    city_muniTb.Rows.Add(1269, 59, "Panabo City");
                    city_muniTb.Rows.Add(1270, 59, "San Isidro");
                    city_muniTb.Rows.Add(1271, 59, "Santo Tomas");
                    city_muniTb.Rows.Add(1272, 59, "Talaingod");
                }

                if (provinceCb.SelectedValue == "60")
                {
                    // Region Xi
                    // Davao Del Sur
                    city_muniTb.Rows.Add(1273, 60, "Bansalan");
                    city_muniTb.Rows.Add(1274, 60, "Davao City");
                    city_muniTb.Rows.Add(1275, 60, "Digos City");
                    city_muniTb.Rows.Add(1276, 60, "Hagonoy");
                    city_muniTb.Rows.Add(1277, 60, "Kiblawan");
                    city_muniTb.Rows.Add(1278, 60, "Magsaysay");
                    city_muniTb.Rows.Add(1279, 60, "Malalag");
                    city_muniTb.Rows.Add(1280, 60, "Matanao");
                    city_muniTb.Rows.Add(1281, 60, "Padada");
                    city_muniTb.Rows.Add(1282, 60, "Santa Cruz");
                    city_muniTb.Rows.Add(1283, 60, "Sulop");
                }

                if (provinceCb.SelectedValue == "61")
                {
                    // Region Xi
                    // Davao Occidental
                    city_muniTb.Rows.Add(1284, 61, "Don Marcelino");
                    city_muniTb.Rows.Add(1285, 61, "Jose Abad Santos (Trinidad)");
                    city_muniTb.Rows.Add(1286, 61, "Malita");
                    city_muniTb.Rows.Add(1287, 61, "Santa Maria");
                    city_muniTb.Rows.Add(1288, 61, "Sarangani");
                }

                if (provinceCb.SelectedValue == "62")
                {
                    // Region Xi
                    // Davao Oriental
                    city_muniTb.Rows.Add(1289, 62, "Baganga");
                    city_muniTb.Rows.Add(1290, 62, "Banaybanay");
                    city_muniTb.Rows.Add(1291, 62, "Boston");
                    city_muniTb.Rows.Add(1292, 62, "Caraga");
                    city_muniTb.Rows.Add(1293, 62, "Cateel");
                    city_muniTb.Rows.Add(1294, 62, "Governor Generoso");
                    city_muniTb.Rows.Add(1295, 62, "Lupon");
                    city_muniTb.Rows.Add(1296, 62, "Manay");
                    city_muniTb.Rows.Add(1297, 62, "Mati City");
                    city_muniTb.Rows.Add(1298, 62, "San Isidro");
                    city_muniTb.Rows.Add(1299, 62, "Tarragona");
                }

                if (provinceCb.SelectedValue == "63")
                {
                    // Region Xii
                    // Cotabato (North Cot.)
                    city_muniTb.Rows.Add(1300, 63, "Alamada");
                    city_muniTb.Rows.Add(1301, 63, "Aleosan");
                    city_muniTb.Rows.Add(1302, 63, "Antipas");
                    city_muniTb.Rows.Add(1303, 63, "Arakan");
                    city_muniTb.Rows.Add(1304, 63, "Banisilan");
                    city_muniTb.Rows.Add(1305, 63, "Carmen");
                    city_muniTb.Rows.Add(1306, 63, "City Of Kidapawan");
                    city_muniTb.Rows.Add(1307, 63, "Kabacan");
                    city_muniTb.Rows.Add(1308, 63, "Libungan");
                    city_muniTb.Rows.Add(1309, 63, "M'Lang");
                    city_muniTb.Rows.Add(1310, 63, "Magpet");
                    city_muniTb.Rows.Add(1311, 63, "Makilala");
                    city_muniTb.Rows.Add(1312, 63, "Matalam");
                    city_muniTb.Rows.Add(1313, 63, "Midsayap");
                    city_muniTb.Rows.Add(1314, 63, "Pigkawayan");
                    city_muniTb.Rows.Add(1315, 63, "Pikit");
                    city_muniTb.Rows.Add(1316, 63, "President Roxas");
                    city_muniTb.Rows.Add(1317, 63, "Tulunan");
                }

                if (provinceCb.SelectedValue == "64")
                {
                    // Region Xii
                    // Sarangani
                    city_muniTb.Rows.Add(1318, 64, "Alabel");
                    city_muniTb.Rows.Add(1319, 64, "Glan");
                    city_muniTb.Rows.Add(1320, 64, "Kiamba");
                    city_muniTb.Rows.Add(1321, 64, "Maasim");
                    city_muniTb.Rows.Add(1322, 64, "Maitum");
                    city_muniTb.Rows.Add(1323, 64, "Malapatan");
                    city_muniTb.Rows.Add(1324, 64, "Malungon");
                }

                if (provinceCb.SelectedValue == "65")
                {
                    // Region Xii
                    // South Cotabato
                    city_muniTb.Rows.Add(1325, 65, "Banga");
                    city_muniTb.Rows.Add(1326, 65, "General Santos City (Dadiangas)");
                    city_muniTb.Rows.Add(1327, 65, "Koronadal City");
                    city_muniTb.Rows.Add(1328, 65, "Lake Sebu");
                    city_muniTb.Rows.Add(1329, 65, "Norala");
                    city_muniTb.Rows.Add(1330, 65, "Polomolok");
                    city_muniTb.Rows.Add(1331, 65, "Santo Niño");
                    city_muniTb.Rows.Add(1332, 65, "Surallah");
                    city_muniTb.Rows.Add(1333, 65, "T`Boli");
                    city_muniTb.Rows.Add(1334, 65, "Tampakan");
                    city_muniTb.Rows.Add(1335, 65, "Tantangan");
                    city_muniTb.Rows.Add(1336, 65, "Tupi");
                }

                if (provinceCb.SelectedValue == "66")
                {
                    // Region Xii
                    // Sultan Kudarat
                    city_muniTb.Rows.Add(1337, 66, "Bagumbayan");
                    city_muniTb.Rows.Add(1338, 66, "Columbio");
                    city_muniTb.Rows.Add(1339, 66, "Esperanza");
                    city_muniTb.Rows.Add(1340, 66, "Isulan");
                    city_muniTb.Rows.Add(1341, 66, "Kalamansig");
                    city_muniTb.Rows.Add(1342, 66, "Lambayong (Mariano Marcos)");
                    city_muniTb.Rows.Add(1343, 66, "Lebak");
                    city_muniTb.Rows.Add(1344, 66, "Lutayan");
                    city_muniTb.Rows.Add(1345, 66, "Palimbang");
                    city_muniTb.Rows.Add(1346, 66, "President Quirino");
                    city_muniTb.Rows.Add(1347, 66, "Sen. Ninoy Aquino");
                    city_muniTb.Rows.Add(1348, 66, "Tacurong City");
                }

                if (provinceCb.SelectedValue == "67")
                {
                    // Region Xiii
                    // Agusan Del Norte
                    city_muniTb.Rows.Add(1349, 67, "Buenavista");
                    city_muniTb.Rows.Add(1350, 67, "Butuan City");
                    city_muniTb.Rows.Add(1351, 67, "Cabadbaran City");
                    city_muniTb.Rows.Add(1352, 67, "Carmen");
                    city_muniTb.Rows.Add(1353, 67, "Jabonga");
                    city_muniTb.Rows.Add(1354, 67, "Kitcharao");
                    city_muniTb.Rows.Add(1355, 67, "Las Nieves");
                    city_muniTb.Rows.Add(1356, 67, "Magallanes");
                    city_muniTb.Rows.Add(1357, 67, "Nasipit");
                    city_muniTb.Rows.Add(1358, 67, "Remedios T. Romualdez");
                    city_muniTb.Rows.Add(1359, 67, "Santiago");
                    city_muniTb.Rows.Add(1360, 67, "Tubay");
                }

                if (provinceCb.SelectedValue == "68")
                {
                    // Region Xiii
                    // Agusan Del Sur
                    city_muniTb.Rows.Add(1361, 68, "Bayugan City");
                    city_muniTb.Rows.Add(1362, 68, "Bunawan");
                    city_muniTb.Rows.Add(1363, 68, "Esperanza");
                    city_muniTb.Rows.Add(1364, 68, "La Paz");
                    city_muniTb.Rows.Add(1365, 68, "Loreto");
                    city_muniTb.Rows.Add(1366, 68, "Prosperidad");
                    city_muniTb.Rows.Add(1367, 68, "Rosario");
                    city_muniTb.Rows.Add(1368, 68, "San Francisco");
                    city_muniTb.Rows.Add(1369, 68, "San Luis");
                    city_muniTb.Rows.Add(1370, 68, "Santa Josefa");
                    city_muniTb.Rows.Add(1371, 68, "Sibagat");
                    city_muniTb.Rows.Add(1372, 68, "Talacogon");
                    city_muniTb.Rows.Add(1373, 68, "Trento");
                    city_muniTb.Rows.Add(1374, 68, "Veruela");
                }

                if (provinceCb.SelectedValue == "69")
                {
                    // Region Xiii
                    // Dinagat Islands
                    city_muniTb.Rows.Add(1375, 69, "Basilisa (Rizal)");
                    city_muniTb.Rows.Add(1376, 69, "Cagdianao");
                    city_muniTb.Rows.Add(1377, 69, "Dinagat");
                    city_muniTb.Rows.Add(1378, 69, "Libjo (Albor)");
                    city_muniTb.Rows.Add(1379, 69, "Loreto");
                    city_muniTb.Rows.Add(1380, 69, "San Jose");
                    city_muniTb.Rows.Add(1381, 69, "Tubajon");
                }

                if (provinceCb.SelectedValue == "70")
                {
                    // Region Xiii
                    // Surigao Del Norte
                    city_muniTb.Rows.Add(1382, 70, "Alegria");
                    city_muniTb.Rows.Add(1383, 70, "Bacuag");
                    city_muniTb.Rows.Add(1384, 70, "Burgos");
                    city_muniTb.Rows.Add(1385, 70, "Claver");
                    city_muniTb.Rows.Add(1386, 70, "Dapa");
                    city_muniTb.Rows.Add(1387, 70, "Del Carmen");
                    city_muniTb.Rows.Add(1388, 70, "General Luna");
                    city_muniTb.Rows.Add(1389, 70, "Gigaquit");
                    city_muniTb.Rows.Add(1390, 70, "Mainit");
                    city_muniTb.Rows.Add(1391, 70, "Malimono");
                    city_muniTb.Rows.Add(1392, 70, "Pilar");
                    city_muniTb.Rows.Add(1393, 70, "Placer");
                    city_muniTb.Rows.Add(1394, 70, "San Benito");
                    city_muniTb.Rows.Add(1395, 70, "San Francisco (Anao-Aon)");
                    city_muniTb.Rows.Add(1396, 70, "San Isidro");
                    city_muniTb.Rows.Add(1397, 70, "Santa Monica (Sapao)");
                    city_muniTb.Rows.Add(1398, 70, "Sison");
                    city_muniTb.Rows.Add(1399, 70, "Socorro");
                    city_muniTb.Rows.Add(1400, 70, "Surigao City");
                    city_muniTb.Rows.Add(1401, 70, "Tagana-An");
                    city_muniTb.Rows.Add(1402, 70, "Tubod");
                }

                if (provinceCb.SelectedValue == "71")
                {
                    // Region Xiii
                    // Surigao Del Sur
                    city_muniTb.Rows.Add(1403, 71, "Barobo");
                    city_muniTb.Rows.Add(1404, 71, "Bayabas");
                    city_muniTb.Rows.Add(1405, 71, "Bislig City");
                    city_muniTb.Rows.Add(1406, 71, "Cagwait");
                    city_muniTb.Rows.Add(1407, 71, "Cantilan");
                    city_muniTb.Rows.Add(1408, 71, "Carmen");
                    city_muniTb.Rows.Add(1409, 71, "Carrascal");
                    city_muniTb.Rows.Add(1410, 71, "Cortes");
                    city_muniTb.Rows.Add(1411, 71, "Hinatuan");
                    city_muniTb.Rows.Add(1412, 71, "Lanuza");
                    city_muniTb.Rows.Add(1413, 71, "Lianga");
                    city_muniTb.Rows.Add(1414, 71, "Lingig");
                    city_muniTb.Rows.Add(1415, 71, "Madrid");
                    city_muniTb.Rows.Add(1416, 71, "Marihatag");
                    city_muniTb.Rows.Add(1417, 71, "San Agustin");
                    city_muniTb.Rows.Add(1418, 71, "San Miguel");
                    city_muniTb.Rows.Add(1419, 71, "Tagbina");
                    city_muniTb.Rows.Add(1420, 71, "Tago");
                    city_muniTb.Rows.Add(1421, 71, "Tandag City");
                }

                if (provinceCb.SelectedValue == "72")
                {
                    // Barmm
                    // Basilan
                    city_muniTb.Rows.Add(1422, 72, "Akbar");
                    city_muniTb.Rows.Add(1423, 72, "Al-Barka");
                    city_muniTb.Rows.Add(1424, 72, "Hadji Mohammad Ajul");
                    city_muniTb.Rows.Add(1425, 72, "Hadji Muhtamad");
                    city_muniTb.Rows.Add(1426, 72, "Isabela City");
                    city_muniTb.Rows.Add(1427, 72, "Lamitan City");
                    city_muniTb.Rows.Add(1428, 72, "Lantawan");
                    city_muniTb.Rows.Add(1429, 72, "Maluso");
                    city_muniTb.Rows.Add(1430, 72, "Sumisip");
                    city_muniTb.Rows.Add(1431, 72, "Tabuan-Lasa");
                    city_muniTb.Rows.Add(1432, 72, "Tipo-Tipo");
                    city_muniTb.Rows.Add(1433, 72, "Tuburan");
                    city_muniTb.Rows.Add(1434, 72, "Ungkaya Pukan");
                }

                if (provinceCb.SelectedValue == "73")
                {
                    // Barmm
                    // Lanao Del Sur
                    city_muniTb.Rows.Add(1435, 73, "Amai Manabilang (Bumbaran)");
                    city_muniTb.Rows.Add(1436, 73, "Bacolod-Kalawi (Bacolod Grande)");
                    city_muniTb.Rows.Add(1437, 73, "Balabagan");
                    city_muniTb.Rows.Add(1438, 73, "Balindong (Watu)");
                    city_muniTb.Rows.Add(1439, 73, "Bayang");
                    city_muniTb.Rows.Add(1440, 73, "Binidayan");
                    city_muniTb.Rows.Add(1441, 73, "Buadiposo-Buntong");
                    city_muniTb.Rows.Add(1442, 73, "Bubong");
                    city_muniTb.Rows.Add(1443, 73, "Butig");
                    city_muniTb.Rows.Add(1444, 73, "Calanogas");
                    city_muniTb.Rows.Add(1445, 73, "Ditsaan-Ramain");
                    city_muniTb.Rows.Add(1446, 73, "Ganassi");
                    city_muniTb.Rows.Add(1447, 73, "Kapai");
                    city_muniTb.Rows.Add(1448, 73, "Kapatagan");
                    city_muniTb.Rows.Add(1449, 73, "Lumba-Bayabao (Maguing)");
                    city_muniTb.Rows.Add(1450, 73, "Lumbaca-Unayan");
                    city_muniTb.Rows.Add(1451, 73, "Lumbatan");
                    city_muniTb.Rows.Add(1452, 73, "Lumbayanague");
                    city_muniTb.Rows.Add(1453, 73, "Madalum");
                    city_muniTb.Rows.Add(1454, 73, "Madamba");
                    city_muniTb.Rows.Add(1455, 73, "Maguing");
                    city_muniTb.Rows.Add(1456, 73, "Malabang");
                    city_muniTb.Rows.Add(1457, 73, "Marantao");
                    city_muniTb.Rows.Add(1458, 73, "Marawi City");
                    city_muniTb.Rows.Add(1459, 73, "Marogong");
                    city_muniTb.Rows.Add(1460, 73, "Masiu");
                    city_muniTb.Rows.Add(1461, 73, "Mulondo");
                    city_muniTb.Rows.Add(1462, 73, "Pagayawan (Tatarikan)");
                    city_muniTb.Rows.Add(1463, 73, "Piagapo");
                    city_muniTb.Rows.Add(1464, 73, "Picong (Sultan Gumander)");
                    city_muniTb.Rows.Add(1465, 73, "Poona Bayabao (Gata)");
                    city_muniTb.Rows.Add(1466, 73, "Pualas");
                    city_muniTb.Rows.Add(1467, 73, "Saguiaran");
                    city_muniTb.Rows.Add(1468, 73, "Sultan Dumalondong");
                    city_muniTb.Rows.Add(1469, 73, "Tagoloan");
                    city_muniTb.Rows.Add(1470, 73, "Tamparan");
                    city_muniTb.Rows.Add(1471, 73, "Taraka");
                    city_muniTb.Rows.Add(1472, 73, "Tubaran");
                    city_muniTb.Rows.Add(1473, 73, "Tugaya");
                    city_muniTb.Rows.Add(1474, 73, "Wao");
                }

                if (provinceCb.SelectedValue == "74")
                {
                    // Barmm
                    // Maguindanao
                    city_muniTb.Rows.Add(1475, 74, "Ampatuan");
                    city_muniTb.Rows.Add(1476, 74, "Barira");
                    city_muniTb.Rows.Add(1477, 74, "Buldon");
                    city_muniTb.Rows.Add(1478, 74, "Buluan");
                    city_muniTb.Rows.Add(1479, 74, "Cotabato City");
                    city_muniTb.Rows.Add(1480, 74, "Datu Abdullah Sangki");
                    city_muniTb.Rows.Add(1481, 74, "Datu Anggal Midtimbang");
                    city_muniTb.Rows.Add(1482, 74, "Datu Blah T. Sinsuat");
                    city_muniTb.Rows.Add(1483, 74, "Datu Hoffer Ampatuan");
                    city_muniTb.Rows.Add(1484, 74, "Datu Odin Sinsuat (Dinaig)");
                    city_muniTb.Rows.Add(1485, 74, "Datu Paglas");
                    city_muniTb.Rows.Add(1486, 74, "Datu Piang");
                    city_muniTb.Rows.Add(1487, 74, "Datu Salibo");
                    city_muniTb.Rows.Add(1488, 74, "Datu Saudi Ampatuan");
                    city_muniTb.Rows.Add(1489, 74, "Datu Unsay");
                    city_muniTb.Rows.Add(1490, 74, "Gen. S. K. Pendatun");
                    city_muniTb.Rows.Add(1491, 74, "Guindulungan");
                    city_muniTb.Rows.Add(1492, 74, "Kabuntalan (Tumbao)");
                    city_muniTb.Rows.Add(1493, 74, "Mamasapano");
                    city_muniTb.Rows.Add(1494, 74, "Mangudadatu");
                    city_muniTb.Rows.Add(1495, 74, "Matanog");
                    city_muniTb.Rows.Add(1496, 74, "Northern Kabuntalan");
                    city_muniTb.Rows.Add(1497, 74, "Pagagawan");
                    city_muniTb.Rows.Add(1498, 74, "Pagalungan");
                    city_muniTb.Rows.Add(1499, 74, "Paglat");
                    city_muniTb.Rows.Add(1500, 74, "Pandag");
                    city_muniTb.Rows.Add(1501, 74, "Parang");
                    city_muniTb.Rows.Add(1502, 74, "Rajah Buayan");
                    city_muniTb.Rows.Add(1503, 74, "Shariff Aguak (Maganoy)");
                    city_muniTb.Rows.Add(1504, 74, "Shariff Saydona Mustapha");
                    city_muniTb.Rows.Add(1505, 74, "South Upi");
                    city_muniTb.Rows.Add(1506, 74, "Sultan Kudarat (Nuling)");
                    city_muniTb.Rows.Add(1507, 74, "Sultan Mastura");
                    city_muniTb.Rows.Add(1508, 74, "Sultan Sa Barongis (Lambayong)");
                    city_muniTb.Rows.Add(1509, 74, "Talayan");
                    city_muniTb.Rows.Add(1510, 74, "Talitay");
                    city_muniTb.Rows.Add(1511, 74, "Upi");
                }

                if (provinceCb.SelectedValue == "75")
                {
                    // Barmm
                    // Sulu
                    city_muniTb.Rows.Add(1512, 75, "Hadji Panglima Tahil (Marunggas)");
                    city_muniTb.Rows.Add(1513, 75, "Indanan");
                    city_muniTb.Rows.Add(1514, 75, "Jolo");
                    city_muniTb.Rows.Add(1515, 75, "Kalingalan Caluang");
                    city_muniTb.Rows.Add(1516, 75, "Lugus");
                    city_muniTb.Rows.Add(1517, 75, "Luuk");
                    city_muniTb.Rows.Add(1518, 75, "Maimbung");
                    city_muniTb.Rows.Add(1519, 75, "Old Panamao");
                    city_muniTb.Rows.Add(1520, 75, "Omar");
                    city_muniTb.Rows.Add(1521, 75, "Pandami");
                    city_muniTb.Rows.Add(1522, 75, "Panglima Estino (New Panamao)");
                    city_muniTb.Rows.Add(1523, 75, "Pangutaran");
                    city_muniTb.Rows.Add(1524, 75, "Parang");
                    city_muniTb.Rows.Add(1525, 75, "Pata");
                    city_muniTb.Rows.Add(1526, 75, "Patikul");
                    city_muniTb.Rows.Add(1527, 75, "Siasi");
                    city_muniTb.Rows.Add(1528, 75, "Talipao");
                    city_muniTb.Rows.Add(1529, 75, "Tapul");
                    city_muniTb.Rows.Add(1530, 75, "Tongkil");
                }

                if (provinceCb.SelectedValue == "76")
                {
                    // Barmm
                    // Tawi-Tawi
                    city_muniTb.Rows.Add(1531, 76, "Bongao");
                    city_muniTb.Rows.Add(1532, 76, "Languyan");
                    city_muniTb.Rows.Add(1533, 76, "Mapun (Cagayan De Tawi-Tawi)");
                    city_muniTb.Rows.Add(1534, 76, "Panglima Sugala (Balimbing)");
                    city_muniTb.Rows.Add(1535, 76, "Sapa-Sapa");
                    city_muniTb.Rows.Add(1536, 76, "Sibutu");
                    city_muniTb.Rows.Add(1537, 76, "Simunul");
                    city_muniTb.Rows.Add(1538, 76, "Sitangkai");
                    city_muniTb.Rows.Add(1539, 76, "South Ubian");
                    city_muniTb.Rows.Add(1540, 76, "Tandubas");
                    city_muniTb.Rows.Add(1541, 76, "Turtle Islands");
                }

                if (provinceCb.SelectedValue == "77")
                {
                    // Car
                    // Abra
                    city_muniTb.Rows.Add(1542, 77, "Bangued");
                    city_muniTb.Rows.Add(1543, 77, "Boliney");
                    city_muniTb.Rows.Add(1544, 77, "Bucay");
                    city_muniTb.Rows.Add(1545, 77, "Bucloc");
                    city_muniTb.Rows.Add(1546, 77, "Daguioman");
                    city_muniTb.Rows.Add(1547, 77, "Danglas");
                    city_muniTb.Rows.Add(1548, 77, "Dolores");
                    city_muniTb.Rows.Add(1549, 77, "La Paz");
                    city_muniTb.Rows.Add(1550, 77, "Lacub");
                    city_muniTb.Rows.Add(1551, 77, "Lagangilang");
                    city_muniTb.Rows.Add(1552, 77, "Lagayan");
                    city_muniTb.Rows.Add(1553, 77, "Langiden");
                    city_muniTb.Rows.Add(1554, 77, "Licuan-Baay (Licuan)");
                    city_muniTb.Rows.Add(1555, 77, "Luba");
                    city_muniTb.Rows.Add(1556, 77, "Malibcong");
                    city_muniTb.Rows.Add(1557, 77, "Manabo");
                    city_muniTb.Rows.Add(1558, 77, "Peñarrubia");
                    city_muniTb.Rows.Add(1559, 77, "Pidigan");
                    city_muniTb.Rows.Add(1560, 77, "Pilar");
                    city_muniTb.Rows.Add(1561, 77, "Sallapadan");
                    city_muniTb.Rows.Add(1562, 77, "San Isidro");
                    city_muniTb.Rows.Add(1563, 77, "San Juan");
                    city_muniTb.Rows.Add(1564, 77, "San Quintin");
                    city_muniTb.Rows.Add(1565, 77, "Tayum");
                    city_muniTb.Rows.Add(1566, 77, "Tineg");
                    city_muniTb.Rows.Add(1567, 77, "Tubo");
                    city_muniTb.Rows.Add(1568, 77, "Villaviciosa");
                }

                if (provinceCb.SelectedValue == "78")
                {
                    // Car
                    // Apayao
                    city_muniTb.Rows.Add(1569, 78, "Calanasan (Bayag)");
                    city_muniTb.Rows.Add(1570, 78, "Conner");
                    city_muniTb.Rows.Add(1571, 78, "Flora");
                    city_muniTb.Rows.Add(1572, 78, "Kabugao");
                    city_muniTb.Rows.Add(1573, 78, "Luna");
                    city_muniTb.Rows.Add(1574, 78, "Pudtol");
                    city_muniTb.Rows.Add(1575, 78, "Santa Marcela");
                }

                if (provinceCb.SelectedValue == "79")
                {
                    // Car
                    // Benguet
                    city_muniTb.Rows.Add(1576, 79, "Atok");
                    city_muniTb.Rows.Add(1577, 79, "Baguio City");
                    city_muniTb.Rows.Add(1578, 79, "Bakun");
                    city_muniTb.Rows.Add(1579, 79, "Bokod");
                    city_muniTb.Rows.Add(1580, 79, "Buguias");
                    city_muniTb.Rows.Add(1581, 79, "Itogon");
                    city_muniTb.Rows.Add(1582, 79, "Kabayan");
                    city_muniTb.Rows.Add(1583, 79, "Kapangan");
                    city_muniTb.Rows.Add(1584, 79, "Kibungan");
                    city_muniTb.Rows.Add(1585, 79, "La Trinidad");
                    city_muniTb.Rows.Add(1586, 79, "Mankayan");
                    city_muniTb.Rows.Add(1587, 79, "Sablan");
                    city_muniTb.Rows.Add(1588, 79, "Tuba");
                    city_muniTb.Rows.Add(1589, 79, "Tublay");
                }

                if (provinceCb.SelectedValue == "80")
                {
                    // Car
                    // Ifugao
                    city_muniTb.Rows.Add(1590, 80, "Aguinaldo");
                    city_muniTb.Rows.Add(1591, 80, "Alfonso Lista (Potia)");
                    city_muniTb.Rows.Add(1592, 80, "Asipulo");
                    city_muniTb.Rows.Add(1593, 80, "Banaue");
                    city_muniTb.Rows.Add(1594, 80, "Hingyon");
                    city_muniTb.Rows.Add(1595, 80, "Hungduan");
                    city_muniTb.Rows.Add(1596, 80, "Kiangan");
                    city_muniTb.Rows.Add(1597, 80, "Lagawe");
                    city_muniTb.Rows.Add(1598, 80, "Lamut");
                    city_muniTb.Rows.Add(1599, 80, "Mayoyao");
                    city_muniTb.Rows.Add(1600, 80, "Tinoc");
                }

                if (provinceCb.SelectedValue == "81")
                {
                    // Car
                    // Kalinga
                    city_muniTb.Rows.Add(1601, 81, "Balbalan");
                    city_muniTb.Rows.Add(1602, 81, "Lubuagan");
                    city_muniTb.Rows.Add(1603, 81, "Pasil");
                    city_muniTb.Rows.Add(1604, 81, "Pinukpuk");
                    city_muniTb.Rows.Add(1605, 81, "Rizal (Liwan)");
                    city_muniTb.Rows.Add(1606, 81, "Tabuk City");
                    city_muniTb.Rows.Add(1607, 81, "Tanudan");
                    city_muniTb.Rows.Add(1608, 81, "Tinglayan");
                }

                if (provinceCb.SelectedValue == "82")
                {
                    // Car
                    // Mountain Province
                    city_muniTb.Rows.Add(1609, 82, "Barlig");
                    city_muniTb.Rows.Add(1610, 82, "Bauko");
                    city_muniTb.Rows.Add(1611, 82, "Besao");
                    city_muniTb.Rows.Add(1612, 82, "Bontoc");
                    city_muniTb.Rows.Add(1613, 82, "Natonin");
                    city_muniTb.Rows.Add(1614, 82, "Paracelis");
                    city_muniTb.Rows.Add(1615, 82, "Sabangan");
                    city_muniTb.Rows.Add(1616, 82, "Sadanga");
                    city_muniTb.Rows.Add(1617, 82, "Sagada");
                    city_muniTb.Rows.Add(1618, 82, "Tadian");
                }

                if (provinceCb.SelectedValue == "83")
                {
                    // Ncr
                    // National Capital Region - Fourth District
                    city_muniTb.Rows.Add(1619, 83, "City Of Las PiñAs");
                    city_muniTb.Rows.Add(1620, 83, "City Of Makati");
                    city_muniTb.Rows.Add(1621, 83, "City Of Muntinlupa");
                    city_muniTb.Rows.Add(1622, 83, "City Of ParañAque");
                    city_muniTb.Rows.Add(1623, 83, "Pasay City");
                    // National Capital Region - Manila
                    city_muniTb.Rows.Add(1624, 83, "Binondo");
                    city_muniTb.Rows.Add(1625, 83, "Ermita");
                    city_muniTb.Rows.Add(1626, 83, "Intramuros");
                    city_muniTb.Rows.Add(1627, 83, "Malate");
                    city_muniTb.Rows.Add(1628, 83, "Paco");
                    city_muniTb.Rows.Add(1629, 83, "Pandacan");
                    city_muniTb.Rows.Add(1630, 83, "Port Area");
                    city_muniTb.Rows.Add(1631, 83, "Quiapo");
                    city_muniTb.Rows.Add(1632, 83, "Sampaloc");
                    city_muniTb.Rows.Add(1633, 83, "San Miguel");
                    city_muniTb.Rows.Add(1634, 83, "San Nicolas");
                    city_muniTb.Rows.Add(1635, 83, "Santa Ana");
                    city_muniTb.Rows.Add(1636, 83, "Santa Cruz");
                    city_muniTb.Rows.Add(1637, 83, "Tondo");
                    // National Capital Region - Second District
                    city_muniTb.Rows.Add(1638, 83, "City Of Mandaluyong");
                    city_muniTb.Rows.Add(1639, 83, "City Of Marikina");
                    city_muniTb.Rows.Add(1640, 83, "City Of Pasig");
                    city_muniTb.Rows.Add(1641, 83, "Quezon City");
                    city_muniTb.Rows.Add(1642, 83, "San Juan City");
                    // National Capital Region - Third District
                    city_muniTb.Rows.Add(1643, 83, "Caloocan City");
                    city_muniTb.Rows.Add(1644, 83, "City Of Valenzuela");
                    city_muniTb.Rows.Add(1645, 83, "Malabon City");
                    city_muniTb.Rows.Add(1646, 83, "Navotas City");
                    city_muniTb.Rows.Add(1647, 83, "Pateros");
                    city_muniTb.Rows.Add(1648, 83, "Taguig");
                }
                city_muniCb.DataSource = city_muniTb;
                city_muniCb.DataTextField = "city_muniName";
                city_muniCb.DataValueField = "city_muniID";
                city_muniCb.DataBind();
                //getbarangay();
            }
        }
        public void getprovince()
        {
            if (int.Parse(regionCb.SelectedValue) > 0)
            {
                DataTable provinceTb = new DataTable();
                provinceTb.Columns.Add("provinceID", typeof(int));
                provinceTb.Columns.Add("regionName");
                provinceTb.Columns.Add("provinceName");

                if (regionCb.SelectedValue == "1")
                {
                    provinceTb.Rows.Add(1, 1, "Please Select Province");
                }
                if (regionCb.SelectedValue == "2")
                {
                    // Region I
                    provinceTb.Rows.Add(2, 2, "Ilocos Norte");
                    provinceTb.Rows.Add(3, 2, "Ilocos Sur");
                    provinceTb.Rows.Add(4, 2, "La Union");
                    provinceTb.Rows.Add(5, 2, "Pangasinan");
                }

                if (regionCb.SelectedValue == "3")
                {
                    // Region Ii
                    provinceTb.Rows.Add(6, 3, "Batanes");
                    provinceTb.Rows.Add(7, 3, "Cagayan");
                    provinceTb.Rows.Add(8, 3, "Isabela");
                    provinceTb.Rows.Add(9, 3, "Nueva Vizcaya");
                    provinceTb.Rows.Add(10, 3, "Quirino");
                }

                if (regionCb.SelectedValue == "4")
                {
                    // Region Iii
                    provinceTb.Rows.Add(11, 4, "Aurora");
                    provinceTb.Rows.Add(12, 4, "Bataan");
                    provinceTb.Rows.Add(13, 4, "Bulacan");
                    provinceTb.Rows.Add(14, 4, "Nueva Ecija");
                    provinceTb.Rows.Add(15, 4, "Pampanga");
                    provinceTb.Rows.Add(16, 4, "Tarlac");
                    provinceTb.Rows.Add(17, 4, "Zambales");
                }

                if (regionCb.SelectedValue == "5")
                {
                    // Region Iv-A
                    provinceTb.Rows.Add(18, 5, "Batangas");
                    provinceTb.Rows.Add(19, 5, "Cavite");
                    provinceTb.Rows.Add(20, 5, "Laguna");
                    provinceTb.Rows.Add(21, 5, "Quezon");
                    provinceTb.Rows.Add(22, 5, "Rizal");
                }

                if (regionCb.SelectedValue == "6")
                {
                    // Region Iv-B
                    provinceTb.Rows.Add(23, 6, "Marinduque");
                    provinceTb.Rows.Add(24, 6, "Occidental Mindoro");
                    provinceTb.Rows.Add(25, 6, "Oriental Mindoro");
                    provinceTb.Rows.Add(26, 6, "Palawan");
                    provinceTb.Rows.Add(27, 6, "Romblon");
                }

                if (regionCb.SelectedValue == "7")
                {
                    // Region V
                    provinceTb.Rows.Add(28, 7, "Albay");
                    provinceTb.Rows.Add(29, 7, "Camarines Norte");
                    provinceTb.Rows.Add(30, 7, "Camarines Sur");
                    provinceTb.Rows.Add(31, 7, "Catanduanes");
                    provinceTb.Rows.Add(32, 7, "Masbate");
                    provinceTb.Rows.Add(33, 7, "Sorsogon");
                }

                if (regionCb.SelectedValue == "8")
                {
                    // Region Vi
                    provinceTb.Rows.Add(34, 8, "Aklan");
                    provinceTb.Rows.Add(35, 8, "Antique");
                    provinceTb.Rows.Add(36, 8, "Capiz");
                    provinceTb.Rows.Add(37, 8, "Guimaras");
                    provinceTb.Rows.Add(38, 8, "Iloilo");
                    provinceTb.Rows.Add(39, 8, "Negros Occidental");
                }

                if (regionCb.SelectedValue == "9")
                {
                    // Region Vii
                    provinceTb.Rows.Add(40, 9, "Bohol");
                    provinceTb.Rows.Add(41, 9, "Cebu");
                    provinceTb.Rows.Add(42, 9, "Negros Oriental");
                    provinceTb.Rows.Add(43, 9, "Siquijor");
                }

                if (regionCb.SelectedValue == "10")
                {
                    // Region Viii
                    provinceTb.Rows.Add(44, 10, "Biliran");
                    provinceTb.Rows.Add(45, 10, "Eastern Samar");
                    provinceTb.Rows.Add(46, 10, "Leyte");
                    provinceTb.Rows.Add(47, 10, "Northern Samar");
                    provinceTb.Rows.Add(48, 10, "Samar (Western Samar)");
                    provinceTb.Rows.Add(49, 10, "Southern Leyte");
                }

                if (regionCb.SelectedValue == "11")
                {
                    // Region Ix
                    provinceTb.Rows.Add(50, 11, "Zamboanga Del Norte");
                    provinceTb.Rows.Add(51, 11, "Zamboanga Del Sur");
                    provinceTb.Rows.Add(52, 11, "Zamboanga Sibugay");
                }

                if (regionCb.SelectedValue == "12")
                {
                    // Region X
                    provinceTb.Rows.Add(53, 12, "Bukidnon");
                    provinceTb.Rows.Add(54, 12, "Camiguin");
                    provinceTb.Rows.Add(55, 12, "Lanao Del Norte");
                    provinceTb.Rows.Add(56, 12, "Misamis Occidental");
                    provinceTb.Rows.Add(57, 12, "Misamis Oriental");
                }

                if (regionCb.SelectedValue == "13")
                {
                    // Region Xi
                    provinceTb.Rows.Add(58, 13, "Compostela Valley");
                    provinceTb.Rows.Add(59, 13, "Davao (Davao Del Norte)");
                    provinceTb.Rows.Add(60, 13, "Davao Del Sur");
                    provinceTb.Rows.Add(61, 13, "Davao Occidental");
                    provinceTb.Rows.Add(62, 13, "Davao Oriental");
                }

                if (regionCb.SelectedValue == "14")
                {
                    // Region Xii
                    provinceTb.Rows.Add(63, 14, "Cotabato (North Cot.)");
                    provinceTb.Rows.Add(64, 14, "Sarangani");
                    provinceTb.Rows.Add(65, 14, "South Cotabato");
                    provinceTb.Rows.Add(66, 14, "Sultan Kudarat");
                }

                if (regionCb.SelectedValue == "15")
                {
                    // Region Xiii
                    provinceTb.Rows.Add(67, 15, "Agusan Del Norte");
                    provinceTb.Rows.Add(68, 15, "Agusan Del Sur");
                    provinceTb.Rows.Add(69, 15, "Dinagat Islands");
                    provinceTb.Rows.Add(70, 15, "Surigao Del Norte");
                    provinceTb.Rows.Add(71, 15, "Surigao Del Sur");
                }

                if (regionCb.SelectedValue == "16")
                {
                    // Barmm
                    provinceTb.Rows.Add(72, 16, "Basilan");
                    provinceTb.Rows.Add(73, 16, "Lanao Del Sur");
                    provinceTb.Rows.Add(74, 16, "Maguindanao");
                    provinceTb.Rows.Add(75, 16, "Sulu");
                    provinceTb.Rows.Add(76, 16, "Tawi-Tawi");
                }

                if (regionCb.SelectedValue == "17")
                {
                    // Car
                    provinceTb.Rows.Add(77, 17, "Abra");
                    provinceTb.Rows.Add(78, 17, "Apayao");
                    provinceTb.Rows.Add(79, 17, "Benguet");
                    provinceTb.Rows.Add(80, 17, "Ifugao");
                    provinceTb.Rows.Add(81, 17, "Kalinga");
                    provinceTb.Rows.Add(82, 17, "Mountain Province");
                }

                if (regionCb.SelectedValue == "18")
                {
                    // Ncr
                    provinceTb.Rows.Add(83, 18, "National Capital Region - Manila");

                }

                provinceCb.DataSource = provinceTb;
                provinceCb.DataTextField = "provinceName";
                provinceCb.DataValueField = "provinceID";
                provinceCb.DataBind();

                Getcity();
                //getbarangay();
            }
        }
        protected void regionCb_SelectedIndexChanged(object sender, EventArgs e)
        {

            getprovince();
        }
        protected void provinceCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Getcity();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string studentno, gender, course, department, phoneno, emailadd, barangay, street, zipcode;
            string lname, fname, mname;




            String region = Convert.ToString(regionCb.SelectedItem.Text);
            String province = Convert.ToString(provinceCb.SelectedItem.Text);
            String city = Convert.ToString(city_muniCb.SelectedItem.Text);
            
            lname = TextBox2.Text;
            fname = TextBox3.Text;
            mname = TextBox4.Text;



            studentno = TextBox1.Text;

            phoneno = TextBox6.Text;
            emailadd = TextBox7.Text;
            barangay = TextBox5.Text;
            street = TextBox8.Text;
            zipcode = TextBox9.Text;


            Label30.Text = studentno.ToString();
            Label31.Text = lname + ", " + fname + " " + mname;
            Label32.Text = Convert.ToString(RadioButtonList1.SelectedItem.Text);
            Label33.Text = Convert.ToString(civilCb.SelectedItem.Text);
            Label34.Text = Convert.ToString(courseCb.SelectedItem.Text);
            Label35.Text = Convert.ToString(DeptCb.SelectedItem.Text);
            Label36.Text = phoneno.ToString();
            Label37.Text = emailadd.ToString();
            Label38.Text = zipcode + " " + barangay + " " + street + " " + barangay + " " + city + "" + province + " " + region;

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void ShowPopup_Click(object sender, EventArgs e)
        {
        }

        protected void btnShowModal_Click(object sender, EventArgs e)
        {
           
            String region = Convert.ToString(regionCb.SelectedItem.Text);
            String province = Convert.ToString(provinceCb.SelectedItem.Text);
            String city = Convert.ToString(city_muniCb.SelectedItem.Text);
            String lname = TextBox2.Text;
            String fname = TextBox3.Text;
            String mname = TextBox4.Text;
            String studentno = TextBox1.Text;
            String phoneno = TextBox6.Text;
            String emailadd = TextBox7.Text;
            String barangay = TextBox5.Text;
            String street = TextBox8.Text;
            String zipcode = TextBox9.Text;

           
            Label30.Text = studentno;
            Label31.Text = lname + ", " + fname + " " + mname;
            Label32.Text = Convert.ToString(RadioButtonList1.SelectedItem.Text);
            Label33.Text = Convert.ToString(civilCb.SelectedItem.Text);
            Label34.Text = Convert.ToString(courseCb.SelectedItem.Text);
            Label35.Text = Convert.ToString(DeptCb.SelectedItem.Text);
            Label36.Text = phoneno;
            Label37.Text = emailadd;
            Label38.Text = zipcode + " " + barangay + " " + street + " " + city + " " + province + " " + region;

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";

           
            TextBox1.Enabled = false;
            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
            TextBox5.Enabled = false;
            TextBox6.Enabled = false;
            TextBox7.Enabled = false;
            TextBox8.Enabled = false;
            TextBox9.Enabled = false;

            civilCb.Enabled = false;
            regionCb.Enabled = false;
            provinceCb.Enabled = false;
            city_muniCb.Enabled = false;
            DeptCb.Enabled = false;
            courseCb.Enabled = false;
            RadioButtonList1.Enabled = false;

            RadioButtonList1.SelectedIndex = -1;
            regionCb.SelectedValue = "1";
            DeptCb.SelectedValue = "1";
            if (int.Parse(regionCb.SelectedValue) > 0)
            {
                DataTable provinceTb = new DataTable();
                provinceTb.Columns.Add("provinceID", typeof(int));
                provinceTb.Columns.Add("regionName");
                provinceTb.Columns.Add("provinceName");

                if (regionCb.SelectedValue == "1")
                {
                    provinceCb.SelectedIndex = -1;
                }
                provinceCb.DataSource = provinceTb;
                provinceCb.DataTextField = "provinceName";
                provinceCb.DataValueField = "provinceID";
                provinceCb.DataBind();
            }

            if (int.Parse(regionCb.SelectedValue) > 0)
            {
                DataTable city_muniTb = new DataTable();
                city_muniTb.Columns.Add("city_muniID", typeof(int));
                city_muniTb.Columns.Add("provinceName");
                city_muniTb.Columns.Add("city_muniName");

                if (provinceCb.SelectedValue == "1")
                {
                    city_muniCb.SelectedIndex = -1;
                }
                city_muniCb.DataSource = city_muniTb;
                city_muniCb.DataTextField = "city_muniName";
                city_muniCb.DataValueField = "city_muniID";
                city_muniCb.DataBind();
            }

            if (int.Parse(DeptCb.SelectedValue) > 0)
            {
                DataTable courseTB = new DataTable();
                courseTB.Columns.Add("CourseID", typeof(int));
                courseTB.Columns.Add("DeptID", typeof(int));
                courseTB.Columns.Add("courseName");

                if (DeptCb.SelectedValue == "1")
                {
                    courseCb.SelectedIndex = -1;
                }
                courseCb.DataSource = courseTB;
                courseCb.DataTextField = "courseName";
                courseCb.DataValueField = "CourseID";
                courseCb.DataBind();
            }
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModalScript", "showModal();", true);


           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            regionCb.SelectedValue = "1";
            DeptCb.SelectedValue = "1";
            if(int.Parse(regionCb.SelectedValue) > 0)
            {
                DataTable provinceTb = new DataTable();
                provinceTb.Columns.Add("provinceID", typeof(int));
                provinceTb.Columns.Add("regionName");
                provinceTb.Columns.Add("provinceName");

                if (regionCb.SelectedValue == "1")
                {
                    provinceCb.SelectedIndex = -1;
                }
               provinceCb.DataSource = provinceTb;
                provinceCb.DataTextField = "provinceName";
                provinceCb.DataValueField = "provinceID";
            provinceCb.DataBind();
            }

            if (int.Parse(regionCb.SelectedValue) > 0)
            {
                DataTable city_muniTb = new DataTable();
                city_muniTb.Columns.Add("city_muniID", typeof(int));
                city_muniTb.Columns.Add("provinceName");
                city_muniTb.Columns.Add("city_muniName");

                if (provinceCb.SelectedValue == "1")
                {
                    city_muniCb.SelectedIndex = -1;
                }
                city_muniCb.DataSource = city_muniTb;
                city_muniCb.DataTextField = "city_muniName";
                city_muniCb.DataValueField = "city_muniID";
                city_muniCb.DataBind();
            }

            if(int.Parse(DeptCb.SelectedValue) > 0)
            {
                DataTable courseTB = new DataTable();
                courseTB.Columns.Add("CourseID", typeof(int));
                courseTB.Columns.Add("DeptID", typeof(int));
                courseTB.Columns.Add("courseName");

                if (DeptCb.SelectedValue == "1")
                {
                    courseCb.SelectedIndex = -1;
                }
                courseCb.DataSource = courseTB;
                courseCb.DataTextField = "courseName";
                courseCb.DataValueField = "CourseID";
                courseCb.DataBind();
            }

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";

           

            TextBox1.Enabled = true;
            TextBox2.Enabled = true;
            TextBox3.Enabled = true;
            TextBox4.Enabled = true;
            TextBox5.Enabled = true;
            TextBox6.Enabled = true;
            TextBox7.Enabled = true;
            TextBox8.Enabled = true;
            TextBox9.Enabled = true;

            civilCb.Enabled =true;
            regionCb.Enabled = true;
            provinceCb.Enabled = true;
            city_muniCb.Enabled = true;
            DeptCb.Enabled = true;
            courseCb.Enabled = true;
            RadioButtonList1.Enabled = true;


        }
    }
}