namespace LocalNetworkNameSpace
{
    /// <summary>
    /// Class of computer in network
    /// </summary>
    public class Computer
    {
        public bool IsInfected { get; set; }

        private OperationSystem operationSystem;

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="isInfected"></param>
        /// <param name="operationSystem"></param>
        public Computer(bool isInfected, OperationSystem operationSystem)
        {
            IsInfected = isInfected;
            this.operationSystem = operationSystem;
        }

        /// <summary>
        /// Returns the probability of infection
        /// of computer whith this operation system
        /// </summary>
        /// <returns></returns>
        public int GetRiskOfIfection()
        {
            return operationSystem.RiskOfInfection;
        }
    }
}
