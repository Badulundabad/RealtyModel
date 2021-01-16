using RealtyModel.Service;

namespace RealtyModel.Interface
{
    public interface IDoubleNumericUpDown
    {
        CustomCommand IncreaseDouble
        {
            get;
        }
        CustomCommand DecreaseDouble
        {
            get;
        }
        void ChangeProperty<T>(object obj, T gain);
    }
}
