using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SaranghaeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            
        }
    
        private async void Mostrar_Clicked(object sender, EventArgs e)
        {
            HttpClient cliente = new HttpClient();
            var response = await cliente.GetAsync("http://192.168.1.86:26601/Ordinari/webresources/ordinario.problemas");
            var jsonString = await response.Content.ReadAsStringAsync();
            List<ProblemasResult> lisde = new List<ProblemasResult>();


            if (jsonString != null)
            {
                lisde = JsonConvert.DeserializeObject<List<ProblemasResult>>(jsonString);
                listviewproductos.ItemsSource = lisde;
            }
        }
    }
}