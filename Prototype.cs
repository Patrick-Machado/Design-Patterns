using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Study
{
    //referencia: https://www.c-sharpcorner.com/UploadFile/SukeshMarla/learn-design-pattern-prototype-pattern/
    // acessado em 24/5/2019
    class Prototype
    {
        public static void Main(string[] args) { 
            Console.WriteLine("Shallow Copy Sample\n");  
            AuthorForShallowCopy o = new AuthorForShallowCopy()  
            {  
              Name="Sukesh Marla",  
              TwitterAccount = "https://twitter.com/SukeshMarla",  
              Website="http://www.sukesh-marla.com",  
              HomeAddress=new Address()  
              {  
                        City="Mumbai",  
                        State= "Maharastra"  
              }  
                };  
                Console.WriteLine("Original Copy");  
                Console.WriteLine(o);  
                AuthorForShallowCopy clonedObject = (AuthorForShallowCopy)o.Clone();  
                Console.WriteLine("\nCloned Copy");  
                Console.WriteLine(clonedObject);  
                Console.WriteLine("\nMake Changes to clone copy address");                             
                clonedObject.Name = "Mr.Changer";  
                clonedObject.TwitterAccount = "https://twitter.com/MrChanger";  
                clonedObject.Website = "https://MrChanger.com";  
                clonedObject.HomeAddress.State = "Karnataka";  
                clonedObject.HomeAddress.City = "Manglore";  
                Console.WriteLine("\nCloned Copy");  
                Console.WriteLine(clonedObject);  
                Console.WriteLine("\nOriginal Copy");  
                Console.WriteLine(o);  
        }
    }

    public class Address
    {
        public string State
        { get; set; }

        public string City
        { get; set; }
    }

    public class AuthorForShallowCopy : ICloneable
    {
        public string Name
        { get; set; }
        public string TwitterAccount
        { get; set; }
        public string Website
        { get; set; }
        public Address HomeAddress
        { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }



}
