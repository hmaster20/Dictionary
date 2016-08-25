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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Edit form = new Edit();
            if (form.ShowDialog() == DialogResult.OK)
            {
                //   _videoCollection.Add(form.Record);
                //   _videoCollection.Save();
                //   RefreshTables();
            }


        }

        private void Edit_Click(object sender, EventArgs e)
        {
           // VideoRecord record = GetSelectedRecord();
            //if (new FormAdd(record).ShowDialog() == DialogResult.OK)
            {
                //_videoCollection.Save();
                //RefreshTables();
            }
        }
    }
}
