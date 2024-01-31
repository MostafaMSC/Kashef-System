
using KSHIFSYSTEM.BackEnd.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using KSHIFSYSTEM.BackEnd.Repositories;
using KSHIFSYSTEM.Data;
using KSHIFSYSTEM.Areas.Identity;
using MudBlazor.Services;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");



builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();


builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();


builder.Services.AddRazorPages();

//builder.Services.AddRazorPages(Options => { Options.Conventions.AddPageRoute("/Identity/Account/Login", ""); });
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationState<IdentityUser>>();
   

builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddMudServices();
builder.Services.AddScoped<IKshifInfo, KshifInfoRepo>();
builder.Services.AddScoped<IDawa, DawaRepo>();
builder.Services.AddScoped<ITotalKshofat, TotalKshofatRepo>();
builder.Services.AddScoped<ITarsheh, TarshehRepo>();
//builder.Services.AddScoped<IPrintingService, PrintingService>();
builder.Services.AddScoped<ISystemUsers, SystemUsersRepo>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();