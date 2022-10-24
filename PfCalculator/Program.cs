
namespace PfCalculator;
class Program
{
    static void Main(string[] args)
    {

        EmployeeDetails E = new EmployeeDetails("Monish", 1000000, 5);
        Company TcsEmployee = new TCS(E);
        Company WfEmployee = new WellsFargo(E);

        ShowInfo(TcsEmployee);
        ShowInfo(WfEmployee);
    }

    private static void ShowInfo(Company CompanyEmployee)
    {
        Console.WriteLine("Company : " + CompanyEmployee.CompanyName);
        Console.WriteLine(CompanyEmployee.GetInfoString());
        Console.WriteLine(CompanyEmployee.LeaveDetails);
        Console.WriteLine("---------------------------");
    }
}
