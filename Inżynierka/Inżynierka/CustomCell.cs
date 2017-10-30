using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Inżynierka
{
    class CustomCell : ViewCell
    {
        public CustomCell()
        {
            //instantiate items in views
            var Image = new Image();
            var NameLabel = new Label();
            var horizontalLayout = new StackLayout() { BackgroundColor = Color.WhiteSmoke };

            //set bindings
            NameLabel.SetBinding(Label.TextProperty, new Binding("Name"));
            Image.SetBinding(Image.SourceProperty, new Binding("Image"));
            Image.HorizontalOptions = LayoutOptions.Center;
            Image.HeightRequest = 600;
            Image.WidthRequest = 600;
            NameLabel.FontSize = 24;

            //add views to the view hierarchy
            horizontalLayout.Children.Add(NameLabel);
            horizontalLayout.Children.Add(Image);

            //add to parent view
            View = horizontalLayout;
        }
    }
}
