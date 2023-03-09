using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using PrimeHolding.Server.Core.DepartmentFeature;
using PrimeHolding.Server.Core.DepartmentFeature.Interfaces;
using PrimeHolding.Server.Core.EmployeeFeature;
using PrimeHolding.Server.Core.EmployeeFeature.Interfaces;
using PrimeHolding.Server.Core.WorkTaskFeature;
using PrimeHolding.Server.Core.WorkTaskFeature.Interfaces;
using PrimeHolding.Server.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IWorkTaskService, WorkTaskService>();

builder.Services.AddDbContext<EmployeeManagementDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("PrimeHoldingConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
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

app.Run();
