using FashionHexa.Entities;
using FashionHexa.Database;
namespace FashionHexa.Services
{
    public class RoleService:IRoleService
    {
        private readonly MyContext _context = null;

        public RoleService(MyContext _context)
        {
            _context = new MyContext();
        }

        public void AddRole(Role role)
        {
            try
            {

                _context.Roles.Add(role);
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Role> GetAllRoles()
        {
            try
            {
                var Res = _context.Roles.ToList();
                return Res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Role GetRoleByName(string roleName)
        {
            try
            {
                var res = _context.Roles.SingleOrDefault(r => r.RoleName == roleName);

                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void UpdateRole(Role role)
        {

            try
            {
                if (role != null)
                {
                    role.RoleName = role.RoleName;
                    _context.SaveChanges();

                }


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
