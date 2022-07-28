using System;
using System.Linq;

namespace Names {
    internal static class HistogramTask {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name) {
            string[] dayOfMonth = new string[31];
            for(int i = 0; i<dayOfMonth.Length;i++ )
                dayOfMonth[i] = (i+1).ToString();

            double[] birthCount = new double[31];

            foreach( var e in names ) {
                if( e.Name == name && e.BirthDate.Day != 1) {
                    birthCount[e.BirthDate.Day - 1]++;            
                    }
                }


            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name),
                dayOfMonth,
                birthCount);
               
        }
    }
}