using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Main : Form
    {
        Dictionary _dictionary = new Dictionary();  // Доступ к коллекции
                                                    //Data data = null;                         // Доступ к записи

        public Main()
        {
            InitializeComponent();
            dgvTable.AutoGenerateColumns = false;   // Отключение автоматического заполнения таблицы
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
            Data data = GetSelectedRecord();
            if (new Edit(data).ShowDialog() == DialogResult.OK)
            {
                _dictionary.Save();
                RefreshTable();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Data data = GetSelectedRecord();
            DialogResult dialog = MessageBox.Show("Вы хотите удалить запись \"" + data.WordEn + "\" ?",
                                      "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                _dictionary.Remove(data);
                dgvTable.ClearSelection();
                _dictionary.Save();
                RefreshTable();
            }
        }


        private void import_Click(object sender, EventArgs e)
        {
            //// Read the file and display it line by line.
            //System.IO.StreamReader file = new System.IO.StreamReader(@"c:\test.txt");
            //while ((line = file.ReadLine()) != null)
            //{
            //    System.Console.WriteLine(line);
            //    counter++;
            //}
            //file.Close();
            //System.Console.WriteLine("There were {0} lines.", counter);

            OpenFileDialog FileDialog = new OpenFileDialog();
            //openFileDialog1.InitialDirectory = "c:\\";
            FileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            FileDialog.FilterIndex = 2;
            FileDialog.RestoreDirectory = true;

            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                var lines = File.ReadAllLines(FileDialog.FileName);
                foreach (var line in lines)
                {
                    if (line.Length > 1)
                    {
                        Data data = new Data();
                        data.WordEn = line;
                        data.WordRu = "";
                        data.Type = TypeWord.Unknown;
                        _dictionary.Add(data);
                    }
                }
                _dictionary.Save();
                RefreshTable();
            }
        }

        private Data GetSelectedRecord()  // получение выбранной записи в dgvTable
        {
            DataGridView dgv = dgvTable;
            if (dgv != null && dgv.SelectedRows.Count > 0 && dgv.SelectedRows[0].Index > -1)
            {
                Data data = null;
                if (dgv.SelectedRows[0].DataBoundItem is Data)
                    data = dgv.SelectedRows[0].DataBoundItem as Data;
                if (data != null)
                    return data;
            }
            return null;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (File.Exists(Dictionary.BaseName))     // Если база создана, то выполняем
            {
                _dictionary = Dictionary.Load();
                if (_dictionary.DictionaryList.Count > 0)
                {
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
            GLobalStatusLabel.Text = "Коллекция из " + _dictionary.DictionaryList.Count.ToString() + " элементов";
        }

























        int timeLeft;
        int addend1;
        int addend2;
        string word;
        Random randomizer = new Random();


        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            StartTheExam();
            startButton.Enabled = false;

            if (rbSelect.Checked) { label1.Text = "Гадаем по словам"; }
            if (rbInsert.Checked) { label1.Text = "Пишем словечки"; }
        }


        /// <summary>
        /// Start the quiz by filling in all of the problem values and starting the timer. 
        /// </summary>
        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            textBox1.Text = addend1.ToString();

            timeLeft = 15;
            timeLabel.Text = "15 seconds";
            timerQuiz.Start();
        }

        private void StartTheExam()
        {
            if (_dictionary.DictionaryList.Count > 3)
            {
                List<Data> LData = new List<Data>();
                while (LData.Count < 3)
                {
                    Data data = _dictionary.DictionaryList[randomizer.Next(_dictionary.DictionaryList.Count)];
                    if (LData.Count == 0)
                        LData.Add(data);
                    else
                        if (!LData.Exists(v => v.WordEn == data.WordEn)) LData.Add(data);
                }

                int i = 0;
                label2.Text = LData[i].WordEn;
                word = LData[i].WordRu;

                var checkedRadio = new[] { groupBox2 }
               .SelectMany(g => g.Controls.OfType<RadioButton>());
                foreach (var c in checkedRadio)
                {
                    c.Text = LData[i].WordRu;    //MessageBox.Show(c.Name);
                    i++;
                }
                
                // var checkedRadio = new[] { groupBox2 }
                //.SelectMany(g => g.Controls.OfType<RadioButton>()
                //                         .Where(r => r.Checked));               
                // // Print name
                // foreach (var c in checkedRadio)
                // { 
                //     System.Diagnostics.Debug.Print(c.Name);
                //     MessageBox.Show(c.Name);
                // }

                //RadioButton rb = new RadioButton();
                //rb.Location = new Point(200, 300 + 1 * 20);
                //groupBox2.Controls.Add(rb);
                

                // var buttons = this.Controls.OfType<RadioButton>()
                //           .FirstOrDefault(n => n.Checked);


                //List<RadioButton> buttons = groupBox2.OfType<RadioButton>().ToList();
                //RadioButton rbTarget = radioButtons
                //      .Where(r => r.GroupName == "GroupName" && r.IsChecked)
                //      .Single();

                // List<RadioButton> buttonss = (List<RadioButton>)new[] { groupBox2 }
                //.SelectMany(g => g.Controls.OfType<RadioButton>());
                // for (int i = 0; i < buttonss.Count; i++)
                // {
                //     buttonss[i].Text = "123_" +i;
                //     MessageBox.Show(buttonss[i].Name);
                // }
            }
            else
            {
                MessageBox.Show("Добавьте больше слов в словарь.");
            }
        }


        private bool isTimeRedZone(int timeLeft)
        {
            return (timeLeft > 0 && timeLeft < 6);
        }

        private void timer_Tick(object sender, EventArgs e) // ежесекундно идет проверка и можно подсчитать среднее время ответа.
        {
            if (isTimeRedZone(timeLeft))
            {
                timeLabel.BackColor = Color.Red;
            }

            if (CheckTheAnswereD())
            {
                timerQuiz.Stop();
                DialogResult result = MessageBox.Show("Ты крут!", "Congratulations!");
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Test");   //this.Close();
                }
                startButton.Enabled = true;
                timeLabel.BackColor = default(Color);

                var checkedRadio = new[] { groupBox2 }.SelectMany(g => g.Controls.OfType<RadioButton>());
                foreach (var c in checkedRadio)
                {
                    c.Checked = false;
                    c.Text = "";
                }
                label2.Text = "";
            }



            if (CheckTheAnswer())
            {
                timerQuiz.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
                timeLabel.BackColor = default(Color);
            }
            if (timeLeft > 0)
            {
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                timerQuiz.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                // sum.Value = addend1 + addend2; //правильный ответ этот
                startButton.Enabled = true;
                timeLabel.BackColor = default(Color);
            }
            timeLabel.Text = "";
        }

        /// <summary>
        /// Check the answer to see if the user got everything right.
        /// </summary>
        /// <returns>True if the answer's correct, false otherwise.</returns>
        private bool CheckTheAnswer()
        {
            // if (addend1 + addend2 == sum.Value)
            if (addend1.ToString() == textBox2.Text)
                return true;
            else
                return false;
        }



       private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private bool CheckTheAnswereD()
        {

            var checkedRadio = new[] { groupBox2 }
           .SelectMany(g => g.Controls.OfType<RadioButton>()
                                    .Where(r => r.Checked));
            foreach (var c in checkedRadio)
            {
                if (c.Text == word)
                    return true;
                else
                    return false;
            }
            return false;
        }



        private void btnFind_Click(object sender, EventArgs e)
        {
            int switch_Find = cbTypeFind.SelectedIndex;
            switch (switch_Find)
            {
                case 0: Find(0); break; // поиск по названию
                case 1: Find(1); break; // поиск по году
                default: MessageBox.Show("Укажите критерий поиска!"); break;
            }
        }

        private void Find(int cell)
        {
            Regex regex = new Regex(tbFind.Text, RegexOptions.IgnoreCase);
            int i = 0;

            dgvTable.ClearSelection();
            dgvTable.MultiSelect = true;    // Требуется для выбора всех строк
            try
            {
                foreach (DataGridViewRow row in dgvTable.Rows)
                {
                    if (regex.IsMatch(row.Cells[cell].Value.ToString()))
                    {
                        i++;
                        row.Selected = true;
                        //break; //Требуется для выбора одно строки
                    }
                }
                FindStatusLabel.Text = "Найдено " + i + " элементов.";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void tControl_Click(object sender, EventArgs e)
        {
            FindStatusLabel.Text = "";
        }
    }


}
// msdn.microsoft.com/ru-ru/library/dd492171.aspx