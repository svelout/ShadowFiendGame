using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace shadowfiend_minigame
{
    public partial class Form1 : Form
    {
        private int _first_shadowrazeX = 400, _first_shadowrazeY = 204;
        private int _second_shadowrazeX = 720, _second_shadowrazeY = 204;
        private int _third_shadowrazeX = 1100, _third_shadowrazeY = 204;
        private int zeus_hp = 1000;
        private int shadow_fiend_hp = 2800;
        private int speed_zeus, damage_zeus;

        public Form1()
        {
            InitializeComponent();            
            this.KeyDown += new KeyEventHandler(ShadowRaze_Click);
            KeyPreview = true;
        }

        bool CheckedBox()
        {
            bool checked1 = checkBox1.Checked;
            bool checked2 = checkBox2.Checked;
            bool checked3 = checkBox3.Checked;
            if (checked1 == false && checked2 == false && checked3 == false)
            {
                return false;
            }
            else return true;
        }


        private async void Start_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Zeus);
            if (CheckedBox() == false)
            {
                MessageBox.Show("Выберите сложность игры!");
            }
            else
            {
                Start.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                thread.Start();
            }
        }

        bool Stop()
        {
            if (label4.Text == "zeus_hp: 0") return true;
            else if (hp.Text == "HP: 0") return true;
            else return false;
        }

        private async void Zeus()
        {
            do
            {
                for (int i = 0; i < 50; i++)
                {
                    var x = _zeus.Location.X;
                    this.Invoke(new Action(() => _zeus.Location = new Point(_zeus.Location.X - 20, _zeus.Location.Y)));
                    Thread.Sleep(speed_zeus);
                    if (_zeus.Location.X == 1100)
                    {
                        if (shock.Visible == true)
                        {
                            zeus_hp = zeus_hp - 200;
                            this.Invoke(new Action(() => label4.Text = "zeus_hp: " + zeus_hp));
                        }
                    }
                    else if (_zeus.Location.X == 720)
                    {
                        if (shock.Visible == true)
                        {
                            zeus_hp = zeus_hp - 200;
                            this.Invoke(new Action(() => label4.Text = "zeus_hp: " + zeus_hp));
                        }
                    }
                    else if (_zeus.Location.X == 400)
                    {
                        if (shock.Visible == true)
                        {
                            zeus_hp = zeus_hp - 200;
                            this.Invoke(new Action(() => label4.Text = "zeus_hp: " + zeus_hp));
                        }
                    }
                }
                Zeus_Attack(damage_zeus);
                if (shadow_fiend_hp == 0)
                {
                    MessageBox.Show("You lose");
                    this.Invoke(new Action(() => Start.Visible = true));
                    this.Invoke(new Action(() => checkBox1.Visible = true));
                    this.Invoke(new Action(() => checkBox2.Visible = true));
                    this.Invoke(new Action(() => checkBox3.Visible = true));
                }
                else if (zeus_hp == 0)
                {
                    MessageBox.Show("You win");
                    this.Invoke(new Action(() => Start.Visible = true));
                    this.Invoke(new Action(() => checkBox1.Visible = true));
                    this.Invoke(new Action(() => checkBox2.Visible = true));
                    this.Invoke(new Action(() => checkBox3.Visible = true));
                }
                for (int i = 0; i < 50; i++)
                {
                    this.Invoke(new Action(() => _zeus.Location = new Point(_zeus.Location.X + 20, _zeus.Location.Y)));
                    Thread.Sleep(speed_zeus);
                }
            }
            while (Stop() != true);
            ResetAll();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Checked = false;
            checkBox1.Checked = false;
            speed_zeus = 30;
            damage_zeus = 200;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            speed_zeus = 10;
            damage_zeus = 400;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Checked = false;
            checkBox2.Checked = false;
            speed_zeus = 50;
            damage_zeus = 100;
        }

        private async void Zeus_Attack(int damage)
        {
            shadow_fiend_hp = shadow_fiend_hp - damage;
            this.Invoke(new Action(() => hp.Text = "HP: " + shadow_fiend_hp));
        }

        private void ResetAll()
        {
            this.Invoke(new Action(() => hp.Text = "HP: 2800"));
            this.Invoke(new Action(() => label4.Text = "zeus_hp: 1000"));
            zeus_hp = 1000;
            shadow_fiend_hp = 2800;
        }
      
        private async void ShadowRaze_Click(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Z:
                    shock.Location = new Point(_first_shadowrazeX, _first_shadowrazeY);
                    shock.Visible = true;
                    this.Update();
                    Thread.Sleep(100);
                    shock.Visible = false;
                    break;
                case Keys.X:
                    shock.Location = new Point(_second_shadowrazeX, _second_shadowrazeY);
                    shock.Visible = true;
                    this.Update();
                    Thread.Sleep(100);
                    shock.Visible = false;
                    break;
                case Keys.C:
                    shock.Location = new Point(_third_shadowrazeX, _third_shadowrazeY);
                    shock.Visible = true;
                    this.Update();
                    Thread.Sleep(100);
                    shock.Visible = false;
                    break;
            }
        }
    }
}
