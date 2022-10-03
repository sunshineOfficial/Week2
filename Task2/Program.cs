Department mcdonalds = new Department("McDonalds", 0, "Billy");
Department kfc = new Department("KFC", 1, "Van");
List<Employee> employees = new List<Employee>()
{
    new Employee("Ivanov", "Ivan", "Ivanovich", 36, mcdonalds),
    new Employee("Herrington", "Billy", "Gachievich", 43, mcdonalds),
    new Employee("Darkholme", "Van", "Billyevich", 18, kfc)
};
var dict = employees.GroupBy(emp => emp.Dep.Name)
    .ToDictionary(emp => emp.Key, emp => emp.ToList());
foreach (var dep in dict)
{
    Console.WriteLine(dep.Key);
    foreach (var emp in dep.Value)
    {
        Console.WriteLine(emp.Name);
    }
    Console.WriteLine();
}

class Department
{
    public string Name { get; set; }
    public int Number { get; set; }
    public string Boss { get; set; }

    public Department(string name, int number, string boss)
    {
        Name = name;
        Number = number;
        Boss = boss;
    }
}

class Employee
{
    public string Surname { get; set; }
    public string Name { get; set; }
    public string Patronymic { get; set; }
    public int Age { get; set; }
    public Department Dep { get; set; }

    public Employee(string surname, string name, string patronymic, int age, Department dep)
    {
        Surname = surname;
        Name = name;
        Patronymic = patronymic;
        Age = age;
        Dep = dep;
    }
}