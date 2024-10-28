using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    internal class NewPair
    {
        string _dayOfWeek;
        string _time;
        string _name;
        string _teacher;
        string _audience;

        public string DayOfWeek
        {
            get { return _dayOfWeek; }
        }
        public string Time
        {
            get { return _time; }
        }
        public string Name
        {
            get { return _name; }
        }
        public string Teacher
        {
            get { return _teacher; }
        }
        public string Audience
        {
            get { return _audience; }
        }

        public NewPair(string dayOfWeek, string time, string name, string teacher, string audience)
        {
            _dayOfWeek = dayOfWeek;
            _time = time;
            _name = name;
            _teacher = teacher;
            _audience = audience;
        }
    }
}
