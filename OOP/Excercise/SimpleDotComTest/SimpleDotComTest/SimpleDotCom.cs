using System;

namespace SimpleDotComTest
{
    public class SimpleDotCom
    {
        int[] locationCells;
        int numOfHits = 0;
        public void SetLocationCells(int[] locs)
        {
            locationCells = locs;
        }
        public string CheckYourself(string stringguess)
        {
            int guess = Int32.Parse(stringguess);
            string result = "miss";

            for (int cell=1;cell<=locationCells.Length;cell++)
            {
                if(guess == cell)
                {
                    result = "hit";
                    numOfHits=numOfHits+1;

                }
            }

            if(numOfHits==locationCells.Length)
            {
                result = "kill";
            }
            Console.WriteLine(result);
            return result;
        }
    }
}