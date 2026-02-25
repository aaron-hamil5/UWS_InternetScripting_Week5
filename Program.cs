var builder = WebApplication.CreateBuilder(args);

//Add Razor services
builder.Services.AddRazorPages();

var app = builder.Build();
//Load defult settings, find index.cshtml
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapRazorPages();

app.Run();
