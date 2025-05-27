using System.Linq;

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
