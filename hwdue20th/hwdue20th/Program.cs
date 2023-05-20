using System;

namespace hwdue20th
{
    class DebitCard
    {
        public string OwnerName { get; set; }
        public string OwnerSurname { get; set; }
        public string CompanyName { get; set; }
        public string CardNumber { get; set; }
        public decimal Balance { get; set; }
        public string CVVCode { get; set; }

        public void IncomeBalance(decimal money)
        {
            if (money <= 0) return;

            Balance += money;

        }

        public class Program
        {
            public static void Main(string[] args)
            {
                DebitCard myDebitCard = new DebitCard();

                myDebitCard.OwnerName = "Zahra";
                myDebitCard.OwnerSurname = "Hashimli";
                myDebitCard.CompanyName = "Unibank";
                myDebitCard.CardNumber = "1234567812345678";
                myDebitCard.CVVCode = "111";

                myDebitCard.IncomeBalance(50);

                Console.WriteLine(myDebitCard);



            }





        }





    }




}
