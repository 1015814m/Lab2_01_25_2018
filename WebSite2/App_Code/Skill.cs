using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// This is the skill class
/// </summary>
public class Skill
{
    private int skillID;
    private string skillName;
    private string skillDescription;
    private string lastUpdatedBy;
    private DateTime lastUpdated;
    private static int skillCount = 0;

    public Skill(string skillName, string skillDescription, string lastUpdatedBy, DateTime lastUpdated)
    {
        //SkillID should come from the database
        SkillName = skillName;
        SkillDescription = skillDescription;
        LastUpdatedBy = lastUpdatedBy;
        LastUpdated = lastUpdated;

        skillCount++;
    }

    public int SkillID
    {
        get
        {
            return skillID;
        }
        private set
        {
            skillID = value;
        }
    }
    public string SkillName
    {
        get
        {
            return skillName;
        }
        private set
        {
            skillName = value;
        }
    }
    public string SkillDescription
    {
        get
        {
            return skillDescription;
        }
        private set
        {
            skillDescription = value;
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