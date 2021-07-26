using System;
using System.Linq;

namespace UsingEF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create dbContext object
            PersonContext context = new PersonContext();
            //Add items
            context.Persons.Add(new Person() { Aadhaar = "AA12", Name = "Jon", Address = "NY", Age = 35, Email = "jon@gmail.com" });
            context.Persons.Add(new Person() { Aadhaar = "AA13", Name = "Bon", Address = "NY", Age = 36, Email = "bon@gmail.com" });
            context.Persons.Add(new Person() { Aadhaar = "AA14", Name = "Don", Address = "NY", Age = 37, Email = "don@gmail.com" });
            context.SaveChanges();

            //Update
            try
            {
                var searchedPerson = context.Persons.Where((p) => p.Name == "Jon").ToList().FirstOrDefault();
                searchedPerson.Address = "India";
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("The update failed");
            }
            context.SaveChanges();
            //Displaying
            context.Persons.ToList().ForEach((p) => { Console.WriteLine(p.Name); });
            
        }
    }
}
