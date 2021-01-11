using System;
using System.Collections.Generic;
using System.Text;
using GRM.Domain.Entities;

namespace GRM.Domain.Filter
{
    public class SearchFilter
    {
        public DeliveryPartner DeliveryPartner { get; set; }
        public DateTime EffectiveDate { get; set; }
       
    }
}
