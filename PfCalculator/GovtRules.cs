namespace GovtRules;
interface IGovtRules{
    double EmployeePF(double BasicSalary);
    string LeaveDetails { get; }

    double GratituityAmount(float ServiceCompleted, double BasicSalary);
}

