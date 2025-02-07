using System.Collections.Generic;
using System.Dynamic;
using DiscreteEventSimulation.api;

namespace DiscreteEventSimulation.objects
{
    public abstract class Unit
    {
        // TODO: Set up abstract info for Unit Class  

        // Required Parameters taken from imported data
        #region Required Parameters

        public string name { get; set; }
        public string product { get; set; }
        public sbyte size { get; set; }
        public UnitType unitType { get; private set; }
        public string flowPlan { get; set; }
        public FlowPlan flow {get; set;}
        
        #endregion

        // Calculated Parameters taken from imported data
        #region Calculated Parameters
        
        public double cumulativeCycleTimeGoal { get; private set; }
        public double cumulativeQueueTimeGoal { get; private set; }
        public double cumulativeProcessTimeGoal { get; private set; }

        private float queueTimeReductionFactor;
        #endregion

        //Simulated values generated from factory controller
        #region Simulated Values

        public double simulatedCycleTime { get; set; }
        public double simulatedQueueTime { get; set; }
        public double simulatedProcessTime { get; set; }

        #endregion

        // Functions to populate in inherited classes and standard functions
        #region Functions

        public double CalculateGoal()
        {
            //TODO: Set up function to calculate the goal from flow-plan for instance
            return -1f;
        }
        #endregion
        
    }
}