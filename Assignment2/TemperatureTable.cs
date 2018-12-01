using System;
namespace Assignment2
{
    public class TemperatureTable
    {
        public TemperatureTable()
        {

            TemperatureMenu();
        }

        private void TemperatureMenu()
        {

          
                Console.WriteLine("1 for C to F");
                Console.WriteLine("2 for F to C");
                Console.WriteLine("3 for C to F with specific C value");
                Console.WriteLine("4 for F to C with specific F value");

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
                  

                }
               
            
        }

       private void ConvertToCelcius(){
            // Converterar till celcius med 4 graders steg
            
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("TABLE OF FARNHEIT / CELSUIS VALUES");
            Console.WriteLine(new string('-', 50));

            for (double i = 0; i < 101; i = i + 4)
            {
                double toCelcius = (5.0 / 9.0) * (i - 32.0);
                Console.WriteLine("      " + i + "C     " + Math.Round(toCelcius, 2) + "F");
            }
        }

        private void ConvertToFahrenheit(){
            // Converterar till farenheit med 4 graders steg
     
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("TABLE OF CELSUIS / FARENHEIT VALUES");
            Console.WriteLine(new string('-', 50));

            for (double i = 0; i < 101; i = i + 4)
            {

                double toFahrenheit = (9.0 / 5.0) * (i + 32.0);
                Console.WriteLine("      " + i + "F     " + Math.Round(toFahrenheit, 2) + "C");
            }
        }

        private double ConvertToCelcius2(){

            // Konverterar input från Fahrenheit till Celcius
            Console.Write("What degree in Farenheit would you like to convert ");

            double userInput = Input.ReadDoubleConsole();
            double toCelcius = (5.0 / 9.0) * (userInput - 32.0);
            Math.Round(toCelcius, 2);
            return toCelcius;

        }

        private double ConvertToFahrenheit2(){

            // Konverterar input från Celcius till Fahrenheit
            Console.Write("What degree in Celcius would you like to convert ");
            double userInput = Input.ReadDoubleConsole();
            double toFahrenheit = (9.0 / 5.0) * (userInput + 32.0);
            Math.Round(toFahrenheit, 2);
            return toFahrenheit;

        }

        private void DisplayResult(int type, double result){

            
            Console.WriteLine(new string('-', 50));
           

            // Beroende på sluttyp så visas F eller C som enhet för temperaturen

            if (type == 1){

                Console.WriteLine(Math.Round(result, 2) + "C");

            }
            else{
               
                Console.WriteLine(Math.Round(result, 2) + "F");
            }


        }
    }
}
