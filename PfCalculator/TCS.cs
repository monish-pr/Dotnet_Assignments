
class TCS : Company
{   
    public override string CompanyName { get; set; } = "TCS";
    public override int CasualLeaves { get; set; }
    public override int SickLeaves { get; set; }
    public override int PrevilageLeaves { get; set; }

    private EmployeeDetails E;
    public TCS(EmployeeDetails E, int CasualLeaves=1, int SickLeaves=12, int PrevilageLeaves=10){
        
        this.E = E;
        this.CasualLeaves = CasualLeaves;
        this.SickLeaves = SickLeaves;
        this.PrevilageLeaves = PrevilageLeaves;
        
    }

    public override string GetInfoString(){
        string Info = "";
        Info += $"PF Amount: {EmployeePF(E.BasicSalary)} \n";
        Info += $"Gratituity Amount: {GratituityAmount(E.ServiceCompleted, E.BasicSalary)} \n";
        return Info;
    }
    public override double EmployeePF(double BasicSalary)
    {
        double PfAmount = Math.Round(0.12*BasicSalary,2); // 12% of Basic Salary
        return PfAmount;
    }

    public override double GratituityAmount(float ServiceCompleted, double BasicSalary)
    {
        if(ServiceCompleted<5)
            return 0.0;
        else if(ServiceCompleted<10)
            return Math.Round(BasicSalary/12,2);
        else if(ServiceCompleted<20)
            return Math.Round(2*(BasicSalary/12),2);
        else
            return Math.Round(3*(BasicSalary/12),2);

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