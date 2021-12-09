public class DayTwo {

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
}
