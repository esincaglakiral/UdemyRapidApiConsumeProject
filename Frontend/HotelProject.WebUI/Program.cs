using FluentValidation;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddControllersWithViews(opts =>
{
    opts.Filters.Add(new AuthorizeFilter());
});


builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Login/Index";
    //options.AccessDeniedPath = "/ErrorPage/Page403"; 
    options.Cookie.Name = Guid.NewGuid().ToString();
    options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
    options.SlidingExpiration = true;
    //options.LogoutPath = "/Login/Logout/";
});




builder.Services.AddHttpClient(); // Controllerda HttpClient Constructor'u oluþturduðum için  httpClientFactory Hatasýný önlemek için bu konfigurasyon saðlanmýþtýr, register iþlemi yapýlmýþtýr

builder.Services.AddDbContext<Context>();  //Identity için
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>(); //Idenitity iþlemleri için konfigurasyon

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();

app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");

app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
