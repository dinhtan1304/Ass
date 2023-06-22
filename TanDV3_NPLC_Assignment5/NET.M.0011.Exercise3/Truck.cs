namespace NET.M._0011.Exercise3
{
    public class Truck : Car
    {
        public int Weight { get; set; }

        public Truck() { }

        public Truck(decimal speed, double regualPrice, string color, int weight) 
            : base(speed, regualPrice, color)
        {
            Weight = weight;
        }
        /// <summary>
        /// Get sale price of truck with weight?
        /// </summary>
        /// <returns>RegualPrice</returns>
        public override double GetSalePrice()
        {
            if (Weight > 2000)
            {
                return RegualPrice * 0.9;
            }
                return RegualPrice * 0.8;
        }
    }
}
