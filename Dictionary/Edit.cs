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
        }

        public Edit(Data _data)
        {
            InitializeComponent();

            data = _data;

            tbWordEn.Text = _data.WordEn;
            tbWordRu.Text = _data.WordRu;


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
            //VideoType type;
            //Existence existence;

            //switch (cbType.SelectedIndex)
            //{
            //    case 0: type = VideoType.Movie; break;
            //    case 1: type = VideoType.Cartoon; break;
            //    case 2: type = VideoType.Series; break;
            //    default: MessageBox.Show("Не выбран тип"); return;
            //}

            //switch (cbExistence.SelectedIndex)
            //{
            //    case 0: existence = Existence.Have; break;
            //    case 1: existence = Existence.WillHave; break;
            //    case 2: existence = Existence.Had; break;
            //    default: MessageBox.Show("Не выбрано хранение"); return;
            //}

            if (data == null)
                data = new Data();

            data.WordEn = tbWordEn.Text;
            data.WordRu = tbWordRu.Text;

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
