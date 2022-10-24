
class EmployeeDetails{
    private string Name { get; set; }
    private int EmployeeID { get; set;}
    private string Department { get; set;}
    private string Designation { get; set;}
    public double BasicSalary { get; set;}
    public float ServiceCompleted { get; set;}

    public EmployeeDetails(string Name,  double BasicSalary, float ServiceCompleted, int EmployeeID = 111, string Department = "tech", string Designation = "sde"){
        this.Name = Name;
        this.EmployeeID = EmployeeID;
        this.Department = Department;
        this.Designation = Designation;
        this.BasicSalary = BasicSalary;
        this.ServiceCompleted = ServiceCompleted;
    }
} 