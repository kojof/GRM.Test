using System;
using System.Collections.Generic;
using System.Text;
using GRM.Domain.Entities;
using GRM.Domain.Repositories;

namespace GRM.Persistence.Repositories
{
    public class MusicContractRepository: IRepository<MusicContract>
    {

        public MusicContractRepository()
        {

        }

        public IEnumerable<MusicContract> GetAll()
        {
            //TODO return csv file
            List<MusicContract> musicContracts = new List<MusicContract>
            {
                new MusicContract()
                {
                    Artist = "Tinie Tempah"
                }
            };
            return musicContracts;
        }
    }
}
