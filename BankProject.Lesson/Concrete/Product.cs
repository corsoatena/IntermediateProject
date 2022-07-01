namespace IntermediateProject.Lesson
{
    public abstract class Product { }
    public class Stock : Product 
    {
        decimal _amount;
        TICKER _symbol;
        public Stock(decimal Total, TICKER Symbol)
        {
            _amount = Total;
            _symbol = Symbol;
        }
    }
    public class Crypto : Product
    {
        decimal _amount;
        CRYPTO _symbol;
        public Crypto(decimal Total, CRYPTO Symbol)
        {
            _amount = Total;
            _symbol = Symbol;
        }
    }
    public class Liquidity : Product 
    {   
        decimal _amount;
        FIAT _currency;
        public string Amount { get { return $"{_amount} {_currency}"; } } 
        public Liquidity(decimal Total, FIAT Currency)
        {
            _amount=Total;
            _currency=Currency; 
        }

        public void ResetAmount(decimal Total)
        {
            _amount= Total;  
        }

    }

}
