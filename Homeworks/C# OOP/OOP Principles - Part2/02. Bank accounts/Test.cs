//A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
//Customers could be individuals or companies.
//All accounts have customer, balance and interest rate (monthly based).
//Deposit accounts are allowed to deposit and with draw money.
//Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: 
//number_of_months * interest_rate.
//Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
//Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//Your task is to write a program to model the bank system by classes and interfaces.
//You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality 
//through overridden methods.
using System;
class Test
{
    static void Main()
    {
        Console.WriteLine("Mortage account");
        MortageAccount mort = new MortageAccount(CustumerType.Individual, 344, 0.006);
        double interAmount = mort.InterestAmount(12);
        Console.WriteLine("The interest amount for the first year is {0:0.00}%", interAmount * 100);
        Console.WriteLine();

        Console.WriteLine("Loan account");
        LoanAccount loan = new LoanAccount(CustumerType.Company, 1500, 0.009);
        interAmount = loan.InterestAmount(24);
        Console.WriteLine("The interest amount for the first two years is {0:0.00}%", interAmount * 100);
        Console.WriteLine();

        Console.WriteLine("Deposit account");
        DepositAccount deposit = new DepositAccount(CustumerType.Company, 1200, 0.007);
        interAmount = deposit.InterestAmount(6);
        Console.WriteLine("The interest amount for the first 6 monts is {0:0.00}%", interAmount * 100);
        Console.WriteLine();
    }
}