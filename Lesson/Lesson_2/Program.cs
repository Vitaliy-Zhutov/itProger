using System;

namespace project {
    class Program {
        static void Main() {
            Console.Write("Enter name: ");
            string role = Console.ReadLine()!;

            if(role == "Admin") {
                Console.Write("Enter user name: ");
                string user_name = Console.ReadLine()!;
                Console.Write("Enter {0} age: ", user_name);
                short age = Convert.ToInt16(Console.ReadLine()!);

                if(age <= 0 || age > 99) {
                    Console.Write("Enter {0} age: ", user_name);
                    age = Convert.ToInt16(Console.ReadLine()!);
                }

                if(age <= 0 || age > 99) {
                    Console.WriteLine("Error");
                    age = 0;
                }
                else
                    Console.WriteLine("User age is " + age);

            } else
                Console.WriteLine("You are not admin!");


        }
    }
}
