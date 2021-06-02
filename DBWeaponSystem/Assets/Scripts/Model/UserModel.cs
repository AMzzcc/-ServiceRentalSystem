using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Model
{
    //用户模型
    public class UserModel
    {
        public string UserName;
        public string Password;

        public UserModel(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
