// <copyright file="AlbumTests.cs" company="Команда">
// Copyright (c) Команда 2022.
// </copyright>
namespace MusicStore.Core.Tests
{
    using MusicStore.Core;

    /// <summary>
    /// Тесты для класса Альбом.
    /// </summary>
    [TestFixture]
    public class AlbumTests
    {
        /// <summary>
        /// Тест на конструктор с пустым названием.
        /// </summary>
        [Test]
        public void ThrowAnExceptionOnNullTitle()
        {
            Author author = new Author("nornal name", "nornal surname", "nornal patronymic", new DateOnly(1999, 12, 4));
            Assert.Throws<ArgumentNullException>(() => _ = new Album(null, "normal description", author, new DateOnly(1922, 2, 5)));
        }

        /// <summary>
        /// Тест на конструктор с пустым автором.
        /// </summary>
        [Test]
        public void ThrowAnExceptionOnNullAuthor()
        {
            Assert.Throws<ArgumentNullException>(() => _ = new Album("normal title", "normal description", null, new DateOnly(1922, 2, 5)));
        }

        /// <summary>
        /// Тест на конструктор с пустым описанием.
        /// </summary>
        [Test]
        public void ThrowAnExceptionOnNullDescription()
        {
            Author author = new Author("nornal name", "nornal surname", "nornal patronymic", new DateOnly(1999, 12, 4));
            Assert.Throws<ArgumentNullException>(() => _ = new Album("normal title", null, author, new DateOnly(1922, 2, 5)));
        }

        /// <summary>
        /// Тест на конструктор с нормальным данными.
        /// </summary>
        [Test]
        public void NormalAlbumCreation()
        {
            Author author = new Author("nornal name", "nornal surname", "nornal patronymic", new DateOnly(1999, 12, 4));
            Assert.DoesNotThrow(() => _ = new Album("normal title", "normal description", author, new DateOnly(1900, 2, 1)));
        }
    }
}