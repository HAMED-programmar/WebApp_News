using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            Models.DBNewsEntities1 dbcontext = new Models.DBNewsEntities1();
            var Query = dbcontext.NwesTypes.Where(nt => nt.ID_NewsType == ID).FirstOrDefault();
            TxtTitle.Value = Query.Title_NewsType;

        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            string StrID = Request.QueryString["ID"];
            int ID = int.Parse(StrID);
            Models.DBNewsEntities1 dbcontext = new Models.DBNewsEntities1();
            var Query = dbcontext.NwesTypes.Where(nt => nt.ID_NewsType == ID).FirstOrDefault();
            Query.Title_NewsType = TxtTitle.Value;
            dbcontext.SaveChanges();
            ScriptManager.RegisterStartupScript(Page, typeof(Page), "PageNew", "  window.close();window.opener.location.reload();", true);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string StrID = Request.QueryString["ID"];
            int ID = int.Parse(StrID);
            Models.DBNewsEntities1 dbcontext = new Models.DBNewsEntities1();
            var Query = dbcontext.NwesTypes.Where(nt => nt.ID_NewsType == ID).FirstOrDefault();
            dbcontext.NwesTypes.Remove(Query);
            dbcontext.SaveChanges();
            ScriptManager.RegisterStartupScript(Page, typeof(Page), "PageNew", "  window.close();window.opener.location.reload();", true);
        }

        protected void btnNew_Click1(object sender, EventArgs e)
        {
            Models.DBNewsEntities1 dbcontext = new Models.DBNewsEntities1();
            Models.NwesType nt = new Models.NwesType();
            nt.Title_NewsType = TxtTitle.Value;
            dbcontext.NwesTypes.Add(nt);
            dbcontext.SaveChanges();
            ScriptManager.RegisterStartupScript(Page, typeof(Page), "PageNew", " window.opener.location.reload();", true);
            TxtTitle.Value = "";
        }
    }
}