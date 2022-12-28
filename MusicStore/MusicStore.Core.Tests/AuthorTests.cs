// <copyright file="AuthorTests.cs" company="Команда">
// Copyright (c) Команда 2022.
// </copyright>
namespace MusicStore.Core.Tests
{
    using MusicStore.Core;

    /// <summary>
    /// Тесты для класса Author.
    /// </summary>
    [TestFixture]
    public class AuthorTests
    {
        /// <summary>
        /// Тест на конструктор с пустым именем.
        /// </summary>
        [Test]
        public void ThrowAnExceptionOnNullName()
        {
            Assert.Throws<ArgumentNullException>(() => _ = new Author(null, "normal surname", "normal patronymic", new DateTime(1922, 2, 5)));
        }

        /// <summary>
        /// Тест на конструктор с пустой фамилий.
        /// </summary>
        [Test]
        public void ThrowAnExceptionOnNullSurname()
        {
            Assert.Throws<ArgumentNullException>(() => _ = new Author("nornal name", null, "normal patronymic", new DateTime(1922, 2, 5)));
        }

        /// <summary>
        /// Тест на конструктор с нормальными данными.
        /// </summary>
        [Test]
        public void NormalAuthorCreation()
        {
            Assert.DoesNotThrow(() => _ = new Author("nornal name", "nornal surname", "normal patronymic", new DateTime(1922, 2, 5)));
        }
    }
}