// <copyright file="Composition.cs" company="Команда">
// Copyright (c) Команда 2022.
// </copyright>
namespace MusicStore.Core
{
    /// <summary>
    /// Композиция.
    /// </summary>
    public class Composition : IEquatable<Composition>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Composition"/>.
        /// </summary>
        /// <param name="title"> Название. </param>
        /// <param name="duration"> Продолжительность. </param>
        /// <param name="album"> Альбом. </param>
        /// <param name="price"> Цена. </param>
        public Composition(string title, int duration, Album album, decimal price)
        {
            if (duration <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(duration));
            }
            else
            {
                this.Duration = duration;
            }

            if (price <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(price));
            }
            else
            {
                this.Price = price;
            }

            this.Id = Guid.NewGuid();
            this.Title = title ?? throw new ArgumentNullException(nameof(title));
            this.Duration = duration;
            this.Album = album;
            this.Price = price;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Composition"/>.
        /// Пустой конструктор для работы с ORM.
        /// </summary>
        [Obsolete("For ORM", true)]
        protected Composition()
        {
        }

        /// <summary>
        /// Серийный номер.
        /// </summary>
        public virtual Guid Id { get; protected set; }

        /// <summary>
        /// Название.
        /// </summary>
        public virtual string Title { get; protected set; }

        /// <summary>
        /// Продолжительность.
        /// </summary>
        public virtual int Duration { get; protected set; }

        /// <summary>
        /// Альбом.
        /// </summary>
        public virtual Album Album { get; set; }

        /// <summary>
        /// Цена.
        /// </summary>
        public virtual decimal Price { get; protected set; }

        /// <inheritdoc/>
        public virtual bool Equals(Composition? other)
        {
            return Equals(this.Id, other?.Id);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}