using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenicsViolation
{
    class Board
    {
        public String board()
        {
         //   int[][] d = new int[20][];
            StringBuilder buf = new StringBuilder();

            // 0
            for (int i = 0; i < 10; i++)
            {
                // 1
                for (int j = 0; j < 10; j++)
                {
                    // 2
                    buf.Append(10);
                }
                buf.Append("\n");
            }

            return buf.ToString();
        }

    }
}
