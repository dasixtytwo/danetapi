using System;

namespace DaNetApi.Contracts.V1.Requests
{
    public class CreatePostRequest
    {
        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Slug { get; set; }

        public string BodyText { get; set; }

        public string PostImage { get; set; }

        public DateTime PostDate { get; set; }
    }
}
