using System;
namespace Assignment2
{
    public class TemperatureTable
    {
        public TemperatureTable()
        {
            TemperatureMenu();
        }

        private void TemperatureMenu(){
            Console.WriteLine("Välj 1 för C till F");
            Console.WriteLine("Välj 1 för F till C");
            Console.WriteLine("Välj 3 för C till F med egen inmatning");
            Console.WriteLine("Välj 4 för F till C med egen inmatning");

            int userInput = Input.ReadIntegerConsole();

            switch (userInput)
            {
                case 1:
                    ConvertToCelcius();

                    break;
                case 2:
                    ConvertToFahrenheit();

                    break;
                case 3:
                    double resultC = ConvertToCelcius2();
                    DisplayResult(1, resultC);
                    break;
                case 4:
                    double resultF = ConvertToFahrenheit2();
                    DisplayResult(2, resultF);
                    break;
                default:
                    Console.WriteLine("Ogiltig inmatning");
                    break;
            }
        }

       private void ConvertToCelcius(){

            for (double i = 0; i < 101; i = i + 4)
            {
                double toCelcius = (5.0 / 9.0) * (i - 32.0);
                Console.WriteLine("      " + i + "     " + Math.Round(toCelcius, 2));
            }
        }

        private void ConvertToFahrenheit()
        {
            for (double i = 0; i < 101; i = i + 4)
            {
                double toFahrenheit = (9.0 / 5.0) * (i + 32.0);
                Console.WriteLine("      " + i + "     " + Math.Round(toFahrenheit, 2));
            }
        }

        private double ConvertToCelcius2(){

            // Konverterar input från Fahrenheit till Celcius
            Console.WriteLine("Ange grader i Fahrenheit");

            double userInput = Input.ReadDoubleConsole();
            double toCelcius = (5.0 / 9.0) * (userInput - 32.0);
            Math.Round(toCelcius, 2);
            return toCelcius;

        }

        private double ConvertToFahrenheit2(){

            // Konverterar input från Celcius till Fahrenheit
            double userInput = Input.ReadDoubleConsole();
            double toFahrenheit = (9.0 / 5.0) * (userInput + 32.0);
            Math.Round(toFahrenheit, 2);
            return toFahrenheit;

        }

        private void DisplayResult(int type, double result){

            // Beroende på sluttyp så visas F eller C som enhet för temperaturen
            if(type == 1){
                Console.WriteLine(Math.Round(result, 2) + "C");
            }
            else{
                Console.WriteLine(Math.Round(result, 2) + "F");
            }


        }
    }
}
