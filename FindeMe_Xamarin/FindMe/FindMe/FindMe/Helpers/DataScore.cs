using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.ComponentModel;

namespace FindMe.Helpers
{
    [Table("Scores")]
    class DataScore : INotifyPropertyChanged
    {
        private int _id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                this._id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
        private string _username;
        [NotNull]
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                this._username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        private double _valueScore;
        [NotNull]
        public double ValueScore
        {
            get
            {
                return _valueScore;
            }
            set
            {
                this._valueScore = value;
                OnPropertyChanged(nameof(ValueScore));
            }
        }
        private Boolean _isHard;
        [NotNull]
        public Boolean IsHard
        {
            get
            {
                return _isHard;
            }
            set
            {
                _isHard = value;
                OnPropertyChanged(nameof(IsHard));
            }
        }


        private int _nbrIcons;
        [NotNull]
        public int NbrIcons
        {
            get
            {
                return _nbrIcons;
            }

            set
            {
                _nbrIcons = value;
                OnPropertyChanged(nameof(NbrIcons));
            }
        }

        private String _gameMode;
        [NotNull]
        public string GameMode
        {
            get
            {
                return _gameMode;
            }

            set
            {
                _gameMode = value;
                OnPropertyChanged(nameof(GameMode));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this,
              new PropertyChangedEventArgs(propertyName));
        }
    }
}
