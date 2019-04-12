using Prototipo.AssertionConcerns;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace Prototipo.Behaviors
{
    public class CpfValidatorBehavior : Behavior<Entry>
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
            if (string.IsNullOrWhiteSpace(args.NewTextValue)) return;

            var digitsRegex = new Regex(@"[^\d]");
            var digits = digitsRegex.Replace(args.NewTextValue, "");
            var itsComplete = digits.Length == 11;

            ((Entry)sender).TextColor = !itsComplete ? Color.Default : CpfAssertionConcern.IsValid(digits) ? Color.Green : Color.Red;
        }
    }
}