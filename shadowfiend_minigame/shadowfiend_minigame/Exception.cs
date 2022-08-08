using System;
using System.IO;
using System.Windows.Forms;
using System.Media;

namespace shadowfiend_minigame
{
    public class Exception 
    {
        SoundPlayer player_1 = new SoundPlayer();
        SoundPlayer player_2 = new SoundPlayer();
        Random r = new Random();

        public Exception()
        {
            player_1.Stream = Properties.Resources.im_not_ready_;
            player_2.Stream = Properties.Resources.Earlya;
        }
        public async void CallException(int error_code)
        {
            switch (error_code)
            {
                case -1:// Принудительный выход из программы (вызывается если с работой программы возникают проблемы)
                    Environment.Exit(0);
                    break;
                case 1:// Нажатие на кнопки z x c до начала игры
                    MessageBox.Show("Начните игру!");
                    break;
                case -2:// Вызывается если сложность игры не выбрана
                    MessageBox.Show("Выберите сложность!");
                    break;
                case 3: // Вызывается если shadowraze в кд, но его попытались использовать\
                    int rnd_value = r.Next(1, 2);
                    switch (rnd_value)
                    {
                        case 1:
                            player_1.Play();
                            break;
                        case 2:
                            player_2.Play();
                            break;
                    }
                    break;
            }
        }
    }
}
