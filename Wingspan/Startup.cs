using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using HotChocolate.Types.Descriptors;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Wingspan.DB;
using Wingspan.GraphQL;
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
            services.AddGraphQLServer().AddQueryType<Query>()
                .AddConvention<INamingConventions>(new SnakeCaseNamingConvention());
            services.AddSingleton<IBirdServices, BirdServices>();
            services.AddSingleton<IBirdsDB>(provider =>
                {
                    var birds = new List<Bird>();
                    using (var reader = new StreamReader("DB/Birds.csv"))
                    {
                        var count = 1;
                        var regex = new Regex("(?!\\B\"[^\"]*),(?![^\"]*\"\\B)");
                        // Exclude heading
                        var fields = regex.Split(reader.ReadLine());
                        while (!reader.EndOfStream)
                        {
                            fields = regex.Split(reader.ReadLine());

                            try
                            {
                                birds.Add(
                                    new Bird
                                    {
                                        CommonName = fields[0],
                                        ScientificName = fields[1],
                                        GameSet = fields[2],
                                        AbilityColor = fields[3],
                                        AbilityDescription = fields[4],
                                        BirdInformation = fields[5],
                                        IsPredator = fields[6] == "X",
                                        IsFlocking = fields[7] == "X",
                                        ProvideBonusCard = fields[8] == "X",
                                        BirdPoints = Convert.ToInt32(fields[9]),
                                        NestType = fields[10],
                                        EggCapacity = fields[11],
                                        Wingspan = fields[12],
                                        Habitat = fields[13] == "X" ? HabitatType.Forest :
                                            fields[13] == "X" ? HabitatType.Grassland : HabitatType.Wetland
                                    }
                                );
                                count++;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"Error occurs at row {count} of the data file : {fields[9]} ");
                            }
                        }
                    }

                    Console.WriteLine($"Total number of birds load : {birds.Count}");

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
