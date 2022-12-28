// <copyright file="AlbumMapTests.cs" company="Команда">
// Copyright (c) Команда 2022.
// </copyright>
namespace ORM.Tests
{
    using FluentNHibernate.Testing;
    using MusicStore.Core;
    using NUnit.Framework;

    /// <summary>
    /// Тесты маппингов для класса Album.
    /// </summary>
    [TestFixture]
    internal class AlbumMapTests : BaseMapTests
    {
        /// <summary>
        /// Тест правильной работы маппинга.
        /// </summary>
        [Test]
        public void PersistenceSpecification_ValidData_Success()
        {
            // arrange
            Author author = new Author("nornal name", "nornal surname", "nornal patronymic", new DateTime(1999, 12, 4));
            this.Session.Save(author);
            var album = new Album("normal title", "normal description", author, new DateTime(1900, 2, 1));

            // act & assert
            new PersistenceSpecification<Album>(this.Session)
                .VerifyTheMappings(album);
        }
    }
}