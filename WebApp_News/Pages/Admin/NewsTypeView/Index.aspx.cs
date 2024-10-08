﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
namespace WebApp_News.Pages.Admin.NewsTypeView
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetList();
        }
        private void GetList()
        {

            Models.DBNewsEntities dbContext = new Models.DBNewsEntities();
            var Query = dbContext.NewsTypes.Select(nt => nt);
            StringBuilder strHtml = new StringBuilder();
            int CountRow = 1;

            foreach (var nt in Query)
            {
                strHtml.Append("<tr><td>" + CountRow + "</td>");
                strHtml.Append("<td>" + nt.Title_NewsType + "</td>");
                strHtml.Append("<td> <a onclick=\"OpenPage("+ nt.ID_NewsType + ")\" class=\"btn btn-info\">  ویرایش </a></tr>");
                CountRow++;
            }

            BodyTable.Controls.Add(new Literal { Text = strHtml.ToString() });
        }
    }
}