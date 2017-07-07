using System;
using System.Collections.Generic;
using System.Net;
using XamarinFormsMix2.Views.TabbedPages;


using Xamarin.Forms;
using XamarinFormsMix2.Services;

[assembly: Dependency(typeof(Page1) )]

namespace XamarinFormsMix2.Views.TabbedPages
{
    public partial class Page1 : ContentPage
    {

        private string serviceUrl = "https://api.myjson.com/bins/1czns7";
        public ListView _List { get; set; }

        public Page1()
        {
            InitializeComponent();
            GetMonkeyList();
        }


        public void GetMonkeyList ()
         {
            this.Title = "List of Monkeys";


            _List = new ListView();

            _List.ItemTemplate = new DataTemplate(typeof(ImageCell));
            _List.ItemTemplate.SetBinding(TextCell.TextProperty,"Name");
            _List.ItemTemplate.SetBinding(ImageCell.DetailProperty, "Location");
            _List.ItemTemplate.SetBinding(ImageCell.ImageSourceProperty, "Image");

            _List.ItemsSource = DependencyService.Get<IMonkeyService>().GetMonkeys(serviceUrl);
            Content = _List;

        }
    }
}
