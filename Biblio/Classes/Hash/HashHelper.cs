namespace Biblio.Classes.Hash
{
    /// <summary>
    /// Хэширование и верификация данных.
    /// </summary>
    public class HashHelper
    {
        /// <summary>
        /// Хэширование данных.
        /// </summary>
        /// <param name="field"></param>
        /// <returns>хэшированный пароль</returns>
        public static string HashData(string field)
        {
            return BCrypt.Net.BCrypt.HashPassword(field);
        }

        /// <summary>
        /// Верификация данных.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="storedHash"></param>
        /// <returns>сравнение данных</returns>
        public static bool VerifyData(string field, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(field, storedHash);
        }
    }
}
