using System;
using System.Collections.Generic;

namespace DiscreteEventSimulation.objects.interfaces
{
    public class FlowPlan
    {
        // Required Parameters taken from imported data
        #region Required Parameters
        
        public string name { get; set; }
        public string product { get; set; }
        public string productFamily { get; set; }
        
        #endregion

        // Calculated Parameters taken from imported data
        #region Calculated Parameters
        
        public Int16 nodeCount { get; set; }
        public List<Node> nodes { get; set; }
        
        #endregion

        //Simulated values generated from factory controller
        #region Simulated Values

        #endregion
    }
}