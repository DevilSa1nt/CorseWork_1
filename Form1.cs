using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace Coursework
{
    /// <summary>
    /// Класс, который отвечает за работу формы
    /// </summary>
    public partial class Form1 : Form
    {
        List<Pair> _pairs;
        List<Pair> _pairsTemp;

        List<string> avaibleDays;

        List<string> avaibleTime;

        Pairs dsPairs;
        CrystalReport1 cr;

        /// <summary>
        /// Конструктор класса Form1
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            Init();
        }

        /// <summary>
        /// Метод, который вызывае инициализацию всех элементов
        /// </summary>
        void Init()
        {
            InitLists();

            InitControl();

            InitPairs();

            InitTable(_pairs);

            InitDataset();
        }

        /// <summary>
        /// Метод, который инициализирует и заполняет списки с возможными днями пар
        /// и временем, когда они могут проходить
        /// </summary>
        void InitLists()
        {
            avaibleDays = new List<string>();
            avaibleTime = new List<string>();

            for(int i = 0; i < _dayOfWeekComboBox.Items.Count - 1; i++)
            {
                avaibleDays.Add(_dayOfWeekComboBox.Items[i].ToString());
            }

            for (int i = 0; i < _timeComboBox.Items.Count - 1; i++)
            {
                avaibleTime.Add(_timeComboBox.Items[i].ToString());
            }
        }

        /// <summary>
        /// Метод, который устанавливает видимость некоторых элементов управление,
        /// а также привязывает методы к событиям
        /// </summary>
        void InitControl()
        {
            _IdtextBox.Visible = false;
            _dayOfWeekEditComboBox.Visible = false;
            _timeEditComboBox.Visible = false;
            _nameEditTextBox.Visible = false;
            _teacherEditTextBox.Visible = false;
            _audienceEditTextBox.Visible = false;

            _addButton.Click += _addButton_Click;
            _editButton.Click += _editButton_Click;
            _findButton.Click += _findButton_Click;
            _deleteButton.Click += _deleteButton_Click;
            _applyButton.Click += _applyButton_Click;
        }

        /// <summary>
        /// Метод, который заполняет список пар и сортирует их
        /// </summary>
        void InitPairs()
        {
            _pairs = GetPairs("Pairs.txt");

            if (_pairs != null)
            {

            }
            else
            {
                _pairs = new List<Pair>();
            }

            SortPairs();
        }

        /// <summary>
        /// Метод, который заполняет таблицу списком пар,
        /// который был передан в качестве аргумента
        /// </summary>
        /// <param name="pairArray">Список пар</param>
        void InitTable(List<Pair> pairArray)
        {
            dataGridView1.Rows.Clear();

            for(int i = 0; i < pairArray.Count; i++)
            {
                dataGridView1.Rows.Add();

                dataGridView1.Rows[i].Cells[0].Value = pairArray[i].ID;
                dataGridView1.Rows[i].Cells[1].Value = pairArray[i].Day;
                dataGridView1.Rows[i].Cells[2].Value = pairArray[i].Time;
                dataGridView1.Rows[i].Cells[3].Value = pairArray[i].Name;
                dataGridView1.Rows[i].Cells[4].Value = pairArray[i].Teacher;
                dataGridView1.Rows[i].Cells[5].Value = pairArray[i].Audience;

            }
        }

        /// <summary>
        /// Метод, который инициализирует dataset и заполняет его, а также
        /// заполняте отчёт CrystalReport
        /// </summary>
        void InitDataset()
        {
            dsPairs = new Pairs();

            for(int i = 0; i < _pairs.Count ;i++)
            {
                var pair = _pairs[i];

                DataRow dr = dsPairs.DataTable1.NewRow();

                for(int j = 0; j < 5; j++)
                {
                    dr[j] = pair[j];
                }

                dsPairs.DataTable1.Rows.Add(dr);
            }

            cr = new CrystalReport1();

            cr.SetDataSource(dsPairs);

            crystalReportViewer1.ReportSource = cr;
            cr.Refresh();
        }

        /// <summary>
        /// Метод, который вызывается при нажатии кнопки _addButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void _addButton_Click(object sender,EventArgs e)
        {
            int currentMaxId = 0;

            for(int i = 0; i < _pairs.Count; i++)
            {
                currentMaxId = Math.Max(currentMaxId, _pairs[i].iID + 1);
            }

            string day = _dayOfWeekComboBox.Text;
            string time = _timeComboBox.Text;
            string name = _nameTextBox.Text;
            string teacher = _teacherTextBox.Text;
            string audience = _audienceTextBox.Text;
           
            if(avaibleDays.Contains(day) && avaibleTime.Contains(time))
            {
                var newPair = new Pair(currentMaxId.ToString(), day, time, name, teacher, audience);

                bool bIsOk = true;

                foreach (var i in _pairs)
                {
                    if (i == newPair)
                    {
                        bIsOk = false;
                        break;
                    }
                }

                if (bIsOk)
                {
                    _pairs.Add(newPair);

                    SortPairs();

                    SavePairs();

                    _errorLabel.Text = "You successfull add pair";
                    _errorLabel.BackColor = Color.LightGreen;

                    InitTable(_pairs);
                    InitDataset();
                }
                else
                {
                    _errorLabel.Text = "You can't add pair with this params";
                    _errorLabel.BackColor = Color.Red;
                }
            }
            else
            {
                _errorLabel.Text = "You can't add pair with this params";
                _errorLabel.BackColor = Color.Red;
            }
        }

        /// <summary>
        /// Метод, который вызывается при нажатии кнопки _findButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void _findButton_Click(object sender, EventArgs e)
        {
            Pair.DayOfWeek day = Pair.DayOfWeek.Null;

            switch (_dayOfWeekComboBox.Text)
            {
                case "Monday":
                    {
                        day = Pair.DayOfWeek.Monday;
                        break;
                    }
                case "Tuesday":
                    {
                        day = Pair.DayOfWeek.Tuesday;
                        break;
                    }
                case "Wednesday":
                    {
                        day = Pair.DayOfWeek.Wednesday;
                        break;
                    }
                case "Thursday":
                    {
                        day = Pair.DayOfWeek.Thursday;
                        break;
                    }
                case "Friday":
                    {
                        day = Pair.DayOfWeek.Friday;
                        break;
                    }
                case "Saturday":
                    {
                        day = Pair.DayOfWeek.Saturday;
                        break;
                    }
                case "Sunday":
                    {
                        day = Pair.DayOfWeek.Sunday;
                        break;
                    }
            }

            string time = _timeComboBox.Text;
            string name = _nameTextBox.Text;
            string teacher = _teacherTextBox.Text;
            string audience = _audienceTextBox.Text;

            _pairsTemp = new List<Pair>();

            for(int i = 0; i < _pairs.Count; i++)
            {
                var bIsOk = true;

                if(day != Pair.DayOfWeek.Null)
                {
                    if (_pairs[i].Day != day.ToString())
                    {
                        bIsOk = false;
                    }
                }
                if (time != " " & time != "")
                {
                    if (_pairs[i].Time != time)
                    {
                        bIsOk = false;
                    }
                }
                if (name != "")
                {
                    if (_pairs[i].Name != name)
                    {
                        bIsOk = false;
                    }
                }
                if (teacher != "")
                {
                    if (_pairs[i].Teacher != teacher)
                    {
                        bIsOk = false;
                    }
                }
                if (audience != "")
                {
                    if (_pairs[i].Audience != audience)
                    {
                        bIsOk = false;
                    }
                }

                if(bIsOk)
                {
                    _pairsTemp.Add(_pairs[i]);
                }
            }

            InitTable(_pairsTemp);
        }

        /// <summary>
        /// Метод, который вызывается при нажатии кнопки _editButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void _editButton_Click(object sender, EventArgs e)
        {
            _IdtextBox.Visible = true;
            _dayOfWeekEditComboBox.Visible = true;
            _timeEditComboBox.Visible = true;
            _nameEditTextBox.Visible = true;
            _teacherEditTextBox.Visible = true;
            _audienceEditTextBox.Visible = true;
        }

        /// <summary>
        /// Метод, который вызывается при нажатии кнопки _deleteButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void _deleteButton_Click(object sender, EventArgs e)
        {
            _IdtextBox.Visible = true;

            _dayOfWeekEditComboBox.Visible = false;
            _timeEditComboBox.Visible = false;
            _nameEditTextBox.Visible = false;
            _teacherEditTextBox.Visible = false;
            _audienceEditTextBox.Visible = false;
        }

        /// <summary>
        /// Метод, который вызывается при нажатии кнопки _applyButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void _applyButton_Click(object sender, EventArgs e)
        {
            int currentMaxId = 0;

            if (_dayOfWeekEditComboBox.Visible && int.TryParse(_IdtextBox.Text, out currentMaxId))
            {
                string day = _dayOfWeekEditComboBox.Text;
                string time = _timeEditComboBox.Text;
                string name = _nameEditTextBox.Text;
                string teacher = _teacherEditTextBox.Text;
                string audience = _audienceEditTextBox.Text;

                if (avaibleDays.Contains(day) && avaibleTime.Contains(time))
                {
                    var newPair = new Pair(currentMaxId.ToString(), day, time, name, teacher, audience);

                    bool bIsOk = true;

                    foreach (var i in _pairs)
                    {
                        if (i == newPair)
                        {
                            bIsOk = false;
                            break;
                        }
                    }

                    if (bIsOk)
                    {
                        for(int k = 0; k < _pairs.Count; k++)
                        {
                            if (_pairs[k].iID == currentMaxId)
                            {
                                _pairs[k].Day = day;
                                _pairs[k].Time = time;
                                _pairs[k].Name = name;
                                _pairs[k].Teacher = teacher;
                                _pairs[k].Audience = audience;
                            }
                        }

                        SortPairs();

                        SavePairs();

                        _errorLabel.Text = "You successfull edit pair";
                        _errorLabel.BackColor = Color.LightGreen;

                        InitTable(_pairs);
                        InitDataset();
                    }
                    else
                    {
                        _errorLabel.Text = "You can't edit pair with this params";
                        _errorLabel.BackColor = Color.Red;
                    }
                }
                else
                {
                    _errorLabel.Text = "You can't add edit with this params";
                    _errorLabel.BackColor = Color.Red;
                }
            }
            else
            {
                if(int.TryParse(_IdtextBox.Text, out currentMaxId))
                {
                    List<Pair> pairs = new List<Pair>();

                    for(int i = 0; i < _pairs.Count; i++)
                    {
                        if (_pairs[i].iID != currentMaxId)
                        {
                            pairs.Add(_pairs[i]);
                        }
                    }

                    _pairs = pairs;

                    SortPairs();

                    SavePairs();

                    _errorLabel.Text = "You successfull delete pair";
                    _errorLabel.BackColor = Color.LightGreen;

                    InitTable(_pairs);
                    InitDataset();
                }
                else
                {
                    _errorLabel.Text = "No such id";
                    _errorLabel.BackColor = Color.Red;
                }
            }

            _IdtextBox.Visible = false;
            _dayOfWeekEditComboBox.Visible = false;
            _timeEditComboBox.Visible = false;
            _nameEditTextBox.Visible = false;
            _teacherEditTextBox.Visible = false;
            _audienceEditTextBox.Visible = false;
        }

        /// <summary>
        /// Метод, котрый получает список пар из файла
        /// </summary>
        /// <param name="fileName">имя файла со списком пар</param>
        /// <returns></returns>
        List<Pair> GetPairs(string fileName)
        {
            List<Pair> pairs = new List<Pair>();

            using(StreamReader sr = new StreamReader(fileName))
            {
                var s = sr.ReadLine();

                while (s != null)
                {
                    var sArray = s.Split(';');

                    var id = sArray[0];
                    var day = sArray[1];
                    var time = sArray[2];
                    var name = sArray[3];
                    var teacher = sArray[4];
                    var audience = sArray[5];

                    var pair = new Pair(id, day, time, name, teacher, audience);

                    pairs.Add(pair);

                    s = sr.ReadLine();
                }
            }

            return pairs;
        }

        /// <summary>
        /// Метод, который сортирует списко пар
        /// </summary>
        void SortPairs()
        {
            bool bIsSort = true;

            while(bIsSort)
            {
                bIsSort = false;

                for(int i = 0; i < _pairs.Count - 1; i++)
                {
                    if (_pairs[i] > _pairs[i+1])
                    {
                        var t = _pairs[i];
                        _pairs[i] = _pairs[i+1];
                        _pairs[i+1] = t;

                        bIsSort = true;
                    }
                }
            }

        }

        /// <summary>
        /// Метод, который записывает список пар в файл
        /// </summary>
        void SavePairs()
        {
            using (StreamWriter sw = new StreamWriter("Pairs.txt"))
            {
                for(int i = 0; i < _pairs.Count; i++)
                {
                    var str = $"{_pairs[i].ID};{_pairs[i].Day};{_pairs[i].Time};{_pairs[i].Name};{_pairs[i].Teacher};{_pairs[i].Audience}";

                    sw.WriteLine(str);
                }
            }
        }
    }
}
