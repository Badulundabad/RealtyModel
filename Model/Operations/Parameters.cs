using System;

namespace RealtyModel.Model.Operations
{
    public class Parameters
    {
        private Initiator initiator;
        private Target target;
        private Act type;
        private Direction direction;

        public Initiator Initiator { get => initiator; set => initiator = value; }
        public Target Target { get => target; set => target = value; }
        public Act Action { get => type; set => type = value; }
        public Direction Direction { get => direction; set => direction = value; }

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
