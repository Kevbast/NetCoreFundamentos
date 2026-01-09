using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ProyectoClases
{
    public class FacturaEnero : IFactura
    {
        public int precioBase { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int precioTotal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CalcularIva()
        {
            throw new NotImplementedException();
        }

        public void OdioHacienda(int mucho)
        {
            throw new NotImplementedException();
        }
    }
}
