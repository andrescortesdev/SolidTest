using SolidTest.Models;

namespace SolidTest.Services
{
    public interface IUserRepository
    {   
        // Estos son las funciones que voy a utilizar aqui se mapean
        IEnumerable<User> GetAll(); // Select * from users
        User GetById(int id); // Select * from users where id = ?
        void add(User user); // Insert into users ()values()
        void remove(int id); // Delete from users where id = ?
        void update(User user); // update set Name='' , LastName='' from user where id = ?
    }
}