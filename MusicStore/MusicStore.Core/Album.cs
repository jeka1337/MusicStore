// <copyright file="Album.cs" company="Команда">
// Copyright (c) Команда 2022.
// </copyright>
namespace MusicStore.Core
{
    /// <summary>
    /// Альбом.
    /// </summary>
    public class Album : IEquatable<Album>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Album"/>.
        /// </summary>
        /// <param name="title"> Название. </param>
        /// <param name="description"> Описание. </param>
        /// <param name="author"> Автор. </param>
        /// <param name="dateOfProduction"> Дата производства. </param>
        public Album(string title, string description, Author author, DateOnly dateOfProduction)
        {
            this.Id = Guid.NewGuid();
            this.Title = title ?? throw new ArgumentNullException(nameof(title));
            this.Description = description ?? throw new ArgumentNullException(nameof(description));
            this.Author = author ?? throw new ArgumentNullException(nameof(author));
            this.DateOfProduction = dateOfProduction;
        }

        /// <summary>
        /// Идентификатор.
        /// </summary>
        public Guid Id { get; protected set; }

        /// <summary>
        /// Название.
        /// </summary>
        public string Title { get; protected set; }

        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; protected set; }

        /// <summary>
        /// Автор.
        /// </summary>
        public Author Author { get; protected set; }

        /// <summary>
        /// Дата производства.
        /// </summary>
        public DateOnly DateOfProduction { get; protected set; }

        /// <summary>
        /// Композиции.
        /// </summary>
        private ISet<Composition> Compositions { get; set; } = new HashSet<Composition>();

        /// <summary>
        /// Добавление композиции альбому.
        /// </summary>
        /// <param name="composition"> Композиция. </param>
        public void AddCompositionToAlbum(Composition composition)
        {
            this.Compositions.Add(composition);
            composition.Album = this;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        /// <inheritdoc/>
        public bool Equals(Album? other)
        {
            return Equals(this.Id, other?.Id);
        }
    }
}
