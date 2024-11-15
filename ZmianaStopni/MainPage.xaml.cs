namespace ZmianaStopni
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var wartosc = Convert.ToDouble(stopnie.Text);
            var typ = rodzaj.SelectedIndex;
            if (typ == 0) //Celcjusze na Faranhaity
            {
                wynik.Text = typ.ToString();
            }
            if (typ == 1) //Farankhaity na Celcjusze
            {
                wynik.Text = typ.ToString();
            }

            
        }
    }

}
