namespace ApiRest.Model
{
    public class DolarSoles
    {
        public decimal Calculated { get; set; }
    }

    public class DolarSolesRoot
    {
        public DolarSolesEnvelope Envelope { get; set; }
    }

    public class DolarSolesResult
    {
        public decimal Calculated { get; set; }
    }

    public class DolarSolesResponse
    {
        public DolarSolesResult DolarSolesResult { get; set; }
    }

    public class DolarSolesBody
    {
        public DolarSolesResponse DolarSolesResponse { get; set; }
    }

    public class DolarSolesEnvelope
    {
        public DolarSolesBody Body { get; set; }
    }
}
