using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace CensusAnalyserProject
{
   public class StateCensusAnalyser
    {

        public List<StateCensusDataDAO> StateCensusAnalyserlist = new List<StateCensusDataDAO>();
        public Dictionary<String, List<StateCensusDataDAO>> Dictionary = new Dictionary<string, List<StateCensusDataDAO>>();
        public List<StateCensusDataDAO> loadStateCensusData(String path)
        {

            var file = new System.IO.StreamReader(path);
            StateCensusAnalyserlist = new CsvHelper.CsvReader(file, System.Globalization.CultureInfo.InvariantCulture)
                    .GetRecords<StateCensusDataDAO>().ToList();

            Dictionary.Add("StateCensusAnalyzer", StateCensusAnalyserlist);
            var matchKey = "StateCensusAnalyzer";


            return Dictionary[matchKey];
        }
    }
}
