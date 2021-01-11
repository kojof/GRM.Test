using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GRM.Domain.Entities;
using GRM.Domain.Filter;
using GRM.Domain.Repositories;
using GRM.Domain.Services;

namespace GRM.Application.Services
{
    public class ProductService : IProductService
    {
       // private readonly IRepository<DeliveryPartner> _deliveryPartnerRepository;
        private readonly IRepository<MusicContract> _musicContractRepository;

        public ProductService(IRepository<MusicContract> musicContractRepository)
        {
            //_deliveryPartnerRepository = deliveryPartnerRepository;
            _musicContractRepository = musicContractRepository;
        }


        public IEnumerable<MusicContract> Search(SearchFilter searchFilter)
        {
         

            if (searchFilter == null)
            {
                throw new ArgumentNullException();
            }

            try
            {
                //TODO get all contracts


                var musicContracts = _musicContractRepository.GetAll();

                //TODO do search by filter criteria
                //musicContracts.Where(x =>  x.StartDate <= searchFilter.EffectiveDate && x.Usages.Contains(searchFilter.DeliveryPartner)).ToList();

                return new List<MusicContract>();


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
             //   throw;
            }

            return null;
        }
    }
}
