using System;

namespace IntermediateProject.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person bruno = new Person();    
            BankAccount bankAccount1 = new BankAccount(bruno);
            Console.WriteLine(BankAccount.AccontNumbers);
            BankAccount bankAccount2 = new BankAccount(bruno);
            Console.WriteLine(BankAccount.AccontNumbers);


        }
    }  
    

}
