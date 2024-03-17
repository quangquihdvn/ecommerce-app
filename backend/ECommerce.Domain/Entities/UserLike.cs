using System;
using ECommerce.Domain.Common;
using ECommerce.Domain.Entities.Identity;

namespace ECommerce.Domain.Entities
{
    public class UserLike : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }

        public AppUser User { get; set; }
        public Product Product { get; set; }
    }
}