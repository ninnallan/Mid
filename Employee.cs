/*შექმენით კლასი სახელად "Employee" შემდეგი მახასიათებლებით:
private integer field "_employeeName". Public string property "Salary" 
get and set აქსესუარებით. კონსტრუქტორი, რომელიც იღებს ორ პარამეტრს 
სახელის და ხელფასის ინიციალიზაციისთვის. შექმენით public მეთოდი
სახელწოდებით "DisplayInfo", რომელიც აბრუნებს შეტყობინებას:
"Hi, I'm [_employeeName] and I earn [Salary] per year". 
შექმენით "Employee" კლასის ობიექტი, სახელით და ხელფასით და
 გამოიძახეთ "DisplayInfo" მეთოდი.
*/
class Employee
{
    private string _employeeName;
    public string Salary { get; set; }

    public Employee(string name, string salary)
    {
        _employeeName = name;
        Salary = salary;
    }

    public string DisplayInfo()
    {
        return $"Hi, I'm {_employeeName} and I earn {Salary} per year.";
    }
}

