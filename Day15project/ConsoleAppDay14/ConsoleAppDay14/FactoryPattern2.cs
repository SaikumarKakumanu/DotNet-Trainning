using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay14
{

    public interface CreditCard
    {
        string GetCardType();
        float GetCreditLimit();
        int GetAnnualFees();
    }

    public class Platinum : CreditCard
    {
        public int GetAnnualFees()
        {
            return 2000;
        }

        public string GetCardType()
        {
            return " Platinum Card";
        }

        public float GetCreditLimit()
        {
            return 40000;
        }
    }

    public class Titanium : CreditCard
    {
        public int GetAnnualFees()
        {
            return 1500;
        }

        public string GetCardType()
        {
            return "Titanium Card";
        }

        public float GetCreditLimit()
        {
            return 30000;
        }
    }

    public class MoneyBack : CreditCard
    {
        public int GetAnnualFees()
        {
            return 1000;
        }

        public string GetCardType()
        {
            return " MoneyBack Card";
        }

        public float GetCreditLimit()
        {
            return 20000;
        }
    }

    //Factory class to abstract the creation logic 
    public abstract class CreditCardFactory
    {
        protected abstract CreditCard CreateCard();//abstract method

        public CreditCard GenerateCard() //non-abstract method
        {
            return this.CreateCard();
        }
        public static CreditCard GetCard(int a)
        {
            CreditCard credit;
            switch (a)
            {
                case 1:
                    credit = new Platinum();
                    break;
                case 2:
                    credit = new Titanium();
                    break;
                case 3:
                    credit = new MoneyBack();
                    break;
                default:
                    credit = null;
                    break;
            }
            return credit;
        }
    }

    //derived factory classes of the abstract class and impplement the abstract method
    public class MoneybackFactory : CreditCardFactory
    {
        protected override CreditCard CreateCard()
        {
            CreditCard ctype = new MoneyBack();
            return ctype;
        }
    }

    public class TitaniumFactory : CreditCardFactory
    {
        protected override CreditCard CreateCard()
        {
            CreditCard ctype = new Titanium();
            return ctype;
        }

    }

    public class PlatinumFactory : CreditCardFactory
    {
        protected override CreditCard CreateCard()
        {
            CreditCard ctype = new Platinum();
            return ctype;
        }
    }

    internal class FactoryPattern2
    {

        static void Main()
        {
            Console.WriteLine("Enter 1 for platinum card");
            Console.WriteLine("Enter 2 for titanium card");
            Console.WriteLine("Enter 3 for moneyback card");
            int value = Convert.ToInt32(Console.ReadLine());
            CreditCard creditcard = CreditCardFactory.GetCard(value);



            if (creditcard != null)
            {
                Console.WriteLine("Card Type is : " + " " + creditcard.GetCardType());
                Console.WriteLine("Credit Limit is :" + " " + creditcard.GetCreditLimit());
                Console.WriteLine("Annual Fees is: " + " " + creditcard.GetAnnualFees());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }

            //CreditCard cc = new PlatinumFactory().GenerateCard();
            //if (cc != null)
            //{
            //    Console.WriteLine("Card Type is : " + " " + cc.GetCardType());
            //    Console.WriteLine("Credit Limit is :" + " " + cc.GetCreditLimit());
            //    Console.WriteLine("Annual Fees is: " + " " + cc.GetAnnualFees());
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Card Type");
            //}
            //Console.WriteLine("---------------------------");
            //cc = new TitaniumFactory().GenerateCard();
            //if (cc != null)
            //{
            //    Console.WriteLine("Card Type is : " + " " + cc.GetCardType());
            //    Console.WriteLine("Credit Limit is :" + " " + cc.GetCreditLimit());
            //    Console.WriteLine("Annual Fees is: " + " " + cc.GetAnnualFees());
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Card Type");
            //}
            ////write the code for moneybackfactory as above
            //Console.WriteLine("---------------------------------");
            //cc= new MoneybackFactory().GenerateCard();

            //if (cc != null)
            //{
            //    Console.WriteLine("Card Type is : " + " " + cc.GetCardType());
            //    Console.WriteLine("Credit Limit is :" + " " + cc.GetCreditLimit());
            //    Console.WriteLine("Annual Fees is: " + " " + cc.GetAnnualFees());
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Card Type");
            //}

            //Console.WriteLine("--------------------------------------------------");


            //if (cc == new MoneybackFactory().GenerateCard() || cc == new PlatinumFactory().GenerateCard() || cc == new TitaniumFactory().GenerateCard())
            //{
            //    if (cc != null)
            //    {
            //        Console.WriteLine("Card Type is : " + " " + cc.GetCardType());
            //        Console.WriteLine("Credit Limit is :" + " " + cc.GetCreditLimit());
            //        Console.WriteLine("Annual Fees is: " + " " + cc.GetAnnualFees());
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Card Type");
            //    }
            //}
            Console.Read();
        }
    }
}
