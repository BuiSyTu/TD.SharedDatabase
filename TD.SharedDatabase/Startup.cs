using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TD.SharedDatabase.Data.Models;
using TD.SharedDatabase.Services;

namespace TD.SharedDatabase
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<GiaoDucContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("TD.SharedDatabase.Api")));
            services.AddControllers();

            // TODO: Add services
            services.AddScoped<HttpService>();
            services.AddScoped<TinhThanhService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, GiaoDucContext giaoDucContext, HttpService httpService)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            // Code here
            //var tinhThanhService = new TinhThanhService(Configuration, giaoDucContext, httpService);
            //tinhThanhService.Post();

            //var donViService = new DonViService(Configuration, giaoDucContext, httpService);
            //donViService.Post();

            //var quanHuyenService = new QuanHuyenService(Configuration, giaoDucContext, httpService);
            //quanHuyenService.Post();

            //var phuongXaService = new PhuongXaService(Configuration, giaoDucContext, httpService);
            //phuongXaService.Post();

            //var truongHocService = new TruongHocService(Configuration, giaoDucContext, httpService);
            //truongHocService.Post();

            //var giaoVienService = new GiaoVienService(Configuration, giaoDucContext, httpService);
            //giaoVienService.Post();

            //var hocSinhService = new HocSinhService(Configuration, giaoDucContext, httpService);
            //hocSinhService.Post();

            //var lopHocService = new LopHocService(Configuration, giaoDucContext, httpService);
            //lopHocService.Post();

            var chiTieuService = new ChiTieuService(giaoDucContext, httpService);
            chiTieuService.Add();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
