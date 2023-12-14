using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13June_StudentMangmant
{
     class Program
    {   static  List<Student> studentsList=new List<Student>();
       static  List<StudentFees> studentFeesList = new List<StudentFees>();
        static void Main(string[] args)
        {
        CallAddStudent:
            AddStudent();
            Console.WriteLine("do u want to add more sdtudent");
            string check=Console.ReadLine();
            if (check == "yes" || check == "Yes")
                goto CallAddStudent;

            ShowStudents();
            Console.Read();

        }

        public  static void AddStudent()
        {   Student s = new Student();
            Console.Write("Enter Id:   ");
            s.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name:");
            s.Name = (Console.ReadLine());

            Console.Write("Enter Total fees:   ");
            s.TotalFees = Convert.ToInt32(Console.ReadLine());
           
            studentsList.Add(s);
            AddStudentFees(s.Id, s.TotalFees, 20000);

        }

        public static void AddStudentFees(int studentid,int Totalfees,int feessubmitted)
        {
            StudentFees s1 = new StudentFees();
            s1.StudentId = studentid;

            int remaining=Totalfees-feessubmitted;
            s1.FeesRemaining=remaining;
            s1.FeesSubmitted = feessubmitted;
           

           
            studentFeesList.Add(s1);
           
        }

        public static void ShowStudents()
        {
            foreach (var student in studentsList)
            {
                Console.WriteLine(student.Id +".."+student.Name+ " "+student.TotalFees);
            }
            
            foreach (var student in studentFeesList)
            {
                Console.WriteLine(student.StudentId + "--" +student.FeesSubmitted+"--"+student.FeesRemaining);
            }
        }
    }
}
