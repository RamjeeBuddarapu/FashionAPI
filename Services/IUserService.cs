using FashionHexa.Entities;
namespace FashionHexa.Services
{
    public class IUserService
    {
        void CreateUser(User user); 
        List<User> GetAllUsers(); 
        User GetUser(string userId);
        void EditUser(User user);
        void DeleteUser(string userId);
        User ValidteUser(string email, string password);
    }
}
