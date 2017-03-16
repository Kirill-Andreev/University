namespace LocalNetworkNameSpace
{
    /// <summary>
    /// Class of computer operation system
    /// with the probability of infection
    /// </summary>
    public class OperationSystem
    {
        public int RiskOfInfection { get; set; }

        public OperationSystem(int risk)
        {
            RiskOfInfection = risk;
        }
    }
}
