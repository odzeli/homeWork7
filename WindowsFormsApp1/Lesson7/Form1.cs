using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lesson7;

namespace Lesson7
{
    public partial class fMain : Form
    {
        Udvoitel udvoitel;
        int _counter;
        public int Counter
        {
            get
            {
                return _counter;
            }
        }
        public fMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            udvoitel = new Udvoitel(10, 100);
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            lblFinish.Text = udvoitel.Finish.ToString();
            tbCurrent.Text = udvoitel.Current.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (udvoitel == null)
            {
                MessageBox.Show("Start game!");
                return;
            }
            _counter++;
            label1.Text = _counter.ToString();
            udvoitel.Plus();
            UpdateInfo();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (udvoitel == null)
            {
                MessageBox.Show("Start game!");
                return;
            }
            _counter++;
            label1.Text = _counter.ToString();
            udvoitel.Multi();
            UpdateInfo();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (udvoitel == null)
            {
                MessageBox.Show("Start game!");
                return;
            }
            _counter++;
            udvoitel.Reset();
            UpdateInfo();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (udvoitel == null)
            {
                MessageBox.Show("Start game!");
                return;
            }
            udvoitel.Back();
            UpdateInfo();
        }
    }
}
