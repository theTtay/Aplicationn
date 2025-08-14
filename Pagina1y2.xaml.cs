namespace Aplicationn;

public partial class Pagina1y2 : ContentPage
{
    private bool isCounting = false;

    public Pagina1y2()
	{
		InitializeComponent();
	}

    private async void btnStart_Clicked(object sender, EventArgs e)
    {
        if (isCounting)
            return;

        isCounting = true;
        btnStart.IsEnabled = false;

        for (int i = 10; i >= 0; i--)
        {
            lblCountdown.Text = i.ToString();

            await lblCountdown.FadeTo(1, 200); // Aparece
            await lblCountdown.ScaleTo(1.2, 300, Easing.CubicOut); // Se agranda
            await lblCountdown.ScaleTo(1.0, 300, Easing.CubicIn); // Vuelve a su tamaño normal

            if (i > 0)
            {
                await Task.Delay(800); // Pausa entre números
                await lblCountdown.FadeTo(0, 200); // Desaparece para el siguiente número
            }
        }

        lblCountdown.Text = "¡Listo!";
        lblCountdown.FadeTo(1, 500);
        lblCountdown.ScaleTo(1.5, 500, Easing.SpringOut);

        btnStart.IsEnabled = true;
        isCounting = false;

    }
}