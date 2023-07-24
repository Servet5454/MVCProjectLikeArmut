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
                   opts.ExpireTimeSpan = TimeSpan.FromDays(10);  //Burada cookie'nin ömrünü belirliyoruz...
                   opts.SlidingExpiration = false; // Burayý false vererek Kullanýcýnýn 14 gün sonra zorla tekrardan þifreyle vs login olmasýný saðlýyoruz.. true verirsek her girdiðinde süreye 14 gün ekler...
                   opts.LoginPath = "/Kullanici/GirisYap"; //Burada Kullanýcý Login Deðilse Direk Tanýmladýðýmýz controller'ýn Action'nýna gidiyor.
                   opts.LogoutPath = "/Kullanici/CikisYap"; // Burayý daha tanýmlamadým tanýmlanýcak...!!!
                   opts.AccessDeniedPath = "/Home/Anasayfa"; //Burasýda Yetki olmadýðý zaman gideceði yer ben burayý kullanmayý düþünmüyorum silerim ileride...
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
