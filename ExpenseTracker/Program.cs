using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt+QHFqVkNrWU5FdUBAXWFKblB8RmFTfFZgFChNYlxTR3ZbQ15iTH1RdUxnUH5Z;Mgo+DSMBPh8sVXJ1S0d+X1RPc0BDXnxLflF1VWBTfFx6d11WACFaRnZdQV1nSH1Sc0ZhWnZbcnRS;ORg4AjUWIQA/Gnt2VFhhQlJBfVpdXGBWfFN0RnNadV1yflZOcDwsT3RfQF5jTX9Qd0BgW3xXdXdRQQ==;MTcxNDcxNkAzMjMxMmUzMTJlMzMzNU0zV2hQUHdUSHdJU1J3dUhoZGhYc0RWWTNMdTJFbU03ZVpzT1hNWnVsSU09;MTcxNDcxN0AzMjMxMmUzMTJlMzMzNURGWHBLOVNDZlY3dXRvM2grTy9OQUdLbGhpQTlabnFTQ3NXbjlxVzZ5VXM9;NRAiBiAaIQQuGjN/V0d+XU9Hc1RHQmJKYVF2R2BJfFRzdl9FaEwxOX1dQl9gSXpSdURmWn1deXFdT2c=;MTcxNDcxOUAzMjMxMmUzMTJlMzMzNU8wbVkrNHMwcWF0dEVsQXc2dzNKN2tIMmNzRzVWUHZOOVoxL0J3NUJleWM9;MTcxNDcyMEAzMjMxMmUzMTJlMzMzNWhkdnBCMzM2bkxrMW9oZ0laNW85UGx0Z0JzaVFEelNzN1RPQXB3bjdEaFU9;Mgo+DSMBMAY9C3t2VFhhQlJBfVpdXGBWfFN0RnNadV1yflZOcDwsT3RfQF5jTX9Qd0BgW3xXdndTQQ==;MTcxNDcyMkAzMjMxMmUzMTJlMzMzNWsxTmMvTHN6Z0VXU3VjRjFQNEFPaWFxNHZhaW5hcWlJcWhsNVU3TCszbWc9;MTcxNDcyM0AzMjMxMmUzMTJlMzMzNW5rcVA0anp4WjJ4Y3dPT1V6NXFTS0dIT0VKdGJROFh5VS9FaWdQd28xaWM9;MTcxNDcyNEAzMjMxMmUzMTJlMzMzNU8wbVkrNHMwcWF0dEVsQXc2dzNKN2tIMmNzRzVWUHZOOVoxL0J3NUJleWM9");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
