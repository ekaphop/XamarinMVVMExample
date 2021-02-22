
using Xamarin.Forms;

namespace NewKMA.Services
{
    public class FontSwiftUtils
    {
        public static void UpdateFontStyles()
        {
            // update font styles

            double baseMultiplier;

            baseMultiplier = 1.04d;

            double multiplier = baseMultiplier;

            

            System.Diagnostics.Debug.WriteLine("FontUtils: update font style with multiplier = " + multiplier);

            Color blackColor = Color.Black;

            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 13d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(153, 153, 153));
                Application.Current.Resources["Style-13-Label-Gray"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedMedium");
                style.Setters.Add(Label.FontSizeProperty, 12d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(153, 153, 153));
                Application.Current.Resources["Style-Medium-12-Label-Gray"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedMedium");
                style.Setters.Add(Label.FontSizeProperty, 13d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(153, 153, 153));
                Application.Current.Resources["Style-Medium-13-Label-Gray"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 13d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(58, 48, 48));
                Application.Current.Resources["Style-Bold-13-Label"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedMedium");
                style.Setters.Add(Label.FontSizeProperty, 12d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(111, 95, 94));
                Application.Current.Resources["Style-Medium-12-Label-111-95-94"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 13d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(58, 52, 51));
                Application.Current.Resources["Style-Bold-13-Label-Topic"] = style;
             }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 20d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-20-Label"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedMedium");
                style.Setters.Add(Label.FontSizeProperty, 11d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(153, 153, 153));
                Application.Current.Resources["Style-Medium-11-Label-Gray"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 11d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(153, 153, 153));
                Application.Current.Resources["Style-11-Label-Gray"] = style;
            }
            {
                    Style style = new Style(typeof(Entry));
                    style.Setters.Add(Entry.FontFamilyProperty, "KrungsriCondense");
                    style.Setters.Add(Entry.FontSizeProperty, 17d * multiplier);
                    style.Setters.Add(Entry.TextColorProperty, blackColor);
                    Application.Current.Resources["Style-Swift-Entry-17"] = style;
            }
            {
                    Style style = new Style(typeof(Editor));
                    style.Setters.Add(Entry.FontFamilyProperty, "KrungsriCondense");
                    style.Setters.Add(Entry.FontSizeProperty, 17d * multiplier);
                    style.Setters.Add(Entry.TextColorProperty, blackColor);
                    Application.Current.Resources["Style-Swift-Editor-17"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 12d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(153, 153, 153));
                Application.Current.Resources["Style-12-Label-Gray"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 13d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(58, 52, 51));
                Application.Current.Resources["Style-13-Label-Black"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 17d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(58, 52, 51));
                Application.Current.Resources["Style-17-Label-Black"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 12d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(111, 95, 94));
                Application.Current.Resources["Style-12-Receipt-Detail"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedMedium");
                style.Setters.Add(Label.FontSizeProperty, 13d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Medium-13-Label"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 10d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-10-Label"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 12d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(111, 95, 94));
                Application.Current.Resources["Style-12-Label-111-95-94"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 14d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-14-Label"] = style;
            }
            {
                Style style = new Style(typeof(Entry));
                style.Setters.Add(Entry.FontFamilyProperty, "KrungsriCondense");
                style.Setters.Add(Entry.FontSizeProperty, 20d * multiplier);
                style.Setters.Add(Entry.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Swift-Entry-20"] = style;
            }
        }
    }
}

