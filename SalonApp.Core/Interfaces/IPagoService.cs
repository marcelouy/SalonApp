using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonApp.Core.Interfaces
{
    public interface IPagoService
    {
        Task<bool> ProcesarPago(decimal monto, string metodoPago);
    }
}
