using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace AnnotationsDemo
{
    class AnnotationsTest
    {
        public static void Display()
        {
            Console.WriteLine("Employee Class Validation");

            Employee objEmployee = new Employee();

            objEmployee.Name = "Suchindra";
            objEmployee.Age = 23;
            objEmployee.PhoneNumber = "9087654321";
            objEmployee.emailId = "abc.xyz@gmail.com";

            ValidationContext context = new ValidationContext(objEmployee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(objEmployee, context, results, true);

            if(!valid)
            {
                foreach(ValidationResult Totalresult in results)
                {
                    Console.WriteLine("Member Name : {0}", Totalresult.MemberNames.First(),Environment.NewLine);
                    Console.WriteLine("Error Message :: {0}{1}", Totalresult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name: "+objEmployee.Name+"\nAge: "+objEmployee.Age+"\nPhone Number: "+objEmployee.PhoneNumber+"\nEmail Id: "+objEmployee.emailId);
            }
            Console.WriteLine("\nPress Any Key To Exit");
            Console.ReadKey();
        }
    }
}
