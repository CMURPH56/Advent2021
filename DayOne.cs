    public class DayOne {
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
