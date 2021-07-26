using System;
using System.Collections.Generic;
using BL;

namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //CreateDefaultPerson();
                //CreatePersonWithParams();
                //VerifyInheritance();
                //VerifyAssociation();
                //VerifyOverride();
                //ImplementInterface();
                //VerifyAccess();
                //WorkWithCollections();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please contact support@danske.com. Provide the following exception detail to them");
                Console.WriteLine($"Message: {ex.Message}| StackTrace: {ex.StackTrace}");
            } 
           

        }

        private static void WorkWithCollections()
        {
            string[] strArray = { "Eena", "Meena", "Deeka" };
            
            List<string> strList = new List<string>() { "Eena", "Meena", "Deeka" };
            strList.Add("Cheeka");
            strList.Add("Pika");
            strList.Remove("Pika");

            List<Person> persons = new List<Person>();
            persons.Add(new Person() { Aadhaar = "A3492304ZZ", Name = "Jon", Age = 30, Gender = PersonGender.Male });
            foreach (Person p in persons)
            {
                Console.WriteLine($"Name: {p.Name}, Aadhaar:{p.Aadhaar}, Age: {p.Age}, Gender: {p.Gender}");
            }
        }

        private static void VerifyAccess()
        {
            IamPublic publicObject = new IamPublic();
            publicObject.PublicInfo = "Public Info";
            publicObject.SetPrivateInfo("A new secret");
            publicObject.SetProtectedInfo("My CTC is 1000000000");
            Console.WriteLine(publicObject.GetProtectedInfo());
            Console.WriteLine(publicObject.GetPrivateSecret());
        }

        private static void ImplementInterface()
        {
            string inputDbms = Console.ReadLine();
            ISql sqlDb = null;
            switch (inputDbms.Trim().ToLower())
            {
                case "mssqlserver":
                    sqlDb = new MsSQLServer();
                    break;

                case "oracle":
                    sqlDb = new Oracle();
                    break;

                default:
                    break;
            }

            //Call required methods...
            Console.WriteLine($"##### DBMS:: {sqlDb.GetType().Name} #####");
            Console.WriteLine($"SELECT Syntax:: {sqlDb.GetSelectQuerySyntax()}");
            Console.WriteLine($"INSERT Syntax:: {sqlDb.GetInsertQuerySyntax()}");
            Console.WriteLine($"UPDATE Syntax:: {sqlDb.GetUpdateQuerySyntax()}");
            Console.WriteLine($"DELETE Syntax:: {sqlDb.GetDeleteQuerySyntax()}");
        }

        private static void VerifyOverride()
        {
            string inputShape = Console.ReadLine();
            Shape s = null;
            //base =new derived()
            #region Decide on the correct shape instance
            switch (inputShape.Trim().ToLower())
            {
                case "circle":
                    s = new Circle() { Radius=5};
                    break;
                case "square":
                    s = new Square() { Side = 10 };
                    break;
                default:
                    break;
            }
            #endregion

            try
            {
                s.Draw();
                Console.WriteLine($"Area={s.CalculateArea()} units");
            }
            catch (NotImplementedException nex)
            {
                Console.WriteLine("Please choose a shape between Circle and Square Only");
                throw nex;
            }
            catch(DivideByZeroException dex)
            {
                throw dex;
            }
            catch
            {
                throw new Exception("Please choose a shape between Circle and Square Only");
            }
            finally
            {
                Console.WriteLine("Returning to caller ....");
            }
            

        }

        private static void VerifyAssociation()
        {
            Engine Suzuki = new Engine();
            Suzuki.Brand = "Suzuki";
            Suzuki.EngineType = "8-Stroke";
            Suzuki.HorsePower = 100;

            Car Maruti = new Car(Suzuki);
            Console.WriteLine($"Maruti's Engine Features: Brand:{Maruti.CarEngine.Brand}," +
                              $"Engine Type: {Maruti.CarEngine.EngineType}, " +
                              $"Horse Power: {Maruti.CarEngine.HorsePower}cc");
        }

        private static void VerifyInheritance()
        {
            Parent Daddy = new Parent();
            Child DaddysChild = new Child();
            Grandchild Chintu = new Grandchild();

            //For DaddysChild
            DaddysChild.Name = "Ashokan";
            DaddysChild.Email = "ashokan@gmail.com";
            Console.WriteLine("Verifying access to Daddy");
            DaddysChild.CheckAvailabilityFromParent();

            //For Chintu
            Chintu.Name = "Chintu Swamy";
            Chintu.Email = "chintu@gmail.com";
            Console.WriteLine("Verifying access to Daddy & DaddysChild: ");
            Chintu.TestAll();

        }

        private static void CreateDefaultPerson()
        {
            Person Jon = new Person();
            Jon.Aadhaar = "AB203943249340YZ";
            Jon.Name = "Jon Fernandes";
            Jon.Age = 32;
            Jon.Email = "jon@gmail.com";
            Jon.Gender = PersonGender.Male;
            string[] sArray = { "Rice", "Sabji", "Sambar", "Curd" };
            Console.WriteLine($"Total calories after meal: {Jon.Eats(sArray)}");
            Console.WriteLine($"Total steps walked: {Jon.Walks(2)}");
        }

        static void CreatePersonWithParams()
        {
            Person Bob = new Person("Bob", "AA1234598765VZ");
            Console.WriteLine("########");
            Console.WriteLine($"Person object created with " +
                $"name: {Bob.Name}, aadhar:{Bob.Aadhaar}");

            Console.WriteLine($"Calling overloaded Walks(): " +
                              $"{Bob.Walks(2, "FiAt")}");
        }
    }
}
