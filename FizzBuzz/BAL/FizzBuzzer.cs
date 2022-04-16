using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FizzBuzz.BAL
{
    public class FizzBuzzer
    {
        private int Num;
        public FizzBuzzer(): this(3, 5)
        {

        }
        public FizzBuzzer(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;            
        }
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public string GetOutputText(string input)
        {
            if (!int.TryParse(input, out int value))
                return "Invalid item";

            string outPutText = "";
            Num = Num1 * Num2;

            if (value % Num == 0)
                outPutText = "FizzBuzz";
            else if (value % Num1 == 0)
                outPutText = "Fizz";
            else if (value % Num2 == 0)
                outPutText = "Buzz";
            else
                outPutText = $"Divided {value} by {Num1} {Environment.NewLine} Divided {value} by {Num2}";

            return outPutText.Replace("\r\n", "<br>");
        }
    }
}