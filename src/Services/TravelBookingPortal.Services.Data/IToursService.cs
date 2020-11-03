namespace TravelBookingPortal.Services.Data
{
    using System.Collections.Generic;

    public interface IToursService
    {
        IEnumerable<T> GetAll<T>(int? count = null);
    }
}
