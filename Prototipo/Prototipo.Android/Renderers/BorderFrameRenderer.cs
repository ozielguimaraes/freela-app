using Android.Content;
using Android.Graphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

//[assembly: ExportRenderer(typeof(Frame), typeof(Prototipo.Droid.Renderers.BorderFrameRenderer))]
namespace Prototipo.Droid.Renderers
{
    //public class BorderFrameRenderer : FrameRenderer
    //{
    //    public override void Draw(Canvas canvas)
    //    {
    //        base.Draw(canvas);
    //        using (var strokePaint = new Paint())
    //        using (var rect = new RectF(0, 0, canvas.Width, canvas.Height))
    //        {
    //            // stroke
    //            strokePaint.SetStyle(Paint.Style.Stroke);
    //            strokePaint.Color = Element.BorderColor.ToAndroid();
    //            strokePaint.StrokeWidth = 5;

    //            canvas.DrawRoundRect(rect, Element.CornerRadius * 2, Element.CornerRadius * 2, strokePaint);  // stroke
    //        }
    //    }

    //    public BorderFrameRenderer(Context context) : base(context)
    //    {
    //    }

    //    protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
    //    {
    //        base.OnElementChanged(e);
    //    }
    //}
}