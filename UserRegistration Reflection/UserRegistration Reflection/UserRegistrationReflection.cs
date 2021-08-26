using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace UserRegistrationReflection
{
    class UserRegistrationReflection
    {
        public static void UserRegistrationReflectionTest()
        {
            Type type = typeof(UseCases);
            Console.WriteLine("Full Name: {0}",type.FullName);
            Console.WriteLine("Class Name: {0}", type.Name);
            Console.WriteLine("\n");
            Console.WriteLine("Methods In UseCases Class");
            MethodInfo[] methods = type.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name+" "+method.Name);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Properties In UseCases Class");
            PropertyInfo[] properties = type.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name+" "+property.Name);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Constructors In UseCases Classes");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach(ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
