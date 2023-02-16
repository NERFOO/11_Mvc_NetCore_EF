using _11_Mvc_NetCore_EF.Data;
using _11_Mvc_NetCore_EF.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2022";

//SI UTILIZAMOS CONTEXT DE EF ESTAMOS OBLIGADOS A UTILIZAR TRANNSIENT EN LOS REPOSITORIOS
builder.Services.AddTransient<RepositoryHospital>();

//PARA INYECTAR EL CONTEXT NECESITAMOS LA CADENA DE CONEXION SOLAMENTE PORQUE ESTAMOS HABLANDO DE SQL SEVER
//SE UTILIZA EL METODO ADDDBCONTEXT<CONTEXT> PARA LA INYECCION
builder.Services.AddDbContext<HospitalContext>( options => options.UseSqlServer(connectionString));

builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Hospitales}/{action=Index}/{id?}");

app.Run();
