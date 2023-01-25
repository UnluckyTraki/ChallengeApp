using ChallengeApp;

Employee emp1 = new Employee("Wiktor", "P", 29);
Employee emp2 = new Employee("Adam", "K", 33);
Employee emp3 = new Employee("Maja", "P", 28);

emp1.AddScore(5);
emp1.AddScore(10);
emp1.AddScore(1);
emp1.AddScore(8);
emp1.AddScore(6);

emp2.AddScore(1);
emp2.AddScore(3);
emp2.AddScore(8);
emp2.AddScore(8);
emp2.AddScore(2);

emp3.AddScore(9);
emp3.AddScore(10);
emp3.AddScore(5);
emp3.AddScore(3);
emp3.AddScore(1);

List <Employee> employees = new List<Employee>()
{
    emp1, emp2, emp3
};

var maxResult = 0;
Employee employeeWithMaxResult = null;


foreach (var emp in employees)
{   
    if (emp1.Result > maxResult)
    {
        employeeWithMaxResult = emp1;
        maxResult = emp1.Result;
    }
    else if (emp2.Result > maxResult)
    {
        employeeWithMaxResult = emp2;
        maxResult = emp2.Result;
    }
    if (emp3.Result > maxResult)
    {
        employeeWithMaxResult = emp3;
        maxResult = emp3.Result;
    }
    
}
Console.WriteLine($"Największą ilość punktów: {maxResult} uzyskał/a {employeeWithMaxResult.FullInfo} lat.");
