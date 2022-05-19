using Microsoft.EntityFrameworkCore;
using ZAI.Server.Database;
using System.Text.Json.Serialization;
using ZAI.Server.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
                    .AddJsonOptions(x => {
                        x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                        x.JsonSerializerOptions.MaxDepth = 0;
                        x.JsonSerializerOptions.IgnoreReadOnlyProperties = true;
                        x.JsonSerializerOptions.WriteIndented = true;
                        x.JsonSerializerOptions.PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase;
                    });

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ZAIDbContext>(options => options.UseSqlite(builder.Configuration["ConnectionStrings:Sql"]));

// moje serwisy
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Services.CreateScope().ServiceProvider.GetService<ZAIDbContext>()?.Database.Migrate();

app.Run();
