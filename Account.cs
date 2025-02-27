namespace UppgiftBankomat
{
    internal class Account
    {
        private static int currentHighestAccountNumber = 0;
        
        public int AccountNumber { get; private set; }
        public decimal Balance { get; private set; }
        public string FormattedAccountNumber { get { return $"{AccountNumber:00000000}";  } } // 6 digits e.g. 000001
        public string FormattedBalance {  get { return $"{Balance,17:C}"; } } // length 17, currency format

        public Account()
        {
            AccountNumber = ++currentHighestAccountNumber;
            Balance = 0.00M;
        }

        public void AddFunds(decimal amount)
        {
            if (amount > 0)
                Balance += amount;
        }

        public void WithdrawFunds(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
                Balance -= amount;
        }

        public override string ToString()
        {
            return $"Konto: {FormattedAccountNumber} Saldo: {FormattedBalance}";
        }
    }
}