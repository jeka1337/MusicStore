using System;
using System.Collections.Generic;
using System.Linq;
// <copyright file="Author.cs" company="Команда">
// Copyright (c) Команда 2022.
// </copyright>
namespace MusicStore.Core
{

    /// <summary>
    /// Автор.
    /// </summary>
    public class Author
    {

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Author"/>.
        /// </summary>
        /// <param name="name"> Имя. </param>
        /// <param name="surname"> Фамилия. </param>
        /// <param name="patronic"> Отчество. </param>
        /// <param name="dateOfBirth"> Дата рождения. </param>
        public Author(string name, string surname, string patronic, DateOnly dateOfBirth)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            Patronic = patronic; // Может не быть
            DateOfBirth = dateOfBirth;
        }

        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Отчество.
        /// </summary>
        public string Patronic { get; set; }

        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateOnly DateOfBirth { get; set; }
    }
}
