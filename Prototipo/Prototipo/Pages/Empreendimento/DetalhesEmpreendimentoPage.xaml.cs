using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototipo.Pages.Empreendimento
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalhesEmpreendimentoPage : ContentPage
    {
        private readonly DetalhesEmpreendimentoPageModel _pageModel;

        public DetalhesEmpreendimentoPage(Models.Empreendimento model)
        {
            InitializeComponent();
            BindingContext = _pageModel = _pageModel ?? new DetalhesEmpreendimentoPageModel(model);
        }
    }
}