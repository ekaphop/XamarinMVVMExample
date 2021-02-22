using Xamarin.Essentials;
using Xamarin.Forms;
namespace NewKMA.Services
{
    public class FontFavoriteUtils
    {
        public static void UpdateFontStyles()
        {
            // update font styles
            double baseMultiplier;

            // find basic size
            baseMultiplier = 1.04d;

            double multiplier = baseMultiplier;


            System.Diagnostics.Debug.WriteLine("FontUtils: update font style with multiplier = " + multiplier);

            Color blackColor = Color.FromHex("3A3433");
            Color grayColor = Color.FromHex("999999");
            Color yellowColor = Color.FromHex("F9CD00");
            Color whiteColor = Color.FromHex("FFFFFF");

            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 18d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Favorite-Header-Label-Black"] = style;
            }

            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 16d * multiplier);
                style.Setters.Add(Label.TextColorProperty, grayColor);
                Application.Current.Resources["Style-Favorite-Title-Label-Gray"] = style;
            }
        }
    }
}