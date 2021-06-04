﻿using System;
using RealtyModel.Model.Base;
using Status = RealtyModel.Model.RealtyObjects.Status;

namespace RealtyModel.Model.Derived
{
    [Serializable]
    public class Flat : BaseRealtorObject
    {
        public FlatInfo Info { get; set; }

        public Flat()
        {
        }
        public static Flat CreateTestFlat() {
            return new Flat() {
                //Agent = credential.Name,
                Album = new Album() {
                    Location = "sdsa"
                },
                Location = new Location() {
                    City = new City() { Name = "asd" },
                    District = new District() { Name = "asd" },
                    Street = new Street() { Name = "asd" },
                    HouseNumber = "1",
                    FlatNumber = 1
                },
                Cost = new Cost() {
                    Price = 1220
                },
                GeneralInfo = new BaseInfo() {
                    HasBanner = false,
                    HasExchange = false,
                    Ceiling = 10,
                    Condition = "asdsa",
                    Convenience = "asd",
                    Description = "asd",
                    General = 10,
                    Heating = "asd",
                    Kitchen = 10,
                    Living = 10,
                    RoomCount = 10,
                    Water = "asdsad",
                    Year = 1950
                },
                Info = new FlatInfo() {
                    Balcony = "asd",
                    Bath = "asd",
                    Bathroom = "asd",
                    Floor = "asd",
                    Fund = "asd",
                    HasChute = false,
                    HasElevator = false,
                    HasGarage = false,
                    HasImprovedLayout = false,
                    HasRenovation = false,
                    IsCorner = false,
                    IsPrivatised = false,
                    IsSeparated = false,
                    Loggia = "asd",
                    Material = "asd",
                    Rooms = "asdsad",
                    Type = "asd",
                    TypeOfRooms = "asdsa",
                    Windows = "asdsad"
                },
                HasExclusive = false
            };
        }
        public static Flat GetEmptyInstance() {
            return new Flat() {
                Album = new Album() {
                    Location = ""
                },
                Location = new Location() {
                    City = new City(),
                    District = new District(),
                    Street = new Street(),
                    HouseNumber = "",
                    FlatNumber = 0
                },
                Cost = new Cost() {
                    Price = 0
                },
                GeneralInfo = new BaseInfo() {
                    HasBanner = false,
                    HasExchange = false,
                    Ceiling = 0,
                    Condition = "",
                    Convenience = "",
                    Description = "",
                    General = 0,
                    Heating = "",
                    Kitchen = 0,
                    Living = 0,
                    RoomCount = 0,
                    Water = "",
                    Year = 1950
                },
                Info = new FlatInfo() {
                    Balcony = "",
                    Bath = "",
                    Bathroom = "",
                    Floor = "",
                    Fund = "",
                    HasChute = false,
                    HasElevator = false,
                    HasGarage = false,
                    HasImprovedLayout = false,
                    HasRenovation = false,
                    IsCorner = false,
                    IsPrivatised = false,
                    IsSeparated = false,
                    Loggia = "",
                    Material = "",
                    Rooms = "",
                    Type = "",
                    TypeOfRooms = "",
                    Windows = ""
                },
                HasExclusive = false
            };
        }
    }
}
