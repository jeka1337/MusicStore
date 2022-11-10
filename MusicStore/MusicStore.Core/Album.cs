// <copyright file="Album.cs" company="Команда">
// Copyright (c) Команда 2022.
// </copyright>
namespace MusicStore.Core
{
    /// <summary>
    /// Альбом.
    /// </summary>
    public class Album
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Album"/>.
        /// </summary>
        /// <param name="title"> Название. </param>
        /// <param name="description"> Описание. </param>
        /// <param name="dateOfProduction"> Дата производства. </param>
        public Album(string title, string description, DateOnly dateOfProduction)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            DateOfProduction = dateOfProduction; // Может быть неизвестно
            Compositions = new HashSet<Composition>();
        }

        /// <summary>
        /// Название.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Автор.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Дата производства.
        /// </summary>
        public DateOnly DateOfProduction { get; set; }

        /// <summary>
        /// Композиции.
        /// </summary>
        private ISet<Composition> Compositions { get; set; }

        /// <summary>
        /// Добавление композиции альбому.
        /// </summary>
        /// <param name="composition"> Композиция. </param>
        /// <returns> <see langword="true"/> в случае успешного добавления. </returns>
        public void AddCompositionToAlbum(Composition composition)
        {
            Compositions.Add(composition);
            composition.Album = this;
        }
    }
}
