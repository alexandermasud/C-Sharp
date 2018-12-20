namespace Assignment3
{
    class BMICalculator
    {
        // Sets object variables
        private string name = "No Name";
        private double height = 0;
        private double weight = 0;
        private UnitTypes unit;
        private double bmiValue = 0.0;
        private string bmiCategory = "";

        // Gets instance name
        public string GetName()
        {
            return name;
        }

        // Sets instance name
        public void SetName(string value)
        {

            // Validates if string has value
            if (!string.IsNullOrEmpty(value))
                name = value;
        }

        // Sets height
        public void SetHeight(double value)
        {
            // validates value is 0 or heigher
            if (value >= 0)
                height = value;
        }

        // Sets weight
        public void SetWeight(double value)
        {
            // validates value is 0 or heigher
            if (value >= 0)
                weight = value;
        }

        // Sets unitType
        public void SetUnit(UnitTypes value)
        {
            unit = value;
        }

        // Gets unitType
        public UnitTypes GetUnit()
        {
            return unit;
        }

        // Calculates BMI
        public void CalculateBMI()
        {
            
            double factor = 0.0;

            if (unit == UnitTypes.American)
            {
                factor = 703.0;
            }
            else
            {
                factor = 1.0;
            }

            bmiValue = factor * weight / (height * height);
        }

        // Gets BMI
        public double GetBMI() {
            
            return bmiValue;
        }

        // Calculates BMI Category
        public void CalculateBMICategory() {
            if (bmiValue > 40)
            {
                bmiCategory = "Class 3 Obesity";
            }
            else if (bmiValue >= 35)
            {
                bmiCategory = "Class 2 Obesity";
            }
            else if (bmiValue >= 30)
            {
                bmiCategory = "Class 1 Obesity";
            }
            else if (bmiValue >= 25)
            {
                bmiCategory = "Overweight";
            }
            else if (bmiValue >= 18.5)
            {
                bmiCategory = "Normal";
            }
            else
            {
                bmiCategory = "Underweight";
            }
        }

        // Gets BMI category
        public string GetBMICategory()
        {
            return bmiCategory;
        }
    }
}