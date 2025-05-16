using Biblio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Classes.DataAccess
{
    internal class UserAvatarDataHelper
    {
        public static string GetBase64ImageFromDatabase(int currentUserAvatar)
        {
            var user = Program.context.Users.FirstOrDefault(u => u.UserID == currentUserAvatar);
            if (user != null)
            {
                return user.AvatarPath;
            }
            return null;
        }
    }
}
