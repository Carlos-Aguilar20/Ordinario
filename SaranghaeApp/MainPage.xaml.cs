using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SaranghaeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();

        //    Device.BeginInvokeOnMainThread(async() => {

        //        RestClient cliente = new RestClient();
        //        var productoresult = await cliente.Get<ProductoResult>("http://10.0.2.2:8080/WebAppService/webresources/entity.productos/6");
        //        if (productoresult != null)
        //        {
        //            labelAct.Text = productoresult.descripcion;
        //        }
        //        else
        //        {
        //            labelAct.Text = "El json en Nulo";
        //        }
        //    });

        //}


        private async void Ingresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }

}
