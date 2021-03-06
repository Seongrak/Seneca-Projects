// Author : Seongrak Choi (156405177)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExAvocateprog15
{
    public class ExAv
    {
        public int ExAvId { get; private set; }
        public string Description { get; private set; }
        public int MaximumApplicants { get; private set; }


        public ExAv(int ExAvId, string Description, int MaximumApplicants)
        {
            this.ExAvId = ExAvId;
            this.Description = Description;
            this.MaximumApplicants = MaximumApplicants;
        }
    }
}