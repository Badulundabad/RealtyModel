using RealtyModel.Model.Base;
using System;

namespace RealtyModel.Model.Derived
{
    [Serializable]
    public class House : BaseRealtorObject
    {
        HouseInfo info = new HouseInfo();
        public House GetCopy() {
            return (House)this.MemberwiseClone();
        }
        public static House CreateTestHouse() {
            return new House() {
                HasMortgage = true,
                CustomerName = "Петров Петр Петрович",
                CustomerPhoneNumbers = "88005553535 ; 89515038517",
                Location = new Location() {
                    City = "Батайск",
                    District = "РДВС",
                    Street = "Добролюбова",
                    HouseNumber = "3А",
                    FlatNumber = 1
                },
                Price = 1300,
                GeneralInfo = new BaseInfo() {
                    ObjectType = "Дом",
                    HasBanner = true,
                    HasExchange = true,
                    Ceiling = 2.3f,
                    Condition = "Требуется косметический ремонт",
                    Convenience = "Частичные",
                    Description = "Тут что-то должно быть написано",
                    General = 10,
                    Kitchen = 10.5f,
                    Living = 10,
                    Heating = "Котел",
                    RoomCount = 5,
                    Water = "Нет",
                    Year = 1990,
                    CurrentLevel = 3,
                    LevelCount = 9
                },
                Info = new HouseInfo() {
                    Yard = "Нет",
                    EarthCategory = "Земли запаса",
                    Demarcation = "В процессе",
                    HasElectricity = true,
                    HasSlope = true,
                    Hectar = 10,
                    FacadeLength = 100,
                    Hundreds = 2,
                    Roof = "Ондулин",
                    Walls = "Дерево",
                    Gas = "Рядом",
                    Sewerage = "Нет"
                },
            };
        }
        public HouseInfo Info
        {
            get => info;
            set
            {
                info = value;
                OnPropertyChanged();
            }
        }
    }
}
