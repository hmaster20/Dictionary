using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Edit : Form
    {
        public Data data = null;

        public Edit()
        {
            InitializeComponent();

            foreach (var item in Enum.GetValues(typeof(TypeWordRus)))
            {
                cbType.Items.Add(item);
            }
        }

        public Edit(Data _data)
        {
            InitializeComponent();

            data = _data;

            tbWordEn.Text = _data.WordEn;
            tbWordRu.Text = _data.WordRu;

            // Создание списка на основе перечисления
            foreach (var item in Enum.GetValues(typeof(TypeWordRus)))
            {
                cbType.Items.Add(item);
            }


            //switch (record.Type)
            //{
            //    case VideoType.Movie: cbType.SelectedIndex = 0; break;
            //    case VideoType.Cartoon: cbType.SelectedIndex = 1; break;
            //    case VideoType.Series: cbType.SelectedIndex = 2; break;
            //}
            //switch (record.Existence)
            //{
            //    case Existence.Have: cbExistence.SelectedIndex = 0; break;
            //    case Existence.WillHave: cbExistence.SelectedIndex = 1; break;
            //    case Existence.Had: cbExistence.SelectedIndex = 2; break;
            //}
        }


        private void btOk_Click(object sender, EventArgs e)
        {
            TypeWord type;

            //VideoType type;


            //switch (cbType.SelectedIndex)
            //{
            //    case 0: type = TypeWord.noun; break;
            //    case 1: type = VideoType.Cartoon; break;
            //    case 2: type = VideoType.Series; break;
            //    default: MessageBox.Show("Не выбран тип"); return;
            //}

            //foreach (var item in Enum.GetValues(typeof(TypeWordRus)))
            //{
            //    cbType.Items.Add(item);
            //}

            //type = (int)(TypeWord)Enum.Parse(typeof(TypeWord), cbType.SelectedIndex);
            type = (TypeWord)cbType.SelectedIndex;

            if (data == null)
                data = new Data();

            data.WordEn = tbWordEn.Text;
            data.WordRu = tbWordRu.Text;
            data.Type = type;

            DialogResult = DialogResult.OK;
        }


        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
