using System;
using System.Collections.Generic;
using System.Text;

namespace GRM.Domain.Entities
{
    public class MusicContract
    {

        public string Artist { get; set; }
        public string Title { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public IEnumerable<String> Usages { get; set; }
        public string SelectedUsage { get; set; }
    }
}
