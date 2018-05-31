using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GlazerCalc2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        /*public enum TintOptions
        {
            black,
            brown,
            blue
        }*/

       // ObservableCollection<TintOptions> tints = new ObservableCollection<TintOptions>();

        public MainPage()
        {
            this.InitializeComponent();
           
            
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if( widthInput.Text == "" || heightInput.Text == "" || tintDropdown.SelectedValue == null)
            {
                errorBox.Text = "You must input a width, height and tint selection";
            }
            else
            {
                GetResult();
            }
           
        
        }

        private void GetResult()
        {
            var width = double.Parse(widthInput.Text);
            var height = double.Parse(heightInput.Text);

            var woodlength = 2 * (width * height) * 3.25;
            var glassArea = 2 * (width * height);
            var dateString = DateTime.Today.ToString("dd-MM-yyy");

            //Display all the things
            widthDisplay.Text = width.ToString();
            heightDisplay.Text = height.ToString("0.00");
            woodFrameDisplay.Text = woodlength.ToString("0.00");
            areaDisplay.Text = glassArea.ToString("0.00");
            tintSelected.Text = tintDropdown.SelectedValue.ToString();
            //quantitySelected.Text = 
            dateDisplay.Text = dateString;
        }

        private void Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            //quantityDisplay.Text = e.NewValue.ToString();
            var sldrQuantity = sender as Slider;

            var quantity = sldrQuantity.Value;

            quantityDisplay.Text = quantity.ToString();

        }
            // Slider sliderQuantity = sender as Slider;
          
                //quantitySelected.Text = sliderQuantity.Value.ToString("0");
               // var quantity = sliderValue.Value.ToString(" ");

        

        
    }
}
