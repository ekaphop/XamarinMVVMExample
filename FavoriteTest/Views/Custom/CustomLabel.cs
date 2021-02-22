using System;
using Xamarin.Forms;

namespace NewKMA.Views.Custom
{
	public class CustomLabel : Label
	{
        //public static readonly BindableProperty MaxLineEllipsizeProperty = BindableProperty.Create(nameof(MaxLineEllipsize), typeof(int?), typeof(CustomLabel), 1, defaultBindingMode: BindingMode.TwoWay);

        public new float LineHeight { get; set; }

		public float LetterSpacing { get; set; }

        public bool IsEllipsize { get; set; }

        public int MaxLineEllipsize { get; set; }

        public CustomLabel()
		{   
            MaxLineEllipsize = 1;
        }
	}
}

