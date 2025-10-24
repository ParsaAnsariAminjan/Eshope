using EShope.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace EShope.Entities.Catalog
{
    public class Banner:BaseEntity
    {


        [MaxLength(200)]
        public string Title { get; set; }

        [MaxLength(300)]
        public string Image { get; set; }

        [MaxLength(500)]
        public string Url { get; set; }

        [MaxLength(300)]
        public string UrlTitle { get; set; }

        [MaxLength(1000)]
        public string? Text { get; set; }

        public int DisplayOrder { get; set; }

        [MaxLength(100)]
        public string Position { get; set; }

    }
}
