using System.Drawing.Drawing2D;

namespace PcGameTrainer_v._1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool isToggled1 = false; //track toggle state
        private bool isToggled2 = false; //track toggle state
        private bool isToggled3 = false; //track toggle state
        private bool isToggled4 = false; //track toggle state

        private void toggleButton1_Click_1(object sender, EventArgs e)
        {
            if (isToggled1)
            {
                toggleButton1.BackColor = Color.Red;
                toggleButton1.Text = "OFF";
                isToggled1 = false;
            }
            else
            {
                isToggled1 = true;
                toggleButton1.BackColor = Color.Green;
                toggleButton1.Text = "ON";
            }
        }

        private void toggleButton2_Click(object sender, EventArgs e)
        {
            if (isToggled2)
            {
                toggleButton2.BackColor = Color.Red;
                toggleButton2.Text = "OFF";
                isToggled2 = false;
            }
            else
            {
                isToggled2 = true;
                toggleButton2.BackColor = Color.Green;
                toggleButton2.Text = "ON";
            }
        }

        private void toggleButton3_Click(object sender, EventArgs e)
        {
            if (isToggled3)
            {
                toggleButton3.BackColor = Color.Red;
                toggleButton3.Text = "OFF";
                isToggled3 = false;
            }
            else
            {
                isToggled3 = true;
                toggleButton3.BackColor = Color.Green;
                toggleButton3.Text = "ON";
            }
        }

        private void toggleButton4_Click(object sender, EventArgs e)
        {
            if (isToggled4)
            {
                toggleButton4.BackColor = Color.Red;
                toggleButton4.Text = "OFF";
                isToggled4 = false;
            }
            else
            {
                isToggled4 = true;
                toggleButton4.BackColor = Color.Green;
                toggleButton4.Text = "ON";
            }
        }

        private void toggleButton1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(0,0,toggleButton1.Width,toggleButton1.Height);
            toggleButton1.Region = new Region(p);
        }
    }
}
