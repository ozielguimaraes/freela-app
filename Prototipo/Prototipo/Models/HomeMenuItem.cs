namespace Prototipo.Models
{
    public enum MenuItemType
    {
        Carteira,
        Proposta,
        Browse,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}