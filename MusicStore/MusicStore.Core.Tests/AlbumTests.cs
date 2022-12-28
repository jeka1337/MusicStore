// <copyright file="AlbumTests.cs" company="�������">
// Copyright (c) ������� 2022.
// </copyright>
namespace MusicStore.Core.Tests
{
    using MusicStore.Core;

    /// <summary>
    /// ����� ��� ������ Album.
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
            Author author = new Author("nornal name", "nornal surname", "nornal patronymic", new DateTime(1999, 12, 4));
            Assert.Throws<ArgumentNullException>(() => _ = new Album(null, "normal description", author, new DateTime(1922, 2, 5)));
        }

        /// <summary>
        /// ���� �� ����������� � ������ �������.
        /// </summary>
        [Test]
        public void ThrowAnExceptionOnNullAuthor()
        {
            Assert.Throws<ArgumentNullException>(() => _ = new Album("normal title", "normal description", null, new DateTime(1922, 2, 5)));
        }

        /// <summary>
        /// ���� �� ����������� � ������ ���������.
        /// </summary>
        [Test]
        public void ThrowAnExceptionOnNullDescription()
        {
            Author author = new Author("nornal name", "nornal surname", "nornal patronymic", new DateTime(1999, 12, 4));
            Assert.Throws<ArgumentNullException>(() => _ = new Album("normal title", null, author, new DateTime(1922, 2, 5)));
        }

        /// <summary>
        /// ���� �� ����������� � ���������� �������.
        /// </summary>
        [Test]
        public void NormalAlbumCreation()
        {
            Author author = new Author("nornal name", "nornal surname", "nornal patronymic", new DateTime(1999, 12, 4));
            Assert.DoesNotThrow(() => _ = new Album("normal title", "normal description", author, new DateTime(1900, 2, 1)));
        }
    }
}