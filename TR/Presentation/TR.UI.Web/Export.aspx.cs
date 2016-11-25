using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MK.Framework.DXE;
using MK.Framework.DXE.Entities;
using MK.Framework.DXE.Enumeration;

namespace TR.UI.Web
{
    public partial class Export : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Process.TrainingController listTraining = new Process.TrainingController();

            GridView1.DataSource =
            listTraining.ListTraining(0);

            GridView1.DataBind();
        }

        protected void btnExport_Click(object sender, EventArgs e)
        {

            PackageCreator packageCreator = new PackageCreator();
           packageCreator.ExecuteMode = ExecuteMode.FileSystem;
           packageCreator.StagingFolder = @"C:\Temp\Drop\Staging";
          packageCreator.AutoGeneratePassword = true;

            // Generates a dtsx file and return password. 
            string password = packageCreator.CreateExportToFlatFilePackage(
               "MyExcelDtsxPackage","SELECT [TRequestID], [CorrelationID], [UserName], [StartDate], [EndDate], [RequestStatus], [SubmitDate],[TrainingName] FROM dbo.TrainingRequest", @"Data Source=ENGSOON;Initial Catalog=HRTrainingRequest;User ID=sa;Password=CESoon1012", "MyGeneratedExcelFile",".csv","|", true,true);
            

        }
    }
}