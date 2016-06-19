using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.System.Threading;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Eventmaker.Common;
using IkeaTabletopApp.Annotations;
using IkeaTabletopApp.Model;
using IkeaTabletopApp.View;

namespace IkeaTabletopApp.ViewModel
{
    public class RectangularFinalVM : INotifyPropertyChanged
    {
        private int _tempWidth;
        private int _tempLength;
        public RelayCommand NavigateToCommand { get; set; }
        public string TempLength { get; set; }
        public string TempWidth { get; set; }

        //public int TempLength
        //{
        //    get { return _tempLength; }
        //    set
        //    {
        //        _tempLength = value;
                
        //    }
        //}

        //public int TempWidth
        //{
        //    get { return _tempWidth; }
        //    set
        //    {
                
        //        Width = value;
        //        _tempWidth = value;
              
        //    }
        //}

        public int Width { get; set; }
        public int Length { get; set; }

        
       

        public RectangularFinalVM()
        {
            NavigateToCommand = new RelayCommand(Navigate);
            //Width = 500;
            //Length = 600;
            
        }

        public void Setvalue()
        {
            int x = Int32.Parse(TempWidth);
            int y = Int32.Parse(TempLength);
            x = Width;
            y = Length;
        }
        public void Navigate()
        {
            Setvalue();
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof (RectangularFinalView));
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
