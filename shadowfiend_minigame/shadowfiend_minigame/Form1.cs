using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Media;

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
        private bool PlayGame_Check = false;
        private bool shock_accessZ = true;
        private bool shock_accessX = true;
        private bool shock_accessC = true;
        Exception exc = new Exception();
        SoundPlayer sp = new SoundPlayer();
        private int[] _frst_location = new int[162]
        {
319,
320,
321,
322,
323,324,
325,
326,
327,
328,
329,
330,
331,
332,
333,
334,
335,
336,
337,
338,
339,
340,
341,
342,
343,
344,
345,
346,
347,
348,
349,
350,
351,
352,
353,
354,
355,
356,
357,
358,
359,
360,
361,
362,
363,
364,
365,
366,
367,
368,
369,
370,
371,
372,
373,
374,
375,
376,
377,
378,
379,
380,
381,
382,
383,
384,
385,
386,
387,
388,
389,
390,
391,
392,
393,
394,
395,
396,
397,
398,
399,
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
448,
449,
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
           
        private int[] _sec_location = new int[162]
        {
639,
640,
641,
642,
643,
644,645,
646,
647,
648,
649,
650,
651,
652,
653,
654,
655,
656,
657,
658,
659,
660,
661,
662,
663,
664,
665,
666,
667,
668,
669,
670,
671,
672,
673,
674,
675,
676,
677,
678,
679,
680,
681,
682,
683,
684,
685,
686,
687,
688,
689,
690,
691,
692,
693,
694,
695,
696,
697,
698,
699,
700,
701,
702,
703,
704,
705,
706,
707,
708,
709,
710,
711,
712,
713,
714,
715,
716,
717,
718,
719,
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
        private int[] _thrd_location = new int[162]
        {
1019,
1020,
1021,
1022,
1023,
1024,
1025,
1026,
1027,
1028,
1029,
1030,
1031,
1032,
1033,
1034,
1035,
1036,
1037,
1038,
1039,
1040,
1041,
1042,
1043,
1044,
1045,
1046,
1047,
1048,
1049,
1050,
1051,
1052,
1053,
1054,
1055,
1056,
1057,
1058,
1059,
1060,
1061,
1062,
1063,
1064,
1065,
1066,
1067,
1068,
1069,
1070,
1071,
1072,
1073,
1074,
1075,
1076,
1077,
1078,
1079,
1080,
1081,
1082,
1083,
1084,
1085,
1086,
1087,
1088,
1089,
1090,
1091,
1092,
1093,
1094,
1095,
1096,
1097,
1098,
1099,
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
            sp.Stream = Properties.Resources.ShadowrazeWav;
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
                exc.CallException(-2);
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
            PlayGame_Check = true;
            do
            {
                for (int i = 0; i < 50; i++)
                {
                    this.Invoke(new Action(() => _zeus.Location = new Point(_zeus.Location.X - 20, _zeus.Location.Y)));
                    Thread.Sleep(speed_zeus);
                    if (Array.Exists(_frst_location, element => element == _zeus.Location.X) == true)
                    {
                        if (shock.Visible == true)
                        {
                            zeus_hp = zeus_hp - 200;
                            this.Invoke(new Action(() => label4.Text = "zeus_hp: " + zeus_hp));
                        }
                    }
                    else if (Array.Exists(_sec_location, element => element == _zeus.Location.X) == true)
                    {
                        if (shock.Visible == true)
                        {
                            zeus_hp = zeus_hp - 200;
                            this.Invoke(new Action(() => label4.Text = "zeus_hp: " + zeus_hp));
                        }
                    }
                    else if (Array.Exists(_thrd_location, element => element == _zeus.Location.X) == true)
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
                for (int i = 0; i < 50; i++)
                {
                    this.Invoke(new Action(() => _zeus.Location = new Point(_zeus.Location.X + 20, _zeus.Location.Y)));
                    Thread.Sleep(speed_zeus);
                    if (Array.Exists(_frst_location, element => element == _zeus.Location.X) == true)
                    {
                        if (shock.Visible == true)
                        {
                            zeus_hp = zeus_hp - 200;
                            this.Invoke(new Action(() => label4.Text = "zeus_hp: " + zeus_hp));
                        }
                    }
                    else if (Array.Exists(_sec_location, element => element == _zeus.Location.X) == true)
                    {
                        if (shock.Visible == true)
                        {
                            zeus_hp = zeus_hp - 200;
                            this.Invoke(new Action(() => label4.Text = "zeus_hp: " + zeus_hp));
                        }
                    }
                    else if (Array.Exists(_thrd_location, element => element == _zeus.Location.X) == true)
                    {
                        if (shock.Visible == true)
                        {
                            zeus_hp = zeus_hp - 200;
                            this.Invoke(new Action(() => label4.Text = "zeus_hp: " + zeus_hp));
                        }
                    }
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
            PlayGame_Check = false;
        }

        private async void ZShock_Time()
        {
            shock_accessZ = false;
            this.Invoke(new Action(() => time1.Visible = true));
            Thread.Sleep(1000);
            this.Invoke(new Action(() => time1.Text = "2"));
            Thread.Sleep(1000);
            this.Invoke(new Action(() => time1.Text = "1"));
            Thread.Sleep(1000);
            this.Invoke(new Action(() => time1.Visible = false));
            this.Invoke(new Action(() => time1.Text = "3"));
            shock_accessZ = true;
        }

        private async void XShock_Time()
        {
            shock_accessX = false;
            this.Invoke(new Action(() => time2.Visible = true));
            Thread.Sleep(1000);
            this.Invoke(new Action(() => time2.Text = "2"));
            Thread.Sleep(1000);
            this.Invoke(new Action(() => time2.Text = "1"));
            Thread.Sleep(1000);
            this.Invoke(new Action(() => time2.Visible = false));
            this.Invoke(new Action(() => time2.Text = "3"));
            shock_accessX = true;
        }

        private async void CShock_Time()
        {
            shock_accessC = false;
            this.Invoke(new Action(() => time3.Visible = true));
            Thread.Sleep(1000);
            this.Invoke(new Action(() => time3.Text = "2"));
            Thread.Sleep(1000);
            this.Invoke(new Action(() => time3.Text = "1"));
            Thread.Sleep(1000);
            this.Invoke(new Action(() => time3.Visible = false));
            this.Invoke(new Action(() => time3.Text = "3"));
            shock_accessC = true;
        }

        private async void ShadowRaze_Click(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Z:
                    Thread z_thread = new Thread(ZShock_Time);
                    if (PlayGame_Check == false)
                    {
                        exc.CallException(1);
                        return;
                    }
                    if (shock_accessZ == false)
                    {
                        exc.CallException(3);
                        break;
                    }
                    shock.Location = new Point(_first_shadowrazeX, _first_shadowrazeY);
                    shock.Visible = true;
                    this.Update();
                    Thread.Sleep(100);
                    shock.Visible = false;
                    if (zeus_hp == 0)
                    {
                        MessageBox.Show("You win");
                        this.Invoke(new Action(() => Start.Visible = true));
                        this.Invoke(new Action(() => checkBox1.Visible = true));
                        this.Invoke(new Action(() => checkBox2.Visible = true));
                        this.Invoke(new Action(() => checkBox3.Visible = true));
                        break;
                    }
                    sp.Play();
                    z_thread.Start();
                    break;
                case Keys.X:
                    Thread x_thread = new Thread(XShock_Time);
                    if (PlayGame_Check == false)
                    {
                        exc.CallException(1);
                        return;
                    }
                    if (shock_accessX == false)
                    { exc.CallException(3);
                        break;
                    }
                    shock.Location = new Point(_second_shadowrazeX, _second_shadowrazeY);
                    shock.Visible = true;
                    this.Update();
                    Thread.Sleep(100);
                    shock.Visible = false;
                    if (zeus_hp == 0)
                    {
                        MessageBox.Show("You win");
                        this.Invoke(new Action(() => Start.Visible = true));
                        this.Invoke(new Action(() => checkBox1.Visible = true));
                        this.Invoke(new Action(() => checkBox2.Visible = true));
                        this.Invoke(new Action(() => checkBox3.Visible = true));
                        break;
                    }
                    sp.Play();
                    x_thread.Start();
                    break;
                case Keys.C:
                    Thread c_thread = new Thread(CShock_Time);
                    if (PlayGame_Check == false)
                    {
                        exc.CallException(1);
                        return;
                    }
                    if (shock_accessC == false)
                    { exc.CallException(3);
                        break;
                    }
                    shock.Location = new Point(_third_shadowrazeX, _third_shadowrazeY);
                    shock.Visible = true;
                    this.Update();
                    Thread.Sleep(100);
                    shock.Visible = false;
                    if (zeus_hp == 0)
                    {
                        MessageBox.Show("You win");
                        this.Invoke(new Action(() => Start.Visible = true));
                        this.Invoke(new Action(() => checkBox1.Visible = true));
                        this.Invoke(new Action(() => checkBox2.Visible = true));
                        this.Invoke(new Action(() => checkBox3.Visible = true));
                        break;
                    }
                    sp.Play();
                    c_thread.Start();
                    break;
            }
        }
    }
}
