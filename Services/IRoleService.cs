using FashionHexa.Entities;
namespace FashionHexa.Services
{
    public class IRoleService
    {
        void AddRole(Role role);
        List<Role> GetAllRoles();
        Role GetRoleByName(string roleName);
        void UpdateRole(Role role);
    }
}
