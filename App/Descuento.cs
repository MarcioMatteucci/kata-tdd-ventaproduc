namespace App
{
    public class Descuento
    {
        public decimal getDescuentoBySubtotal (decimal subtotal)
        {
            if (subtotal >= 1000m && subtotal < 5000m)
            {
                return 0.03m;
            }
            if (subtotal >= 5000m && subtotal < 10000m)
            {
                return 0.05m;
            }
            if (subtotal >= 10000m && subtotal < 15000m)
            {
                return 0.08m;
            }
            if (subtotal >= 15000m && subtotal < 50000m)
            {
                return 0.1m;
            }
            if (subtotal >= 50000m)
            {
                return 0.15m;
            }

            return 0m;
        }
    }
}
