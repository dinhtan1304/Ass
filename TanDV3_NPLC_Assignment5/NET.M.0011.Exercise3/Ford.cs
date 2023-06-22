namespace NET.M._0011.Exercise3
{
    public class Ford : Car
    {
        public int Year { get; set; }
        public int ManufactureDiscount { get; set; }

        public Ford() { }

        public Ford(decimal speed, double regualPrice, string color, int year, int manufactureDiscount) 
            : base(speed, regualPrice, color)
        {
            Year = year;
            ManufactureDiscount = manufactureDiscount;
        }
        /// <summary>
        /// Get sale price of Ford with ManufactureDiscount
        /// </summary>
        /// <returns>RegualPrice</returns>
        public override double GetSalePrice()
        {
            return (double)RegualPrice - (double)ManufactureDiscount;
        }
    }
}
