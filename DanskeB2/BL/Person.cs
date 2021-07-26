using System;
using System.Collections.Generic;
using System.Text;



namespace BL
{
    //Every class and its related entities have accessibility
    /*
     * 1. public : Is accessible inside the project and outside the project
     * 2. private : Is accessible only and only inside a scope {...}
     * 3. internal : Is accessible only inside its assembly (project)
     * 4. protected : Is accessible only to relatives or children entities
     */
    public enum PersonGender
    {
        Male,
        Female
    }
    public class Person
    {
        #region Constructor
        //Constructor is a method WITHOUT return-type & the name MUST BE the same as the CLASS NAME
        public Person()
        {

        }
        public Person(string name, string aadhaar)
        {
            //this => Current object
            this.Name = name;
            this.Aadhaar = aadhaar;
        }
        #endregion

        #region Properties
        //Name, Age, Email, Height, Weight, Address, Aadhaar, Gender
        //Auto-properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public string Address { get; set; }
        public string Aadhaar { get; set; }

        public PersonGender Gender { get; set; }
        #endregion

        #region Methods
        //Works(),Eats(),Talks(),Walks()

        public void Works(string taskwithStatus)
        {

        }

        public float Eats(string[] itemsAte)
        {
            return 0;
        }

        public void Talks(string wordsSpoken)
        {

        }

        public int Walks(float distance)
        {
            return ((int)distance) * 1500;
        }

        public int Walks(float distance, string terrainType)
        {
            if (terrainType.ToLower() == "flat")
            {
               return Walks(distance);
            }
            return Walks(distance) * 2;
            
        }

        #endregion
    }
}
