﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW_ASP_NET_WebSite_Division
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBoxNumber_Validate(
            object source, ServerValidateEventArgs args)
        {
            string v = txtNumber.Text;
            if (v == string.Empty)
            {
                args.IsValid = false;  // field is empty
            }

            args.IsValid = true;
        }

        protected void btnResult_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                
                //lblNumber.Text = "Page is valid.";
                //lblDiv.Text = "Page is valid.";

                double i = double.Parse(txtNumber.Text);
                double j = double.Parse(txtDiv.Text);
                double z = i / j;                
                lblRes.Text += (z.ToString());                
            }
            else
            {
                lblNumber.Text = "Page is not valid!!";
                lblDiv.Text = "Page is not valid!";
            }
        }
    }
}