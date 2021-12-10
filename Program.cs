using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace adventofcode
{
    class Program
    {
        static void Main(string[] args)
        {

            DayOne dayOne = new DayOne();
            int answerDayOnePartOne = dayOne.DayOnePartOne();
            Console.WriteLine("Answer Day One Part One:  " + answerDayOnePartOne);
            int answerDayOnePartTwo = dayOne.DayOnePartTwo();
            Console.WriteLine("Answer Day One Part Two: " + answerDayOnePartTwo);

            DayTwo dayTwo = new DayTwo();
            int answerDayTwoPartOne = dayTwo.DayTwoPartOne();
            Console.WriteLine("Answer Day Two PartOne: " + answerDayTwoPartOne);
            int answerDayTwoPartTwo = dayTwo.DayTwoPartTwo();
            Console.WriteLine("Answer to Day Two Part Two: " + answerDayTwoPartTwo);

            DayThree dayThree = new DayThree();
            int answerDayThreePartOne = dayThree.DayThreePartOne();
            Console.WriteLine("Answer to Day Three Part One: " + answerDayThreePartOne);

            int  answerDayThreePartTwo = dayThree.DayThreePartTwo();
            Console.WriteLine("Answer to Day Three Part Two: " + answerDayThreePartTwo);
        }
    }
}
