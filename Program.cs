namespace _12._9._22_Function_Exercise_BODY_MASS_INDEX
{
    internal class Program
    {
        //INPUT FUNCTION
        static string Input(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        //BMI CALCULATOR FUNCTION
        static double BMIFnctn(double weight, double height)
        {
            double BMI = (weight * 703) / (height * height);
            return BMI;
        }
        static void Main(string[] args)
        {
            //VARIABLES
            double inputWeight = 0;
            double inputHeight = 0;

            //USER INPUT
            inputWeight = double.Parse(Input("Enter your weight: "));
            inputHeight = double.Parse(Input($"Enter your height in inches: "));

            //OUTPUT
            Console.WriteLine($"Your BMI is {BMIFnctn(inputWeight, inputHeight):f2}");

            
        }
    }
}