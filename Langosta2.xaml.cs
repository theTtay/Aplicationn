namespace Aplicationn;

public partial class Langosta2 : ContentPage
{
	string _tipo;
	int min = 0;
	int max = 0;

	public Langosta2(string tipo)
	{
		InitializeComponent();

		_tipo = tipo;

		if(tipo == "individual")
		{
			min = 1;
			max = 150;
		}
		else if(tipo == "grupal")
		{
			min = 200;
			max = 500;
		}

		Picker();

	}

	 private void Picker()
	 {
		for (int i = min; i <= max; i++)
		{
			Pickerr.Items.Add(i.ToString());
		}

		Pickerr.SelectedIndex = 0;
	 }

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
		var picker = (Picker)sender;

		if (picker.SelectedIndex >= 0)
		{
			Seleccion.Text = picker.Items[picker.SelectedIndex];
		}
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		int cantidad = int.Parse(Seleccion.Text);
		int Total;


        if (cantidad > 300)
		{
			 Total = cantidad * 75;
		}
		else if(cantidad > 200)
		{
			Total = cantidad * 85;
		}
		else
		{
			Total = cantidad * 95;
		}

		TotalL.Text = $"El total a cancelar es de: $ {Total.ToString()}";
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Langosta());
    }
}