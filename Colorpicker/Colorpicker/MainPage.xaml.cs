using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Colorpicker
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private Color editedColor;

        public Color EditedColor
        {
            get => editedColor;
            set { editedColor = value; OnPropertyChanged(); }
        }
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnGetcolors_Clicked(object sender, EventArgs e)
        {
            //yeah

         
            var color2 = colorx.ViewModel.Color;
            var colorhex = colorx.ViewModel.Hex;
            var color22 = colorx.ViewModel.HueColor;

            // aqui estoy tomando varios colores del picker

            // aqui los pondre en labels para que puedan ver sus valores :3

            hex.Text = colorhex.ToString();
            colorp.Text = color2.ToString();
            Hue.Text = color22.ToString();

            //con esto es suficiente
        }
    }
}
