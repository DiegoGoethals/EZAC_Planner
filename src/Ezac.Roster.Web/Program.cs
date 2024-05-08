using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Domain.Interfaces.Services;
using Ezac.Roster.Domain.Services;
using Ezac.Roster.Infrastructure.Data;
using Ezac.Roster.Infrastructure.Repositories;
using Ezac.Roster.Web.Components;
using Microsoft.EntityFrameworkCore;

namespace Ezac.Roster.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add database service
            builder.Services.AddDbContext<ApplicationDbContext>
                (options => options
                .UseSqlServer(builder.Configuration.GetConnectionString("DefaultDb")));

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            //builder.Services.AddScoped<ICalendarService, CalendarService>();
            //builder.Services.AddScoped<ICalendarRepository, CalendarRepository>();

            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();

            //builder.Services.AddScoped<IDayPeriodService, DayPeriodService>();
            //builder.Services.AddScoped<IDayPeriodRepository, DayPeriodRepository>();

            //builder.Services.AddScoped<IDayService, DayService>();
            builder.Services.AddScoped<IDayRepository, DayRepository>();

            //builder.Services.AddScoped<IPreferenceService, PreferenceService>();
            builder.Services.AddScoped<IPreferenceRepository, PreferenceRepository>();

            //builder.Services.AddScoped<IPermissionsService, PermissionsService>();
            //builder.Services.AddScoped<IPermissionsRepository, PermissionsRepository>();

            builder.Services.AddScoped<IJobService, JobService>();
            builder.Services.AddScoped<IJobRepository, JobRepository>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
