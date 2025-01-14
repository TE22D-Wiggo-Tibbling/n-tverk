using System.Net.Http.Json;
using System.Text.Json;
using nätverk;

HttpClient client = new();
client.BaseAddress = new("https://opendata-download-metfcst.smhi.se/");
HttpResponseMessage response = client.GetAsync("/api/category/pmp3g/version/2/geotype/point/lon/16/lat/58/data.json").Result;

pokemon p = response.Content.ReadFromJsonAsync<pokemon>().Result;

// string väder = response.Content.ReadAsStringAsync().Result;

// pokemon vädern = JsonSerializer.Deserialize<pokemon>(väder);

foreach (Parameter param in p.timeseries[0].parameters)
{
    if (param.name == "t"){
    Console.WriteLine(param.value);
    }
}


// Console.WriteLine(p.parameter);

// File.WriteAllText("trubbish.json",väder);
Console.ReadLine();
