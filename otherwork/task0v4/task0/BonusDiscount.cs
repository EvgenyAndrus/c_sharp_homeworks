namespace task0
{
    class BonusDiscount : IDiscount
    {
        private const double Bonus = 50000;
        public double SetPrice(double price, int count)
        {
            return price * count - Bonus;
        }

        public override string ToString()
        {
            return string.Format("\t{0} BYR Bonus ", Bonus);
        }
    }
}