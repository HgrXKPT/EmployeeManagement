using EmployeeManagement.Components;
using EmployeeManagement.Data;
using EmployeeManagement.Repository.EmployeeRepository.Implementation;
using EmployeeManagement.Repository.EmployeeRepository.Interface;
using EmployeeManagement.Services.EmployeeServices.Interfaces;
using EmployeeManagement.Services.EmployeeServices;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Services.EmployeeServices.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer( builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
    

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
