using BideryaMvcProject.DataBase;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<BideryaMvcDatabase>();
builder.Services
               .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
               .AddCookie(opts =>
               {
                   opts.Cookie.Name = ".Biderya";
                   opts.ExpireTimeSpan = TimeSpan.FromDays(10);  //Burada cookie'nin �mr�n� belirliyoruz...
                   opts.SlidingExpiration = false; // Buray� false vererek Kullan�c�n�n 14 g�n sonra zorla tekrardan �ifreyle vs login olmas�n� sa�l�yoruz.. true verirsek her girdi�inde s�reye 14 g�n ekler...
                   opts.LoginPath = "/Kullanici/GirisYap"; //Burada Kullan�c� Login De�ilse Direk Tan�mlad���m�z controller'�n Action'n�na gidiyor.
                   opts.LogoutPath = "/Kullanici/CikisYap"; // Buray� daha tan�mlamad�m tan�mlan�cak...!!!
                   opts.AccessDeniedPath = "/Home/Anasayfa"; //Buras�da Yetki olmad��� zaman gidece�i yer ben buray� kullanmay� d���nm�yorum silerim ileride...
               });

var app = builder.Build();


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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Anasayfa}/{id?}");

app.Run();
