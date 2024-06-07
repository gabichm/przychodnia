using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Przychodnia;
using Przychodnia.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");



builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5176/") });
builder.Services.AddScoped<IApiService, ApiService>();

await builder.Build().RunAsync();




// using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
// using Microsoft.Extensions.DependencyInjection;
// using System;
// using System.Net.Http;
// using System.Threading.Tasks;
// using Przychodnia;
// using Przychodnia.Services;
//
// namespace Przychodnia
// {
//     public class Program
//     {
//         public static async Task Main(string[] args)
//         {
//             var builder = WebAssemblyHostBuilder.CreateDefault(args);
//             builder.RootComponents.Add<App>("#app");
//
//             builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//             builder.Services.AddScoped<IApiService, ApiService>();
//
//             await builder.Build().RunAsync();
//
//
//             // Build the app
//             var app = builder.Build();
//             
//             // Run the app
//             await app.RunAsync();
//         }
//     }
// }
//
//
//
//
//
//
// //
// //
// //
// // // public static async Task Main(string[] args)
// // // {
// // //     
// // // }
// //
// //
// //    
// //             //
// //             // var builder = WebAssemblyHostBuilder.CreateDefault(args);
// //             // builder.RootComponents.Add<App>("app");
// //             //
// //             // // Configure HttpClient to use the REST API
// //             // builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5176") });
// //             //
// //             //
// //             // builder.Services.AddScoped<DataSeeder>(serviceProvider =>
// //             // {
// //             //     var dataSeeder = serviceProvider.GetRequiredService<DataSeeder>();
// //             //     Task.Run(async () => await dataSeeder.SeedData()); // Execute the seed data operation asynchronously
// //             //     return dataSeeder;
// //             // });
// //             //
// //             // await builder.Build().RunAsync();
// //             //
// //
// // //
// // // var builder = WebAssemblyHostBuilder.CreateDefault(args);
// // // builder.RootComponents.Add<App>("#app");
// // // builder.RootComponents.Add<HeadOutlet>("head::after");
// // //
// // // // Configure the HttpClient to use the base address of the API
// // // builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5176/") });
// // // builder.Services.AddScoped<ApiService>();
// // //
// // // // Register the DataSeeder as a scoped service
// // // builder.Services.AddScoped<DataSeeder>();
// // //
// // // var host = builder.Build();
// // //
// // // // Run the data seeder
// // // // using (var scope = host.Services.CreateScope())
// // // // {
// // // //     var dataSeeder = scope.ServiceProvider.GetRequiredService<DataSeeder>();
// // // //     await dataSeeder.SeedData();
// // // // }
// // // builder.Services.AddScoped<DataSeeder>(serviceProvider =>
// // // {
// // //     var dataSeeder = serviceProvider.GetRequiredService<DataSeeder>();
// // //     Task.Run(async () => await dataSeeder.SeedData()); // Execute the seed data operation asynchronously
// // //     return dataSeeder;
// // // });
// // //
// // // // await host.RunAsync();
// // // await builder.Build().RunAsync();
// //
// //
// //
// // // // Configure the data seeder to run at the beginning of the application
// // // builder.Services.AddScoped<DataSeeder>(serviceProvider =>
// // // {
// // //     var dataSeeder = serviceProvider.GetRequiredService<DataSeeder>();
// // //     Task.Run(async () => await dataSeeder.SeedData()); // Execute the seed data operation asynchronously
// // //     return dataSeeder;
// // // });
// // //
// // // await builder.Build().RunAsync();
// //
// //
// //
// // // using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
// // // using Microsoft.Extensions.DependencyInjection;
// // // using Przychodnia.Services;
// // // using System;
// // // using System.Net.Http;
// // // using Przychodnia;
// // //
// // // var builder = WebAssemblyHostBuilder.CreateDefault(args);
// // // builder.RootComponents.Add<App>("#app");
// // //
// // // builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5176") });
// // // builder.Services.AddScoped<ApiService>();
// // //
// // // await builder.Build().RunAsync();
// // //
