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
        public WidthLengthVM WidthLengthVm { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }

        public RectangularFinalVM()
        {
            WidthLengthVm = new WidthLengthVM();
            //Width = Int32.Parse(WidthLengthVm.Width);
            //Length = Int32.Parse(WidthLengthVm.Length);
        }




        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
