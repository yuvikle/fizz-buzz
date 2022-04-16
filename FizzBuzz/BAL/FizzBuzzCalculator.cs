using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FizzBuzz.Models;

namespace FizzBuzz.BAL
{
    public class FizzBuzzCalculator : IFizzBuzzCalculator
    {
        private readonly FizzBuzzer fizzBuzzer;
        public FizzBuzzCalculator()
        {
            fizzBuzzer = new FizzBuzzer();
        }
        public List<ResultModel> Calculate(string[] inputList)
        {
            List<ResultModel> results = new List<ResultModel>();
            string item;         
            foreach (string input in inputList)
            {
                item = input.Trim();
                string outputText = fizzBuzzer.GetOutputText(item);
                results.Add(new ResultModel { Input = item, Output = outputText });
            }

            return results;
        }
    }
}