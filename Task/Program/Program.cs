using System;
using System.Diagnostics;
using System.Text;

namespace Program
{

    public class Program
    {
        static void Main()
        {
            User user = new User("Raqif","Mursalov","T5T6",Month.February);
            Console.WriteLine(user.GetDetails());

            User user1 = new User("Farid", "Necefli", "T5T6V8", Month.January);
            Console.WriteLine(user1.GetDetails());

            User user2 = new User("Rufat", "Guluzade", "T5T6", Month.march);
            Console.WriteLine(user2.GetDetails());

        }


    }

}