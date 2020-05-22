using ComboBox_Dropdown;
using ComboBox_Dropdown.UWP;
using Syncfusion.XForms.UWP.ComboBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomComboBox), typeof(CustomRenderer))]
namespace ComboBox_Dropdown.UWP
{
    /// <summary>
    /// CustomRenderer class
    /// </summary>
    public class CustomRenderer : SfComboBoxRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Syncfusion.XForms.ComboBox.SfComboBox> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                SetInternalProperty(Control, "DropDownButtonMinimumWidth", 0.0);
                SetInternalProperty(Control, "DropDownButtonMinimumHeight", 0.0);
            }
        }
        private static void SetInternalProperty(Syncfusion.XForms.UWP.ComboBox.SfComboBox nativeComboBox, string propertyName, Object value)
        {
            var property = typeof(Syncfusion.XForms.UWP.ComboBox.SfComboBox).GetProperty(propertyName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            if (property != null)
            {
                property.SetValue(nativeComboBox, value);
            }
        }
    }
}
