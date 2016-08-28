using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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







    }


}
