using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sales_application
{
    public partial class Form1 : Form
    {

        private Form currentChildForm;
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelForButtonSection_1.Visible = false;
            panelForButtonSection_2.Visible = false;
        }

        private void hideSubMenuButtonSection()
        {
            if (panelForButtonSection_1.Visible = true)
                panelForButtonSection_1.Visible = false;
            if (panelForButtonSection_2.Visible = true)
                panelForButtonSection_2.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenuButtonSection();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelForButtonSection_1);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            showSubMenu(panelForButtonSection_2);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            hideSubMenuButtonSection();
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            hideSubMenuButtonSection();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            hideSubMenuButtonSection();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            hideSubMenuButtonSection();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            hideSubMenuButtonSection();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            hideSubMenuButtonSection();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            hideSubMenuButtonSection();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            hideSubMenuButtonSection();
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            hideSubMenuButtonSection();
        }
    }
}
