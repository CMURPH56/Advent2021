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
            // int answerDayOnePartOne = DayOnePartOne();
            // Console.WriteLine("Answer Day One Part One:  " + answerDayOnePartOne);
            // int answerDayOnePartTwo = DayOnePartTwo();
            // Console.WriteLine("Answer Day One Part Two: " + answerDayOnePartTwo);
            // int answerDayTwoPartOne = DayTwoPartOne();
            // Console.WriteLine("Answer Day Two PartOne: " + answerDayTwoPartOne);
            // int answerDayTwoPartTwo = DayTwoPartTwo();
            // Console.WriteLine("Answer to Day Two Part Two: " + answerDayTwoPartTwo);
            // int answerDayThreePartOne = DayThreePartOne();
            // Console.WriteLine("Answer to Day Three Part One: " + answerDayThreePartOne);
            int  answerDayThreePartTwo = DayThreePartTwo();
            Console.WriteLine("Answer to Day Three Part Two: " + answerDayThreePartTwo);
        }

        private static int DayThreePartTwo(){

            string[] linesArray = System.IO.File.ReadAllLines(@"/home/cam/Projects/adventofcode/inputdaythree.txt");
            List<string> lines = linesArray.ToList();
            for(int i = 0; i < 12; i++){
                int amount = 0;
                foreach(string line in lines){
                    char[] numbers = line.ToCharArray();
                    int number = int.Parse(numbers[i].ToString());
                    amount = amount + number;
                }
                lines = removeLines(lines, amount, i);
            }
            
            string oxygenString = lines[0];

            int oxygen = Convert.ToInt32(oxygenString, 2);

            StringBuilder sb = new StringBuilder();
            char[] word = lines[0].ToCharArray();
            foreach(char letter in word){
                if(letter == '0') {
                    sb.Append('1');
                }
                else {
                    sb.Append('0');
                }
            }
            string COString = sb.ToString();
            int CO = Convert.ToInt32(COString, 2);

            return CO * oxygen;
        }


        private static List<string> removeLines(List<string> input, int amount, int index){
            int cutoff = input.Count() / 2;
            if(amount < cutoff){
                input.RemoveAll( x => int.Parse(x.ToCharArray()[index].ToString()) != 0);
            }
            else{
                input.RemoveAll( x => int.Parse(x.ToCharArray()[index].ToString()) != 1);
            }
            return input;
        }


        private static int DayThreePartOne(){
            string[] lines = System.IO.File.ReadAllLines(@"/home/cam/Projects/adventofcode/inputdaythree.txt");
            
            Dictionary<string, int> answer = new Dictionary<string, int>();

            for(int i = 0; i < 12; i++){
                answer.Add("column" + i, 0);
            }

            int halfway = lines.Length / 2;
            foreach(string line in lines){
                char[] numbers  = line.ToCharArray();
                for(int i = 0; i < numbers.Length; i++){
                    string key = "column" + i;
                    answer["column" + i] =  answer["column" + i] + int.Parse(numbers[i].ToString());
                }
            }
            StringBuilder gammaStringBuilder = new StringBuilder();
            StringBuilder episilonStringBuilder = new StringBuilder();

            foreach (KeyValuePair<string, int> kvp in answer)
            {
                if(kvp.Value < 500){
                    gammaStringBuilder.Append("0");
                    episilonStringBuilder.Append("1");
                }
                else{
                    gammaStringBuilder.Append("1");
                    episilonStringBuilder.Append("0");
                }
            }
            string binaryGammaString = gammaStringBuilder.ToString();
            string binaryEpisilonString = episilonStringBuilder.ToString();
            int gamma = Convert.ToInt32(binaryGammaString, 2);
            Console.WriteLine(gamma);
            int episilon = Convert.ToInt32(binaryEpisilonString, 2);
            Console.WriteLine(episilon);
            return gamma * episilon;
        }
        private static int DayTwoPartTwo(){
            int horizontalPosition = 0;
            int depth = 0;
            int aim = 0;
            string[] lines = System.IO.File.ReadAllLines(@"/home/cam/Projects/adventofcode/inputdaytwo.txt");
             foreach( string line in lines){
                string command = line.Split(" ")[0];
                int amount = int.Parse(line.Split(" ")[1]);

                
                if(command == "forward"){
                    horizontalPosition = horizontalPosition + amount;
                    depth = depth + (aim * amount);
                }
                else if(command == "down"){
                    aim = aim + amount;
                }
                else if (command == "up"){
                    aim = aim - amount;
                }
             }
            return horizontalPosition * depth;
        }
        private static int DayTwoPartOne(){
            int horizontalPosition = 0;
            int depth = 0;
            string[] lines = System.IO.File.ReadAllLines(@"/home/cam/Projects/adventofcode/inputdaytwo.txt");
            foreach( string line in lines){
                string command = line.Split(" ")[0];
                int amount = int.Parse(line.Split(" ")[1]);

                if(command == "forward"){
                    horizontalPosition = horizontalPosition + amount;
                }
                else if(command == "down"){
                    depth = depth + amount;
                }
                else if (command == "up"){
                    depth = depth - amount;
                }
            }
            return horizontalPosition * depth;
        }
        private static int DayOnePartTwo()
        {
            int answer = 0; // accounting for the first one
            string[] lines = System.IO.File.ReadAllLines(@"/home/cam/Projects/adventofcode/inputdayone.txt");

            for( int x = 0; x < lines.Length - 3; x++ )
            {
                int current = int.Parse(lines[x]);
                int next = int.Parse(lines[x + 1]);
                int third = int.Parse(lines[x + 2]);
                int fourth = int.Parse(lines[ x + 3]);


                int sumOne = current + next + third;
                int sumTwo = next + third + fourth;
                if(sumOne < sumTwo){
                    answer = answer + 1;
                }
            }
            return answer;
        }
        private static int DayOnePartOne()
        {
            string[] lines = System.IO.File.ReadAllLines(@"/home/cam/Projects/adventofcode/inputdayone.txt");
            int answer = 0;
            for(int x = 0; x  < lines.Length - 1; x++)
            {
                int current = int.Parse(lines[x]);
                int next = int.Parse(lines[x+1]);
                if( current < next){
                    answer = answer + 1;
                }
            }
            return answer;
        }


    }
}
