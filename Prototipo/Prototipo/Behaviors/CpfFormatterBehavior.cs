using Xamarin.Forms;

namespace Prototipo.Behaviors
{
    public class CpfFormatterBehavior : Behavior<Entry>
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

            entry.Text = FormatCpfNumber(entry.Text);
        }

        private static string FormatCpfNumber(string input)
        {
            if (input.Length > 14)
            {
                input = input.Remove(input.Length - 1);
            }
            else switch (input.Length)
                {
                    case 3:
                        input = input + ".";
                        break;
                    case 7:
                        input = input + ".";
                        break;
                    case 11:
                        input = input + "-";
                        break;
                    default: return input;
                }
            return input;
        }
    }
}