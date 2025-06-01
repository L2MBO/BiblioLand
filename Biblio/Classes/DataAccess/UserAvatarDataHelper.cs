using System.Linq;

namespace Biblio.Classes.DataAccess
{
    internal class UserAvatarDataHelper
    {
        public static string GetBase64ImageFromDatabase(int currentUserAvatar)
        {
            var currentUser = Program.context.Users.FirstOrDefault(user => user.UserID == currentUserAvatar);

            if (currentUser != null)
            {
                return currentUser.AvatarPath;
            }

            return null;
        }
    }
}
