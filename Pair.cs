using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    /// <summary>
    /// Класс, который описывает пару
    /// </summary>
    public class Pair
    {
        public enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
            Null
        }

        int _id;
        DayOfWeek _day;
        string _time;
        string _name;
        string _teacher;
        string _audience;

        public string ID
        {
            get { return _id.ToString(); }
        }
        public int iID
        {
            get { return _id; }
        }
        public string Day
        {
            get { return _day.ToString(); }
            set
            {
                _day = DayOfWeek.Null;

                switch (value)
                {
                    case "Monday":
                        {
                            _day = DayOfWeek.Monday;
                            break;
                        }
                    case "Tuesday":
                        {
                            _day = DayOfWeek.Tuesday;
                            break;
                        }
                    case "Wednesday":
                        {
                            _day = DayOfWeek.Wednesday;
                            break;
                        }
                    case "Thursday":
                        {
                            _day = DayOfWeek.Thursday;
                            break;
                        }
                    case "Friday":
                        {
                            _day = DayOfWeek.Friday;
                            break;
                        }
                    case "Saturday":
                        {
                            _day = DayOfWeek.Saturday;
                            break;
                        }
                    case "Sunday":
                        {
                            _day = DayOfWeek.Sunday;
                            break;
                        }
                }
            }
        }
        public string Time
        {
            get { return _time; }
            set { _time = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }
        public string Audience
        {
            get { return _audience; }
            set { _audience = value; }
        }

        /// <summary>
        /// Конструктор класса Pair
        /// </summary>
        /// <param name="id">id пары</param>
        /// <param name="day">день недели, в который пара проводится</param>
        /// <param name="time">время, в которое проходит пара</param>
        /// <param name="name">навание пары</param>
        /// <param name="teacher">преподаватель, который проводит пару</param>
        /// <param name="audience">аудитория, в которой проходит пара</param>
        public Pair(int id, DayOfWeek day, string time, string name, string teacher, string audience)
        {
            _id = id;
            _day = day;
            _time = time;
            _name = name;
            _teacher = teacher;
            _audience = audience;
        }

        /// <summary>
        /// Конструктор класса Pair
        /// </summary>
        /// <param name="id">id пары</param>
        /// <param name="day">день недели, в который пара проводится</param>
        /// <param name="time">время, в которое проходит пара</param>
        /// <param name="name">навание пары</param>
        /// <param name="teacher">преподаватель, который проводит пару</param>
        /// <param name="audience">аудитория, в которой проходит пара</param>
        public Pair(string id, string day, string time, string name, string teacher, string audience)
        {
            //TryPatse?
            _id = int.Parse(id);

            _day = DayOfWeek.Null;

            switch (day)
            {
                case "Monday":
                    {
                        _day = DayOfWeek.Monday;
                        break;
                    }
                case "Tuesday":
                    {
                        _day = DayOfWeek.Tuesday;
                        break;
                    }
                case "Wednesday":
                    {
                        _day = DayOfWeek.Wednesday;
                        break;
                    }
                case "Thursday":
                    {
                        _day = DayOfWeek.Thursday;
                        break;
                    }
                case "Friday":
                    {
                        _day = DayOfWeek.Friday;
                        break;
                    }
                case "Saturday":
                    {
                        _day = DayOfWeek.Saturday;
                        break;
                    }
                case "Sunday":
                    {
                        _day = DayOfWeek.Sunday;
                        break;
                    }
            }

            _time = time;
            _name = name;
            _teacher = teacher;
            _audience = audience;
        }

        /// <summary>
        /// Проверка 2 пар на равенство
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Pair p1, Pair p2)
        {
            bool b = true;

            var day = p1._day == p2._day;
            var time = p1._time == p2._time;
            var name = p1._name == p2._name;
            var teacher = p1._teacher == p2._teacher;
            var audience = p1._audience == p2._audience;

            b = day & time & teacher | day & time & audience;

            return b;
        }

        /// <summary>
        /// Проверка 2 пар на неравенство
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Pair p1, Pair p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Сравнение 2 пар
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator >(Pair p1, Pair p2)
        {
            if(p1._day == p2._day)
            {
                var t1 = p1._time;
                var t2 = p2._time;

                var t11 = int.Parse(t1.Split('.')[0]);
                var t22 = int.Parse(t2.Split('.')[0]);

                if (t11 > t22)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return p1._day > p2._day;
            }
        }

        /// <summary>
        /// Сравнение 2 пар
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator <(Pair p1, Pair p2)
        {
            return !(p1 > p2 | p1==p2);
        }

        /// <summary>
        /// Создавние строки из пары
        /// </summary>
        /// <returns>Строка</returns>
        public override string ToString()
        {
            return $"{_day}    {_time}    {_name}    {_teacher}    {_audience}";
        }

        /// <summary>
        /// Индексатор для класса Pair, где индекс - номер параметра
        /// </summary>
        /// <param name="i">номер параметра</param>
        /// <returns>параметр</returns>
        public string this[int i]
        {
            get
            {
                switch(i)
                {
                    case 0:
                        {
                            return $"{(int)_day + 1}. {Day}";
                        }
                    case 1:
                        {
                            return Time;
                        }
                    case 2:
                        {
                            return Name;
                        }
                    case 3:
                        {
                            return Teacher;
                        }
                    case 4:
                        {
                            return Audience;
                        }
                }

                return "";
            }
        }
    }
}
