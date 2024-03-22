using System.ComponentModel.Design;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            string answer;

            do
            {
                Console.WriteLine("Isci elave etmek ucun: 1\n" +
                    "Butun iscilere baxmaq ucun: 2\n" +
                    "Maas aralığına göre işçileri axtarış et: 3\n" +
                    "Programi bitir: 0");
                 answer = Console.ReadLine();
                if(answer == "1")
                {
                    Console.Write("Iscinin adini daxil edin: ");
                    string name = Console.ReadLine();
                    Console.Write("Iscinin soyadini daxil edin: ");
                    string surname = Console.ReadLine();
                    string ageStr = "";
                    byte age;
                    do
                    {
                       Console.Write("Iscinin yasini daxil edin: ");
                       ageStr = Console.ReadLine();

                    } while (!byte.TryParse(ageStr, out age));
                      Console.Write("Iscinin aid oldugu departman adini yazin: ");
                      string departmentName = Console.ReadLine();
                      string salaryStr = "";
                      int salary;
                    do
                    {
                        Console.Write("Iscinin maasini daxil edin: ");
                        salaryStr = Console.ReadLine();
                    } while (!int.TryParse(salaryStr, out salary));

                        Employee employee = new Employee(name, surname, age, departmentName,salary);


                         department.AddEmployee(employee);

                }
                else if (answer == "2")
                {
                    department.ShowEmployeeInfo();
                }
                else if (answer == "3")
                {
                    string minStr = "";
                    int minSalary;

                    do
                    {
                        Console.Write("Min maas daxil edin: ");
                        minStr = Console.ReadLine();

                    } while (!int.TryParse(minStr, out minSalary));
                    string maxStr = "";
                    int maxSalary;
                    do
                    {
                        Console.Write("Max maas daxil edin: ");
                        maxStr = Console.ReadLine();

                    } while (!int.TryParse(maxStr, out maxSalary));
                    department.GetAllEmployeesBySalary(minSalary, maxSalary);
                }

            } while (answer != "0");
            

        }
    }
}
