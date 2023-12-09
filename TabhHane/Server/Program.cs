using Blazored.LocalStorage;
using Blazored.Modal;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NSwag.Generation.Processors.Security;
using System.Text;
using TabhHane.Server.Data.Context;
using TabhHane.Server.Services.Extensions;
using TabhHane.Server.Services.Interface;
using TabhHane.Server.Services.Service;

namespace TabhHane
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigurationManager configuration = builder.Configuration;
            // Add services to the container.

            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();
            builder.Services.AddBlazoredModal();
            builder.Services.ConfigureMapping();
            builder.Services.AddScoped<IKullaniciService, KullaniciService>();
            builder.Services.AddSwaggerDocument(config =>
            {
                config.AddSecurity("Bearer", new NSwag.OpenApiSecurityScheme()
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Bearer {token}\"",
                    Name = "Authorization",
                    Type = NSwag.OpenApiSecuritySchemeType.Basic,
                    In = NSwag.OpenApiSecurityApiKeyLocation.Header,
                    Scheme = JwtBearerDefaults.AuthenticationScheme,
                    BearerFormat = JwtBearerDefaults.AuthenticationScheme,
                });
                config.OperationProcessors.Add(new AspNetCoreOperationSecurityScopeProcessor("Bearer"));


            });
            builder.Services.AddScoped<IKullaniciService, KullaniciService>();
            builder.Services.AddDbContext<TabhHaneContext>(config =>
            {
                config.UseSqlServer("Server=DESKTOP-SLOIL0F;Database=TabhHaneTest;User Id=sa;Password=17421742;TrustServerCertificate=True");
                config.EnableSensitiveDataLogging();
            });
            builder.Services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = configuration["JwtIssuer"],
                    ValidAudience = configuration["JwtAudience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSecurityKey"])),
                    ClockSkew=TimeSpan.FromDays(1),

                };
               
            });
            builder.Services.AddBlazoredLocalStorage();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
                app.UseDeveloperExceptionPage();
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
            app.UseAuthorization();
            app.UseAuthentication();
            app.UseOpenApi();
            app.UseSwaggerUi3();
            app.MapRazorPages();
            app.MapControllers();
            app.MapFallbackToFile("index.html");

            app.Run();
        }
    }
}