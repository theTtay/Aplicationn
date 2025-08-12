namespace ejercicio4._0;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(entryHoras.Text, out double horas) &&
                double.TryParse(entryPagoHora.Text, out double pagoHora))
        {
            double sueldo = horas * pagoHora;
            lblResultado.Text = $"El sueldo semanal es: ${sueldo:F2}";
        }
        else
        {
            lblResultado.Text = "Por favor, ingrese valores numéricos válidos.";
            lblResultado.TextColor = Colors.Red;
        }
    }
}