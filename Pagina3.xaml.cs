namespace Aplicationn;

public partial class Pagina3 : ContentPage
{
	public Pagina3()
	{
		InitializeComponent();
	}

    void GenerarTablas()
    {
        var listaColores = new List<Color>
        {
            Colors.LightBlue, Colors.LightGreen, Colors.LightPink,
            Colors.LightYellow, Colors.LightCoral, Colors.LightGray,
            Colors.MistyRose, Colors.PaleTurquoise, Colors.Thistle,
            Colors.Wheat
        };

        for (int tabla = 1; tabla <= 10; tabla++)
        {
            var stack = new StackLayout
            {
                Padding = 10,
                Spacing = 5
            };

            stack.Children.Add(new Label
            {
                Text = $"Tabla del {tabla}",
                FontSize = 18,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            });

            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                int resultado = tabla * multiplicador;
                stack.Children.Add(new Label
                {
                    Text = $"{tabla} × {multiplicador} = {resultado}",
                    FontSize = 16,
                    TextColor = Colors.Black
                });
            }

            var frame = new Frame
            {
                Margin = new Thickness(5),
                BackgroundColor = listaColores[tabla - 1],
                CornerRadius = 12,
                BorderColor = Colors.Black,
                Content = stack,
                WidthRequest = 150,
                VerticalOptions = LayoutOptions.Start // ?? Esto evita que se estire
            };

            MainLayout.Children.Add(frame);
        }
    }

}