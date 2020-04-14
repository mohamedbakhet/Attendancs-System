using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystem
{
    public partial class Form1 : Form
    {
        ODPLayer DB = new ODPLayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            //gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            //Region rg = new Region(gp);
            //pictureBox1.Region = rg;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DB.login(name_txt.Text,password_txt.Text)) {
               user user= DB.getUser();
                if (user is admin)
                {

                }
                else if (user is teacher)
                {

                }
                else if (user is student)
                {

                }

            }
            else
            {
                MessageBox.Show("Login error","Please check from name or password");
            }
        }
    }
}
