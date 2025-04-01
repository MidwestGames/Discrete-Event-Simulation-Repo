using System.Collections.Generic;

namespace DiscreteEventSimulation.objects
{
    public class Frame
    {
        // Required Parameters taken from imported data
        #region Required Parameters

        private string ceid { get; set; }
        private float availability { get; set; }
        private sbyte inventory { get; set; }
        private List<Chamber> chambers { get; set; }

        #endregion

        // Calculated Parameters taken from imported data

        #region Calculated Parameters

        // Index for statistical metrics (From Actual Factory Data):
        // 0: Min | 1: 25%tile | 2: Mean | 3: Median | 4: 75%tile | 5: 90%tile | 6: Max | 7: Standard Deviation | 8: Variance
        private List<float> availabilitySummary { get; set; }

        #endregion

        //Simulated values generated from factory controller

        #region Simulated Values

        #endregion
    }
}