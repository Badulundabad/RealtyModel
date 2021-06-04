using System;

namespace RealtyModel.Model.Operations
{
    [Serializable]
    public class Operation
    {
        private byte[] data;
        private String name;
        private Target target;
        private Action action;
        public Operation() {

        }
        public Operation(Action action, Target target, byte[] data) {
            this.Action = action;
            this.Target = target;
            this.Data = data;
        }
        public Operation(Action action, Target target) {
            this.Action = action;
            this.Target = target;
        }
        public Operation(Action action) {
            this.Action = action;
            this.Target = Target.None;
        }
        public Operation(Action action, byte[] data) {
            this.Action = action;
            this.Data = data;
        }
        public Boolean IsSuccessfully {
            get; set;
        }
        public String Name
        {
            get => name;
            set => name = value;
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
