using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace ComboBox_Dropdown
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        /// <summary>
        /// ComboBox ValueChanged event
        /// </summary>
        /// <param name="sender">SfComboBox</param>
        /// <param name="e">Args</param>
        private void ComboBox_ValueChanged(object sender, Syncfusion.XForms.ComboBox.ValueChangedEventArgs e)
        {
            labelText.Text = e.Value;
        }

        /// <summary>
        /// ImageButton clicked event
        /// </summary>
        /// <param name="sender">ImageButton</param>
        /// <param name="e">Args</param>
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            if (comboBox.IsDropDownOpen)
            {
                comboBox.IsDropDownOpen = false;
            }
            else
            {
                comboBox.IsDropDownOpen = true;
            }
        }
    }
}
