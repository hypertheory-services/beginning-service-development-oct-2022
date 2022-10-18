var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.



app.MapGet("/breaks/{minutes:int}", (int minutes) =>
{
    var timeNow = DateTime.Now;
    var timeAtEndOfBreak = timeNow.AddMinutes(minutes);
    return new TakeBreakResponse(timeNow, timeAtEndOfBreak, minutes);
});

app.Run();


record TakeBreakResponse(DateTime StartTime, DateTime EndTime, int Minutes);