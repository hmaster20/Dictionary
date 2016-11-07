using System;
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

            switch (_data.Type)
            {
                case TypeWord.verb: cbType.SelectedIndex = 0; break;
                case TypeWord.noun: cbType.SelectedIndex = 1; break;
                case TypeWord.pronoun: cbType.SelectedIndex = 2; break;
                case TypeWord.questions: cbType.SelectedIndex = 3; break;
                case TypeWord.participle: cbType.SelectedIndex = 4; break;
                case TypeWord.prepositions: cbType.SelectedIndex = 5; break;
                case TypeWord.Unknown: cbType.SelectedIndex = 6; break;
            }
        }


        private void btOk_Click(object sender, EventArgs e)
        {
            TypeWord type;

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
            if (e.KeyCode == Keys.Escape) Close();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            //$specialCharacters.= "Latin-1 Supplement".PHP_EOL;
            //$specialCharacters.= "ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿ".PHP_EOL;
            //$specialCharacters.= "Latin Extended-A".PHP_EOL;
            //$specialCharacters.= "ĀāĂăĄąĆćĈĉĊċČčĎďĐđĒēĔĕĖėĘęĚěĜĝĞğĠġĢģĤĥĦħĨĩĪīĬĭĮįİıĲĳĴĵĶķĸĹĺĻļĽľĿŀŁłŃńŅņŇňŉŊŋŌōŎŏŐőŒœŔŕŖŗŘřŚśŜŝŞşŠšŢţŤťŦŧŨũŪūŬŭŮůŰűŲųŴŵŶŷŸŹźŻżŽžſ".PHP_EOL;
            //$specialCharacters.= "Latin Extended-B".PHP_EOL;
            //$specialCharacters.= "ƒǺǻǼǽǾǿ".PHP_EOL;
            //$specialCharacters.= "Latin Extended Additional".PHP_EOL;
            //$specialCharacters.= "ẀẁẂẃẄẅỲỳ".PHP_EOL;

            string specialCharacters =  "ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿ";

            char[] arr = specialCharacters.ToCharArray();

            foreach (var item in arr)
            {
                comboBox1.Items.Add(item);
            }
           




        }
    }
}
