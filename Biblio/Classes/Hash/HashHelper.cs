using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Classes.Hash
{
    /// <summary>
    /// Хэширование и верификация пароля.
    /// </summary>
    public class HashHelper
    {
        /// <summary>
        /// Хэширование пароля.
        /// </summary>
        /// <param name="password"></param>
        /// <returns>хэшированный пароль</returns>
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        /// <summary>
        /// Верификация пароля.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="storedHash"></param>
        /// <returns>сравнение пароля</returns>
        public static bool VerifyPassword(string password, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, storedHash);
        }
    }
}
