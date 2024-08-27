using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAcceess_NetFrameWork.DO.Session10.Interface
{
    public interface IBookingCancellation
    {
        ActionResult CancelBooking(int bookingId);
    }
}
