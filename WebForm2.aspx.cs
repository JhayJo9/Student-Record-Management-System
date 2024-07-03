using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Ensure the script to show the modal is registered on postback
            if (!IsPostBack)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "showModal", "showModal();", true);
            }
        }

        protected void btnShowModal_Click(object sender, EventArgs e)
        {
            // Set the text of the label inside the modal to the text from the textbox
            lblModalText.Text = textbox.Text;

            // Register the JavaScript function to show the modal
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModalScript", "showModal();", true);
        }

        protected void btnAddToDropdown_Click(object sender, EventArgs e)
        {
            // Add the text from the textbox to the dropdown list
            dropdown.Items.Add(new ListItem(textbox.Text));
        }

    }
}