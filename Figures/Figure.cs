using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public interface IFigure
    {
        int Circuit { get;}
        int Field { get;}

        int Multiply()
        {
            return 0;
        }
        int Divide()
        {
            return 0;
        }
        
    }
    public class Figure 
    {
        Dictionary<int, string> factory = new Dictionary<int, string>();
    }
}
