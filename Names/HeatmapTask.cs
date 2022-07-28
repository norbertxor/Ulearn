using System;

namespace Names {
    internal static class HeatmapTask {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names) {
            string[] month = new string[12];
            for( int i = 0; i < month.Length; i++ )
                month[i] = ( i + 1 ).ToString();
            string[] day = new string[30];
            for( int i = 0; i < day.Length; i++ )
                day[i] = ( i + 2 ).ToString();
            double[,] result = new double[30, 12];
            foreach(var e in names ) {
                if(e.BirthDate.Day != 1)
                    result[e.BirthDate.Day-2, e.BirthDate.Month-1]++;
                }
            return new HeatmapData(
                "Пример карты интенсивностей",
                result, 
                day, 
                month);
        }
    }
}