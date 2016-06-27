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
using IkeaTabletopApp.Annotations;
using IkeaTabletopApp.Model;
using IkeaTabletopApp.Persistency;
using IkeaTabletopApp.View;

namespace IkeaTabletopApp.ViewModel
{
   public class WidthLengthVM : INotifyPropertyChanged
    {
       public MaterialeSingleton MaterialeSingleton { get; set; }
        private int _tempWidth;
        private int _tempLength;
        public RelayCommand NavigateToCommand { get; set; }
       public WidthLength WidthLengthClass { get; set; }
       public ListWidthLengthSingleton ListWidthLengthSingleton { get; set; }
        public string Navn { get; set; }

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
            ListWidthLengthSingleton= ListWidthLengthSingleton.Intance;
            MaterialeSingleton = MaterialeSingleton.Intance;
           // Navn = MaterialeSingleton.ListMaterialeSingleton[0];
           NavnMateriale();

        }

        public void NavnMateriale()
        {
            //if (MaterialeSingleton.ListMaterialeSingleton.Count == 1)
            {
                 Navn = MaterialeSingleton.ListMaterialeSingleton[0];
            }
           
        }
        public void test()
       {
            ListWidthLengthSingleton.ListObjSingletonList.Add(new WidthLength(Width,Length));
          
        }
      
        
        public void Navigate()
        {
           test();
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
