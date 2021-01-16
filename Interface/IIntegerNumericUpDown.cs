using RealtyModel.Service;

namespace RealtyModel.Interface
{
    interface IIntegerNumericUpDown
    {
        CustomCommand IncreaseInteger
        {
            get;
        }
        CustomCommand DecreaseInteger
        {
            get;
        }
        void ChangeProperty<T>(object obj, T gain);
    }
}
