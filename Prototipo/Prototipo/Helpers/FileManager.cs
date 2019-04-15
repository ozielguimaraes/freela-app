using Plugin.FilePicker;
using Prototipo.Models;
using System.IO;
using System.Threading.Tasks;

namespace Prototipo.Helpers
{
    public class FileManager
    {
        public static async Task<Documento> ObterDocumentoAsync(string[] fileTypes)
        {
            var pickedFile = await CrossFilePicker.Current.PickFile(fileTypes);
            return new Documento(pickedFile.DataArray, pickedFile.FileName, pickedFile.FilePath);
        }

        public static Stream ObterStream(byte[] byteArray)
        {
            return new MemoryStream(byteArray);
        }
    }
}