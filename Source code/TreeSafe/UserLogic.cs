using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TreeSafe
{
    internal static class UserLogic
    {
        public static string FilePath { get; set; }
        public static string EncryptedFilePath { get; set; }
        public static string SecondFilePath { get; set; }
        public static string Password { get; set; }
        public static int CurrentSize { get; set; }
        public static int TotalLines { get; set; }

        public static int GetTotalLines(string filePath)
        {
            try
            {
                return File.ReadLines(filePath).Count();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while getting the total lines: " + ex.Message);
                return 0;
            }
        }

        public static bool IsValidEmail(string email)
        {
            const string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        public static bool IsPasswordValid(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            if (password.Length < 6)
            {
                return false;
            }

            const string pattern = @"[!@#$%^&*()_+{}\[\]:;""'<>,.?/\\|~-]";
            return Regex.IsMatch(password, pattern);
        }

        public static SaveFileDialog CreateSaveFileDialog(string databaseName)
        {
            var saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = Path.Combine(Application.StartupPath, "Scripts"),
                Title = databaseName,
                FileName = databaseName,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 0,
                RestoreDirectory = true
            };

            return saveFileDialog;
        }

        public static int GetRandomNumber(int min, int max)
        {
            var rand = new Random();
            return rand.Next(min, max + 1);
        }

        public static string GenerateString(int length, bool includeSpecialChars)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            const string specials = "!@#$%^&*()_+-={}[]|;:',.<>?";

            var random = new Random();

            var charPool = includeSpecialChars ? chars + specials : chars;

            var randomString = new StringBuilder(length);
            for (var i = 0; i < length; i++)
            {
                randomString.Append(charPool[random.Next(charPool.Length)]);
            }

            return randomString.ToString();
        }

        public static string GetSelectedFilePath()
        {
            const string filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            using var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = filter,
                FilterIndex = 0,
                RestoreDirectory = true
            };

            return openFileDialog.ShowDialog() == DialogResult.OK ? openFileDialog.FileName : null;
        }
    }
}
