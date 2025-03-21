using System.Collections.Generic;

namespace DiscreteEventSimulation.objects.interfaces
{
    public class Entity
    {
        // TODO: Set up abstract info for Entity Class  
        
        // Required Parameters taken from imported data
        #region Required Parameters

        protected string ceid;
        protected float availability;
        protected sbyte inventory;
        protected List<string> entities;

        #endregion

        // Calculated Parameters taken from imported data

        #region Calculated Parameters

        // Index for statistical metrics (From Actual Factory Data):
        // 0: Min | 1: 25%tile | 2: Mean | 3: Median | 4: 75%tile | 5: 90%tile | 6: Max | 7: Standard Deviation | 8: Variance
        protected List<float> availabilitySummary;

        #endregion

        //Simulated values generated from factory controller

        #region Simulated Values

        #endregion
    }
}