using System;
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

            Models.DBNewsEntities1 dbContext = new Models.DBNewsEntities1();
            var Query = dbContext.NwesTypes.Select(nt => nt);
            StringBuilder strHtml = new StringBuilder();
            int CountRow = 1;

            foreach (var nt in Query)
            {
                strHtml.Append("<tr><td>" + CountRow + "</td>");
                strHtml.Append("<tr><td>" + nt.Title_NewsType + "</td>");

            }
            BodyTable.Controls.Add(new Literal { Text = strHtml.ToString() });
        }
    }
}