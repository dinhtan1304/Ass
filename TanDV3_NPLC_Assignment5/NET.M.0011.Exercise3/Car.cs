namespace NET.M._0011.Exercise3
{
    public class Car
    {
        public decimal Speed { get; set; }
        public double RegualPrice { get; set; }
        public string Color { get; set; }

        public Car()
        {

        }

        public Car(decimal speed, double regualPrice, string color)
        {
            Speed = speed;
            RegualPrice = regualPrice;
            Color = color;
        }

        public virtual double GetSalePrice()
        {
            return RegualPrice;
        }
    }
}
