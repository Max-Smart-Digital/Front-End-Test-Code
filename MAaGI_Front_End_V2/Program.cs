﻿using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MAaGI_Front_End_V2;
using System.ComponentModel.DataAnnotations;
using Microsoft.Data.SqlClient;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

namespace MAaGI_Front_End_V2.Models
{
    public class QueryModel
    {
        [Required]
        public string PromptText { get; set; }
        public QueryModel()
        {
            PromptText = string.Empty; // Initialize with a non-null value
        }
    }
}