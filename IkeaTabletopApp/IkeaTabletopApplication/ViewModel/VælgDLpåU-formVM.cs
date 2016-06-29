﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Eventmaker.Common;
using IkeaTabletopApplication.Annotations;
using IkeaTabletopApplication.Model;
using IkeaTabletopApplication.Singleton;
using IkeaTabletopApplication.VIew;

namespace IkeaTabletopApplication.ViewModel
{
    public class VælgDLpåU_formVM:INotifyPropertyChanged
    {
        public DLClass DL { get; set; }
        public DLSingleton DlSingleton { get; set; }
        public RelayCommand NavigateToMaterialeCommand { get; set; }

        public VælgDLpåU_formVM()
        {
            DL = new DLClass();
            DlSingleton = DLSingleton.Instance;
            NavigateToMaterialeCommand = new RelayCommand(NavigateToMateriale);
            DL.C = 635;
            DL.F = 635;

        }

        public void NavigateToMateriale()
        {
            DL.G = DL.E - DL.C;
            DL.H = DL.D - DL.A - DL.F;
            DL.I = DL.B - DL.C;
            DlSingleton.ListDLSingleton.Add(DL);
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(VælgMateriale));
        }

        #region propertychanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    } 
    #endregion
}
