using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertmessage", "alert('Please enter your name')", true);
        
        
    }

    protected void btnCommitProject_Click(object sender, EventArgs e)
    {
        Boolean ensureDB = true;
        
        

        if (ensureDB == true)
        {
            Project newProject = new Project(txtProjectName.Text, txtProjectDescription.Text, (string)Session["user"], System.DateTime.Now);

            try
            {
                System.Data.SqlClient.SqlConnection sqlc = connectToDB();

                //Creates the sql insert statement 
                System.Data.SqlClient.SqlCommand insert = new System.Data.SqlClient.SqlCommand();
                insert.Connection = sqlc;

                insert.CommandText += "insert into [dbo].[PROJECT] values ('" + newProject.ProjectName + "','" + newProject.ProjectDescription + "','" + newProject.LastUpdatedBy
                    + "','" + newProject.LastUpdated + "')";
                lblAlert.Text += insert.CommandText;
                insert.ExecuteNonQuery();
                sqlc.Close();
            }
            catch (Exception c)
            {
                lblAlert.Text += c;
            }
        }

    }

    protected void btnClearProject_Click(object sender, EventArgs e)
    {
        
    }

    protected System.Data.SqlClient.SqlConnection connectToDB()
    {
        try
        {
            //Connects to the database and returns the connection
            System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection();
            sc.ConnectionString = @"Server =Localhost; Database=Lab2;Trusted_Connection=Yes";
            sc.Open();
            return sc;
        }
        catch (Exception)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertmessage", "alert('There was an error connecting to the Database')", true);
            return null;
        }
    }

    private Boolean checkDB(string a, string colName)
    {
        
        try
        {
            System.Data.SqlClient.SqlConnection sqlc = connectToDB();

            //Creates the sql insert statement 
            System.Data.SqlClient.SqlCommand select = new System.Data.SqlClient.SqlCommand();
            select.Connection = sqlc;

            select.CommandText += "SELECT COUNT (*) [" + colName + "] FROM [DBO].[PROJECT] WHERE [" + colName
                + "] = '" + a + "'";
            lblAlert.Text += select.CommandText;

            int i = (int)select.ExecuteScalar();
            sqlc.Close();
            
            if (i == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        catch (Exception c)
        {
            lblAlert.Text += c;
            return false;
        }
    }
}
