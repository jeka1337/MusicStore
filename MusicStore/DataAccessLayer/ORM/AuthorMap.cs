// <copyright file="AuthorMap.cs" company="Команда">
// Copyright (c) Команда 2022.
// </copyright>
namespace DataAccessLayer.ORM
{
    using FluentNHibernate.Mapping;
    using MusicStore.Core;

    /// <summary>
    /// Mapping на <see cref="Author"/>.
    /// </summary>
    public class AuthorMap : ClassMap<Author>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AuthorMap"/>.
        /// </summary>
        public AuthorMap()
        {
            this.Table("Author");

            this.Id(x => x.Id);

            this.Map(x => x.Name)
                .Not.Nullable().Length(50);

            this.Map(x => x.Surname)
                .Not.Nullable().Length(50);

            this.Map(x => x.Patronymic)
                .Length(50);

            this.Map(x => x.DateOfBirth);
        }
    }
}