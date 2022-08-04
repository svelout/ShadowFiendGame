using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace shadowfiend_minigame
{
    public partial class Form1 : Form
    {
        private readonly int _first_shadowrazeX = 400, _first_shadowrazeY = 204;
        private readonly int _second_shadowrazeX = 720, _second_shadowrazeY = 204;
        private readonly int _third_shadowrazeX = 1100, _third_shadowrazeY = 204;
        private int zeus_hp = 1000;
        private int shadow_fiend_hp = 2800;
        private int speed_zeus, damage_zeus;
        private int[] _frst_location = new int[81]
        {
            400,
401,
402,
403,
404,
405,
406,
407,
408,
409,
410,
411,
412,
413,
414,
415,
416,
417,
418,
419,
420,
421,
422,
423,
424,
425,
426,
427,
428,
429,
430,
431,
432,
433,
434,
435,
436,
437,
438,
439,
440,
441,
442,
443,
444,
445,
446,
447,
448,449,
450,
451,
452,
453,
454,
455,
456,
457,
458,
459,
460,
461,
462,
463,
464,
465,
466,
467,
468,
469,
470,
471,
472,
473,
474,
475,
476,
477,
478,
479,
480

        };
           
        private int[] _sec_location = new int[81]
        {
            720,
721,
722,
723,
724,
725,
726,
727,
728,
729,
730,
731,
732,
733,
734,
735,
736,
737,
738,
739,
740,
741,
742,
743,
744,
745,
746,
747,
748,
749,
750,
751,
752,
753,
754,
755,
756,
757,
758,
759,
760,
761,
762,
763,
764,
765,
766,
767,
768,
769,
770,
771,
772,
773,
774,
775,
776,
777,
778,
779,
780,
781,
782,
783,
784,
785,
786,
787,
788,
789,
790,
791,
792,
793,
794,
795,
796,
797,
798,
799,
800

        };
        private int[] _thrd_location = new int[81]
        {
            1100,
1101,
1102,
1103,
1104,
1105,
1106,
1107,
1108,
1109,
1110,
1111,
1112,
1113,
1114,
1115,
1116,
1117,
1118,
1119,
1120,
1121,
1122,
1123,
1124,
1125,
1126,
1127,
1128,
1129,
1130,
1131,
1132,
1133,
1134,
1135,
1136,
1137,
1138,
1139,
1140,
1141,
1142,
1143,
1144,
1145,
1146,
1147,
1148,
1149,
1150,
1151,
1152,
1153,
1154,
1155,
1156,
1157,
1158,
1159,
1160,
1161,
1162,
1163,
1164,
1165,
1166,
1167,
1168,
1169,
1170,
1171,
1172,
1173,
1174,
1175,
1176,
1177,
1178,
1179,
1180

        };
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
                    if (_zeus.Location.X == 1106)
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
            shadow_fiend_hp -= damage;
            this.Invoke(new Action(() => hp.Text = "HP: " + shadow_fiend_hp));
        }

        private void ResetAll()
        {
            this.Invoke(new Action(() => hp.Text = "HP: 2800"));
            this.Invoke(new Action(() => label4.Text = "zeus_hp: 1000"));
            zeus_hp = 1000;
            shadow_fiend_hp = 2800;
            _zeus.Location = new Point(1320, 194);
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
