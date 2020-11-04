namespace TravelBookingPortal.Services.Data
{
    using System.Collections.Generic;

    public interface IToursService
    {
        IEnumerable<T> GetAll<T>(int? count = null);

        IEnumerable<T> GetTopPopular<T>(int? count = null);

        T GetByName<T>(string name);

        //T GetDetails<T>(int id);
        T GetById<T>(int id);
    }
}
