using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Fluent;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using myWebApp7475.Hubs;
using myWebApp7475.Models;
using myWebApp7475.Services;
using System.IO;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System;


namespace myWebApp7475
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
            var ConnectionString = Configuration.GetConnectionString("AdventureWorks2017");
            services.AddDbContext<AdventureWorks2017Context>(options =>
                options.UseSqlServer(ConnectionString)
            );

            // Add framework services.  
            //services.AddMvc(option => option.EnableEndpointRouting = false);
            services.Add(new ServiceDescriptor(typeof(EmployeesDbContext), new EmployeesDbContext(Configuration.GetConnectionString("EmployeesDb"))));

            
            services.AddDbContext<ToDoContext>(opt =>
                    opt.UseInMemoryDatabase("ToDoList"));
            services.AddControllers();
            

            services.AddRazorPages();
            services.AddSignalR();

            // Register the Swagger services
            //services.AddSwaggerDocument();
            services.AddSwaggerDocument(config =>
            {
                config.PostProcess = document =>
                {
                    document.Info.Version = "v1";
                    document.Info.Title = "myWebApp7475 API";
                    document.Info.Description = "A simple ASP.NET Core web API";
                    document.Info.TermsOfService = "https://mywebapp7475free.azurewebsites.net/Terms";
                    document.Info.Contact = new NSwag.OpenApiContact
                    {
                        Name = "myWebApp7475 Api",
                        Email = "rajesh.prasad0@PrasadEdu.com",
                        Url = "https://mywebapp7475free.azurewebsites.net/swagger"
                    };
                    document.Info.License = new NSwag.OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = "https://mywebapp7475free.azurewebsites.net/Terms"
                    };
                };
            });

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                // c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "myWebApp7475 API",
                    Description = "A simple example ASP.NET Core Web API",
                    TermsOfService = new Uri("https://mywebapp7475free.azurewebsites.net/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "myWebApp7475 API ",
                        Email = "rajesh.prasad0@PrasadEdu.com",
                        Url = new Uri("https://mywebapp7475free.azurewebsites.net/swagger"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use Development",
                        Url = new Uri("https://mywebapp7475free.azurewebsites.net/Terms"),
                    }
                });

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
           //services.AddSingleton<ICosmosDbService>(InitializeCosmosClientInstanceAsync(Configuration.GetSection("CosmosDb")).GetAwaiter().GetResult());


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            //app.UseSwagger();

            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "myWebApp7475 API V1");
            });


            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapHub<ChatHub>("/chatHub");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

            });
            


        }

        /*
        // <InitializeCosmosClientInstanceAsync>        
        /// <summary>
        /// Creates a Cosmos DB database and a container with the specified partition key. 
        /// </summary>
        /// <returns></returns>
        private static async Task<CosmosDbService> InitializeCosmosClientInstanceAsync(IConfigurationSection configurationSection)
        {

                string databaseName = configurationSection.GetSection("DatabaseName").Value;
                string containerName = configurationSection.GetSection("ContainerName").Value;
                string account = configurationSection.GetSection("Account").Value;
                string key = configurationSection.GetSection("Key").Value;
                CosmosClientBuilder clientBuilder = new CosmosClientBuilder(account, key);
                CosmosClient client = clientBuilder
                                    .WithConnectionModeDirect()
                                    .Build();
                CosmosDbService cosmosDbService = new CosmosDbService(client, databaseName, containerName);
                DatabaseResponse database = await client.CreateDatabaseIfNotExistsAsync(databaseName);
                await database.Database.CreateContainerIfNotExistsAsync(containerName, "/id");
                return cosmosDbService;
        }
        // </InitializeCosmosClientInstanceAsync>
        */
    }
}
