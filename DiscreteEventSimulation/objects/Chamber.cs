using DiscreteEventSimulation.objects.interfaces;
using System.Collections.Generic;

namespace DiscreteEventSimulation.objects
{
    public class Chamber
    {
        // Required Parameters taken from imported data
        private string chamberName { get; set; }
        private float availability { get; set; }
        private float protectiveCapacity { get; set; }
        private float aggregateRunRate { get; set; }
        private float unitStartCapacity { get; set; }
        private List<Node> modeledNodes { get; set; } // Only use nodes modeled in capacity system
        private float modeledUtilization { get; set; } // U = availability / (1 + protectiveCapacity)

        // Calculated Parameters taken from imported data
        // Index for statistical metrics (From Actual Factory Data):
        //0: Min | 1: 25%tile | 2: Mean | 3: Median | 4: 75%tile | 5: 90%tile | 6: Max | 7: Standard Deviation | 8: Variance
        private List<float> availabilitySummary { get; set; }

        //Simulated values generated from factory controller
    }
}
