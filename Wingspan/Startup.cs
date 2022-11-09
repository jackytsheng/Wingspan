using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Wingspan.DB;
using Wingspan.GraphQL.Schema;
using Wingspan.Model;
using Wingspan.Services;

namespace Wingspan
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddGraphQLServer().AddQueryType<Query>();
            services.AddSingleton<IBirdServices, BirdServices>();
            services.AddSingleton<IBirdsDB>(provider =>
                {
                    var birds = new List<Bird>();
                    using (var reader = new StreamReader("DB/Birds.csv"))
                    {
                        while (!reader.EndOfStream)
                        {
                            var fields = reader.ReadLine().Split(",");

                            birds.Add(
                                new()
                                {
                                    CommonName = fields[0],
                                    ScientificName = fields[1],
                                    GameSet = fields[2],
                                    AbilityColor = fields[3],
                                    AbilityDescription = fields[4]
                                }
                            );
                        }
                    }

                    return new LocalBirdsDb(birds);
                }
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
                endpoints.MapControllers();
            });
        }
    }
}
