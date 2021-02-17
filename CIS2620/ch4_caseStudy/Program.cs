/*
 *  Filename: greenvilleRevenue
 *  Written by: Jacob Ogima
 *  Written on: 02/11/21
 *  Notes:
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

class GreenvilleRevenue
{
    static void Main()
    {
        // int list
        int lastYear;
        int thisYear;

        // ask user for last year
        Console.WriteLine("Enter contestants from LAST year:");
        lastYear = Convert.ToInt32(Console.ReadLine());

        // ask user for this year
        Console.WriteLine("Enter contestants from THIS year:");
        thisYear = Convert.ToInt32(Console.ReadLine());

        // run if statement to find which year was better or worse
        if (thisYear > (lastYear * 2))
        {
            // more than twice of last year
            Console.WriteLine("The competition is more than twice as big this year");
        }
        else if (thisYear > lastYear && thisYear < (lastYear * 2))
        {
            // bigger than last year but not more than twice
            Console.WriteLine("The competition is bigger than ever!");
        }
        else
        {
            // smaller than last year
            Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        }
    }
}