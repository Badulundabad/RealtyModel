using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model.Base
{
    [ComplexType, Serializable]
    public class BaseInfo : INotifyPropertyChanged
    {
        private Int32 year = 2000;
        private Int32 roomCount = 1;
        private Int32 levelCount = 1;
        private Int32 currentLevel = 1;
        private float general = 0;
        private float living = 0;
        private float kitchen = 0;
        private float ceiling = 0;
        private String description = "";
        private String water = "";
        private String convenience = "";
        private String heating = "";
        private String condition = "";
        private string objectType = "";
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        public string Water {
            get => water;
            set {
                water = value;
                OnPropertyChanged();
            }
        }
        public float Ceiling {
            get => ceiling;
            set {

                if (value >= 0f && value <= 10f) {
                    ceiling = value;
                    OnPropertyChanged();
                } else if (value < 0f) {
                    ceiling = 0f;
                    OnPropertyChanged();
                } else if (value > 10f) {
                    ceiling = 10f;
                    OnPropertyChanged();
                }
            }
        }
        public float General {
            get => general;
            set {
                if (value >= 0 && value <= 400) {
                    general = value;
                    OnPropertyChanged();
                } else if (value < 0) {
                    general = 0;
                    OnPropertyChanged();
                } else if (value > 400) {
                    general = 400;
                    OnPropertyChanged();
                }
            }
        }
        public string Convenience {
            get => convenience;
            set {
                convenience = value;
                OnPropertyChanged();
            }
        }
        public string Heating {
            get => heating;
            set {
                heating = value;
                OnPropertyChanged();
            }
        }

        public string Condition {
            get => condition;
            set {
                condition = value;
                OnPropertyChanged();
            }
        }

        public Int32 Year {
            get => year;
            set {
                if (value >= 1950 && value <= 2050) {
                    year = value;
                    OnPropertyChanged();
                } else if (value < 1950) {
                    year = 1950;
                    OnPropertyChanged();
                } else if (value > 2050) {
                    year = 2050;
                    OnPropertyChanged();
                }
            }
        }
        public Int32 RoomCount {
            get => roomCount;
            set {
                if (value >= 0 && value <= 100) {
                    roomCount = value;
                    OnPropertyChanged();
                } else if (value < 0) {
                    roomCount = 0;
                    OnPropertyChanged();
                } else if (value > 100) {
                    roomCount = 100;
                    OnPropertyChanged();
                }
                if (value == 1 && ObjectType == "Квартира") {
                    ObjectType = "Комната";
                }
                if (value != 1 && ObjectType == "Комната") {
                    ObjectType = "Квартира";
                }
            }
        }
        public Int32 LevelCount {
            get => levelCount;
            set {
                levelCount = value;
                if (levelCount < CurrentLevel) {
                    CurrentLevel = levelCount;
                }
                OnPropertyChanged();
            }
        }
        public Int32 CurrentLevel {
            get => currentLevel;
            set {
                currentLevel = value;
                if (currentLevel > LevelCount) {
                    LevelCount = currentLevel;
                }
                OnPropertyChanged();
            }
        }

        public float Living {
            get => living;
            set {
                if (value >= 0 && value <= 500f) {
                    living = value;
                    OnPropertyChanged();
                } else if (value < 0) {
                    living = 0;
                    OnPropertyChanged();
                } else if (value > 500) {
                    living = 500;
                    OnPropertyChanged();
                }
            }
        }
        public float Kitchen {
            get => kitchen;
            set {
                if (value >= 0 && value <= 500f) {
                    kitchen = value;
                    OnPropertyChanged();
                } else if (value < 0) {
                    kitchen = 0;
                    OnPropertyChanged();
                } else if (value > 500) {
                    kitchen = 500;
                    OnPropertyChanged();
                }
            }
        }
        public string Description {
            get => description;
            set {
                description = value;
                OnPropertyChanged();
            }
        }
        public Boolean HasBanner {
            get; set;
        }
        public Boolean HasExchange {
            get; set;
        }
        public string ObjectType {
            get => objectType;
            set {
                objectType = value;
                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName] string property = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
