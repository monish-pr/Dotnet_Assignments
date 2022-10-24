using GovtRules;
using LeavesDetails;
abstract class Company : IGovtRules, ILeavesDetails
{
    public abstract string CompanyName{ get; set; }
    public abstract int CasualLeaves { get; set; }
    public abstract int SickLeaves { get; set; }
    public abstract int PrevilageLeaves { get; set; }

    public abstract double EmployeePF(double BasicSalary);
    public abstract string LeaveDetails { get; }

    public abstract double GratituityAmount(float ServiceCompleted, double BasicSalary);
    public abstract string GetInfoString();
} 