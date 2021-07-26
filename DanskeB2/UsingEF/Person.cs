using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UsingEF
{
    public enum PersonGender
    {
        Male,
        Female
    }
    public class Person
    {
        #region Properties
        //Name, Age, Email, Height, Weight, Address, Aadhaar, Gender
        //Auto-properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public string Address { get; set; }

        [Key]
        public string Aadhaar { get; set; }

        public PersonGender Gender { get; set; }
        #endregion
    }
}
