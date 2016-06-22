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
using IkeaTabletopApp.Persistency;
using IkeaTabletopApp.View;

namespace IkeaTabletopApp.ViewModel
{
    public class RectangularFinalVM : INotifyPropertyChanged
    {
        
        public int Width { get; set; }
        public int Length { get; set; }
        public ListWidthLengthSingleton ListWidthLengthSingleton { get; set; }
        public RelayCommand NavigateToWidthLengthCommand { get; set; }
      

        public RectangularFinalVM()
        {
            ListWidthLengthSingleton= ListWidthLengthSingleton.Intance;
            
            SetTableSize();
            NavigateToWidthLengthCommand = new RelayCommand(NavigateToWidtgLength);
            // WidthLengthVm = new WidthLengthVM();
            //Test=new WidthLength(WidthLengthVm.WidthLengthClass.Width,WidthLengthVm.WidthLengthClass.Length);


        }

        public void NavigateToWidtgLength()
        {
            ListWidthLengthSingleton.ListObjSingletonList.Clear();
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(WidthLengthView));
        }

        public void SetTableSize()
        {
            Width = ListWidthLengthSingleton.ListObjSingletonList[0].Width;
            Length = ListWidthLengthSingleton.ListObjSingletonList[0].Length;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
