using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserServices
    {
        public Serializer serializer;
        public string Directory;
        public string FileName;
        User user;

        public UserServices()
        {
            serializer = new Serializer();
            Directory = "Users";
            FileName = "users.dat";
            user = new User();

        }
        public void Add(User user)
        {
            UserRepository.Instancia.User_List.Add(user);
            serializer.Serialize(UserRepository.Instancia.User_List, Directory, FileName);
        }
        public bool GetUser(string User, bool Login, string Password = "") 
        {
            List<User> users = (List<User>)serializer.Deserialize(Directory, FileName);
            int index = -1;
            if (users != null)
            {
                if (Login)
                {
                    UserRepository.Instancia.User_List = users;
                    while (index != UserRepository.Instancia.User_List.Count - 1)
                    {
                        index++;
                        this.user = UserRepository.Instancia.User_List[index];

                        if (User == user.Usuario && Password == user.Contraseña)
                        {
                            return true;
                        }
                    }
                    return false;
                }
                else
                {
                    UserRepository.Instancia.User_List = users;
                    while (index != UserRepository.Instancia.User_List.Count - 1)
                    {
                        index++;
                        this.user = UserRepository.Instancia.User_List[index];

                        if (User == user.Usuario)
                        {
                            return true;
                        }
                    }
                        return false;
                }
            }
            else
            {
                return false;
            }

        }
    }
}
