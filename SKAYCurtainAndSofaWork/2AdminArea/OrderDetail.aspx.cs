﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _2AdminArea_OrderDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserPhoneNumber"] != null && Session["AccountType"].ToString() == "Super Admin")
        {
            if (!IsPostBack)
            {

            }
        }
        else
        {
            Response.Redirect("../4CustomerArea/LogIn.aspx");
        }
    }
}