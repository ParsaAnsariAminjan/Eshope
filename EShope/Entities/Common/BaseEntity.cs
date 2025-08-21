using System.ComponentModel.DataAnnotations;

namespace EShope.Entities.Common
{


    //I Add abstract Phrese Bitwin public & class
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
