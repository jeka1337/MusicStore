// <copyright file="CompositionTests.cs" company="Команда">
// Copyright (c) Команда 2022.
// </copyright>
namespace MusicStore.Core.Test
{
    using MusicStore.Core;

    /// <summary>
    /// Тесты для класса Composition.
    /// </summary>
    [TestFixture]
    public class CompositionTests
    {
        /// <summary>
        /// Тест на конструктор с пустым названием.
        /// </summary>
        [Test]
        public void ThrowAnExceptionOnNullTitle()
        {
            Assert.Throws<ArgumentNullException>(() => _ = new Composition(null, 123, null, 12.1m));
        }

        /// <summary>
        /// Тест на конструктор с нулевой ценой.
        /// </summary>
        [Test]
        public void ThrowAnExceptionOnZeroPrice()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _ = new Composition("ok title", 123, null, 0));
        }

        /// <summary>
        /// Тест на конструктор с ценой меньше нуля.
        /// </summary>
        [Test]
        public void ThrowAnExceptionOnLessZeroPrice()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _ = new Composition("ok title", 123, null, -12.1m));
        }

        /// <summary>
        /// Тест на конструктор с нормальными данными.
        /// </summary>
        [Test]
        public void NormalCompositionCreation()
        {
            Author author = new Author("nornal name", "nornal surname", "nornal patronymic", new DateTime(1999, 12, 4));
            Album album = new Album("normal title", "nornal author", author, new DateTime(1900, 2, 1));
            Assert.DoesNotThrow(() => _ = new Composition("ok title", 123, album, 12.1m));
        }
    }
}