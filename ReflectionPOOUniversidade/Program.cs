using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPOOUniversidade
{
    public class Program
    { 
        public static void DisplayPublicProperties(object obj)
        {
            Type t = obj.GetType();
            PropertyInfo[] propriedades = t.GetProperties();
            Console.WriteLine("Propriedades publicas de Student");
            Console.Write(" - ");
            foreach (var propriedade in propriedades) 
            {
                Console.Write(propriedade.Name);
                Console.Write(" - ");

            }
        }

        public static void CreateInstanceStudent()
        {
            Type t = typeof(Student);

            object estudante = Activator.CreateInstance(t);
            PropertyInfo propriedade = t.GetProperty("Name");
            propriedade.SetValue(estudante, "Jose");

            propriedade = t.GetProperty("University");
            propriedade.SetValue(estudante, "PUC");

            propriedade = t.GetProperty("RollNumber");
            propriedade.SetValue(estudante, 12345);
            PropertyInfo[] propriedades = t.GetProperties();
            foreach (PropertyInfo prop in propriedades)
            {
                Console.WriteLine(prop.Name + ": " + prop.GetValue(estudante));
            }
        }
        public static void Main(string[] args)
        {
            Student estudante = new Student();
            DisplayPublicProperties(estudante);

            Console.WriteLine();

            CreateInstanceStudent();                       
           
        }
    }

}
