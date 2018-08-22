using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherCAOA
{
    class Measure  //STEP 1
    {
        public double temp { get; set; }
        public double pressure { get; set; }
        public double humidity { get; set; }
    }
}

//JSON FORMAT EXAMPLE BELOW----We want>> Main[temp, pressure, humidity]
//{"coord":
//{"lon":145.77,"lat":-16.92},
//"weather":[{"id":803,"main":"Clouds","description":"broken clouds","icon":"04n"}],
//"base":"cmc stations",
//"main":{"temp":293.25,"pressure":1019,"humidity":83,"temp_min":289.82,"temp_max":295.37},