using System;
namespace Classes
{
	public class Customer
	{
      
        public int  Id { get; set; }


        private string _firstName;
        public string FirstName
        {
            get { return "Mrs." + _firstName; }
            set {_firstName = value; }
        }


        public string LastName { get; set; }
        public string City { get; set; }
    }
}









//field : değişken  (özellikleri tutmak için)
//public string FirstName;

//Propery :özellik tanımlamak için kullanılır.