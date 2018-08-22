using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherCAOA
{
    class City  //Step 2
    {
        public string name;
        public string id;
        public Measure main { get; set; } //FOR THE OTHER CLASS TO GET INFO OF THIS LOCATION  (main is the JSON section)

    }
}


//THIS IS HOW THE JSON FORMAT FOR EACH LOCARTION IS SEARCHED [name, id, or coord]

 //{
 //   "id": 1861060,
 //   "name": "Japan",
 //   "country": "JP",
 //   "coord": {
 //     "lon": 139.753098,
 //     "lat": 35.68536
 //   }