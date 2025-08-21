using EShope.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace EShope.Entities.Account
{
    public class User : BaseEntity
    {
        [MaxLength(150)]
        public string Email { get; set; }

        [MaxLength(300)]
        public string? EmailActiveCode { get; set; }

        [MaxLength(200)]
        public string Password { get; set; }

        [MaxLength(150)]
        public string? FirstName { get; set; }

        [MaxLength(150)]
        public string? LastName { get; set; }

        [MaxLength(500)]
        public string Address { get; set; }

        public DateTime RegisterDate { get; set; }

        public DateTime? LastLoginDate { get; set; }

        //The is bool Type is Defaultly Is false And No Need to be Nullable
        public bool IsActive { get; set; }
    }
}
