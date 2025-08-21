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
    }
}
