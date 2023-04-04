using Dependency_Injection_AspNetCore.Services;
using Dependency_Injection_AspNetCore.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.Add( new ServiceDescriptor(typeof(ConsoleLog) ,  new  ConsoleLog()));
//builder.Services.Add( new ServiceDescriptor(typeof(TxtLog) ,  new  TxtLog()  /* , ServiceLifetime.Transient*/));
/* assagida ki daha dogrudu */

//builder.Services.AddSingleton<ConsoleLog>(); //new T();

//builder.Services.AddSingleton<ConsoleLog>(p => new ConsoleLog(5)); //new T();

//builder.Services.AddScoped<ConsoleLog>();
//builder.Services.AddScoped<ConsoleLog>(p => new  ConsoleLog(4));

//builder.Services.AddTransient<ConsoleLog>();
//builder.Services.AddTransient<ConsoleLog>(p => new ConsoleLog(6));


//builder.Services.AddScoped<ILog>(p => new ConsoleLog(5));

//builder.Services.AddScoped<ILog , TxtLog>();
builder.Services.AddScoped<ILog, ConsoleLog>(x => new ConsoleLog(5));

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
