﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RealtyModel.Model.Base
{
    public class BaseRealtorObject : INotifyPropertyChanged
    {
        Int32 id = -1;
        Boolean isSold = false;
        Credential credential = new Credential();
        Customer customer = new Customer();
        Location location = new Location();
        Cost cost = new Cost();
        Album album = new Album();

        public Int32 Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        public Boolean IsSold
        {
            get => isSold;
            set
            {
                isSold = value;
                OnPropertyChanged();
            }
        }
        public Credential Credential
        {
            get => credential;
            set
            {
                credential = value;
                OnPropertyChanged();
            }
        }
        public Customer Customer
        {
            get => customer;
            set
            {
                customer = value;
                OnPropertyChanged();
            }
        }
        public Location Location
        {
            get => location;
            set
            {
                location = value;
                OnPropertyChanged();
            }
        }
        public Cost Cost
        {
            get => cost;
            set
            {
                cost = value;
                OnPropertyChanged();
            }
        }
        public Album Album
        {
            get => album;
            set
            {
                album = value;
                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName] String property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
