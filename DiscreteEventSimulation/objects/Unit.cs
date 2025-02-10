using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Runtime.CompilerServices;
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
        private UnitType unitType { get; }
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

        public List<double> CalculateGoals(List<Node> nodes)
        {
            // Goals List Index : 0 - CT | 1 - QT | 2 - RPT
            List<double> goals = new List<double>(3);
            switch (unitType)
            {
                case UnitType.Standard:
                    this.queueTimeReductionFactor = 1.0f;
                    break;
                
                case UnitType.HighPriority:
                    this.queueTimeReductionFactor = 0.8f;
                    break;
                
                case UnitType.SuperPriority:
                    this.queueTimeReductionFactor = 0.6f;
                    break;
                
                case UnitType.UltraPriority:
                    this.queueTimeReductionFactor = 0f;
                    break;

                default:
                    this.queueTimeReductionFactor = 1.0f;
                    break;
            }
            
            foreach (Node node in nodes)
            {
                goals[1] += node.QueueTimeGoal * this.queueTimeReductionFactor;
                goals[2] += node.ProcessTimeGoal;
                goals[0] += goals[1] + goals[2];
            }
            return goals;
        }
        #endregion
        
        // Constructor 1: Empty dataset
        public Unit(string _name, UnitType _unitType, string _product, string _flowPlan, int size)
        {
            this.name = _name;
            this.product = _product;
            this.size = (sbyte)size;
            this.unitType = _unitType;
            this.flowPlan = _flowPlan;
        }
        
    }
}