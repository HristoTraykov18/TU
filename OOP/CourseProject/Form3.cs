using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.CenterToScreen();
            textBoxWidth.Click += Common_TextBoxClick;
            textBoxHeight.Click += Common_TextBoxClick;
            textBoxX.Click += Common_TextBoxClick;
            textBoxY.Click += Common_TextBoxClick;
        }

        public int Width
        {
            get {
                try
                {
                    return int.Parse(textBoxWidth.Text);
                }
                catch (System.FormatException)
                {
                    return -1;
                }
            }
        }

        public int Height
        {
            get
            {
                try
                {
                    return int.Parse(textBoxHeight.Text);
                }
                catch (System.FormatException)
                {
                    return -1;
                }
            }
        }

        public int X_Start
        {
            get
            {
                try
                {
                    return int.Parse(textBoxX.Text);
                }
                catch (System.FormatException)
                {
                    return -1;
                }
            }
        }

        public int Y_Start
        {
            get
            {
                try
                {
                    return int.Parse(textBoxY.Text);
                }
                catch (System.FormatException)
                {
                    return -1;
                }
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (Width > 9 && Height > 9 && X_Start > 0 && Y_Start > 0)
            {
                if (Y_Start < 95)
                {
                    labelAlert.Text = "CAN NOT DRAW THERE";
                    labelAlert.Show();
                }
                else if ((X_Start + Width < 791) && (Y_Start + Height < 591))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    labelAlert.Text = "OUT OF BOUNDS";
                    labelAlert.Show();
                }
            }
            else
            {
                if (Width == -1) textBoxWidth.Text = "INVALID INPUT";
                if (Height == -1) textBoxHeight.Text = "INVALID INPUT";
                if (X_Start == -1) textBoxX.Text = "INVALID INPUT";
                if (Y_Start == -1) textBoxY.Text = "INVALID INPUT";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        
        private void Common_TextBoxClick(object sender, EventArgs e)
        {
            labelAlert.Hide();
        }
    }
}
