using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUpForm
{
    public class user
    {
        public string name, gender, location, email, confirm;
        public int age, pass, c_pass, new_pass, pass_check;

        public user()
        {
                Console.Write("Enter Name: ");
                name = Console.ReadLine();
                Console.Write("Enter Age: ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Gender: ");
                gender = Console.ReadLine();
                Console.Write("Enter Location: ");
                location = Console.ReadLine();
                Console.Write("Enter Email: ");
                email = Console.ReadLine();
            do
            {
                Console.Write("Enter Password: ");
                pass = Convert.ToInt32(Console.ReadLine());
                Console.Write("Confirm Password: ");
                c_pass = Convert.ToInt32(Console.ReadLine());

                if (pass == c_pass)
                {
                    pass = c_pass;
                    break;
                }
                else
                {
                    Console.WriteLine("Passwords do not match");
                    Console.WriteLine("\n");
                    Console.Write("Do You Want To Restart? (Y / N): ");
                    confirm = Console.ReadLine();   
                }
            }
            while (confirm == "y");
            Console.WriteLine("\n");
        }

        public void display()
        {
            Console.WriteLine("\n");
            Console.WriteLine("***User Information***");
            Console.Write("Name: " +name+ "\n");
            Console.Write("Age: " +age+ "\n");
            Console.Write("Gender: " +gender+ "\n");
            Console.Write("Location: " +location+ "\n");
            Console.Write("Email: " +email);
        }
    }

    public class factory
    {
        public static user create()
        {
            user u = new user();
            return u;
        }
        public static void change(ref user u)
        {
            do
            {
                Console.Write("Enter the current password: ");
                u.pass_check = Convert.ToInt32(Console.ReadLine());
                if (u.pass == u.pass_check)
                {
                    Console.Write("Enter New Password: ");
                    u.new_pass = Convert.ToInt32(Console.ReadLine());
                    u.pass = u.new_pass;
                    Console.WriteLine("Password Updated");
                    u.display();
                    break;
                }
                else
                {
                    Console.WriteLine("Passwords do not match");
                    Console.Write("Do You Want To Try Again? (Y / N): ");
                    u.confirm = Console.ReadLine();
                }
            }
            while (u.confirm == "y");
            Console.WriteLine("\n");
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            user u = factory.create();
            Console.Write("Do You Want To Change Your Password? (Y / N): ");
            string choice = Console.ReadLine();
            if (choice == "y")
            {
                factory.change(ref u);
            }
            else
            {
                Console.WriteLine("Program Terminated..");
            }


            Console.ReadKey();
        }
    }
}