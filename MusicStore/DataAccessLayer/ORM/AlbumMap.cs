// <copyright file="AlbumMap.cs" company="Команда">
// Copyright (c) Команда 2022.
// </copyright>
namespace DataAccessLayer.ORM
{
    using FluentNHibernate.Mapping;
    using MusicStore.Core;

    /// <summary>
    /// Mapping на <see cref="Author"/>.
    /// </summary>
    public class AlbumMap : ClassMap<Album>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AlbumMap"/>.
        /// </summary>
        public AlbumMap()
        {
            this.Table("Album");

            this.Id(x => x.Id);

            this.Map(x => x.Title)
                .Not.Nullable().Length(50);

            this.Map(x => x.Description)
                .Not.Nullable().Length(50);

            this.References(x => x.Author)
                .Not.Nullable();

            this.Map(x => x.DateOfProduction);
        }
    }
}