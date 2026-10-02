namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
      
        public MainPage()
        {
            InitializeComponent();
        }

        private void LancarMoedaButton_Clicked(object sender, EventArgs e)
        {
            //Como sortear um lado?
            //Lógica para sortear um lado usando o método Random.Next();
            //Criar uma instância de um novo objeto da classe Random
          Random moeda = new Random();

            //Sorteia um número. O número 2 entre parênteses altera o comportamento do método. Verificar na documentação o que ele significa e testar
            int LadoSorteado = moeda.Next(2);


           //Verifica o que o método Random está devolvendo
           ResultadoLabel.Text = LadoSorteado.ToString();

            //Verificar se o lado que 'caiu' é o mesmo que o usuário selecionou
            if (LadoPicker.SelectedItem =="cara")
            {
                if (LadoSorteado == 0) {
                    //O usuário quis cara e caiu no valor 0
            }
                else
                {
                    //O usuário quis cara e saiu o valor 1
                }

            //Ou

            if (LadoPicker.SelectedIndex ==0)
            {

            }

            //Mostrar para o usuário que el ganhou ou perdeu.

        
        }
    }
}
