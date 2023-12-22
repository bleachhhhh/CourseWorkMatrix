using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal interface ISolver
    {
       double[] Solve(Equation equation1,Equation equation2);
    }
}
