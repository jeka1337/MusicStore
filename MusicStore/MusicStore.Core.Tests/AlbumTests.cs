// <copyright file="AlbumTests.cs" company="�������">
// Copyright (c) ������� 2022.
// </copyright>
namespace MusicStore.Core.Tests
{
    using MusicStore.Core;

    /// <summary>
    /// ����� ��� ������ ������.
    /// </summary>
    [TestFixture]
    public class AlbumTests
    {
        /// <summary>
        /// ���� �� ����������� � ������ ���������.
        /// </summary>
        [Test]
        public void ThrowAnExceptionOnNullTitle()
        {
            Author author = new Author("nornal name", "nornal surname", "nornal patronymic", new DateOnly(1999, 12, 4));
            Assert.Throws<ArgumentNullException>(() => _ = new Album(null, "normal description", author, new DateOnly(1922, 2, 5)));
        }

        /// <summary>
        /// ���� �� ����������� � ������ �������.
        /// </summary>
        [Test]
        public void ThrowAnExceptionOnNullAuthor()
        {
            Assert.Throws<ArgumentNullException>(() => _ = new Album("normal title", "normal description", null, new DateOnly(1922, 2, 5)));
        }

        /// <summary>
        /// ���� �� ����������� � ������ ���������.
        /// </summary>
        [Test]
        public void ThrowAnExceptionOnNullDescription()
        {
            Author author = new Author("nornal name", "nornal surname", "nornal patronymic", new DateOnly(1999, 12, 4));
            Assert.Throws<ArgumentNullException>(() => _ = new Album("normal title", null, author, new DateOnly(1922, 2, 5)));
        }

        /// <summary>
        /// ���� �� ����������� � ���������� �������.
        /// </summary>
        [Test]
        public void NormalAlbumCreation()
        {
            Author author = new Author("nornal name", "nornal surname", "nornal patronymic", new DateOnly(1999, 12, 4));
            Assert.DoesNotThrow(() => _ = new Album("normal title", "normal description", author, new DateOnly(1900, 2, 1)));
        }
    }
}