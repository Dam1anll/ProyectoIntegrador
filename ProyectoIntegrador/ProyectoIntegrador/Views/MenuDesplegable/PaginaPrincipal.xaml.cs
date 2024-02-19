using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoIntegrador.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoIntegrador.Views.MenuDesplegable
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaPrincipal : MasterDetailPage
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
            this.Master = new MenuDes();
            this.Detail = new NavigationPage(new HomeView());
            App.MasterDet = this;
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}