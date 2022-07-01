using System;

namespace IntermediateProject.Lesson
{
    internal abstract class Account
    {
        protected Client _client;
        public Account(Person person)
        {
            _client = new Client();
            CreateNewClient(person);
        }

        //  public abstract void CreateNewClient(Person person); 
        protected void CreateNewClient(Person person)
        {
            Random random = new Random();
            var n = random.Next(1, 100);
            _client._code = n;
        }
    }
    internal class BankAccount : Account
    {   
        Stock _stock;
        Liquidity _liquidity;
        Crypto _cryptpo;

        public BankAccount(Person person) :base(person)
        {
           
        }
        //public override void CreateNewClient(Person person)
        //{
        //    Random random = new Random(); 
        //    var n = random.Next(1,100);
        //    _client._code = n;
        //}

    }
    internal class CryptoAccount : Account
    {
        Crypto _cryptpo;
        public CryptoAccount(Person person) : base(person)
        {
            CreateNewClient(person);
        }
        //public override void CreateNewClient(Person person)
        //{
        //    Random random = new Random();
        //    var n = random.Next(1, 100);
        //    _client._code = n;
        //}
    }
    internal class StockAccount : Account
    {
        Stock _stock;
        public StockAccount(Person person) : base(person)
        {
            CreateNewClient(person);
        }
        //public override void CreateNewClient(Person person)
        //{
        //    Random random = new Random();
        //    var n = random.Next(1, 100);
        //    _client._code = n;
        //}
    }
    
}
