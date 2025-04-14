using DiscreteEventSimulation.util;

namespace DiscreteEventSimulation.objects.interfaces
{
    public abstract class Unit
    {
        // Required Parameters taken from imported data
        protected string name { get; set; }
        protected string product { get; set; }
        protected sbyte size { get; set; }
        protected  UnitType unitType { get; set; }
        protected string flowPlan { get; set; } 
        protected FlowPlan flow {get; set;}

        // Calculated Parameters taken from imported data        
        protected double cumulativeCycleTimeGoal { get; private set; }
        protected double cumulativeQueueTimeGoal { get; private set; }
        protected double cumulativeProcessTimeGoal { get; private set; }

            // Calculated based on UnitType and individual node CT and PT goals to determine the best reduction method
        protected float queueTimeReductionFactor;
        protected float cycleTimeReductionFactor;
        
        //Simulated values generated from factory controller
        protected double simulatedCycleTime { get; set; }
        protected double simulatedQueueTime { get; set; }
        protected double simulatedProcessTime { get; set; }
        
        // Constructor 1: Empty FlowPlan
        protected Unit(string _name, string _product, string _flowPlan, int size)
        {
            this.name = _name;
            this.product = _product;
            this.size = (sbyte)size;
            this.flowPlan = _flowPlan;

            this.flow = null;
        }
        
        // Constructor 2: Known FlowPlan
        protected Unit(string _name, string _product, string _flowPlan, FlowPlan _flow, int size)
        {
            this.name = _name;
            this.product = _product;
            this.size = (sbyte)size;
            this.flowPlan = _flowPlan;

            this.flow = _flow;
        }
        
        
        // Helper Functions
        protected string GetUnitType()
        {
            switch (this.unitType)
            {
                case UnitType.Standard:
                    return "Standard";
                case UnitType.HighPriority:
                    return "High Priority";
                case UnitType.SuperPriority:
                    return "Super Priority";
                case UnitType.UltraPriority:
                    return "Ultra Priority";
                default:
                    return "No Unit Type";
            }
        }
    }
}