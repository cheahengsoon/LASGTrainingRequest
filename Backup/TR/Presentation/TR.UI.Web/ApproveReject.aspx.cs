using MK.Framework.ACE;
using MK.Framework.ACE.Entities;
using System;
using System.Web.UI;
using TR.Entities;

namespace TR.UI.Web
{
    public partial class ApproveReject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            lblUserName.Text = Session["name"].ToString();

            User user = (User)Session["newLogin"];
            lbluserID.Text = user.UserID.ToString();


            string policyId = "DB676D6E-5CF5-42CA-850E-57ACF020865C";


            // TODO: call UIPC to get userpolicy

            btnCancel.Visible = false;
            btnSubmit.Visible = false;

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

        protected void btnApprove_Click(object sender, EventArgs e)
        {


            TrainingRequest approveTraining = new TrainingRequest();
            approveTraining.TRequestID = lblRequestID.Text;
            approveTraining.UserName = lblUserName.Text;
            approveTraining.CorrelationID = Guid.Parse(lblguid.Text);
            approveTraining.StartDate = Convert.ToDateTime(txtStartDate.Text);
            approveTraining.EndDate = Convert.ToDateTime(txtEndDate.Text);
            //approveTraining.CorrelationID = Guid.Parse(lblguid.Text);
            approveTraining.RequestStatus = "Approval";
            approveTraining.TrainingName = txtTrainingName.Text;
            approveTraining.SubmitDate = Convert.ToDateTime(lblSubmitDate.Text);
            Process.TrainingController approvalTraining = new Process.TrainingController();
            approvalTraining.Approve(approveTraining);


            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }

        protected void btnReject_Click(object sender, EventArgs e)
        {
            // TrainingController getID = new TrainingController();



            TrainingRequest rejectTraining = new TrainingRequest();
            rejectTraining.TRequestID = lblRequestID.Text;
            rejectTraining.UserName = lblUserName.Text;
            rejectTraining.CorrelationID = Guid.Parse(lblguid.Text);
            rejectTraining.StartDate = Convert.ToDateTime(txtStartDate.Text);
            rejectTraining.EndDate = Convert.ToDateTime(txtEndDate.Text);
            // approveTraining.CorrelationID = Guid.Parse(lblguid.Text);
            rejectTraining.RequestStatus = "Rejected";
            rejectTraining.TrainingName = txtTrainingName.Text;
            rejectTraining.SubmitDate = Convert.ToDateTime(lblSubmitDate.Text);

            Process.TrainingController rejectedTraining = new Process.TrainingController();
            rejectedTraining.Reject(rejectTraining);


            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }

        protected void btnExport_Click(object sender, EventArgs e)
        {
            //TrainingComponent tc = new TrainingComponent();
            //tc.Export();

            // TODO: call UIPC to export.
        }
    }
}