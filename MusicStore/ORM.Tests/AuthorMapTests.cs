// <copyright file="AuthorMapTests.cs" company="Команда">
// Copyright (c) Команда 2022.
// </copyright>
namespace ORM.Tests
{
    using FluentNHibernate.Testing;
    using MusicStore.Core;
    using NUnit.Framework;

    /// <summary>
    /// Тесты маппингов для класса Author.
    /// </summary>
    [TestFixture]
    internal class AuthorMapTests : BaseMapTests
    {
        /// <summary>
        /// Тест правильной работы маппинга.
        /// </summary>
        [Test]
        public void PersistenceSpecification_ValidData_Success()
        {
            // arrange
            var author = new Author("nornal name", "nornal surname", "normal patronymic", new DateTime(1922, 2, 5));

            // act & assert
            new PersistenceSpecification<Author>(this.Session)
                .VerifyTheMappings(author);
        }
    }
}