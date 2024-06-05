using RapidBootcamp.WebApplication.DAL;

var builder = WebApplication.CreateBuilder(args);

//menambahkan modul mvc
builder.Services.AddControllersWithViews();

//menambahkan DI
builder.Services.AddScoped<ICategory, CategoriesDAL>();

var app = builder.Build();

app.UseRouting();

app.MapControllerRoute(
       name: "default",
       pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
