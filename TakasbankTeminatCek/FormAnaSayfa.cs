using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakasbankTeminatCek
{
    public partial class FormAnaSayfa : Form
    {
        bool IsMouseDown;
        private Point Offset;
        FormDataCek formDataCek = new FormDataCek();
        FormOption formOption = new FormOption();
        private Form activeForm = null;

        public FormAnaSayfa()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;


            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            activeForm = childForm;
            activeForm.BringToFront();
            activeForm.Show();
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            Offset.X = e.X;
            Offset.Y = e.Y;
            IsMouseDown = true;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                Point currentScreenPosition = PointToScreen(e.Location);
                Location = new Point(currentScreenPosition.X - Offset.X, currentScreenPosition.Y - Offset.Y);
            }
        }

        private void buttonDataCek_Click(object sender, EventArgs e)
        {
            openChildForm(formDataCek);
        }

        private void buttonMainPage_Click(object sender, EventArgs e)
        {
            formDataCek.Hide();
        }

        private void buttonFilePaths_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(formOption);
        }
    }
}
