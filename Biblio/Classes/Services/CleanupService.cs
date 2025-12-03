using System;
using System.Linq;

namespace Biblio.Classes.Services
{
    internal class CleanupService
    {
        public static void CleanupExpiredConfirmationCodes()
        {
            var expiredUsers = Program.context.Users
                .Where(u => u.ConfirmationCodeExpiration < DateTime.Now)
                .ToList();

            foreach (var user in expiredUsers)
            {
                user.ConfirmationCodeHash = null;
                user.ConfirmationCodeExpiration = null;
            }

            Program.context.SaveChanges();
        }

        public static void CleanupExpiredBans()
        {
            var expiredBans = Program.context.UserBans
                .Where(b => b.BanExpiration <= DateTime.Now)
                .ToList();

            Program.context.UserBans.RemoveRange(expiredBans);
            Program.context.SaveChanges();
        }
    }
}