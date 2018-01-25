using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Project
{
    private int projectID;
    private string projectName;
    private string projectDescription;
    private string lastUpdatedBy;
    private DateTime lastUpdated;
    private static int projectCount = 0;

    public Project(string projectName, string projectDescription, string lastUpdatedBy, DateTime lastUpdated)
    {
        //ProjectID should come from the database
        ProjectName = projectName;
        ProjectDescription = projectDescription;
        LastUpdatedBy = lastUpdatedBy;
        LastUpdated = lastUpdated;

        projectCount++;
    }
    public int ProjectID
    {
        get
        {
            return projectID;
        }
        private set
        {
            projectID = value;
        }
    }
    public string ProjectName
    {
        get
        {
            return projectName;
        }
        private set
        {
            projectName = value;
        }
    }
    public string ProjectDescription
    {
        get
        {
            return projectDescription;
        }
        private set
        {
            projectDescription = value;
        }
    }
    public string LastUpdatedBy
    {
        get
        {
            return lastUpdatedBy;
        }
        private set
        {
            lastUpdatedBy = value;
        }
    }
    public DateTime LastUpdated
    {
        get
        {
            return lastUpdated;
        }
        private set
        {
            lastUpdated = value;
        }
    }

}