using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix.Models
{
    internal class Enrollee
    {
        /// <summary>
        /// Номер абитуриента
        /// </summary>
        public int EnrolleID { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string MiddleName { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Паспорт
        /// </summary>
        public Passport Passport { get; set; }
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Электронная почта
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Адрес проживания
        /// </summary>
        public string FactualAddress { get; set; }
        /// <summary>
        /// Заявление приложено
        /// </summary>
        public bool HasApplication { get; set; }
        /// <summary>
        /// Оригинал диплома приложен
        /// </summary>
        public bool HasOriginalDiploma { get; set; }
        /// <summary>
        /// СНИЛС
        /// </summary>
        public string InsuranceCard { get; set; }
        /// <summary>
        /// Средний бал
        /// </summary>
        public double AvgPoint { get; set; }
        /// <summary>
        /// Школа
        /// </summary>
        public string School { get; set; }
        /// <summary>
        /// Уровень образования
        /// </summary>
        public EducationLevel Level { get; set; }
        /// <summary>
        /// Полис ОМС
        /// </summary>
        public string MedialInsurance { get; set; }
        /// <summary>
        /// Наличие медицинской справки
        /// </summary>
        public bool HasMedicalClearance { get; set; }
        /// <summary>
        /// Родитель
        /// </summary>
        public IEnumerable<Parent> Parents { get; set; }


    }
}
