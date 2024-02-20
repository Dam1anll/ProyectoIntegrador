using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoIntegrador.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SensoresView : ContentPage
    {
        public SensoresView()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }
    }
}