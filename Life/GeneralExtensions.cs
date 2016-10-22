namespace DD.Life
{
    public static class GeneralExtensions
    {
        public static int Modulo(this int divident, int divisor)
        {
            var modulo = divident%divisor;
            return modulo >= 0 ? modulo : modulo + divisor;
        }
    }
}