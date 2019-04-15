using Xamarin.Forms;

namespace Prototipo.Models
{
    public class Documento
    {
        public Documento(byte[] fileByte, string fileName, string filePath)
        {
            FileByte = fileByte;
            FileName = fileName;
            FilePath = filePath;
        }

        public byte[] FileByte { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public TipoDocumento TipoDocumento { get; set; }

        public ImageSource Image
        {
            get
            {
                switch (TipoDocumento)
                {
                    case TipoDocumento.Cpf: return ImageSource.FromFile("cpf");
                    case TipoDocumento.Cnh: return ImageSource.FromFile("cnh");
                    case TipoDocumento.Rg: return ImageSource.FromFile("rg");
                    default: return ImageSource.FromFile("outro_doc");
                }
            }
        }
    }
}