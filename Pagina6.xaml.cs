namespace Aplicationn;

public partial class Pagina6 : ContentPage
{
	public Pagina6()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        //1 USD = 18.67 MXC
        double dolar = Double.Parse(Uno.Text);

        double pesoMx = dolar * 18.67;
        Dos.Text = Convert.ToString(pesoMx);
    }

    private void Cambiar_Clicked(object sender, EventArgs e)
    {

    }
}