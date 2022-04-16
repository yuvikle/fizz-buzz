using FizzBuzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.BAL
{
    interface IFizzBuzzCalculator
    {
        List<ResultModel> Calculate(string[] inputList);
    }
}
