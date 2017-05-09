namespace App
{
    public class Calculador
    {
        private Descuento desc = new Descuento();

        public decimal getSubtotalSinDescuento (int cant, decimal precio)
        {
            var subtotalSinDesc = cant * precio;
            return subtotalSinDesc;
        }

        public decimal getSubtotalConDescuento (decimal subtotalSinDesc)
        {
            var descuento = desc.getDescuentoBySubtotal(subtotalSinDesc);
            var subtotalConDesc = subtotalSinDesc - (subtotalSinDesc * descuento);
            return subtotalConDesc;
        }

        public decimal getTotal (int cant, decimal precio)
        {
            var subtotalSinDesc = getSubtotalSinDescuento(cant,precio);
            var subtotalConDesc = getSubtotalConDescuento(subtotalSinDesc);
            return subtotalConDesc;
        }
        
    }
}
