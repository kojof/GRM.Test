using GRM.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using GRM.Domain.Entities;

namespace GRM.Persistence.Repositories
{
    public class DeliveryPartnerRepository: IRepository<DeliveryPartner>
    {

        public DeliveryPartnerRepository()
        {

        }

        public IEnumerable<DeliveryPartner> GetAll()
        {
            //TODO return csv file
            return new List<DeliveryPartner>();
        }

       
    }
}
