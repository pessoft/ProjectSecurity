using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    public interface IFrequency
    {
        Dictionary<string, double> GetLetterFreq();
        Dictionary<string, double> GetPairLetterFreq();
    }
}
