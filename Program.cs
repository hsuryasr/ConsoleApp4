//using System;
//public class HelloWorld
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Nested For Loop");
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                Console.WriteLine("when i is {0}", i);
//                Console.WriteLine("j is {0}", j);
//            }
//        }
//        Console.ReadKey();
//    }
//}


//internal class Employee
//{
//    //Private variable
//    int EmpId;
//    //public property
//    public int EMPID { get; set; }
//    string EmpName;
//    public string EMPNAME { get; set; }



//    //to get the data members should be intialized
//    //Defalt constructor
//    public Employee()
//    {
//        Console.WriteLine("This is Default constructor for Employee");
//    }
//    public Employee(int empid, string empname)
//    {
//        this.EMPID = empid;
//        this.EMPNAME = empname;



//    }



//    public void DiplayEmpDetails()
//    {
//        Console.WriteLine("The EmpId is  " + EMPID + " " + "Emp Name is " + EMPNAME);
//    }
//}



//class Manager : Employee
//{



//    int FoodAllowance;
//    public int FOODALLOWANCE { get; set; }
//    public Manager()
//    {
//        Console.WriteLine("This is Default constructor for Manager");
//    }
//}



//class ClientEmp
//{
//    static void Main()
//    {
//        Employee e1 = new Employee(100, "Hema");
//        e1.DiplayEmpDetails();



//        //  e1.EmpId;//inaccessible due to projection level



//        //  e1.EMPID = 100;
//        // e1.EMPNAME = "Rashmi";




//        //Manager m1 = new Manager();
//        Console.ReadKey();
//    }
//}
internal class Employee
{
    //Private variable
    int EmpId;
    //public property
    public int EMPID { get; set; }
    string EmpName;
    public string EMPNAME { get; set; }



    //to get the data members should be intialized
    //Defalt constructor
    public Employee()
    {
        Console.WriteLine("This is Default constructor for Employee");
    }
    public Employee(int empid, string empname)
    {
        this.EMPID = empid;
        this.EMPNAME = empname;



    }



    public void DiplayEmpDetails()
    {
        Console.WriteLine("The EmpId is  " + EMPID + " " + "Emp Name is " + EMPNAME);
    }
}



class Manager : Employee
{



    int FoodAllowance;
    public int FOODALLOWANCE { get; set; }
    public Manager()
    {
        Console.WriteLine("This is Default constructor for Manager");
    }
}



class ClientEmp
{
    static void Main()
    {
        Employee e1 = new Employee(100, "Hema");
        e1.DiplayEmpDetails();



        //  e1.EmpId;//inaccessible due to projection level



        //  e1.EMPID = 100;
        // e1.EMPNAME = "Rashmi";




        //Manager m1 = new Manager();
        Console.ReadKey();
    }
}