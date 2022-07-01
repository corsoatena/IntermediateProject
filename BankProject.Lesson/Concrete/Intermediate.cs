using System;

namespace IntermediateProject.Lesson
{
    internal abstract class Intermediate : ICentralBank
    {
        public abstract void ManageMoney();        
    }
    internal class Bank : Intermediate
    {  
         BankAccount account;
        public override void ManageMoney()
        {
            Withdraw();
        }
        public void Withdraw()
        {
            Console.WriteLine(" Sto prelevando dalla banca.");
        }
    }
    public class Borsa : Intermediate
    {
        public override void ManageMoney()
        {
            Sell();
        }
        public void Sell()
        {
            Console.WriteLine(" Sto vendendo le mie azioni.");
        }
    }
}
