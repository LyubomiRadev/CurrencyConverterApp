
using Catel.Data;
using Catel.MVVM;

namespace CurrencyConverterApp.Models
{
    public class BaseCurrencyMode : ViewModelBase
    {
        #region Name

        public string Name
        {
            get { return GetValue<string>(NameProperty); }
            set { SetValue(NameProperty, value); }
        }
        public static readonly PropertyData NameProperty = RegisterProperty(nameof(Name), typeof(string), null);

        #endregion End Name

        #region Value

        public double Value
        {
            get { return GetValue<double>(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }
        public static readonly PropertyData ValueProperty = RegisterProperty(nameof(Value), typeof(double), null);

        #endregion End Value
    }
}
