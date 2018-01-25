using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// This is the employee class. 
/// </summary>
public class Employee
{
    private int employeeID;
    private string fName;
    private string lName;
    private string mName;
    private string houseNum;
    private string street;
    private string county;
    private string state;
    private string country;
    private string zip;
    private DateTime dateOfBirth;
    private DateTime hireDate;
    private DateTime terminationDate;
    private double salary;
    private int managerID;
    private string updatedBy;
    private DateTime updatedDate;
    public static int EmployeeCount = 0;

    public Employee(string fName, string lName, string mName, string houseNum, string street, string county, string state, string country, string zip,
        DateTime dateOfBirth, DateTime hireDate, DateTime terminationDate, double salary, int managerID, string updatedBy, DateTime updatedDate)
    {
        //EmployeeID should come from the database
        FirstName = fName;
        LastName = lName;
        MiddleName = mName;
        HouseNum = houseNum;
        Street = street;
        County = county;
        State = state;
        Country = country;
        Zip = zip;
        DateOfBirth = dateOfBirth;
        HireDate = hireDate;
        TerminationDate = terminationDate;
        Salary = salary;
        ManagerID = managerID;
        LastUpdatedBy = updatedBy;
        LastUpdated = updatedDate;

        EmployeeCount++;

    }

    public int EmployeeID
    {
        get
        {
            return employeeID;
        }
        private set
        {
            employeeID = value;
        }
    }
    public string FirstName
    {
        get
        {
            return fName;
        }
        private set
        {
            fName = value;
        }
    }
    public string LastName
    {
        get
        {
            return lName;
        }
        private set
        {
            lName = value;
        }
    }
    public string MiddleName
    {
        get
        {
            return mName;
        }
        private set
        {
            mName = value;
        }

    }
    public string HouseNum
    {
        get
        {
            return houseNum;
        }
        private set
        {
            houseNum = value;
        }
    }
    public string Street
    {
        get
        {
            return street;
        }
        private set
        {
            street = value;
        }
    }
    public string County
    {
        get
        {
            return county;
        }
        private set
        {
            county = value;
        }
    }
    public string State
    {
        get
        {
            return state;
        }
        private set
        {
            state = value;
        }
    }
    public string Country
    {
        get
        {
            return country;
        }
        private set
        {
            country = value;
        }
    }

    public string Zip
    {
        get
        {
            return zip;
        }
        private set
        {
            zip = value;
        }
    }
    public DateTime DateOfBirth
    {
        get
        {
            return dateOfBirth;
        }
        private set
        {
            dateOfBirth = value;
        }
    }
    public DateTime HireDate
    {
        get
        {
            return hireDate;
        }
        private set
        {
            hireDate = value;
        }
    }
    public DateTime TerminationDate
    {
        get
        {
            return terminationDate;
        }
        private set
        {
            terminationDate = value;
        }
    }
    public double Salary
    {
        get
        {
            return salary;
        }
        private set
        {
            salary = value;
        }
    }
    public int ManagerID
    {
        get
        {
            return managerID;
        }
        private set
        {
            managerID = value;
        }
    }
    public string LastUpdatedBy
    {
        get
        {
            return updatedBy;
        }
        private set
        {
            updatedBy = value;
        }
    }
    public DateTime LastUpdated
    {
        get
        {
            return updatedDate;
        }
        private set
        {
            updatedDate = value;
        }
    }







}