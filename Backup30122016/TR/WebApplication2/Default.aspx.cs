using MK.Framework.ACE;
using MK.Framework.ACE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TR.UI.Web
{
    public partial class Default : System.Web.UI.Page
    {
        //  private readonly object UserPolicies;
      
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Process.TrainingController newlogin = new Process.TrainingController();
           
            Session["newLogin"] = newlogin.LoginVerify(txtusername.Text, txtPassword.Text);
            User user = (User)Session["newLogin"];

            string name = txtusername.Text.Trim();

            if(user.ToString()!=null && user.UserID.ToString()=="4")
            {

                Session["name"] = name;
                Response.Redirect("Apply.aspx");
            }
            else
            {
                Session["name"] = name;
                Response.Redirect("ApproveReject.aspx");
      
            }

        }
    }
}