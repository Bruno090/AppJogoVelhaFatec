using System;
using Xamarin.Forms;

namespace AppJogoVelha
{
    public partial class MainPage : ContentPage
    {
        string Vez = "X";
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if(Vez == "X")
            {
                btn.Text = "X";
                Vez = "O";
            }else
            {
                btn.Text = "O";
                Vez = "X";
            }

            //Verificando se o X ganhou
            if (btn10.Text == "X" && btn11.Text =="X" && btn12.Text == "X")
            {
               await DisplayAlert("Parabéns ", "O X ganhou", "OK");
                zerar();
            }
            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                await DisplayAlert("Parabéns ", "O X ganhou", "OK");
                zerar();
            }

            if(btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                await DisplayAlert("Parabéns ", "O X ganhou", "OK");
                zerar();
            }

            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                await DisplayAlert("Parabéns ", "O X ganhou", "OK");
                zerar();
            }

            if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
            {
                await DisplayAlert("Parabéns ", "O X ganhou", "OK");
                zerar();
            }

            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                await DisplayAlert("Parabéns ", "O X ganhou", "OK");
                zerar();
            }

            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                await DisplayAlert("Parabéns ", "O X ganhou", "OK");
                zerar();
            }

            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                await DisplayAlert("Parabéns ", "O X ganhou", "OK");
                zerar();
            }

            //Verificar se o 0 Ganhou
            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                await DisplayAlert("Parabéns ", "O 0 ganhou", "OK");
                zerar();
            }
            if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                await DisplayAlert("Parabéns ", "O 0 ganhou", "OK");
                zerar();
            }

            if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                await DisplayAlert("Parabéns ", "O 0 ganhou", "OK");
                zerar();
            }

            if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                await DisplayAlert("Parabéns ", "O 0 ganhou", "OK");
                zerar();
            }

            if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
            {
                await DisplayAlert("Parabéns ", "O 0 ganhou", "OK");
                zerar();
            }

            if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                await DisplayAlert("Parabéns ", "O 0 ganhou", "OK");
                zerar();
            }

            if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                await DisplayAlert("Parabéns ", "O 0 ganhou", "OK");
                zerar();
            }

            if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                await DisplayAlert("Parabéns ", "O 0 ganhou", "OK");
                zerar();
            }
        }//Fim Do Metodo button

        private void zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";

            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";

            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;

            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;

            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;

        }//Fim do metodo Zerar
    }//Fim do partial class mainpage
}// Fim do name Space
