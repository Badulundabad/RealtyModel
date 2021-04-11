﻿using RealtyModel.Model.Derived;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Event
{
    public class UpdateFlatEventArgs
    {
        private Flat flat;
        public Flat Flat { get => flat; set => flat = value; }

        public UpdateFlatEventArgs(Flat flat)
        {
            this.flat = flat;
        }
    }
}
