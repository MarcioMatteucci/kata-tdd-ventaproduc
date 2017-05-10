namespace App
{
    public class Calculador
    {
        private Descuento desc = new Descuento();
        private Impuesto imp = new Impuesto();

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

        public decimal getSubtotalConImpuesto (decimal subtotalConDesc, string estado)
        {
            var impuesto = imp.getImpuesto(estado);
            var subtotalConImp = subtotalConDesc + (subtotalConDesc * impuesto);
            return subtotalConImp;
        }

        public decimal getTotal (int cant, decimal precio, string estado)
        {
            var subtotalSinDesc = getSubtotalSinDescuento(cant,precio);
            var subtotalConDesc = getSubtotalConDescuento(subtotalSinDesc);
            var total = getSubtotalConImpuesto(subtotalConDesc, estado);
            return total;
        }
        
    }
}
