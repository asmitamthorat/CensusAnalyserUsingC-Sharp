using NUnit.Framework;
using CensusAnalyserProject;

using System;
using System.Collections.Generic;

namespace CensusAnalyserTest
{
    public class Tests
    {


        String IndiaStateCodeCensusFilePath = @"C:\\Users\\com\\source\\repos\\CensusAnalyserProject\\CensusAnalyserTest\\utilities\\IndiaStateCode.csv";
        String IndiaCensusDataWithDelimiter = @"C:\\Users\\com\\source\\repos\\CensusAnalyserProject\\CensusAnalyserTest\\utilities\\DelimiterIndiaStateCensusData.csv";
        String IndiaCensusDataWithWrongFile = @"C:\\Users\\com\\source\\repos\\CensusAnalyserProject\\CensusAnalyserTest\\utilities\\IndiaStateCode.txt";
        String IndiaStateCensusWithoutHeader = @"C:\\Users\\com\\source\\repos\\CensusAnalyserProject\\CensusAnalyserTest\\utilities\\WrongHeaderIndiaStateCensusData.csv";
        String IndiaCensusAnalyserWithWrong_File = @"C:\\Users\\com\\source\\repos\\CensusAnalyserProject\\CensusAnalyserTest\\utilities\\IndiaCensusAnalyser.txt";
        String IndiaStateCodeWithDelimiter = @"C:\\Users\\com\\source\\repos\\CensusAnalyserProject\\CensusAnalyserTest\\utilities\\IndiaStateCode_withDelimiterIssue.csv";
        String USCensusData = @"C:\\Users\\com\\source\\repos\\CensusAnalyserProject\\CensusAnalyserTest\\utilities\\USCensusData.csv";
        String IndiaCensusDataFilePath1 = @"C:\\Users\\com\\source\\repos\\CensusAnalyserProject\\CensusAnalyserTest\\utilities\\IndiaStateCensusData.csv";


        [Test]
        public void givenStateCensusData_ifHasCorrectNumberOfRecord_ShouldReturnTrue()
        {

            StateCensusAnalyser stateCensusAnalyser = new StateCensusAnalyser();
            List<StateCensusDataDAO> list = stateCensusAnalyser.loadStateCensusData(IndiaCensusDataFilePath1);
            int count = list.Count;
            Console.WriteLine(count);
            Assert.AreEqual(29, count);
        }
    }
}