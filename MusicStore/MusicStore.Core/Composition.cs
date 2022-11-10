// <copyright file="Composition.cs" company="Команда">
// Copyright (c) Команда 2022.
// </copyright>
namespace MusicStore.Core
{
    /// <summary>
    /// Композиция.
    /// </summary>
    public class Composition
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Composition"/>.
        /// </summary>
        /// <param name="title"> Название. </param>
        /// <param name="duration"> Продолжительность. </param>
        /// <param name="album"> Альбом. </param>
        /// <param name="price"> Цена. </param>
        public Composition(string title, int duration, Album album, float price)
        {
            this.SerialNumber = Guid.NewGuid();
            this.Title = title ?? throw new ArgumentNullException(nameof(title));
            this.Duration = duration;
            this.Album = album;
            this.Price = price;
        }

        /// <summary>
        /// Серийный номер.
        /// </summary>
        public Guid SerialNumber { get; set; }

        /// <summary>
        /// Название.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Продолжительность.
        /// </summary>
        public int Duration
        {
            get
            {
                return this.Duration;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                else
                {
                    this.Duration = value;
                }
            }
        }

        /// <summary>
        /// Альбом.
        /// </summary>
        public Album Album { get; set; }

        /// <summary>
        /// Цена.
        /// </summary>
        public float Price
        {
            get
            {
                return this.Price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                else
                {
                    this.Price = value;
                }
            }
        }

        /// <summary>
        /// Автор.
        /// </summary>
        public string Author { get; set; }
    }
}