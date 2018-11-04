namespace Assignment3
{
    class BMICalculator
    {
        // Sets object variables
        private string name = "No Name";
        private double height = 0;
        private double weight = 0;
        private UnitTypes unit;

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
        public double CalculateBMI()
        {
            double bmiValue = 0.0;
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

            return bmiValue;
        }
    }
}
