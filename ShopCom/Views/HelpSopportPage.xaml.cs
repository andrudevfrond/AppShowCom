namespace ShopCom.Views;

public partial class HelpSopportPage : ContentPage
{
	public HelpSopportPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		var dataObject = Resources["data"] as HelpSopportData;
		dataObject.VisitsPenddings = 30;
    }
}


