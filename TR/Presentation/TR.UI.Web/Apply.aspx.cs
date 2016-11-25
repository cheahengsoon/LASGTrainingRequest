using MK.Framework.ACE.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using TR.Entities;

using TR.UI.Process.TrainingServiceReference1;
using MK.Framework.SNE;
using System.Activities.Statements;
using MK.Framework.DXE;
using MK.Framework.DXE.Enumeration;
using System.Activities;
using TR.UI.Process;
using TR.Data;
using TR.Workflows;
using TR.UI.Process.TrainingWorkflowServiceReference1;
using MK.Framework.ACE;

namespace TR.UI.Web
{
    public partial class Apply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            lblUserName.Text = Session["name"].ToString();

            User user = (User)Session["newLogin"];
            lbluserID.Text = user.UserID.ToString();

          
                string policyId = "DB676D6E-5CF5-42CA-850E-57ACF020865C";

                var ace = new AccessControl();
                var ap = ace.GetAccessPolicy(user.UserID, policyId);

                if (ap.HasFullAccess())
                {
                    btnApprove.Visible = false;
                    btnReject.Visible = false;
                    btnExport.Visible = false;
                }
            
           
            Process.TrainingController listTraining = new Process.TrainingController();

            GridView1.DataSource =
            listTraining.ListTraining(0);

            GridView1.DataBind();

            DateTime time = DateTime.Now;
            lblSubmitDate.Text = Convert.ToString(time);


        }

     

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            TrainingRequest newTraining = new TrainingRequest();
            newTraining.CorrelationID = Guid.NewGuid();
            newTraining.UserName = lblUserName.Text;
            newTraining.StartDate = Convert.ToDateTime(txtStartDate.Text);
            newTraining.EndDate = Convert.ToDateTime(txtEndDate.Text);
            newTraining.RequestStatus = lblStatus.Text;
            newTraining.TrainingName = txtTrainingName.Text;  
            newTraining.SubmitDate = Convert.ToDateTime(lblSubmitDate.Text);
           
           Process.TrainingController submitTraining = new Process.TrainingController();
            submitTraining.Apply(newTraining);

            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lblRequestID.Text = GridView1.SelectedRow.Cells[1].Text;
            txtTrainingName.Text = GridView1.SelectedRow.Cells[8].Text;
            txtStartDate.Text = GridView1.SelectedRow.Cells[4].Text;
            txtEndDate.Text = GridView1.SelectedRow.Cells[5].Text;
           lblguid.Text = GridView1.SelectedRow.Cells[2].Text;
            lblStatus.Text = GridView1.SelectedRow.Cells[6].Text;

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

                TrainingRequest cancelTraining = new TrainingRequest();
                cancelTraining.TRequestID = lblRequestID.Text;
                cancelTraining.UserName = lblUserName.Text;
                cancelTraining.CorrelationID = Guid.Parse(lblguid.Text);
                cancelTraining.StartDate = Convert.ToDateTime(txtStartDate.Text);
                cancelTraining.EndDate = Convert.ToDateTime(txtEndDate.Text);
                cancelTraining.RequestStatus = "Cancelled";
                cancelTraining.TrainingName = txtTrainingName.Text;
                cancelTraining.SubmitDate = Convert.ToDateTime(lblSubmitDate.Text);

                Process.TrainingController CancelledTraining = new Process.TrainingController();
                CancelledTraining.Cancel(cancelTraining);
            Page.Response.Redirect(Page.Request.Url.ToString(), true);

        }

      

     
      
    }
}