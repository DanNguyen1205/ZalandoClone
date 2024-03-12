using Microsoft.EntityFrameworkCore;
using ZaunShop.Data;
using ZaunShop.Repository.Implementations;
using ZaunShop.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMvc().AddRazorRuntimeCompilation();
builder.Services.AddControllersWithViews();
//Depedendency injection into the pipeline. Map IZaunShopDbRepository with ZaunShopDbRepostiory
builder.Services.AddScoped<IZaunShopDbRepository, ZaunShopDbRepository>();

//Add session for shopping cart logic. 
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(10);
});

//Specify which authentication handler the authenticaion middleware has to work with. Then add that authentication handler as well.
builder.Services.AddAuthentication("MyCookieAuth").AddCookie("MyCookieAuth", options =>
{
    options.LoginPath = "/Account/Login";
    options.AccessDeniedPath = "/Account/AccessDenied";
    options.Cookie.Name = "MyCookieAuth";
});

builder.Services.AddAuthorization(options =>
{
    //When authorization with this policy the department=management claim must be there to gain access. 
    //options.AddPolicy("AdminPolicy", policy => policy.RequireClaim("Department", "Management"));

    //Claim has to exist, value does not matter.
    options.AddPolicy("AdminPolicy", policy => policy
    .RequireClaim("Admin"));
});

builder.Services.AddDbContext<ZaunShopDbContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("DBConnectionString")));

var app = builder.Build();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

app.UseSession();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

//Seed database
AppDbInitializer.Seed(app);

app.Run();


