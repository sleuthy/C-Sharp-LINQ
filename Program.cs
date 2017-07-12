using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{

// // Which of the following numbers are multiples of 4 or 6
// List<int> numbers = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// }

// var fourSixMultiples = numbers.Where();


// // Order these student names alphabetically, in descending order (Z to A)
// List<string> names = new List<string>()
// {
//     "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
//     "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
//     "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
//     "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
//     "Francisco", "Tre" 
// }

// var descend = ...
// // Build a collection of these numbers sorted in ascending order
// List<int> numbers = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// }

// // Output how many numbers are in this list
// List<int> numbers = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// }
// How much money have we made?
// List<double> purchases = new List<double>()
// {
//     2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
// }
// What is our most expensive product?
// List<double> prices = new List<double>()
// {
//     879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
// }

/*
    Store each number in the following List until a perfect square
    is detected.

    Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
*/
// List<int> wheresSquaredo = new List<int>()
// {
//     66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
// }

// Build a collection of customers who are millionaires
public class Customer
{
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
}

public class Program
{
    public static void Main() {
        List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

        var millionaires = from cust in customers
            where cust.Balance >= 1000000
            select cust;
        
        // var grouped = customers.Where(c => c.Balance >= 1000000)
        //                         .GroupBy(d => d.Bank, d => d.Name);


    // // Find the words in the collection that start with the letter 'L'
    List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

    var LFruits = from fruit in fruits
        where fruit.StartsWith("L")
        select fruit;
    
    foreach (var fruit in fruits)
    {
        Console.WriteLine($"{fruit}");
    }

        foreach (var cust in millionaires)
        {
            Console.WriteLine($"{cust.Name} ${cust.Balance}");
        }

        var grouped = from mill in millionaires
            group mill by mill.Bank into taco
            select new { Bank = taco.Key, Customers = taco };

        foreach (var taco in grouped)
        {
            Console.WriteLine($"{taco.Bank}");
            Console.WriteLine($"{taco.Customers}");

            foreach (var cust in taco.Customers)
            {
                Console.WriteLine($" {cust.Name}");
            }
        }
    }
}



/* 
    Given the same customer set, display how many millionaires per bank.
    Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

    Example Output:
    WF 2
    BOA 1
    FTB 1
    CITI 1
*/


/*
    TASK:
    As in the previous exercise, you're going to output the millionaires,
    but you will also display the full name of the bank. You also need
    to sort the millionaires' names, ascending by their LAST name.

    Example output:
        Tina Fey at Citibank
        Joe Landy at Wells Fargo
        Sarah Ng at First Tennessee
        Les Paul at Wells Fargo
        Peg Vale at Bank of America
*/

// // Define a bank
// public class Bank
// {
//     public string Symbol { get; set; }
//     public string Name { get; set; }
// }

// // Define a customer
// public class Customer
// {
//     public string Name { get; set; }
//     public double Balance { get; set; }
//     public string Bank { get; set; }
// }

// public class Program
// {
//     public static void Main() {
//         // Create some banks and store in a List
//         List<Bank> banks = new List<Bank>() {
//             new Bank(){ Name="First Tennessee", Symbol="FTB"},
//             new Bank(){ Name="Wells Fargo", Symbol="WF"},
//             new Bank(){ Name="Bank of America", Symbol="BOA"},
//             new Bank(){ Name="Citibank", Symbol="CITI"},
//         };

//         // Create some customers and store in a List
//         List<Customer> customers = new List<Customer>() {
//             new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
//             new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
//             new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
//             new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
//             new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
//             new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
//             new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
//             new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
//             new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
//             new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
//         };


//         var millionaireReport = ...

//         foreach (var customer in millionaireReport)
//         {
//             Console.WriteLine($"{customer.Name} at {customer.Bank}");
//         }

}