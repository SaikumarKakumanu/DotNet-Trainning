using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonDay7
{
    class VotingException : ApplicationException
    {
        public VotingException(string msg) : base(msg)
        {

        }
    }

    class Vote
    {
        int age;

        public void acceptAge()
        {
            Console.WriteLine("Enter Your Age");
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                throw (new VotingException("Age should be greater than 18 to Vote"));
            }
            else
                Console.WriteLine("Thanks for Voting..");
        }
    }
    internal class UserDefinedException
    {
        static void Main()
        {
            Vote vote = new Vote();
            try
            {
                vote.acceptAge();
            }
            catch (VotingException ve)
            {
                Console.WriteLine(ve.Message);
            }
            catch (Exception fe)
            {
                Console.WriteLine("Some error occured");
            }
            Console.Read();
        }
    }
}
