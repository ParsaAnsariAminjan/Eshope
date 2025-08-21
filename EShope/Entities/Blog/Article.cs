using EShope.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace EShope.Entities.Blog
{
    public class Article :BaseEntity
    {

        [MaxLength(300)]
        public string Title { get; set; }

        public string Text { get; set; }

        [MaxLength(2000)]
        public string? Tags { get; set; }

        [MaxLength(300)]
        public string Image { get; set; }

        public bool Published { get; set; }

        public DateTime CreateDate { get; set; }

        public bool Deleted { get; set; }

    }
}
