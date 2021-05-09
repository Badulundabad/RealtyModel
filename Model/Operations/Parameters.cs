using System;

namespace RealtyModel.Model.Operations
{
    public class Parameters
    {
        private Boolean hasBaseChanges;
        private Boolean hasAlbumChanges;
        private Boolean hasCustomerChanges;
        private Boolean hasLocationChanges;
        private Initiator initiator;
        private Target target;
        private Act type;
        private Direction direction;

        public Boolean HasBaseChanges { get => hasBaseChanges; set => hasBaseChanges = value; }
        public Boolean HasAlbumChanges { get => hasAlbumChanges; set => hasAlbumChanges = value; }
        public Boolean HasCustomerChanges { get => hasCustomerChanges; set => hasCustomerChanges = value; }
        public Boolean HasLocationChanges { get => hasLocationChanges; set => hasLocationChanges = value; }
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
