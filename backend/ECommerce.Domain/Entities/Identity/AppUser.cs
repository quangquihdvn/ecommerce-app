using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ECommerce.Domain.Entities.Identity
{
    public class AppUser : IdentityUser<Guid>
    {
        public string DisplayName { get; set; }
        public string ProfilePictureUrl { get; set; }
        public Address Address { get; set; }

        public IEnumerable<UserLike> UserLikes { get; set; }
    }
}