using System;
using System.Collections.Generic;
using DiscreteEventSimulation.api;

namespace DiscreteEventSimulation.objects
{
    public abstract class Node
    {
        // TODO: Set up abstract info for Node Class  

        // Required Parameters taken from imported data
        #region Required Parameters
        
        public NodeType NType { get; private set; }
        public string Name { get; set; }
        public int Sequence { get; set; }
        public string Description { get; set; } 
        public double CycleTimeGoal { get; set; }
        public double QueueTimeGoal { get; set; }
        public string FlowPlan { get; set; }
        public FlowPlan flow { get; private set; }
        public Node PreviousNode { get; set; }
        public Node NextNode { get; set; } 
        public List<Entity> Entities { get; set; }

        #endregion

        // Calculated Parameters taken from imported data
        #region Calculated Parameters
            // Index for statistical metrics:
            // 0: Min | 1: 25%tile | 2: Mean | 3: Median | 4: 75%tile | 5: 90%tile | 6: Max | 7: Standard Deviation 
        public string ProcessTimeGoal { get; private set; }
        public List<double> ActualCycleTimeStats { get; private set; }
        public List<double> ActualQueueTimeStats { get; private set; }
        public List<double> ActualProcessTimeStats { get; private set; }
        
        #endregion

        //Simulated values generated from factory controller
        #region Simulated Values

        // TODO: Set up simulated data instance variables

        #endregion

        // Functions to populate in inherited classes and standard functions
        #region Functions

        public List<double> CalculateStats(List<double> dataset)
        {
            // Index for statistical metrics:
            // 0: Min | 1: 25%tile | 2: Mean | 3: Median | 4: 75%tile | 5: 90%tile | 6: Max | 7: Standard Deviation 
            // TODO: Complete function to calculate statistical values

            return null;
        }
        
        #endregion

    }
}