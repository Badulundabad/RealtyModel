using RealtyModel.Model.Derived;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Model
{
    [Serializable]
    public class DistrictOptions : INotifyPropertyChanged
    {
        private bool isAllDistricts = true;  
        private bool isAviagorodok = true;
        private bool isSkver = true;
        private bool isAzovskiy = true;
        private bool isVetlecheblitsa = true;
        private bool isVzhm = true;
        private bool isGaydara = true;
        private bool isZalesie= true;
        private bool isZarya = true;
        private bool isZzhm = true;
        private bool isNalivnaya = true;
        private bool isPalmira = true;
        private bool isPchl = true;
        private bool isRdvs = true;
        private bool isSzhm = true;
        private bool isOzero = true;
        private bool isSolnechniy = true;
        private bool isCentr = true;

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public void Filter(List<Flat> realtorObjects) {
            if (!IsAllDistricts) {
                if (!IsAviagorodok) {
                    realtorObjects.RemoveAll(ro => ro.Location.District == "Авиагородок");
                }
                if (!IsSkver) {
                    realtorObjects.RemoveAll(ro => ro.Location.District == "Авиаторов сквер");
                }
                if (!IsAzovskiy) {
                    realtorObjects.RemoveAll(ro => ro.Location.District == "Азовский");
                }
                if (!IsVetlecheblitsa) {
                    realtorObjects.RemoveAll(ro => ro.Location.District == "Ветлечебница");
                }
                if (!IsVzhm) {
                    realtorObjects.RemoveAll(ro => ro.Location.District == "ВЖМ");
                }
                if (!IsGaydara) {
                    realtorObjects.RemoveAll(ro => ro.Location.District == "Гайдара");
                }
                if (!IsZalesie) {
                    realtorObjects.RemoveAll(ro => ro.Location.District == "Залесье");
                }
                if (!IsZarya) {
                    realtorObjects.RemoveAll(ro => ro.Location.District == "Заря");
                }
                if (!IsZzhm) {
                    realtorObjects.RemoveAll(ro => ro.Location.District == "ЗЖМ");
                }
                if (!IsNalivnaya) {
                    realtorObjects.RemoveAll(ro => ro.Location.District == "Наливная");
                }
                if (!IsPalmira) {
                    realtorObjects.RemoveAll(ro => ro.Location.District == "Пальмира");
                }
                if (!IsPchl) {
                    realtorObjects.RemoveAll(ro => ro.Location.District == "ПЧЛ");
                }
                if (!IsRdvs) {
                    realtorObjects.RemoveAll(ro => ro.Location.District == "РДВС");
                }
                if (!IsSzhm) {
                    realtorObjects.RemoveAll(ro => ro.Location.District == "СЖМ");
                }
                if (!IsOzero) {
                    realtorObjects.RemoveAll(ro => ro.Location.District == "Соленое озеро");
                }
                if (!IsSolnechniy) {
                    realtorObjects.RemoveAll(ro => ro.Location.District == "Солнечный");
                }
                if (!IsCentr) {
                    realtorObjects.RemoveAll(ro => ro.Location.District == "Центр");
                }
            }
        }
        public void Filter(List<House> realtorObjects) {

        }
        private void CheckDistricts() {
            if (IsAviagorodok
                && IsSkver
                && IsAzovskiy
                && IsVetlecheblitsa
                && IsVzhm
                && IsGaydara
                && IsZalesie
                && IsZarya
                && IsZzhm
                && IsNalivnaya
                && IsPalmira
                && IsPchl
                && IsRdvs
                && IsSzhm
                && IsOzero
                && IsSolnechniy
                && IsCentr) {
                IsAllDistricts = true;
            }else {
                IsAllDistricts = false;
            }
        }
        public bool IsAllDistricts {
            get => isAllDistricts;
            set {
                isAllDistricts = value;
                if (value) {
                    IsAllDistricts = true;
                    IsAviagorodok = true;
                    IsSkver = true;
                    IsAzovskiy = true;
                    IsVetlecheblitsa = true;
                    IsVzhm = true;
                    IsGaydara = true;
                    IsZalesie = true;
                    IsZarya = true;
                    IsZzhm = true;
                    IsNalivnaya = true;
                    IsPalmira = true;
                    IsPchl = true;
                    IsRdvs = true;
                    IsSzhm = true;
                    IsOzero = true;
                    IsSolnechniy = true;
                    IsCentr = true;
                }
                OnPropertyChanged();
            }
        }
        public bool IsAviagorodok {
            get => isAviagorodok;
            set {
                isAviagorodok = value;
                CheckDistricts();
                OnPropertyChanged();
            }
        }
        public bool IsSkver {
            get => isSkver;
            set {
                isSkver = value;
                CheckDistricts();
                OnPropertyChanged();
            }
        }
        public bool IsAzovskiy {
            get => isAzovskiy;
            set {
                isAzovskiy = value;
                CheckDistricts();
                OnPropertyChanged();
            }
        }
        public bool IsVetlecheblitsa {
            get => isVetlecheblitsa;
            set {
                isVetlecheblitsa = value;
                CheckDistricts();
                OnPropertyChanged();
            }
        }
        public bool IsVzhm {
            get => isVzhm;
            set {
                isVzhm = value;
                CheckDistricts();
                OnPropertyChanged();
            }
        }
        public bool IsGaydara {
            get => isGaydara;
            set {
                isGaydara = value;
                CheckDistricts();
                OnPropertyChanged();
            }
        }
        public bool IsZalesie {
            get => isZalesie;
            set {
                isZalesie = value;
                CheckDistricts();
                OnPropertyChanged();
            }
        }
        public bool IsZarya {
            get => isZarya;
            set {
                isZarya = value;
                CheckDistricts();
                OnPropertyChanged();
            }
        }
        public bool IsZzhm {
            get => isZzhm;
            set {
                isZzhm = value;
                CheckDistricts();
                OnPropertyChanged();
            }
        }
        public bool IsNalivnaya {
            get => isNalivnaya;
            set {
                isNalivnaya = value;
                CheckDistricts();
                OnPropertyChanged();
            }
        }
        public bool IsPalmira {
            get => isPalmira;
            set {
                isPalmira = value;
                CheckDistricts();
                OnPropertyChanged();
            }
        }
        public bool IsPchl {
            get => isPchl;
            set {
                isPchl = value;
                CheckDistricts();
                OnPropertyChanged();
            }
        }
        public bool IsRdvs {
            get => isRdvs;
            set {
                isRdvs = value;
                CheckDistricts();
                OnPropertyChanged();
            }
        }
        public bool IsSzhm {
            get => isSzhm;
            set {
                isSzhm = value;
                CheckDistricts();
                OnPropertyChanged();
            }
        }
        public bool IsOzero {
            get => isOzero;
            set {
                isOzero = value;
                CheckDistricts();
                OnPropertyChanged();
            }
        }
        public bool IsSolnechniy {
            get => isSolnechniy;
            set {
                isSolnechniy = value;
                CheckDistricts();
                OnPropertyChanged();
            }
        }
        public bool IsCentr {
            get => isCentr;
            set {
                isCentr = value;
                CheckDistricts();
                OnPropertyChanged();
            }
        }
    }
}
