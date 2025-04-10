using System;
using System.Collections.Generic;
using DiscreteEventSimulation.util;

namespace DiscreteEventSimulation.objects.interfaces
{
    public abstract class Node
    {
        // Required Parameters taken from imported data
        protected NodeType NType { get; private set; }
        protected string Name { get; set; }
        protected int Sequence { get; set; }
        protected string Description { get; set; } 
        protected double CycleTimeGoal { get; set; }
        protected double QueueTimeGoal { get; set; }
        
        // Because Nodes can have unique processing times based on the flow it is included in, must add keys to make individual nodes for each of those factors
        protected string productCode { get; set; } // Might warrant creating structure to group product codes into families based on naming

        // Calculated Parameters taken from imported data
            // Index for statistical metrics (From Actual Factory Data):
            // 0: Min | 1: 25%tile | 2: Mean | 3: Median | 4: 75%tile | 5: 90%tile | 6: Max | 7: Standard Deviation | 8: Variance
        protected double ProcessTimeGoal { get; private set; }
        protected List<double> ActualCycleTimeStats { get; private set; }
        protected List<double> ActualQueueTimeStats { get; private set; }
        protected List<double> ActualProcessTimeStats { get; private set; }
        
        protected List<Entity> Entities { get; set; }

        //Simulated values generated from factory controller
            // TODO: Set up simulated data instance variables

        protected List<double> CalculateStats(List<double> dataset)
        {
            // Index for statistical metrics:
            // 0: Min | 1: 25%tile | 2: Mean | 3: Median | 4: 75%tile | 5: 90%tile | 6: Max | 7: Standard Deviation 
            // TODO: Complete function to calculate statistical values

            return null;
        }

        override
        public string ToString()
        {
            //TODO: Implement in to string function
            return "TODO";
        }
        
        /* TODO: Create all constructors for:
            Empty Entity List
            Known Entity List
            Unparsed CT/PT And Entity Data - Primary
         */
    }
}