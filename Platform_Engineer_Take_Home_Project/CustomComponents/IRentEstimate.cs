using System;
using System.Threading.Tasks;

namespace CustomComponents
{
    public interface IRentEstimate
    {
        public decimal GetRentEstimate(string address, string city, string state, string zip);
    }
}
