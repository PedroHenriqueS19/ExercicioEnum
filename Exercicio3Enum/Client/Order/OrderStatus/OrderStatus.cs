using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3Enum.Client.Order.OrderStatus
{
        enum OrderStatuss : int
        {
            Pending_Payment = 1,
            Processing = 2,
            Shipped = 3,
            Delivered = 4
        }
}
