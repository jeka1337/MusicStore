// <copyright file="CompositionMapTests.cs" company="Команда">
// Copyright (c) Команда 2022.
// </copyright>
namespace ORM.Tests
{
    using FluentNHibernate.Testing;
    using MusicStore.Core;
    using NUnit.Framework;

    /// <summary>
    /// Тесты маппингов для класса Composition.
    /// </summary>
    [TestFixture]
    internal class CompositionMapTests : BaseMapTests
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
            Album album = new Album("normal title", "nornal author", author, new DateTime(1900, 2, 1));
            this.Session.Save(album);
            var composition = new Composition("ok title", 123, album, 12.1m);

            // act & assert
            new PersistenceSpecification<Composition>(this.Session)
                .VerifyTheMappings(composition);
        }
    }
}