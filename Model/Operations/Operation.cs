using System;

namespace RealtyModel.Model.Operations
{
    [Serializable]
    public class Operation
    {
        private Target target;
        private Action action;
        private byte[] data;
        public Operation() {

        }
        public Operation(Action action, Target target) {
            this.action = action;
            this.target = target;
        }
        public Operation(Action action) {
            this.action = action;
            this.Target = Target.None;
        }
        public Operation(byte[] data, Action action, Target target) {
            this.Data = data;
            this.action = action;
            this.target = target;
        }
        public Operation(byte[] data, Action action) {
            this.Data = data;
            this.action = action;
            this.Target = Target.None;
        }
        public Boolean IsSuccessfully {
            get; set;
        }
        public byte[] Data {
            get => data;
            set => data = value;
        }
        public Target Target {
            get => target; set => target = value;
        }
        public Action Action {
            get => action; set => action = value;
        }
    }
}
