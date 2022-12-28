// <copyright file="Settings.cs" company="Команда">
// Copyright (c) Команда 2022.
// </copyright>
namespace DataAccessLayer
{
    /// <summary>
    /// Настройки для СУБД.
    /// </summary>
    public sealed class Settings
    {
        private string databaseHost;
        private string user;
        private string password;
        private string databaseName;

        /// <summary>
        /// Сеттер для databaseHost.
        /// </summary>
        /// <param name="databaseHost"> Хост СУБД. </param>
        public void AddDatabaseHost(string databaseHost)
        {
            this.databaseHost = databaseHost;
        }

        /// <summary>
        /// Геттер для databaseHost.
        /// </summary>
        /// <returns>Строку хоста СУБД.</returns>
        public string GetDatabaseHost()
        {
            return this.databaseHost;
        }

        /// <summary>
        /// Сеттер для user.
        /// </summary>
        /// <param name="user">Пользователь СУБД.</param>
        public void AddUser(string user)
        {
            this.user = user;
        }

        /// <summary>
        /// Геттер для user.
        /// </summary>
        /// <returns>Пользователь СУБД.</returns>
        public string GetUser()
        {
            return this.user;
        }

        /// <summary>
        /// Сеттер для password.
        /// </summary>
        /// <param name="password">Пароль пользователя СУБД.</param>
        public void AddPassword(string password)
        {
            this.password = password;
        }

        /// <summary>
        /// Геттер для password.
        /// </summary>
        /// <returns>Пароль пользователя СУБД.</returns>
        public string GetPassword()
        {
            return this.password;
        }

        /// <summary>
        /// Сеттер для databaseName.
        /// </summary>
        /// <param name="databaseName">Название БД.</param>
        public void AddDatabaseName(string databaseName)
        {
            this.databaseName = databaseName;
        }

        /// <summary>
        /// Геттер для databaseName.
        /// </summary>
        /// <returns>Название БД.</returns>
        public string GetDatabaseName()
        {
            return this.databaseName;
        }
    }
}
