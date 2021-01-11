using System;
using System.Collections.Generic;
using System.Text;
using GRM.Domain.Entities;
using GRM.Domain.Filter;
using GRM.Domain.Repositories;
using GRM.Domain.Services;

namespace GRM.Application.Services
{
    public class DeliveryPartnerService : IDeliveryPartnerService
    {
        private readonly IRepository<DeliveryPartner> _deliveryPartnerRepository;
        

        public DeliveryPartnerService(IRepository<DeliveryPartner> deliveryPartnerRepository)
        {
            _deliveryPartnerRepository = deliveryPartnerRepository;
        }


        public IEnumerable<DeliveryPartner> GetAll()
        {
            return _deliveryPartnerRepository.GetAll();
        }
    }
}
