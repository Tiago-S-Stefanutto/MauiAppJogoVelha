namespace MauiAppJogoVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "O";
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Button disparador = (Button)sender;
            disparador.IsEnabled = false;

            if (vez == "O")
            {
                disparador.Text = "O";
                vez = "X";
            }
            else
            {

                disparador.Text = "X";
                vez = "O";

            }


            //X GANHA (VARIAVEIS)

            //X ganha linha 1
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
            //X ganha linha 2
            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
            //X ganha linha 3
            if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
            //X ganha coluna 1
            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
            //X ganha coluna 2
            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
            //X ganha coluna 3
            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
            //X ganha diagonal 1
            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
            //X ganha diagonal 2
            if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");


            //O GANHA (VARIAVEIS)

            //O ganha linha 1
            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
            //O ganha linha 2
            if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
            //O ganha linha 3
            if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
            //O ganha coluna 1
            if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
            //O ganha coluna 2
            if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
            //O ganha coluna 3
            if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
            //O ganha diagonal 1
            if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
            //O ganha diagonal 2
            if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");

            if
           (btn10.IsEnabled == false &&
            btn11.IsEnabled == false &&
            btn12.IsEnabled == false &&
            btn21.IsEnabled == false &&
            btn22.IsEnabled == false &&
            btn20.IsEnabled == false &&
            btn30.IsEnabled == false &&
            btn31.IsEnabled == false &&
            btn32.IsEnabled == false
            ) 

            {
                DisplayAlert("Que pena!", "O jogo deu velha", "Fechar");
            }
        }
    } //Fecha a classe Mainpage

} //Fecha o Namespace
