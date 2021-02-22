using System;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace NewKMA.Services
{
	public class FontUtils
	{
        public static double CurrentMultiplier { get; private set; }

        public static void UpdateFontStyles()
		{
			// update font styles

			double baseMultiplier;

            baseMultiplier = 1.04d;

            double multiplier = baseMultiplier;


            CurrentMultiplier = multiplier;

            System.Diagnostics.Debug.WriteLine("FontUtils: update font style with multiplier = " + multiplier);

			Color blackColor = Color.Black;

			// text style
			{
				Style style = new Style(typeof(Label));
				style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
				style.Setters.Add(Label.FontSizeProperty, 36d * multiplier);
				style.Setters.Add(Label.TextColorProperty, blackColor);
				Application.Current.Resources["Style-Label-Main"] = style;
			}
			{
				Style style = new Style(typeof(Label));
				style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
				style.Setters.Add(Label.FontSizeProperty, 28d * multiplier);
				style.Setters.Add(Label.TextColorProperty, blackColor);
				Application.Current.Resources["Style-Label-SubMain"] = style;
			}
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 32d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-SubMain-FontSize32"] = style;
            }
            {
				Style style = new Style(typeof(Label));
				style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
				style.Setters.Add(Label.FontSizeProperty, 17d * multiplier);
				style.Setters.Add(Label.TextColorProperty, blackColor);
				Application.Current.Resources["Style-Label-Navigation"] = style;
			}
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 14d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-AssetCompanyHeader"] = style;
            }
			{
				Style style = new Style(typeof(Label));
				style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
				style.Setters.Add(Label.FontSizeProperty, 12d * multiplier);
				style.Setters.Add(Label.TextColorProperty, blackColor);
				Application.Current.Resources["Style-Label-SubNavigation"] = style;
			}
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedMedium");
                style.Setters.Add(Label.FontSizeProperty, 12d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-SubNavigationMedium"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 12d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-SubNavigationBold"] = style;
            }
            {
				Style style = new Style(typeof(Label));
				style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
				style.Setters.Add(Label.FontSizeProperty, 17d * multiplier);
				style.Setters.Add(Label.TextColorProperty, blackColor);
				Application.Current.Resources["Style-Label-MainBody"] = style;
			}
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedMedium");
                style.Setters.Add(Label.FontSizeProperty, 17d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-MainBodyMedium"] = style;
            }

            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 17d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-MainBodyBold"] = style;
            }

            //CR092
            {
				Style style = new Style(typeof(Label));
				style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
				style.Setters.Add(Label.FontSizeProperty, 17d * multiplier);
				style.Setters.Add(Label.TextColorProperty, blackColor);
                style.Setters.Add(Label.LineBreakModeProperty, LineBreakMode.WordWrap);
                Application.Current.Resources["Style-Label-MainBodyBold-Wrap"] = style;
			}

            {
				Style style = new Style(typeof(Label));
				style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
				style.Setters.Add(Label.FontSizeProperty, 12d * multiplier);
				style.Setters.Add(Label.TextColorProperty, blackColor);
				Application.Current.Resources["Style-Label-SubBody"] = style;
			}

            //CR059
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 11d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-SubBodySmall"] = style;
            }

            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedMedium");
                style.Setters.Add(Label.FontSizeProperty, 12d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-SubBodyMedium"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 12d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-SubBodyBold"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 13d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-Small"] = style;
            }
            {
				Style style = new Style(typeof(Label));
				style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
				style.Setters.Add(Label.FontSizeProperty, 13d * multiplier);
				style.Setters.Add(Label.TextColorProperty, Color.FromRgb(144,110,107));
				Application.Current.Resources["Style-Label-Action"] = style;
			}
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedMedium");
                style.Setters.Add(Label.FontSizeProperty, 13d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(58, 48, 48));
                Application.Current.Resources["Style-Label-SubBodyMedium"] = style;
            }
			{
				Style style = new Style(typeof(Label));
				style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
				style.Setters.Add(Label.FontSizeProperty, 10d);
				style.Setters.Add(Label.TextColorProperty, Color.FromRgb(144,110,107));
				Application.Current.Resources["Style-Label-Action2"] = style;
			}
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 13d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(144, 110, 107));
                Application.Current.Resources["Style-Label-Action-Normal"] = style;
            }
            {
				Style style = new Style(typeof(Label));
				style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 12d * Math.Min(1,baseMultiplier));
                //style.Setters.Add(Label.TextColorProperty, (Color)Application.Current.Resources["BrownishGrayColor"]);
				Application.Current.Resources["Style-Label-Menu"] = style;
			}
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 15d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(144, 110, 107));
                Application.Current.Resources["Style-Label-Action3"] = style;
            }

            #region ***CR042 Car4Cash ยอดผ่อนชำระ***
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedMedium");
                style.Setters.Add(Label.FontSizeProperty, 36d * multiplier);
                //style.Setters.Add(Label.TextColorProperty, (Color)Application.Current.Resources["AquaGreenColor"]);
                Application.Current.Resources["Style-Label-Installment"] = style;
            }
            #endregion
            // number
            {
                Style style = new Style(typeof(Label));
				style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
				style.Setters.Add(Label.FontSizeProperty, 36d * multiplier);
				style.Setters.Add(Label.TextColorProperty, blackColor);
				Application.Current.Resources["Style-Label-Input"] = style;
			}
			{
				Style style = new Style(typeof(Label));
				style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
				style.Setters.Add(Label.FontSizeProperty, 20d * multiplier);
				style.Setters.Add(Label.TextColorProperty, blackColor);
				Application.Current.Resources["Style-Label-AvailableAmount"] = style;
			}
			{
				Style style = new Style(typeof(Label));
				style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
				style.Setters.Add(Label.FontSizeProperty, 20d * multiplier);
				style.Setters.Add(Label.TextColorProperty, blackColor);
				Application.Current.Resources["Style-Label-MainNumber"] = style;
			}
			{
				Style style = new Style(typeof(Label));
				style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
				style.Setters.Add(Label.FontSizeProperty, 17d * multiplier);
				style.Setters.Add(Label.TextColorProperty, blackColor);
				Application.Current.Resources["Style-Label-SubNumber1"] = style;
			}
			{
				Style style = new Style(typeof(Label));
				style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
				style.Setters.Add(Label.FontSizeProperty, 12d * multiplier);
				style.Setters.Add(Label.TextColorProperty, blackColor);
				Application.Current.Resources["Style-Label-SubNumber2"] = style;
			}
            #region ***CR052 CrossBorder*** **เมื่อ enlarge จะไม่ enlarge**
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 26d * baseMultiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-CrossBorderAmount"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 20d * baseMultiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-CrossBorderAmountResize"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 10d * baseMultiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-CrossBorderCurrencyCode"] = style;
            }
            #endregion

            // entry
            {
                Style style = new Style(typeof(Entry));
				style.Setters.Add(Entry.FontFamilyProperty, "KrungsriCondensed");
				style.Setters.Add(Entry.FontSizeProperty, 17d * multiplier);
				style.Setters.Add(Entry.TextColorProperty, blackColor);
				style.Setters.Add(Entry.PlaceholderColorProperty, Color.FromHex("#B2B2B2"));
				Application.Current.Resources["Style-Entry-MainBody"] = style;
			}
            {
                Style style = new Style(typeof(Entry));
                style.Setters.Add(Entry.FontFamilyProperty, "KrungsriCondensedMedium");
                style.Setters.Add(Entry.FontSizeProperty, 17d * multiplier);
                style.Setters.Add(Entry.TextColorProperty, blackColor);
                style.Setters.Add(Entry.PlaceholderColorProperty, Color.FromHex("#B2B2B2"));
                Application.Current.Resources["Style-Entry-MainBodyMedium"] = style;
            }

			// editor
			{
				Style style = new Style(typeof(Editor));
				style.Setters.Add(Editor.FontFamilyProperty, "KrungsriCondensed");
				style.Setters.Add(Editor.FontSizeProperty, 17d * multiplier);
				style.Setters.Add(Editor.TextColorProperty, blackColor);
				Application.Current.Resources["Style-Editor-MainBody"] = style;
			}

            // buttons
            {
				Style style = new Style(typeof(Button));
				style.Setters.Add(Button.FontFamilyProperty, "KrungsriCondensedBold");
				style.Setters.Add(Button.FontSizeProperty, 17d * multiplier);
				style.Setters.Add(Button.TextColorProperty, blackColor);
				style.Setters.Add(VisualElement.BackgroundColorProperty, Color.FromRgb(249, 205, 0));
				style.Setters.Add(Button.CornerRadiusProperty, 0);
				style.Setters.Add(VisualElement.HeightRequestProperty, 54d);

				Trigger disabledTrigger = new Trigger(typeof(Button))
				{
					Property = VisualElement.IsEnabledProperty,
					Value = false
				};
				disabledTrigger.Setters.Add(Button.TextColorProperty, Color.FromHex("#2C2525"));
				disabledTrigger.Setters.Add(VisualElement.BackgroundColorProperty, Color.FromHex("#C5C5C5"));

				style.Triggers.Add(disabledTrigger);
				Application.Current.Resources["Style-Button-Primary"] = style;
			}
			{
				Style style = new Style(typeof(Button));
				style.Setters.Add(Button.FontFamilyProperty, "KrungsriCondensedBold");
				style.Setters.Add(Button.FontSizeProperty, 17d * multiplier);
				style.Setters.Add(Button.TextColorProperty, Color.White);
				style.Setters.Add(VisualElement.BackgroundColorProperty, Color.FromHex("#3E3E3E"));
				style.Setters.Add(Button.CornerRadiusProperty, 0);
				style.Setters.Add(VisualElement.HeightRequestProperty, 54d);

				Trigger disabledTrigger = new Trigger(typeof(Button))
				{
					Property = VisualElement.IsEnabledProperty,
					Value = false
				};
				disabledTrigger.Setters.Add(Button.TextColorProperty, Color.FromHex("#CCCCCC"));
				disabledTrigger.Setters.Add(VisualElement.BackgroundColorProperty, Color.FromHex("#3E3E3E"));

				style.Triggers.Add(disabledTrigger);
				Application.Current.Resources["Style-Button-Secondary"] = style;
			}
			{
				double fontSize = 30d * multiplier;

				Style style = new Style(typeof(Button));
				style.Setters.Add(Button.FontFamilyProperty, "KrungsriCondensedBold");
				style.Setters.Add(Button.FontSizeProperty, fontSize);
				style.Setters.Add(Button.TextColorProperty, blackColor);
				style.Setters.Add(VisualElement.BackgroundColorProperty, Color.FromRgb(249, 205, 0));
				style.Setters.Add(Button.CornerRadiusProperty, 0);
				Application.Current.Resources["Style-Button-Numpad"] = style;
			}
			{
				double fontSize = 30d * multiplier;

				Style style = new Style(typeof(Button));
				style.Setters.Add(Button.FontFamilyProperty, "KrungsriCondensedBold");
				style.Setters.Add(Button.FontSizeProperty, fontSize);
				style.Setters.Add(Button.TextColorProperty, blackColor);
				style.Setters.Add(VisualElement.BackgroundColorProperty, Color.FromRgb(249, 205, 0));
				style.Setters.Add(Button.CornerRadiusProperty, 0);
				Application.Current.Resources["Style-Button-NumpadSmall"] = style;
			}
			{
				double fontSize = 18d * multiplier;

				Style style = new Style(typeof(Button));
				style.Setters.Add(Button.FontFamilyProperty, "KrungsriCondensedBold");
				style.Setters.Add(Button.FontSizeProperty, fontSize);
				style.Setters.Add(Button.TextColorProperty, blackColor);
				style.Setters.Add(VisualElement.BackgroundColorProperty, Color.FromRgb(249, 205, 0));
				style.Setters.Add(Button.CornerRadiusProperty, 0);
				Application.Current.Resources["Style-Button-Numpad-Action"] = style;
			}
			{
				Style style = new Style(typeof(Button));
				style.Setters.Add(Button.FontFamilyProperty, "KrungsriCondensedBold");
				style.Setters.Add(Button.FontSizeProperty, 17d * multiplier);
				style.Setters.Add(Button.TextColorProperty, blackColor);
				style.Setters.Add(VisualElement.BackgroundColorProperty, Color.FromRgb(249, 205, 0));
				style.Setters.Add(Button.CornerRadiusProperty, 0);
				style.Setters.Add(VisualElement.HeightRequestProperty, 54d);

				Trigger disabledTrigger = new Trigger(typeof(Button))
				{
					Property = VisualElement.IsEnabledProperty,
					Value = false
				};
				disabledTrigger.Setters.Add(Button.TextColorProperty, Color.FromHex("#2C2525"));

				style.Triggers.Add(disabledTrigger);
				Application.Current.Resources["Style-Button-NumpadNext"] = style;
			}
			{
				Style style = new Style(typeof(Button));
				style.Setters.Add(Button.FontFamilyProperty, "KrungsriCondensedBold");
				style.Setters.Add(Button.FontSizeProperty, 13d * multiplier);
				style.Setters.Add(Button.TextColorProperty, Color.FromRgb(144, 110, 107));
				style.Setters.Add(VisualElement.BackgroundColorProperty, Color.Transparent);
				style.Setters.Add(VisualElement.HeightRequestProperty, 25d);
				style.Setters.Add(Button.CornerRadiusProperty, 2);

				Trigger disabledTrigger = new Trigger(typeof(Button))
				{
					Property = VisualElement.IsEnabledProperty,
					Value = false
				};
				disabledTrigger.Setters.Add(Button.TextColorProperty, Color.Black);
				disabledTrigger.Setters.Add(VisualElement.BackgroundColorProperty, Color.FromRgb(249, 205, 0));

				style.Triggers.Add(disabledTrigger);
				Application.Current.Resources["Style-Button-Action"] = style;
			}
            {
                Style style = new Style(typeof(Button));
                style.Setters.Add(Button.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Button.FontSizeProperty, 13d * multiplier);
                style.Setters.Add(Button.TextColorProperty, Color.FromRgb(144, 110, 107));
                style.Setters.Add(VisualElement.BackgroundColorProperty, Color.Transparent);
                style.Setters.Add(VisualElement.HeightRequestProperty, 25d);
                style.Setters.Add(Button.CornerRadiusProperty, 2);

                Trigger disabledTrigger = new Trigger(typeof(Button))
                {
                    Property = VisualElement.IsEnabledProperty,
                    Value = false
                };
                disabledTrigger.Setters.Add(Button.TextColorProperty, Color.White);

                style.Triggers.Add(disabledTrigger);
                Application.Current.Resources["Style-Button-NAV"] = style;
            }

            // additional styles
            {
				Style style = new Style(typeof(Entry));
				style.Setters.Add(Entry.FontFamilyProperty, "KrungsriCondensed");
				style.Setters.Add(Entry.FontSizeProperty, 17d * multiplier);
				style.Setters.Add(Entry.TextColorProperty, Color.FromHex("#F62529"));
				style.Setters.Add(Entry.PlaceholderColorProperty, Color.FromHex("#B2B2B2"));
				Application.Current.Resources["Style-Entry-MainBody-Error"] = style;
			}
			{
				Style style = new Style(typeof(Label));
				style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
				style.Setters.Add(Label.FontSizeProperty, 17d * multiplier);
				style.Setters.Add(Label.TextColorProperty, Color.FromHex("#B2B2B2"));
				Application.Current.Resources["Style-Label-MainBody-Placeholder"] = style;
			}
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 12d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-SubBodyBold"] = style;
            }
            //RTP
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 12d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromHex("#00A6FF"));
                Application.Current.Resources["Style-Label-SubNavigation-AzureColor"] = style;
            }
            //Robo
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 10d);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-ActionBlack"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 20d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromHex("#6f5f5e"));
                Application.Current.Resources["Style-Label-Question"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 13d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(111,95,94));
                Application.Current.Resources["Style-Label-SubBodyRobo"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 13d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(111, 95, 94));
                Application.Current.Resources["Style-Label-SubBodyRoboBold"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 17d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(111, 95, 94));
                Application.Current.Resources["Style-Label-LabelMainBodyRobo"] = style;
            }
            //CR024
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 13d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromHex("#ffffff"));
                Application.Current.Resources["Style-Label-SubBody-white"] = style;
            }
            //RoboMVP2
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 14d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(153, 153, 153));
                Application.Current.Resources["Style-Label-Detail-Entry-Robo"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 14d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-Type-Robo"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 14d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(111 ,95, 94));
                Application.Current.Resources["Style-Label-Option-Robo"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 20d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromHex("#6f5f5e"));
                Application.Current.Resources["Style-Label-Question-Bold"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 40d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromHex("#3a3433"));
                Application.Current.Resources["Style-Label-Amount-Robo-Graph"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedMedium");
                style.Setters.Add(Label.FontSizeProperty, 17d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(111, 95, 94));
                Application.Current.Resources["Style-Label-RoboBodyMedium"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedMedium");
                style.Setters.Add(Label.FontSizeProperty, 17d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(58, 48 ,48));
                Application.Current.Resources["Style-Label-RoboBodyMedium-Black"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedMedium");
                style.Setters.Add(Label.FontSizeProperty, 14d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(58, 48, 48));
                Application.Current.Resources["Style-Label-RoboSubBodyMedium"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 14d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-Small-Robo"] = style;
            }

            //Facebook Pay
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 20d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.Black);
                Application.Current.Resources["Label_SizeM_Primary"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 19d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.Black);
                Application.Current.Resources["Label_SizeM_HeaderBold"] = style;
            }

          
            //KSE
            {
	            Style style = new Style(typeof(Label));
	            style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
	            style.Setters.Add(Label.FontSizeProperty, 24d * multiplier);
	            style.Setters.Add(Label.TextColorProperty, blackColor);
	            Application.Current.Resources["Style-Label-KSE-Privilege-Header"] = style;
            }
            //RSP
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 11d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-small-RSP"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 8d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-small-datesuffix"] = style;
            }

            // OrdinaryNo
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 8d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(144, 110, 107));
                Application.Current.Resources["Style-Label-small-datesuffixbrown"] = style;
            }

            //BScanC
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 36d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(74, 74, 74));
                Application.Current.Resources["Style-Number-Countdown"] = style;
            }

            //// OrdinaryNo
            //{
            //    Style style = new Style(typeof(Label));
            //    style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
            //    style.Setters.Add(Label.FontSizeProperty, 8d * multiplier);
            //    style.Setters.Add(Label.TextColorProperty, blackColor);
            //    Application.Current.Resources["Style-Label-MainBodyBold-"] = style;
            //}
            // FSS
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 14d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-FSSTitle"] = style;
            }
            //BScanC
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 11d * multiplier);//224 32 32
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(224, 32, 32));
                Application.Current.Resources["Style-Label-small-red-bscanc"] = style;
            }
            // Email
            {
                Style style = new Style(typeof(Editor));
                style.Setters.Add(Editor.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Editor.FontSizeProperty, 12d * multiplier);
                style.Setters.Add(Editor.TextColorProperty, Color.FromRgb(150, 117, 115));
                Application.Current.Resources["Style-Email-Resent"] = style;
            }
            {
                Style style = new Style(typeof(Editor));
                style.Setters.Add(Editor.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Editor.FontSizeProperty, 12d * multiplier);
                style.Setters.Add(Editor.TextColorProperty, Color.FromRgb(153, 153, 153));
                Application.Current.Resources["Style-Email-MainDes"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 12d * multiplier);//224 32 32
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(224, 32, 32));
                Application.Current.Resources["Style-Email-Error_MSG"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 11d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-CoopMedium"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Editor.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Editor.FontSizeProperty, 11d * multiplier);
                style.Setters.Add(Editor.TextColorProperty, Color.FromRgb(201, 193, 193));
                Application.Current.Resources["Style-Label-SubBankName"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 17d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(201, 193, 193));
                Application.Current.Resources["Style-Label-MainBodyBold_Inactive"] = style;
            }

            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedMedium");
                style.Setters.Add(Label.FontSizeProperty, 12d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(153, 153, 153));
                Application.Current.Resources["Style-Label-Subject-NewSuit"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedMedium");
                style.Setters.Add(Label.FontSizeProperty, 12d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(144,110,107));
                Application.Current.Resources["Style-Label-Subject-NewSuit-Brown"] = style;
			}
            //receipt 
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 22d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromRgb(58, 52, 51));
                Application.Current.Resources["Style-Label-Main-receipt-title"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 14d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromHex("#999999"));// WarmGrayColor
                Application.Current.Resources["Style-Label-Main-Receipt-RowHeader"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 14d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.Black);
                Application.Current.Resources["Style-Label-Main-Receipt-RowData"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 14d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromHex("#6F5F5E"));// BrownishGrayColor
                Application.Current.Resources["Style-Label-Main-Receipt-RowDetail"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 12d * multiplier);
                style.Setters.Add(Label.TextColorProperty, Color.FromHex("#999999"));// WarmGrayColor
                Application.Current.Resources["Style-Label-Main-Receipt-QRCDesc"] = style;
            }
            //One consent
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 20d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-OneConsent-Header"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensed");
                style.Setters.Add(Label.FontSizeProperty, 11d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-OneConsent"] = style;
            }
            {
                Style style = new Style(typeof(Label));
                style.Setters.Add(Label.FontFamilyProperty, "KrungsriCondensedBold");
                style.Setters.Add(Label.FontSizeProperty, 11d * multiplier);
                style.Setters.Add(Label.TextColorProperty, blackColor);
                Application.Current.Resources["Style-Label-OneConsent-Bold"] = style;
            }
        }
    }
}
