
class WellsFargo : Company
{   
    public override string CompanyName { get; set; } = "WellsFargo";
    public override int CasualLeaves { get; set; }
    public override int SickLeaves { get; set; }
    public override int PrevilageLeaves { get; set; }

    private EmployeeDetails E;
    public WellsFargo(EmployeeDetails E, int CasualLeaves=2, int SickLeaves=5, int PrevilageLeaves=5){
        this.E = E;
        this.CasualLeaves = CasualLeaves;
        this.SickLeaves = SickLeaves;
        this.PrevilageLeaves = PrevilageLeaves;
    }

    public override string GetInfoString(){
        string Info = "";
        Info += $"PF Amount: {EmployeePF(E.BasicSalary)} \n";
        Info += $"Gratituity Amount: NA \n";
        return Info;
    }
    public override double EmployeePF(double BasicSalary)
    {
        double PfAmount = Math.Round(0.12*BasicSalary,2); // 12% of Basic Salary
        return PfAmount;
    }

    public override double GratituityAmount(float ServiceCompleted, double BasicSalary)
    {
        return -1;
    }

    public override string LeaveDetails
    {
        get
        {
            string res = "";
            res += $"Casual Leave(s)/month : {CasualLeaves} \n";
            res += $"Sick Leave(s)/year : {SickLeaves} \n";
            res += $"Previlage Leave(s)/year : {PrevilageLeaves} \n";
            return res;
        }
    }
}