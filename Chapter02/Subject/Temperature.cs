namespace Chapter02.Subject
{
    public class Temperature
    {
        public double Value { get; set; }
        public TemperatureTypeEnum TemperatureType { get; set; }

        public Temperature()
        {
            TemperatureType = TemperatureTypeEnum.Fahrenheit;
        }

        public enum TemperatureTypeEnum
        {
            Fahrenheit = 1
        }
    }
}
