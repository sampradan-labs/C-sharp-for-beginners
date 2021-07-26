using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class Parent {
        public string Name { get; set; }
        public double GetAssetValue()
        {
            return 100000000d;
        }
    }

    public class Child : Parent {
        public string Email { get; set; }
        public void CheckAvailabilityFromParent() {
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Asset Value: {this.GetAssetValue()}");
        }
    }

    public class Grandchild : Child {
        public void TestAll()
        {
            Console.WriteLine($"Email: {this.Email}");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Asset Value: {this.GetAssetValue()}");
        }
    }
}
