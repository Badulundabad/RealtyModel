using System;
using RealtyModel.Model.Base;

namespace RealtyModel.Model.Derived
{
    [Serializable]
    public class Flat : BaseRealtorObject
    {
        private FlatInfo info = new FlatInfo();

        public Flat() {
            this.GeneralInfo.ObjectType = "Квартира";
        }
        public FlatInfo Info {
            get => info;
            set => info = value;
        }
        public Flat GetCopy() {
            return (Flat)this.MemberwiseClone();
        }
        public static Flat CreateTestFlat() {
            return new Flat() {
                HasMortgage = true,
                CustomerName = "Петров Петр Петрович",
                CustomerPhoneNumbers = "88005553535 ; 89515038517",
                Location = new Location() {
                    City = "Батайск",
                    District = "РДВС",
                    Street  = "Добролюбова",
                    HouseNumber = "3А",
                    FlatNumber = 1
                },
                Price = 1300,
                GeneralInfo = new BaseInfo() {
                    ObjectType = "Квартира",
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
                Info = new FlatInfo() {
                    Balcony = "Нет",
                    Bath = "Нет",
                    Bathroom = "Нет",
                    Floor = "Деревянный",
                    Fund = "Новый",
                    HasChute = true,
                    HasElevator = true,
                    HasGarage = true,
                    HasImprovedLayout = true,
                    HasRenovation = true,
                    IsCorner = true,
                    IsSeparated = true,
                    Loggia = "Нет",
                    Material = "Кирпичный",
                    Rooms = "Тут что-то написано",
                    Type = "Изолированная",
                    Windows = "Тут что-то написано"
                },
            };
        }
    }
}
