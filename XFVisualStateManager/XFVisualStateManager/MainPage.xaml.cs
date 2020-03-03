using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFVisualStateManager
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private Button _lastbutton;
        private Button _lastbutton2;
        public MainPage()
        {

            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //最後に選択したボタンがNullじゃない
            if (_lastbutton != null)
            {
                VisualStateManager.GoToState(_lastbutton, "UnSelectedState");
            }
            _lastbutton = (Button)sender;
            VisualStateManager.GoToState(_lastbutton, "SelectedState");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if(_lastbutton2!=null)
            {
                VisualStateManager.GoToState(_lastbutton2, "Normal");
            }
            _lastbutton2 = (Button)sender;
            VisualStateManager.GoToState(_lastbutton2, "Selected");
        }
    }
}
