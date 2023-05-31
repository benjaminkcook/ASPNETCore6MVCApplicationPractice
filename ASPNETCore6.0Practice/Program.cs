using ASPNETCore6._0Practice.Models;

var builder = WebApplication.CreateBuilder(args); // application on startup looks at appsettings.json file and loads the settings from that file

// registered services
builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<IPieRepository, MockPieRepository>();

// services
builder.Services.AddControllersWithViews(); // make sure our application knows about asp.net core and mvc

var app = builder.Build(); // application instance is ready

// middleware
app.UseStaticFiles(); // configured to look for incoming requests for static files, such as a jpeg or a css file (wwwroot)

// app.MapGet("/", () => "Hello World!");

if (app.Environment.IsDevelopment()) { // check if the app is running in a development enviornment
    app.UseDeveloperExceptionPage(); // diagnostic middleware component that will show the developer exception page
}

app.MapDefaultControllerRoute(); // set some defaults to route to views (lets MVC handle incoming requests on controllers, this is considered endpoint middleware)

app.Run();
