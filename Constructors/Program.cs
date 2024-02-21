using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            Customer customer1 = new Customer { Id = 1, FirstName = "Engin", LastName = "Demirog", City = "Ankara" };


            Customer customer4 = new Customer() { Id = 1, FirstName = "Engin", LastName = "Demirog", City = "Ankara" };


            Customer customer5 = new Customer()
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demirog",
                City = "Ankara"
            };



            Customer customer6 = new Customer
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demirog",
                City = "Ankara"
            };


            
            Customer customer2 = new Customer(2, "Derin", "Demirog", "Ankara");



            Console.WriteLine(customer2.FirstName);



            Console.ReadLine();

        }


        class Customer
        {

            



            public Customer()  
            {
                Console.WriteLine("Defult Cunstructor worked.");
            }

            public Customer(int id, string firstname, string lastname, string city)
            {
                

                Id = id;
                FirstName = firstname;
                LastName = lastname;
                City = city;

                Console.WriteLine("Yapıcı blok çalıştı.");
            }


            public int Id { get; set; }
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string City { get; set; }
        }

    }

}
