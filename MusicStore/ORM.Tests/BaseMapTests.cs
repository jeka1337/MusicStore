// <copyright file="BaseMapTests.cs" company="Команда">
// Copyright (c) Команда 2022.
// </copyright>
namespace ORM.Tests
{
    using Library.DataAccess;
    using NHibernate;
    using NUnit.Framework;

    /// <summary>
    /// Базовый класс для создания всех последующих тестов, связанных с работой с бд(sqlite).
    /// </summary>
    public class BaseMapTests
    {
        /// <summary>
        /// Сессия для работы с sqlite.
        /// </summary>
        protected ISession Session { get; private set; }

        /// <summary>
        /// Создание сессии sqlite с конфигурацией по умолчанию.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            this.Session = TestsConfigurator.BuildSessionForTest();
        }

        /// <summary>
        /// Закрытие сессии, когда тестирование окончено.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            this.Session?.Dispose();
        }
    }
}