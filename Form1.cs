using System;
using System.Windows.Forms;
using System.Drawing;

namespace bakerydestroyer
{
    public partial class Form1 : Form
    {
        private Button btnSiema;
        private Label titleLabel; 
        private System.Windows.Forms.Timer timer;

        public Form1()
        {

            Text = "bakery-destroyer";
            Width = 900;
            Height = 400;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.White;

            titleLabel = new Label
            {
                Text = "bakery-destroyer",
                Font = new Font("Arial", 24, FontStyle.Bold),
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(300, 80) 
            };
            this.Controls.Add(titleLabel);

            FlowLayoutPanel buttonPanel = new FlowLayoutPanel
            {
                Size = new Size(250, 450),
                Location = new Point((900 - 250) / 2, 160),
                FlowDirection = FlowDirection.TopDown,
                BackColor = Color.Transparent
            };

            Button btnSiema1 = new Button { Text = "zrób nic i umrzyj", Size = new Size(250, 40) };
            btnSiema1.Click += BtnSiema1_Click;
            buttonPanel.Controls.Add(btnSiema1);
            this.Controls.Add(buttonPanel);


            timer = new System.Windows.Forms.Timer();
            timer.Interval = 600000; 
            timer.Tick += Timer_Tick;
            timer.Start();
        }


        private void BtnSiema1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            Application.Exit();
        }
    }
}