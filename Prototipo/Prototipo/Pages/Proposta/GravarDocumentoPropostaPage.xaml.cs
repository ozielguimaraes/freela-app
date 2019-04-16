using Prototipo.Helpers;
using Prototipo.Models;
using System;
using System.Linq;
using Xamarin.Forms;

namespace Prototipo.Pages.Proposta
{
    public partial class GravarDocumentoPropostaPage : ContentPage
    {
        private GravarDocumentoPropostaPageModel _pageModel;

        public GravarDocumentoPropostaPage()
        {
            InitializeComponent();

            BindingContext = _pageModel = _pageModel ?? new GravarDocumentoPropostaPageModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (flex.Children?.Count == 0)
            {
                var tapGestureRecognizer = new TapGestureRecognizer
                {
                    NumberOfTapsRequired = 1
                };
                tapGestureRecognizer.Tapped += AdicionarDocumento;

                var add = new Image
                {
                    Source = ImageSource.FromFile("plus"),
                    HeightRequest = 50,
                    WidthRequest = 50
                };

                add.GestureRecognizers.Add(tapGestureRecognizer);
                flex.Children.Add(add);
            }
        }

        private async void AdicionarDocumento(object sender, EventArgs e)
        {
            var documento = await FileManager.ObterDocumentoAsync(Constants.AllowedTypes);
            if (documento == null) return;

            if (!Constants.AllowedTypes.Contains(documento.FileName))
            {
                await _pageModel.MessageService.ShowAsync("Tipo de documento não aceito");
                return;
            }
            Adicionar(documento);
        }

        private void Adicionar(Documento documento)
        {
            _pageModel.Items.Add(documento);

            flex.Children.Add(new Image
            {
                Source = documento.Image,
                HeightRequest = 50,
                WidthRequest = 50
            });
        }
    }
}