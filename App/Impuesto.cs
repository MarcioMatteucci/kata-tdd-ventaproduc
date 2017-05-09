namespace App
{
    public class Impuesto
    {
        public decimal getImpuesto (string estado)
        {
            string op = estado;

            switch (op)
            {
                case "TX":
                    return 0.15m;
                case "NV":
                    return 0.12m;
                case "CA":
                    return 0.875m;
                default:
                    return 0.10m;
            }
        }
    }
}
