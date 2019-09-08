namespace DaNetApi.Contracts.V1.Requests
{
    public class UpdatePostRequest
    {
        public string Title { get; set;}

        public string SubTitle { get; set; }

        public string Slug { get; set; }

        public string BodyText { get; set; }
    }
}
