using DevelopersApi.Adapters;
using DevelopersApi;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Typed HttpClients
builder.Services.AddHttpClient<OutageSupplierHttpAdapter>(httpClient =>
{
    httpClient.BaseAddress = new Uri(builder.Configuration.GetConnectionString("outages-api"));
}).AddPolicyHandler(BasicPolicies.GetRetyPolicy()).AddPolicyHandler(BasicPolicies.GetCircuitBreakerPolicy());


builder.Services.AddSingleton<MongoDevelopersAdapter>((sp) =>
{
    // CARDINAL SIN - Hardcoding a connection string
    var connectionString = builder.Configuration.GetConnectionString("mongo");
    Console.WriteLine("The connection String" + connectionString);
    return new MongoDevelopersAdapter(connectionString);
});
//builder.Services.AddSingleton<MongoDevelopersAdapter>();

// everything above this line is configuring the internals of our application
var app = builder.Build();
// everything after this line is configuring the app pipeline (middleware)
// that means this is the stuff that handles HTTP request and responses.

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

// this happens before the application is running.
app.MapControllers();

// GET /on-call-developer (create an instance of the DeveloperController and call the GetOnCallDeveloper method

// This is the thing that runs our service. It is a blocking call. It will start up and stay here until
// the application is shut down.
Console.WriteLine("About the run the application");
app.Run();
Console.WriteLine("The application is done. FInished. This application is no more.");
