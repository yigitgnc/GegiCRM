using AutoMapper;
using GegiCRM.BLL.Abstract;
using GegiCRM.BLL.Concrete;
using GegiCRM.DAL.Abstract;
using GegiCRM.DAL.Concrete;
using GegiCRM.DAL.EntityFramework;
using GegiCRM.DAL.Repositories;
using GegiCRM.Entities.Concrete;
using GegiCRM.WebUI.Mappings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSession();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>();

builder.Services.AddScoped<IAppUserDal, EfAppUserRepository>();
builder.Services.AddScoped<AppUserManager>();

builder.Services.AddScoped(typeof(GenericManager<>));


//builder.Services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));
//builder.Services.AddScoped<IAppIdentityRoleDal, EfAppIdentityRoleRepository>();
//builder.Services.AddScoped<AppIdentityRoleManager>();
//builder.Services.AddScoped<GenericManager<Customer>>();

using (var context = new Context())
{
    context.Database.Migrate();
}


// Auto Mapper Configurations
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddIdentity<AppUser, AppIdentityRole>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<Context>();
builder.Services.AddRazorPages();

builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings.
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 0;

    // Lockout settings.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;

    // User settings.
    //options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = true;
    
});

builder.Services.ConfigureApplicationCookie(options =>
{
    // Cookie settings
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromDays(5);
    options.LoginPath = "/Login";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    options.SlidingExpiration = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/Error/", "?statusCode={0}");
app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



