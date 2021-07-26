using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class IamPublic {
        private string Secret { get; set; } //Visible within a scope {...}
        protected string ProtectedInfo { get; set; }    //Visible ONLY to derived classes
        public string PublicInfo { get; set; }  //Visible to all classes and referenced projects
        internal string InternalInfo { get; set; }  //Visible inside the same assembly / project

        public string GetProtectedInfo()
        {
            return this.ProtectedInfo;
        }

        public string GetPrivateSecret()
        {
            return this.Secret;
        }

        public void SetProtectedInfo(string s)
        {
            this.ProtectedInfo = s;
        }
        public void SetPrivateInfo(string s)
        {
            this.Secret = s;
        }
    }

    internal class IamInternal : IamPublic { 
        public void PrintAll()
        {
            // this.Secret //Not accessible
            this.ProtectedInfo = "A protected property";
            this.PublicInfo = "I'm in the public domain";
            this.InternalInfo = "I am an internal property";
        }
    }

}
