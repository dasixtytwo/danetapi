using System;
using System.ComponentModel.DataAnnotations;

namespace DaNetApi.Models
{
    public class Post
    {
        [Key]
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Slug { get; set; }

        public string BodyText { get; set; }
    }
}
