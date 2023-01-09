using BaganBari.EdTech.UserManagement.Domain.ValueObject;

namespace BaganBari.EdTech.UserManagement.Domain.Entity
{
    public class User : AuditableEntity
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public List<Role> Roles { get; set; }



    }
}