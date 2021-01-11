using System;
using System.Collections.Generic;
using GRM.Application.Services;
using GRM.Domain.Entities;
using GRM.Domain.Filter;
using GRM.Domain.Repositories;
using GRM.Persistence.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GRM.UnitTestProject
{

[TestClass]
    public class ProductServiceUnitTests
    {
        #region Private Variables
        private  ProductService _sut;
        private DateTime _effectiveDate; 
        private Mock<IRepository<MusicContract>> _musicContractRepository;
        private SearchFilter _searchFilter;
        #endregion

        #region Initialize Test


        public ProductServiceUnitTests()
        {
            _musicContractRepository = new Mock<IRepository<MusicContract>>();
            _sut = new ProductService(_musicContractRepository.Object);
        }

        [TestInitialize]
        public void Init()
        {
           
        }

        #endregion

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Invalid Search Filter.")]
        public void Search_By_InvalidSearchFilter_ThrowsException()
        {
            _sut.Search(null);
        }


        [TestMethod]
        public void Search_By_ValidSearchFilter_GetResult()
        {
            _effectiveDate = DateTime.Now;

            _searchFilter = new SearchFilter
            {
                DeliveryPartner = new DeliveryPartner
                {
                    Name = "Youtube",
                    Usage = "streaming"
                },
                EffectiveDate = _effectiveDate
                
            };

            List<MusicContract> musicContracts = new List<MusicContract>
            {
                new MusicContract()
                {
                    Artist = "Tinie Tempah"
                }
            };

            _musicContractRepository.Setup(x => x.GetAll()).Returns(musicContracts);

            var contracts = _sut.Search(_searchFilter);

            Assert.IsNotNull(contracts);
        }
    }
}
