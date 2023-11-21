using Payment.Model;
using System.Collections.Immutable;

namespace Payment
{
    public class UserPayment
    {
        public static void Main(string[] args)
        {
            List<User> user = new List<User>()
            {
                new User()
                {
                    id = 1,
                    firstName = "Gabriel",
                    lastName = "Johnson",
                    email = "gj@gmail.com"
                },

                new User()
                {
                    id = 2,
                    firstName = "Temi",
                    lastName = "Dave",
                    email = "td@gmail.com"
                },

                new User()
                {
                    id = 3,
                    firstName = "Paul",
                    lastName = "Orimogunje",
                    email = "paulorimogunje@gmail.com"
                },
                new User()
                {
                    id = 4,
                    firstName = "James",
                    lastName = "Tolu",
                    email = "jt@gmail.com"
                },
                new User()
                {
                    id = 5,
                    firstName = "Sola",
                    lastName = "Tope",
                    email = "st@gmail.com"
                }
            };
            List<Payment1> payment1 = new List<Payment1>()
             {
              new Payment1(){id = 1, userId = 101, paymentAmount = 10000},
              new Payment1(){id = 2, userId = 102, paymentAmount = 11000},
              new Payment1(){id = 3, userId = 103, paymentAmount = 12000},
              new Payment1(){id = 4, userId = 104, paymentAmount = 20000},
              new Payment1(){id = 5, userId = 105, paymentAmount = 1000}
            };

            foreach (var person in user)
            {
                Console.WriteLine(" ID: " + person.id + "\n Name: " + person.firstName + "\n Surname: " + person.lastName + "\n Email " + person.email);
                foreach (var paid in payment1)
                {
                    if (paid.id == person.id)
                    {
                        Console.WriteLine(" UserID " + paid.userId + "\n Amount Paid " + paid.paymentAmount);
                        Console.WriteLine();
                    }
                }
            }
        }
    }  
}
