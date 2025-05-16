using Biblio.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Classes.DataAccess
{
    internal class UserBookDataHelper
    {
        /// <summary>
        /// Устанавливает текущую страницу пользователя для указанной книги.
        /// </summary>
        public static void SetCurrentPage(int userId, int bookId, int currentPage)
        {
            try
            {
                var userBook = Program.context.UserBooks.FirstOrDefault(ub => ub.UserID == userId && ub.BookID == bookId);

                userBook.CurrentPage = currentPage;
                Program.context.SaveChanges();
            }
            catch (Exception ex)
            {
                string logPath = "errorContinueReadingControl_log.txt";
                File.AppendAllText(logPath, $"[{DateTime.Now}] Ошибка при установке текущей страницы: {ex.Message}\n");
            }
        }

        /// <summary>
        /// Получает текущую страницу пользователя для указанной книги.
        /// </summary>
        /// <param name="userId">ID пользователя.</param>
        /// <param name="bookId">ID книги.</param>
        /// <returns>
        /// Возвращает текущую страницу пользователя для указанной книги.
        /// Если запись о пользователе и книге не найдена или CurrentPage равно null, возвращает 0.
        /// </returns>
        public static int GetCurrentPage(int userId, int bookId)
        {
            try
            {
                var userBook = Program.context.UserBooks.FirstOrDefault(ub => ub.UserID == userId && ub.BookID == bookId);

                if (userBook != null)
                {
                    return userBook.CurrentPage ?? 0;
                }
            }
            catch (Exception ex)
            {
                string logPath = "errorContinueReadingControl_log.txt";
                File.AppendAllText(logPath, $"[{DateTime.Now}] Ошибка при получении текущей страницы: {ex.Message}\n");
            }

            return 0;
        }

        /// <summary>
        /// Получает общее количество страниц указанной книги.
        /// </summary>
        /// <param name="bookId">ID книги.</param>
        /// <returns>
        /// Возвращает общее количество страниц книги.
        /// Если книга не найдена или TotalPages равно null, возвращает 0.
        /// </returns>
        public static int GetTotalPages(int bookId)
        {
            try
            {
                var book = Program.context.Books.FirstOrDefault(b => b.BookID == bookId);

                if (book != null)
                {
                    return book.TotalPages ?? 0;
                }
            }
            catch (Exception ex)
            {
                string logPath = "errorContinueReadingControl_log.txt";
                File.AppendAllText(logPath, $"[{DateTime.Now}] Ошибка при получении общего количества страниц: {ex.Message}\n");
            }

            return 0;
        }
    }
}
