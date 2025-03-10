using DiscreteEventSimulation.util;
using DiscreteEventSimulation.objects.interfaces;

namespace DiscreteEventSimulation.objects
{
    public class StandardUnit : interfaces.Unit
    {
        
        // Unknown FlowPlan Constructor
        public StandardUnit(string _name, string _product, string _flowPlan, int size) : base(_name, _product, _flowPlan, size) { this.unitType = UnitType.Standard; }
        
        // Known Flowplan Constructor
        public StandardUnit(string _name, string _product, string _flowPlan, FlowPlan _flow, int size) : base(_name, _product, _flowPlan, _flow, size) { }
        
        
    }
}