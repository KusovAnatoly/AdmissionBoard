namespace Phoenix.Models
{
    public class Passport
    {
        /// <summary>
        /// Код паспорта
        /// </summary>
        public int PassportId { get; set; }
        /// <summary>
        /// Серия
        /// </summary>
        public short Series { get; set; }
        /// <summary>
        /// Номер
        /// </summary>
        public short Number { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Дата выдачи
        /// </summary>
        public string WhereReleased { get; set; }
        /// <summary>
        /// Где выдано
        /// </summary>
        public DateTime WhenReleased { get; set; }
        /// <summary>
        /// Адрес прописки
        /// </summary>
        public string RegistrationAddress { get; set; }
    }
}