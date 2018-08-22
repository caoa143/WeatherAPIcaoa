using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections;

//  http://api.openweathermap.org/data/2.5/forecast?id=524901&APPID={APIKEY} FROM WEBSITE, ONE BELOW IS DIFFERENT
// CAOA API KEY==  130a530153305f566da86f687a3a394f
//STOLEN KEY== 1490b6fe66e11b6dfe593644927ae890



namespace WeatherCAOA
{
    class Program  //STEP 3 --INSERT URL, KEY, READER, DIRECTORIES^
    {
        //3A--HTTP CLIENT--INSERT URL & API KEY OUTISDE MAIN SCOPE-----------------------------------------
        static HttpClient client = new HttpClient(); 
        private const string URL = "https://api.openweathermap.org/data/2.5/weather?q=Atlanta&units=imperial&APPID=130a530153305f566da86f687a3a394f";
        //-----------------------------------------------------------------------------------------------------

        static void Main(string[] args)
        {
            RunAsync().Wait();  //Inserted this...idk why yet >>supposed to be a method below
        }

        //3B---------METHODS OUTSIDE MAIN SCOPE-----READ/ RETURN INFO--------------------------

        static void ShowData(City oCity)  //method to display desired data to CMD Box|| Given city CLASS as input
        {
            Console.WriteLine($"Name: {oCity.name}");  //access city>name
            Console.WriteLine($"Temp: {oCity.main.temp}");  //access city>MEASURE (var type in class)> main(JSON section)>temperature***
            Console.WriteLine($"Pressure: {oCity.main.pressure}");  //^^
            Console.WriteLine($"Humidity: {oCity.main.humidity}");  //^^
        }

        //3C =====PARSING/ READING METHODS=======================

        static async Task RunAsync()  //3C-1:
        {
            City oCity = null;  //NEW INSTANCE OF LOCATION/CITY
            client.BaseAddress = new Uri(URL); //CREATE URL
            client.DefaultRequestHeaders.Accept.Clear();  //URL REQUEST
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));  //????? request JSON?
            oCity = await GetProductAsync();  //method below
            Console.WriteLine();
            ShowData(oCity);  //CALL METHOD ABOVE TO DISPLAY DATA
            Console.ReadLine();
        }

        static async Task<City> GetProductAsync() //3C-2:  
        {
            City oCity = null; //NEW city instance
            HttpResponseMessage resp = client.GetAsync(URL).Result; //call Method GetAsync, input URL, assign resp variable

            if (resp.IsSuccessStatusCode)
            {
                oCity = await resp.Content.ReadAsAsync<City>(); //**INSTALL NUGET: Microsoft.AspNet.WebApi
            }
            return oCity;
        }
    }
}
