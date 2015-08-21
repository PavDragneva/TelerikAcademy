//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
//bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types 
//and descriptive names.
using System;
class BankAccountData
{
    static void Main()
    {
        string firstName = "Krasimira";
        string middleName = "Mireva";
        string lastName = "Ivanova";
        decimal amountMoney = 2560.39m;
        string bankName = "DSK";
        string IBAN = "BG80 BRRG 0000 1020 3456 11";
        long firstCreditCardNumber = 1234567890765;
        long secondCreditCardNumber = 579383589839298;
        long thirdCreditCardNumber = 371449635398431;
        Console.WriteLine("First name: {0} \nSecond name: {1} \nLast name: {2} \nAmount of money: {3} \nBank name: {4} \nIBAN: {5} \nFirst credit card number: {6} \nSecond credit card number: {7} \nThird credit card number: {8}", firstName, middleName, lastName, amountMoney, bankName, IBAN, firstCreditCardNumber, secondCreditCardNumber, thirdCreditCardNumber);
    }
}

