using System;
using System.Windows.Forms;
using Lesson7;

namespace EmptyProject
{
    class Form1 : Form
    {
        Udvoitel udvoitel=new Udvoitel(10,100);
        Button btnPlus,btnMulti,btnReset;
        Label lblFinish;
        TextBox tbCurrent;


        public void Init()
        {
            btnPlus = new Button();
            btnMulti = new Button();
            btnReset = new Button();
            lblFinish = new Label();
            tbCurrent = new TextBox();
            btnMulti.Top = 30;
            btnReset.Top = 60;
            btnPlus.Text = "+1";
            btnReset.Text = "Reset";
            btnMulti.Text = "x2";
            lblFinish.Text = "?";
            tbCurrent.Text = "+1";
            tbCurrent.Left = 100;
            lblFinish.Left = 100;// this.Width-lblFinish.Width;
            lblFinish.Top = 50;

            btnPlus.Click += BtnPlus_Click;
            this.Controls.AddRange(new Control[] { btnMulti, btnPlus, btnReset, lblFinish, tbCurrent });
            btnReset.Select();
            //lblFinish.Parent = this;

            this.Text = "Заголовок 1";
        }

        void BtnPlus_Click(object sender, EventArgs e)
        {
            udvoitel.Plus();
            tbCurrent.Text = udvoitel.Current.ToString();
        }

        public Form1()
        {
            Init();
        }

    }
}
