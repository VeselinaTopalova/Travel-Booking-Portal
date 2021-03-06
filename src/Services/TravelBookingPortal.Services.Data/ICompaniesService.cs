﻿namespace TravelBookingPortal.Services.Data
{
    using System.Collections.Generic;

    public interface ICompaniesService
    {
        IEnumerable<T> GetAll<T>(int? count = null);

        T GetByName<T>(string name);

        T GetById<T>(int id);
    }
}
