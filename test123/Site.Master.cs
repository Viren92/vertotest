﻿using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;

using System.Web.UI.WebControls;

using System.Data.SqlClient;

using Microsoft.AspNet.Identity;
using System.Data;
using System.Configuration;

namespace test123
{
    public partial class SiteMaster : MasterPage
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataBind();

            }

        }


       

        protected void Page_PreRender(object sender, EventArgs e)
        {

        }

        


        protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
        {
            GridView1.DataBind();
            GridView1.SelectRow(-1);

           
        }



    }
}

