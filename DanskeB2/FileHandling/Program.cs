using System;
using System.IO;
using System.Text;
using BL;
using Newtonsoft.Json;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            FileOperations();
            string serialized = Serialization();
            Deserialization(serialized);

        }

        private static void Deserialization(string serialized)
        {
            Person RebornFromJon =JsonConvert.DeserializeObject<Person>(serialized);
            Console.WriteLine("### DESERIALIZED OBJECT ###");
            Console.WriteLine($"Name: {RebornFromJon.Name}");
            Console.WriteLine($"Age: {RebornFromJon.Age}");
            Console.WriteLine($"Gender: {RebornFromJon.Gender}");
            Console.WriteLine($"Address: {RebornFromJon.Address}");
            Console.WriteLine($"Aadhaar: {RebornFromJon.Aadhaar}");

        }

        private static string Serialization()
        {

            Person Jon = new Person() { Aadhaar = "AA0239443924ZA", Name = "Jon Jonny", Gender = PersonGender.Male, Address = "Nagaland", Age = 44, Email = "jon@gmail.com" };
            string jsonString =JsonConvert.SerializeObject(Jon);
            /*
             person = {
                        key1: "value1",
                        key2: 1000,
                        key: []
                      }
             */
            Console.WriteLine($"Serialized Person object: {jsonString}");
            return jsonString;
        }

        private static void FileOperations()
        {
            FileStream fs = File.Create(@"F:\SampleFile.txt");  //overitten
            byte[] toWrite = Encoding.ASCII.GetBytes("Hello, please add this to the file");
            fs.Write(toWrite);
            fs.Close();

            string fileData = File.ReadAllText(@"F:\SampleFile.txt");
            Console.WriteLine($"File Data: {fileData}");
            File.AppendAllText(@"F:\SampleFile.txt", "Some more data added.");
            Console.WriteLine($"File Data after append: {File.ReadAllText(@"F:\SampleFile.txt")}");

            Console.WriteLine(File.GetAttributes(@"F:\SampleFile.txt"));
            Console.WriteLine(File.GetCreationTime(@"F:\SampleFile.txt"));
        }
    }
}
