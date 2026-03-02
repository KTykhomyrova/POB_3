using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._03
{
    public partial class Geometria : Form
    {
        private Form matematyka;

        public Geometria(Form matematyka)
        {
            InitializeComponent();
            this.matematyka = matematyka;
        }

        private void Geomrteia_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.matematyka.Show();
        }
    }
}
