using MediPlus_DAL.Contexts;
using MediPlus_MVC.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionStr = builder.Configuration.GetConnectionString("MSSql");
builder.Services.AddDbContext<MediPlusDbContext>(opt =>
{
    opt.UseSqlServer(connectionStr);
});
builder.Services.AddControllersWithViews();



var app = builder.Build();

app.MapControllerRoute(
			name: "areas",
			pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
		  );
app.MapControllerRoute (
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );
app.UseStaticFiles();

app.Run();
