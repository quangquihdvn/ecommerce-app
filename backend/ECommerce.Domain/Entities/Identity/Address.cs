using ECommerce.Domain.Common;
using System;

namespace ECommerce.Domain.Entities.Identity
{
    public class Address : BaseEntity
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        
        public Guid AppUserId { get; set; }
        public AppUser User { get; set; }
    }
}