﻿using RealtyModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Event.RealtyEvents
{
    public class ReceivedDbUpdateEventArgs
    {
        private object updateData;
        private TargetType targetType;

        public object UpdateData
        {
            get => updateData;
            set => updateData = value;
        }
        public TargetType TargetType
        {
            get => targetType;
            set => targetType = value;
        }

        public ReceivedDbUpdateEventArgs(TargetType targetType, object updateData)
        {
            this.targetType = targetType;
            this.updateData = updateData;
        }
    }
}
