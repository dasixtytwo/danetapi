using System.Collections.Generic;

namespace DaNetApi.Contracts.V1.Responses
{
    public class AuthFailedResponse
    {
        public IEnumerable<string> Errors { get; set; } 
    }
}
