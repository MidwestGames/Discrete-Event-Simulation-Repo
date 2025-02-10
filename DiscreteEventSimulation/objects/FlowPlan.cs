using System;
using System.Collections.Generic;

namespace DiscreteEventSimulation.objects
{
    public class FlowPlan
    {
        // TODO: Set up abstract info for Entity Class  

        // Required Parameters taken from imported data
        #region Required Parameters
        public string name { get; set; }
        public string product { get; set; }
        public string dotProcess { get; set; }
        public List<Node> nodes { get; set; }
        

        #endregion

        // Calculated Parameters taken from imported data
        #region Calculated Parameters
        public Int16 nodeCount { get; set; }
        #endregion

        //Simulated values generated from factory controller
        #region Simulated Values

        #endregion

        // Functions to populate in inherited classes and standard functions
        #region Functions
        
        #endregion

    }
}