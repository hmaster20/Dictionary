using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Main : Form
    {
        Dictionary _dictionary = new Dictionary();  // Доступ к коллекции
        Data data = null;                           // Доступ к записи



        public Main()
        {
            InitializeComponent();
            rbSelect.Checked = true;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Edit form = new Edit();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _dictionary.Add(form.data);
                _dictionary.Save();
                RefreshTable();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            //VideoRecord record = GetSelectedRecord();
            //if (new Edit(record).ShowDialog() == DialogResult.OK)
            //{
            //    _dictionary.Save();
            //    RefreshTable();
            //}
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (File.Exists(Dictionary.BaseName))     // Если база создана, то выполняем
            {
                _dictionary = Dictionary.Load();
                if (_dictionary.DictionaryList.Count > 0)
                {
                    tssLabel.Text = "Коллекция из " + _dictionary.DictionaryList.Count.ToString() + " элементов";
                    RefreshTable();
                }
            }
        }



        private void RefreshTable()    // Обновление таблицы путем фильтрации элементов по полю Path
        {
            //Record selected = GetSelectedRecord();  // получение выбранной строки

            List<Data> filtered = _dictionary.DictionaryList;

            // if (nodeName != "" && nodeName != "Фильмотека")
            // filtered = filtered.FindAll(v => v.Path == _dictionary.Options.Source + Path.DirectorySeparatorChar + nodeName);


            //int switch_filter = tscbTypeFilter.SelectedIndex;
            //switch (switch_filter)  // фильтр по категориям
            //{
            //    case 1: filtered = filtered.FindAll(v => v.Type == TypeWord.noun); break;
            //    case 2: filtered = filtered.FindAll(v => v.Type == TypeWord.participle); break;
            //    case 3: filtered = filtered.FindAll(v => v.Type == TypeWord.Unknown); break;
            //    default: break;
            //}

            //int switch_sort = tscbSort.SelectedIndex;
            //switch (switch_sort)  // Сортировка по столбцам
            //{
            //    case 0: filtered.Sort(Data....CompareByName); break;
            //    case 1: filtered.Sort(Record.CompareByTime); break;
            //    case 2: filtered.Sort(Record.CompareByYear); break;
            //    default: break;
            //}


            dgvTable.DataSource = null;
            dgvTable.DataSource = filtered;

            //if (selected != null)
            //    SelectRecord(dgvTable, selected);
        }








        private void btRun_Click(object sender, EventArgs e)
        {
            //// Создать делегат для типа Timer.
            //TimerCallback timeCB = new TimerCallback(TimerCount);
            //// Установить параметры таймера.
            //System.Threading.Timer t = new System.Threading.Timer(
            //timeCB, // Объект делегата TimerCallback.
            //null,   // Информация для передачи в вызванный метод (null — информация отсутствует).
            //0,      // Период времени ожидания перед запуском (в миллисекундах).
            //1000);  // Интервал времени между вызовами (в миллисекундах).
            //        //Console.WriteLine("Hit key to terminate...");
            //        //Console.ReadLine();

      


        }

        //private void TimerCount(object state)
        //{
          
        //    //label1.Text = count;
        //    label1.Text = "2";
        
        //}

        int timeLeft;
        int addend1;
        int addend2;
        Random randomizer = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // Display the new time left by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
               // sum.Value = addend1 + addend2;
                startButton.Enabled = true;
            }
        }

        /// <summary>
        /// Start the quiz by filling in all of the problem 
        /// values and starting the timer. 
        /// </summary>
        public void StartTheQuiz()
        {
            //// Fill in the addition problem.
            //// Generate two random numbers to add.
            //// Store the values in the variables 'addend1' and 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            textBox1.Text = addend1.ToString();

            //// Convert the two randomly generated numbers
            //// into strings so that they can be displayed
            //// in the label controls.
            //plusLeftLabel.Text = addend1.ToString();
            //plusRightLabel.Text = addend2.ToString();


            //// 'sum' is the name of the NumericUpDown control.
            //// This step makes sure its value is zero before
            //// adding any values to it.
            //sum.Value = 0;

            // Start the timer.
            timeLeft = 15;
            timeLabel.Text = "15 seconds";
            timer1.Start();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;

            if (rbSelect.Checked) { label1.Text = "Гадаем по словам"; }
            if (rbInsert.Checked) { label1.Text = "Пишем словечки"; }


        }





    }


}
// msdn.microsoft.com/ru-ru/library/dd492171.aspx