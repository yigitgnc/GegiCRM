using AutoMapper;
using GegiCRM.BLL.Concrete;
using GegiCRM.BLL.Generic;
using GegiCRM.DAL.Abstract;
using GegiCRM.DAL.Concrete;
using GegiCRM.DAL.EntityFramework;
using GegiCRM.Entities.Concrete;
using GegiCRM.WebUI.Hubs;
using GegiCRM.WebUI.Mappings;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using Quartz;

//using Microsoft.Extensions.DependencyInjection.IdentityServiceCollectionExtensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSession();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddDbContext<CrmDbContext>();

builder.Services.AddScoped<IAppUserDal, EfAppUserRepository>();
builder.Services.AddScoped<AppUserManager>();

builder.Services.AddScoped(typeof(GenericManager<>));

builder.Services.AddQuartz(q =>
{
    // base quartz scheduler, job and trigger configuration
});

// ASP.NET Core hosting
builder.Services.AddQuartzServer(options =>
{
    // when shutting down we want jobs to complete gracefully
    options.WaitForJobsToComplete = true;
});


//builder.Services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));
//builder.Services.AddScoped<IAppIdentityRoleDal, EfAppIdentityRoleRepository>();
//builder.Services.AddScoped<AppIdentityRoleManager>();
//builder.Services.AddScoped<GenericManager<Customer>>();

using (var context = new CrmDbContext())
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

//////aha
builder.Services.AddIdentity<AppUser, AppIdentityRole>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<CrmDbContext>();

builder.Services.ConfigureApplicationCookie(options =>
{
    // Cookie settings
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromDays(5);
    options.LoginPath = "/Login";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    options.SlidingExpiration = true;
});

builder.Services.AddRazorPages();
builder.Services.AddSignalR(options =>
{
    options.EnableDetailedErrors = true;
});

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

StaticFileOptions staticFileOptions = new StaticFileOptions();
FileExtensionContentTypeProvider typeProvider = new FileExtensionContentTypeProvider();
if (!typeProvider.Mappings.ContainsKey(".woff2"))
{
    typeProvider.Mappings.Add(".woff2", "application/font-woff2");
}
staticFileOptions.ContentTypeProvider = typeProvider;
app.UseStaticFiles(staticFileOptions);

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

app.MapHub<UserHub>("/UserHub");

app.Run();



