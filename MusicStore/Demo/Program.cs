// <copyright file="Program.cs" company="Васильева Марина Алексеевна">
// Copyright (c) Васильева Марина Алексеевна 2021. Учебные материалы.
// </copyright>

namespace Demo
{
    using System;
    using DataAccessLayer;
    using DataAccessLayer.ORM;
    using MusicStore.Core;

    /// <summary>
    /// Исполняемый файл.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        private static void Main()
        {
            var author = new Author("Kanye", "West", "", new DateTime(1977, 6, 8));
            var album = new Album("Donda", "new album", author, new DateTime(2021, 8, 29));
            var composition = new Composition("ok title", 123, album, 12.1m);

            Console.WriteLine(author);
            Console.WriteLine(album);
            Console.WriteLine(composition);

            
            var settings = new Settings();

            settings.AddDatabaseHost("127.0.0.1");
            settings.AddUser("SA");
            settings.AddPassword("Jekan1337.");
            settings.AddDatabaseName("orm_test");

            using var sessionFactory = FluentNHibernateConfigurator
                .GetSessionFactory(settings, showSql: true);

            using (var session = sessionFactory.OpenSession())
            {
                session.Save(author);
                session.Save(album); ;
                session.Save(composition);
                session.Flush();
            }
        }
    }
}