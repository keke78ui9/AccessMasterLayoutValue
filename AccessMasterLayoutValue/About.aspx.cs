using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace AccessMasterLayoutValue
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("<script type=\"text/javascript\" src=\"Scripts/jquery-1.4.1.min.js\"></script>");

            ContentPlaceHolder cph = (ContentPlaceHolder)Master.FindControl("scriptPath");
            if (cph != null)
            {
                Literal literal = (Literal)cph.FindControl("scriptText");
                literal.Text = sb.ToString();
            }


            ContentPlaceHolder cph2 = (ContentPlaceHolder)Master.FindControl("HeadContent");
            if (cph2 != null)
            {
                Literal literal = new Literal();
                literal.Text = "<link href=\"~/Styles/Test.css\" rel=\"stylesheet\" type=\"text/css\" />";
                cph2.Controls.Add(literal);

            }


            String name = "ButtonClickScript";
            String jspath = "~/script_include.js";
            Type type = this.GetType();

            ClientScriptManager csm = Page.ClientScript;

            if (!csm.IsClientScriptIncludeRegistered(type, name))
            {
                csm.RegisterClientScriptInclude(type, name, ResolveClientUrl(jspath));
            }
        }
    }
}
