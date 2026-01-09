using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases
{
    public interface IFactura
    {
        //SOLO TIENE ESTRUCTURA DE DECLARACIÓN DE ELEMENTOS
        int precioBase { get; set; }
        int precioTotal { get; set; }

        void CalcularIva();
        void OdioHacienda(int mucho); 
    }
}
