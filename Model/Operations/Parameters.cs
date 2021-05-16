using System;

namespace RealtyModel.Model.Operations
{
    [Serializable]
    public class Parameters
    {
        private Initiator initiator;
        private Target target;
        private Act type;
        private Direction direction;
        private Int32 part = 0;
        private Int32 partCount = 0;

        public Initiator Initiator { get => initiator; set => initiator = value; }
        public Target Target { get => target; set => target = value; }
        public Act Action { get => type; set => type = value; }
        public Direction Direction { get => direction; set => direction = value; }
        public Int32 Part { get => part; set => part = value; }
        public Int32 PartCount { get => partCount; set => partCount = value; }

        public Parameters() { }
        public Parameters(Initiator initiator, Direction direction, Act type, Target target)
        {
            this.initiator = initiator;
            this.direction = direction;
            this.type = type;
            this.target = target;
        }
    }
}
