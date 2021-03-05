using RealtyModel.Model;

namespace RealtyModel.Event
{
    public class LoggedEventArgs
    {
        private object window;

        public LoggedEventArgs() { }
        public LoggedEventArgs(object window) {
            this.Window = window;
        }

        public object Window {
            get => window;
            set => window = value;
        }
    }
}