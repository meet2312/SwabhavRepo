using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenicsSolution
{
    class BoardRefactor
    {
      
        public String board()
        {
            StringBuilder stringbuilder = new StringBuilder();

            collectRows(stringbuilder);

            return stringbuilder.ToString();
        }

        private void collectRows(StringBuilder builder)
        {
            for (int iterator = 0; iterator < 10; iterator++)
            {
                collectRow(builder, iterator);
            }
        }

        private void collectRow(StringBuilder builder, int row)
        {
            for (int iterator = 0; iterator < 10; iterator++)
            {
                builder.Append(10);
            }

            builder.Append("\n");
        }

    }
}
