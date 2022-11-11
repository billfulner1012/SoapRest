using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest.Model
{
    public class SolesDolar
    {
        public decimal Calculated { get; set; }
    }

    public class SolesDolarRoot
    {
        public SolesDolarEnvelope Envelope { get; set; }
    }

    public class SolesDolarResult
    {
        public decimal Calculated { get; set; }
    }

    public class SolesDolarResponse
    {
        public SolesDolarResult SolesDolarResult { get; set; }
    }

    public class SolesDolarBody
    {
        public SolesDolarResponse SolesDolarResponse { get; set; }
    }

    public class SolesDolarEnvelope
    {
        public SolesDolarBody Body { get; set; }
    }
}
