﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PreviousExams : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
       //Response.Write(" Value = " + Session["sid"]);

    }
    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
}
