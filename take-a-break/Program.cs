// See https://aka.ms/new-console-template for more information
using System.Text.Json;
Console.WriteLine("Take A Break!");


var client = new HttpClient();
client.BaseAddress = new Uri("http://localhost:9090");

while (true)
{
    Console.Write("How Many Minutes? ");
    var minutes = int.Parse(Console.ReadLine());

    var response = await client.GetAsync("/breaks/" + minutes);

    var result = await response.Content.ReadAsStringAsync();


    var info = JsonSerializer.Deserialize<BreakInfo>(result);

    Console.WriteLine($"Your Break will end at {info.endTime.ToLocalTime()}");
}

public class BreakInfo
{
    public DateTime startTime { get; set; }
    public DateTime endTime { get; set; }
    public int minutes { get; set; }
}
