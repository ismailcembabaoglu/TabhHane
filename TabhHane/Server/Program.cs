using Blazored.Modal;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using TabhHane.Server.Data.Context;
using TabhHane.Server.Services.Interface;
using TabhHane.Server.Services.Service;

namespace TabhHane
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();
            builder.Services.AddBlazoredModal();
            builder.Services.AddScoped<IKullaniciService, KullaniciService>();
            builder.Services.AddDbContext<TabhHaneContext>(config =>
            {
                config.UseSqlServer("Server = DESKTOP - SLOIL0F; Database = TabhHaneTest; User Id = sa; Password = 17421742; ");
                config.EnableSensitiveDataLogging();
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();


            app.MapRazorPages();
            app.MapControllers();
            app.MapFallbackToFile("index.html");

            app.Run();
        }
    }
}