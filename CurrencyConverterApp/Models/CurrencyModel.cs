using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

using Catel.Data;
using Newtonsoft.Json.Linq;

namespace CurrencyConverterApp.Models
{
    public class CurrencyModel : ModelBase
    {
        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public CurrencyModel()
        {
        }

        public CurrencyModel(string jsonValue)
        {
            JObject jObject = JObject.Parse(jsonValue);
            JToken jUser = jObject["CurrencyModel"];
        }


        /// <summary>
        /// Constructor With Value
        /// </summary>
        public CurrencyModel(CurrencyModel currency)
        {
            this.result = currency.result;
            this.documentation = currency.documentation;
            this.terms_of_use = currency.terms_of_use;
            this.time_last_update_utc = currency.time_last_update_utc;
            this.time_next_update_utc = currency.time_next_update_utc;
            this.conversion_rates = currency.conversion_rates;


            this.SetExchangeOption();
        }

        #endregion

        #region Properties

        public string result { get; set; }
        public string documentation { get; set; }
        public string terms_of_use { get; set; }
        public string time_last_update_utc { get; set; }
        public string time_next_update_utc { get; set; }
        public ConversionRateModel conversion_rates { get; set; }

        #region ExchangeOptions

        public ObservableCollection<string> ExchangeOptions
        {
            get { return GetValue<ObservableCollection<string>>(ExchangeOptionsProperty); }
            set { SetValue(ExchangeOptionsProperty, value); }
        }
        public static readonly PropertyData ExchangeOptionsProperty = RegisterProperty(nameof(ExchangeOptions), typeof(ObservableCollection<string>), null);

        #endregion End ExchangeOptions

        #endregion

        #region Methods


        #region SetExchangeOption Method

        private void SetExchangeOption()
        {
            if (this.conversion_rates != null)
            {

            }
        }

        #endregion End SetExchangeOption Method

        #endregion
    }
}
