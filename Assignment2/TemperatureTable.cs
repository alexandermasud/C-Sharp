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
            Console.WriteLine("Välj 2 för F till C");

            int userInput = Input.ReadIntegerConsole();

            switch (userInput)
            {
                case 1:
                    double resultC = ConvertToCelcius();
                    DisplayResult(1, resultC);
                    break;
                case 2:
                    double resultF = ConvertToFahrenheit();
                    DisplayResult(2, resultF);
                    break;
                default:
                    Console.WriteLine("Ogiltig inmatning");
                    break;
            }
        }

        private double ConvertToCelcius(){

            // Konverterar input från Fahrenheit till Celcius
            Console.WriteLine("Ange grader i Fahrenheit");

            double userInput = Input.ReadDoubleConsole();
            double toCelcius = (5.0 / 9.0) * (userInput - 32.0);
            Math.Round(toCelcius, 2);
            return toCelcius;

        }

        private double ConvertToFahrenheit(){

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
