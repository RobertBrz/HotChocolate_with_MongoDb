using HCMDB.Infrastructure;
using HotChocolate_MongoDb.Models;
using HotChocolate_MongoDb.Mutation;
using HotChocolate_MongoDb.Queries;
using HotChocolate_MongoDb.Queries.Resolvers;
using HotChocolate_MongoDb.Services;
using HotChocolate_MongoDb.Services.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();
        builder.Services.AddScoped<ICarsService, CarsService>();
        builder.Services.AddScoped<IOwnerService, OwnerService>();
        builder.Services.AddGraphQLServer()
            .AddQueryType<Query>()
            .AddTypeExtension<CarExtension>()
            .AddTypeExtension<CarsResolver>()
            .AddTypeExtension<OwnerResolver>()
            .AddMutationType<Mutation>()
            .AddTypeExtension<OwnerMutation>()
            .AddTypeExtension<CarMutation>();
            //.AddDefaultTransactionScopeHandler();

        builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection("MongoDB"));


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
        app.MapGraphQL();
        //app.UseEndpoints(endpoints => endpoints.MapGraphQL());

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}