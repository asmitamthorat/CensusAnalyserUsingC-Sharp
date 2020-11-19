using System;
using System.Collections.Generic;
using System.Text;

namespace CensusAnalyserProject
{
 public class StateCensusDataDAO
    {
        public string State;
        public int Population;
        public string AreaInSqKm;
        public string DensityPerSqKm;




        public StateCensusDataDAO(StateCensusDataDTO stateCensusData)
        {
            this.State = stateCensusData.State;
            this.Population = stateCensusData.Population;
            this.AreaInSqKm = stateCensusData.AreaInSqKm;
            this.DensityPerSqKm = stateCensusData.DensityPerSqKm;
        }
    }
}
