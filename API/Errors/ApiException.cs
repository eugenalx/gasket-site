using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace API.Errors
{
    public class ApiException : ApiResponse
    {
        public ApiException(int statusCode, string message = null, string details = null) : base(statusCode, message)
        {
            Details = details;
        }
        public string Details { get; set; }
    }
}