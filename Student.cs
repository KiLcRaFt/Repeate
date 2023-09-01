//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static Repeate.Program;

//namespace Repeate
//{
//    public class Student
//    {
//        public string Name { get; }
//        public int age;
//        private readonly string _city;
//        public string status;

//        public Student(string name, int age, string city)
//        {
//            Name = name;
//            Age = age;
//            _city = city;
//        }

//        public int Age
//        { 
//            get { return age; }
//            set 
//            {
//                age = value;
//                if (age < 18) status = "alaealine";
//                else status = "täiskasvanud";
//            }
//        }

//        public int BDate ()
//        {
//            int bdate = DateTime.Now.Year;
//            int Result = bdate - age;
//            return Result;
//        }
//        public string Status
//        { 
//            get { return status; } 
//        }
//        public string GetCity()
//        {
//            return _city;
//        }
//        public void ShowInfo()
//        {
//            Console.WriteLine(Name);
//            Console.WriteLine(Age);
//            Console.WriteLine(GetCity());
//            Console.WriteLine(status);
//            Console.WriteLine(BDate());

//        }
//    }
    
//}
