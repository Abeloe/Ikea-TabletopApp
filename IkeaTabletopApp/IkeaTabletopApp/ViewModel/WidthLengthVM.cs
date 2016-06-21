using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Eventmaker.Common;
using IkeaTabletopApp.Annotations;
using IkeaTabletopApp.Model;
using IkeaTabletopApp.View;

namespace IkeaTabletopApp.ViewModel
{
   public class WidthLengthVM : INotifyPropertyChanged
    {
        private int _tempWidth;
        private int _tempLength;
        public RelayCommand NavigateToCommand { get; set; }
        public WidthLength WidthLength { get; set; }

        public int TempLength
        {
            get { return _tempLength; }
            set
            {
                Length = value;
                _tempLength = value;

            }
        }

        public int TempWidth
        {
            get { return _tempWidth; }
            set
            {

                Width = value;
                _tempWidth = value;

            }
        }

        public int Width { get; set; }
        public int Length { get; set; }




        public WidthLengthVM()
        {
            NavigateToCommand = new RelayCommand(Navigate);
            //Width = 500;
            //Length = 600;
            WidthLength = new WidthLength();
        }

        public void Setvalue()
        {
            WidthLength.Width = Width;
            WidthLength.Length = Length;
        }
        public void Navigate()
        {
            Setvalue();
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(RectangularFinalView));
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
