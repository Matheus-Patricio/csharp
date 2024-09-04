using System;

namespace FirstProject {
    class NuxtBank{
            public static void Main(string[] args){
                NuxtUser  JohnUser = new NuxtUser();
                JohnUser.Balance = 0;
                JohnUser.UserName = "John da Silva";
                JohnUser.DepositInAccount(1000);
                JohnUser.ShowBalance();
            }

    }

    public class NuxtUser {
        public string UserName;
        public decimal Balance;

        public void DepositInAccount(decimal amount) {
            Balance +=  amount;
        }
        public void ShowBalance()
        {
            Console.WriteLine($"{UserName} possui saldo de {Balance}");
        }
    }
}