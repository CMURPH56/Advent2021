using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class DayThree {

          public int DayThreePartTwo(){

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


        public int DayThreePartOne(){
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
}
