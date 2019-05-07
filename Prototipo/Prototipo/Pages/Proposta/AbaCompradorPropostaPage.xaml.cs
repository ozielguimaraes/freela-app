using Xamarin.Forms;

namespace Prototipo.Pages.Proposta
{
    public partial class AbaCompradorPropostaPage : ContentPage
    {
        private readonly AbaCompradorPropostaPageModel _pageModel;

        public AbaCompradorPropostaPage()
        {
            InitializeComponent();
            BindingContext = _pageModel = _pageModel ?? new AbaCompradorPropostaPageModel();
        }

        public delegate void AdicionarDocumentos_Clicked(object sender, System.EventArgs e);




        //public System.Action<object, System.EventArgs> AdicionarDocumentos_Clicked { get; set; }

        //public void AdicionarDocumentos_Clicked(System.Action<object, System.EventArgs> action)
        //{

        //}

    }
}