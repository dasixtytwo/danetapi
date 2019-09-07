using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DaNetApi.Domain
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
