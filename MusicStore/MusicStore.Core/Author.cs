// <copyright file="Author.cs" company="Команда">
// Copyright (c) Команда 2022.
// </copyright>
namespace MusicStore.Core
{
    /// <summary>
    /// Автор.
    /// </summary>
    public class Author : IEquatable<Author>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Author"/>.
        /// </summary>
        /// <param name="name"> Имя. </param>
        /// <param name="surname"> Фамилия. </param>
        /// <param name="patronymic"> Отчество. </param>
        /// <param name="dateOfBirth"> Дата рождения. </param>
        public Author(string name, string surname, string patronymic, DateOnly dateOfBirth)
        {
            this.Id = Guid.NewGuid();
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            this.Patronymic = patronymic; // Может не быть
            this.DateOfBirth = dateOfBirth;
        }

        /// <summary>
        /// Идентификатор.
        /// </summary>
        public Guid Id { get; protected set; }

        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Фамилия.
        /// </summary>
        public string Surname { get; protected set; }

        /// <summary>
        /// Отчество.
        /// </summary>
        public string Patronymic { get; protected set; }

        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateOnly DateOfBirth { get; protected set; }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        /// <inheritdoc/>
        public bool Equals(Author? other)
        {
            return Equals(this.Id, other?.Id);
        }
    }
}
