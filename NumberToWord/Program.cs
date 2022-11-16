namespace NumberToWord
{
    internal class Program
    {
        public static string NumbersToWords(int number)
        {
            

            if (number == 0)
            {
                //Console.Write("zero");
                
                return "zero";
            }
                
            
            if (number < 0)
            {
               // Console.Write("Minus " + NumbersToWords(Math.Abs(number)));
                return "Minus " + NumbersToWords(Math.Abs(number));
            }

                
            string words = "";

            /*if ((number / 1_000_000_000_000_000) > 0)
            {
                words += NumbersToWords(number / 1_000_000_000_000_000) + " quadrillion ";
                number %= 1_000_000_000_000_000;
            }
            if ((number / 1_000_000_000_000) > 0)
            {
                words += NumbersToWords(number / 1_000_000_000_000) + " trillion ";
                number %= 1_000_000_000_000;
            }*/
            if ((number / 1_000_000_000) > 0)
            {
                words += NumbersToWords(number / 1_000_000_000) + " billion ";
                number %= 1_000_000_000;
            }
            if((number / 1_000_000) > 0)
            {
                words += NumbersToWords(number / 1_000_000) + " million ";
                number %= 1_000_000;
            }
            if ((number / 100_000) > 0)
            {
                words += NumbersToWords(number / 100_000) + " hundred thousand ";
                number %= 1_000_000_000;
            }
            if ((number / 1_000) > 0)
            {
                words += NumbersToWords(number / 1_000) + " thousand ";
                number %= 1_000;
            }
            if ((number / 100) > 0)
            {
                words += NumbersToWords(number / 100) + " hundred ";
                number %= 100;
            }
            if (number > 0)
            {
                if (words != "")
                    words += " and ";
                var units = new[] { "zero", " one ", " two ", " three ", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
                var tens = new[] { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};

                if (number < 20)
                    words += units[Convert.ToInt32(number)];
                else
                {
                    words += tens[Convert.ToInt32(number / 10)];
                    if ((number % 10) > 0)
                        words += "-" + units[Convert.ToInt32(number % 10)];
                }
            }

            /*Console.Write(words);*/
            return words;
        }
        static void Main(string[] args)
        {
           string result =  NumbersToWords(86780502);
            Console.WriteLine(result);
            
        }
    }
}