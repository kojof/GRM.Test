using System;
using System.Collections.Generic;
using System.Text;
using GRM.Domain.Entities;

namespace GRM.Domain.Services
{
    public  interface IDeliveryPartnerService
    {
        IEnumerable<DeliveryPartner> GetAll();
    }
}
