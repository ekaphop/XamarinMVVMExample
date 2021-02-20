using System;
using Xamarin.Forms;

namespace FavoriteTest.Views.ClearPeople
{
    public partial class ExpandableLabel : ContentView
    {
        //https://www.clearpeople.com/blog/xamarin.forms-how-to-create-a-contentview-with-expandable-functionality
        private bool _IsExpanded;
        private bool _IsExpanding;
         
        public ExpandableLabel()
        {
            InitializeComponent();
            ExpandableLayout.HeightRequest = 0;
            ExpandableText.Text = Text;
            TitleText.Text = Title;
        }

        public static readonly BindableProperty TitleProperty = BindableProperty.Create(
        propertyName: "Title",
        returnType: typeof(string),
        declaringType: typeof(ExpandableLabel),
        defaultValue: default(string));

        public static readonly BindableProperty TextProperty = BindableProperty.Create(
        propertyName: "Text",
        returnType: typeof(string),
        declaringType: typeof(ExpandableLabel),
        defaultValue: default(string));

        public string Title
        {
            get
            {
                return (string)GetValue(TitleProperty);
            }
            set
            {
                SetValue(TitleProperty, value);
            }
        }

        public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }
            set
            {
                SetValue(TextProperty, value);
            }
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == TitleProperty.PropertyName)
            {
                TitleText.Text = Title;
            }
            else if (propertyName == TextProperty.PropertyName)
            {
                ExpandableText.Text = Text;
            }
        }

        private async void Title_Clicked(object sender, EventArgs e)
        {
            if (!_IsExpanding)
            {
                _IsExpanding = true;
                var height = ExpandableContent.Height;
                if (_IsExpanded)
                {
                    var animation = new Animation(v => ExpandableLayout.HeightRequest = v, height, 0);
                    await ExpandableLayout.FadeTo(0, 250);
                    animation.Commit(this, "ExpandSize", 16, 250);
                }
                else
                {
                    var animation = new Animation(v => ExpandableLayout.HeightRequest = v, 0, height);
                    animation.Commit(this, "ExpandSize", 16, 250);
                    await ExpandableLayout.FadeTo(1, 250);
                }
                _IsExpanded = !_IsExpanded;
                _IsExpanding = false;
            }
            else
            {

            }
        }
    }
}
