using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AITLibrary
{
    public partial class StudentHome : Form
    {
        public StudentHome()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void browseMedia_Click(object sender, EventArgs e)
        {
            Browse_Media browse_Media = new Browse_Media();
            browse_Media.Show();
            this.Hide();    

        }
    }
}
