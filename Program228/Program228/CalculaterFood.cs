using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Program228
{
    public class CalculateFood : INotifyPropertyChanged
    {
        private int _age;
        private double _weight;
        private double _height;
        private double _grams;

        public ICommand Calculate { get; set; }

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        public double Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                OnPropertyChanged(nameof(Weight));
            }
        }

        public double Height
        {
            get { return _height; }
            set
            {
                _height = value;
                OnPropertyChanged(nameof(Height));
            }
        }
        public double Grams
        {
            get { return _grams; }
            set
            {
                _grams = value;
                OnPropertyChanged(nameof(Grams));
            }
        }

        public CalculateFood()
        {
            Age = 3;
            Weight = 11;
            Height = 77;
            Calculate = new RelayCommand(CalculateGramsEx, CanCalculateGrams);
        }

        private bool CanCalculateGrams(object arg)
        {
            return true;
        }

        public virtual double CalculateGrams()
        {
            return (Height + Weight) * Age;
        }
        public void CalculateGramsEx(object obj)
        {
            SmallFood sm = new SmallFood();
            AverageFood av = new AverageFood();
            AdultFood ad = new AdultFood();

            if (Age < 3)
                Grams = sm.CalculateGrams();
            else if (Age > 3 && Age < 7)
                Grams = av.CalculateGrams();
            else if (Age >= 7)
                Grams = ad.CalculateGrams();
            else
                Grams = CalculateGrams();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
