using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;

namespace WebApp_News.Pages.Admin.NewsTypeView
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] == null)
            {
                Response.Redirect("~/pages/Error/E404.html", true);
                return;
            }
            string StrID = Request.QueryString["ID"];
            if (StrID == "-1")
            {
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }
            else
            {
                if (!IsPostBack)
                {
                    GetData();
                    btnNew.Visible = false;
                }
            }
        }
        private void GetData()
        {
            string StrID = Request.QueryString["ID"];
            int ID = int.Parse(StrID);
            Models.DBNewsEntities dbcontext = new Models.DBNewsEntities();
            var Query = dbcontext.NewsTypes.Where(nt => nt.ID_NewsType == ID).FirstOrDefault();
            TxtTitle.Value = Query.Title_NewsType;

        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Models.DBNewsEntities dbcontext = new Models.DBNewsEntities();
            Models.NewsType nt = new Models.NewsType();
            nt.Title_NewsType = TxtTitle.Value;
            dbcontext.NewsTypes.Add(nt);
            dbcontext.SaveChanges();
            ScriptManager.RegisterStartupScript(Page, typeof(Page), "PageNew", " window.opener.location.reload();", true);
            TxtTitle.Value = "";
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            string StrID = Request.QueryString["ID"];
            int ID = int.Parse(StrID);
            Models.DBNewsEntities dbcontext = new Models.DBNewsEntities();
            var Query = dbcontext.NewsTypes.Where(nt => nt.ID_NewsType == ID).FirstOrDefault();
            Query.Title_NewsType = TxtTitle.Value;
            dbcontext.SaveChanges();
            ScriptManager.RegisterStartupScript(Page, typeof(Page), "PageNew", "  window.close();window.opener.location.reload();", true);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string StrID = Request.QueryString["ID"];
            int ID = int.Parse(StrID);
            Models.DBNewsEntities dbcontext = new Models.DBNewsEntities();
            var Query = dbcontext.NewsTypes.Where(nt => nt.ID_NewsType == ID).FirstOrDefault();
            dbcontext.NewsTypes.Remove(Query);
            dbcontext.SaveChanges();
            ScriptManager.RegisterStartupScript(Page, typeof(Page), "PageNew", "  window.close();window.opener.location.reload();", true);
        }
    }
}