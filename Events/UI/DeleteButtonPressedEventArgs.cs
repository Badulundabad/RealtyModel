using RealtyModel.Model.Base;
using RealtyModel.Model.Derived;

namespace RealtyModel.Events.UI
{
    public class DeleteButtonPressedEventArgs
    {
        private BaseRealtorObject obj;
        public BaseRealtorObject Object
        {
            get => obj;
            set => obj = value;
        }

        public DeleteButtonPressedEventArgs(BaseRealtorObject obj)
        {
            this.obj = obj;
        }
    }
}
