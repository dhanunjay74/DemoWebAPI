using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.ApiClient.Models
{
    public class ApiClientOptions
    {
        public string? ApiBaseAddress { get; set; } 
        // We will pass the API base address from the consumer application during dependency injection.
    }
}
