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
using IkeaTabletopApp.View;

namespace IkeaTabletopApp.ViewModel
{
    public class StartsideVM : INotifyPropertyChanged
    {
        private string _akryl;
        private string _laminat;
        private string _massivtræ;
        private string _kvarts;
        private string _vægplade;
        public RelayCommand AkrylToWidthLengthCommand { get; set; }
        public RelayCommand LaminatToWidthLengthCommand { get; set; }
        public RelayCommand MassivtræToWidthLengthCommand { get; set; }
        public RelayCommand KvartsToWidthLengthCommand { get; set; }
        public RelayCommand VægpladeToWidthLengthCommand { get; set; }


        #region Akryl

        public string Akryl
        {
            get { return _akryl; }
            set
            {
                Akryl = value;
                _akryl = value;
            }
        }

        #endregion


        #region Laminat

        public string Laminat
        {
            get { return _laminat; }
            set
            {
                Laminat = value;
                _laminat = value;
            }
        }

        #endregion


        #region Massivtræ

        public string Massivtræ
        {
            get { return _massivtræ; }
            set
            {
                Massivtræ = value;
                _massivtræ = value;
            }
        }

        #endregion


        #region Kvarts

        public string Kvarts
        {
            get { return _kvarts; }
            set
            {
                Kvarts = value;
                _kvarts = value;
            }
        }

        #endregion


        #region Vægplade 

        public string Vægplade
        {
            get { return _vægplade; }
            set
            {
                Vægplade = value;
                _vægplade = value;
            }
        }

        #endregion

        public StartsideVM()
        {
            KvartsToWidthLengthCommand = new RelayCommand(KvartsNavigate);
            VægpladeToWidthLengthCommand = new RelayCommand(VægpladeNavigate);
            AkrylToWidthLengthCommand = new RelayCommand(AkrylNavigate);
            LaminatToWidthLengthCommand = new RelayCommand(LaminatNavigate);
            MassivtræToWidthLengthCommand = new RelayCommand(MassivtræNavigate);
        }

        #region Navigate Funktioner

        public void KvartsNavigate()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof (WidthLengthView));
        }

        public void VægpladeNavigate()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof (WidthLengthView));
        }

        public void AkrylNavigate()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof (WidthLengthView));
        }

        public void LaminatNavigate()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof (WidthLengthView));
        }

        public void MassivtræNavigate()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof (WidthLengthView));
        }

        #endregion


        #region 

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
