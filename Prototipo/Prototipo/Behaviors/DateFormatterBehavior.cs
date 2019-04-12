using Xamarin.Forms;

namespace Prototipo.Behaviors
{
    public class DateFormatterBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += OnTextChanged;

            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= OnTextChanged;

            base.OnDetachingFrom(bindable);
        }

        private static void OnTextChanged(object sender, TextChangedEventArgs args)
        {
            if (args.OldTextValue == null) return;
            var entry = (Entry)sender;
            if (args.NewTextValue.Length < args.OldTextValue.Length) return;

            entry.Text = FormatDate(entry.Text);
        }

        private static string FormatDate(string input)
        {
            if (input.Length > 14)
            {
                input = input.Remove(input.Length - 1);
            }
            else switch (input.Length)
                {
                    case 2:
                        input = input + "/";
                        break;
                    case 5:
                        input = input + "/";
                        break;
                    default: return input;
                }
            return input;
        }
    }
}