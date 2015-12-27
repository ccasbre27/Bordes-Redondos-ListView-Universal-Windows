using BordesRedondos.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BordesRedondos.ViewModel
{
    public class OptionViewModel
    {

        private ObservableCollection <Option> _collectionOptions = new ObservableCollection <Option> ();

        public OptionViewModel()
        {
            _collectionOptions = new ObservableCollection<Option>();

        }

        public ObservableCollection<Option> OptionsCollection
        {
            get
            {
                if (_collectionOptions == null)
                {
                    _collectionOptions = new ObservableCollection<Option>();
                }


                for (int i = 0; i < 20; i++)
                {

                    _collectionOptions.Add(new Option() { Title = "Título #" + i, Image = "Assets/settings.png" });

                }
             
                
                return _collectionOptions;
            }
            set
            {

                _collectionOptions = value;
            }
        }


    }
}
