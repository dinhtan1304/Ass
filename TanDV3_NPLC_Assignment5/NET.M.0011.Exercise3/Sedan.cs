namespace NET.M._0011.Exercise3
{
    public class Sedan : Car
    {
        public int Lenght { get; set; }
        public Sedan() { }

        public Sedan(decimal speed, double regualPrice, string color, int lenght) 
            : base(speed, regualPrice, color)
        {
            Lenght = lenght;    
        }
        /// <summary>
        /// Get sale price of Sedan with Lenght
        /// </summary>
        /// <returns>RegualPrice</returns>
        public override double GetSalePrice()
        {
            if (Lenght > 20)
            {
                return RegualPrice * 0.95;
            }
                return RegualPrice * 0.9;
        }
    }
}
