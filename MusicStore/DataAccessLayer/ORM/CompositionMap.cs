// <copyright file="CompositionMap.cs" company="Команда">
// Copyright (c) Команда 2022.
// </copyright>
namespace DataAccessLayer.ORM
{
    using FluentNHibernate.Mapping;
    using MusicStore.Core;

    /// <summary>
    /// Mapping на <see cref="Author"/>.
    /// </summary>
    public class CompositionMap : ClassMap<Composition>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AuthorMap"/>.
        /// </summary>
        public CompositionMap()
        {
            this.Table("Composition");

            this.Id(x => x.Id);

            this.Map(x => x.Title)
                .Not.Nullable().Length(50);

            this.Map(x => x.Duration);

            this.References(x => x.Album);

            this.Map(x => x.Price);
        }
    }
}