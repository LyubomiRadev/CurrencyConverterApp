using System.Collections.ObjectModel;
using System.Linq;

using Catel.Data;

namespace CurrencyConverterApp.Models
{
    public class ConversionRateModel : ModelBase
    {
        #region Constructor

        public ConversionRateModel()
        {

        }

        #endregion


        #region Properties

        #region AED

        public double AED
        {
            get { return GetValue<double>(AEDProperty); }
            set { SetValue(AEDProperty, value); }
        }
        public static readonly PropertyData AEDProperty = RegisterProperty(nameof(AED), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnAEDChanged());

        private void OnAEDChanged()
        {
            this.UpdateCurrency(value: this.AED, currencyName: nameof(AED));
        }

        #endregion End AED  


        #region ARS

        public double ARS
        {
            get { return GetValue<double>(ARSProperty); }
            set { SetValue(ARSProperty, value); }
        }
        public static readonly PropertyData ARSProperty = RegisterProperty(nameof(ARS), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnARSChanged());

        private void OnARSChanged()
        {
            this.UpdateCurrency(value: this.ARS, currencyName: nameof(ARS));
        }

        #endregion End ARS            


        #region AUD

        public double AUD
        {
            get { return GetValue<double>(AUDProperty); }
            set { SetValue(AUDProperty, value); }
        }
        public static readonly PropertyData AUDProperty = RegisterProperty(nameof(AUD), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnAUDChanged());

        private void OnAUDChanged()
        {
            this.UpdateCurrency(value: this.AUD, currencyName: nameof(AUD));
        }

        #endregion End AUD            


        #region BGN

        public double BGN
        {
            get { return GetValue<double>(BGNProperty); }
            set { SetValue(BGNProperty, value); }
        }
        public static readonly PropertyData BGNProperty = RegisterProperty(nameof(BGN), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnBGNChanged());

        private void OnBGNChanged()
        {
            this.UpdateCurrency(value: this.BGN, currencyName: nameof(BGN));
        }

        #endregion End BGN            


        #region BRL

        public double BRL
        {
            get { return GetValue<double>(BRLProperty); }
            set { SetValue(BRLProperty, value); }
        }
        public static readonly PropertyData BRLProperty = RegisterProperty(nameof(BRL), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnBRLChanged());

        private void OnBRLChanged()
        {
            this.UpdateCurrency(value: this.BRL, currencyName: nameof(BRL));
        }

        #endregion End BRL            


        #region BSD

        public double BSD
        {
            get { return GetValue<double>(BSDProperty); }
            set { SetValue(BSDProperty, value); }
        }
        public static readonly PropertyData BSDProperty = RegisterProperty(nameof(BSD), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnBSDChanged());

        private void OnBSDChanged()
        {
            this.UpdateCurrency(value: this.BSD, currencyName: nameof(BSD));
        }

        #endregion End BSD            


        #region CAD

        public double CAD
        {
            get { return GetValue<double>(CADProperty); }
            set { SetValue(CADProperty, value); }
        }
        public static readonly PropertyData CADProperty = RegisterProperty(nameof(CAD), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnCADChanged());

        private void OnCADChanged()
        {
            this.UpdateCurrency(value: this.CAD, currencyName: nameof(CAD));
        }

        #endregion End CAD            


        #region CHF

        public double CHF
        {
            get { return GetValue<double>(CHFProperty); }
            set { SetValue(CHFProperty, value); }
        }
        public static readonly PropertyData CHFProperty = RegisterProperty(nameof(CHF), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnCHFChanged());

        private void OnCHFChanged()
        {
            this.UpdateCurrency(value: this.CHF, currencyName: nameof(CHF));
        }

        #endregion End CHF            


        #region CLP

        public double CLP
        {
            get { return GetValue<double>(CLPProperty); }
            set { SetValue(CLPProperty, value); }
        }
        public static readonly PropertyData CLPProperty = RegisterProperty(nameof(CLP), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnCLPChanged());

        private void OnCLPChanged()
        {
            this.UpdateCurrency(value: this.CLP, currencyName: nameof(CLP));
        }

        #endregion End CLP            


        #region CNY

        public double CNY
        {
            get { return GetValue<double>(CNYProperty); }
            set { SetValue(CNYProperty, value); }
        }
        public static readonly PropertyData CNYProperty = RegisterProperty(nameof(CNY), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnCNYChanged());

        private void OnCNYChanged()
        {
            this.UpdateCurrency(value: this.CNY, currencyName: nameof(CNY));
        }

        #endregion End CNY            


        #region COP

        public double COP
        {
            get { return GetValue<double>(COPProperty); }
            set { SetValue(COPProperty, value); }
        }
        public static readonly PropertyData COPProperty = RegisterProperty(nameof(COP), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnCOPChanged());

        private void OnCOPChanged()
        {
            this.UpdateCurrency(value: this.COP, currencyName: nameof(COP));
        }

        #endregion End COP            


        #region CZK

        public double CZK
        {
            get { return GetValue<double>(CZKProperty); }
            set { SetValue(CZKProperty, value); }
        }
        public static readonly PropertyData CZKProperty = RegisterProperty(nameof(CZK), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnCZKChanged());

        private void OnCZKChanged()
        {
            this.UpdateCurrency(value: this.CZK, currencyName: nameof(CZK));
        }

        #endregion End CZK            


        #region DKK

        public double DKK
        {
            get { return GetValue<double>(DKKProperty); }
            set { SetValue(DKKProperty, value); }
        }
        public static readonly PropertyData DKKProperty = RegisterProperty(nameof(DKK), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnDKKChanged());

        private void OnDKKChanged()
        {
            this.UpdateCurrency(value: this.DKK, currencyName: nameof(DKK));
        }

        #endregion End DKK            


        #region DOP

        public double DOP
        {
            get { return GetValue<double>(DOPProperty); }
            set { SetValue(DOPProperty, value); }
        }
        public static readonly PropertyData DOPProperty = RegisterProperty(nameof(DOP), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnDOPChanged());

        private void OnDOPChanged()
        {
            this.UpdateCurrency(value: this.DOP, currencyName: nameof(DOP));
        }

        #endregion End DOP            


        #region EGP

        public double EGP
        {
            get { return GetValue<double>(EGPProperty); }
            set { SetValue(EGPProperty, value); }
        }
        public static readonly PropertyData EGPProperty = RegisterProperty(nameof(EGP), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnEGPChanged());

        private void OnEGPChanged()
        {
            this.UpdateCurrency(value: this.EGP, currencyName: nameof(EGP));
        }

        #endregion End EGP            


        #region EUR

        public double EUR
        {
            get { return GetValue<double>(EURProperty); }
            set { SetValue(EURProperty, value); }
        }
        public static readonly PropertyData EURProperty = RegisterProperty(nameof(EUR), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnEURChanged());

        private void OnEURChanged()
        {
            this.UpdateCurrency(value: this.EUR, currencyName: nameof(EUR));
        }

        #endregion End EUR            


        #region FJD

        public double FJD
        {
            get { return GetValue<double>(FJDProperty); }
            set { SetValue(FJDProperty, value); }
        }
        public static readonly PropertyData FJDProperty = RegisterProperty(nameof(FJD), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnFJDChanged());

        private void OnFJDChanged()
        {
            this.UpdateCurrency(value: this.FJD, currencyName: nameof(FJD));
        }

        #endregion End FJD            


        #region GBP

        public double GBP
        {
            get { return GetValue<double>(GBPProperty); }
            set { SetValue(GBPProperty, value); }
        }
        public static readonly PropertyData GBPProperty = RegisterProperty(nameof(GBP), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnGBPChanged());

        private void OnGBPChanged()
        {
            this.UpdateCurrency(value: this.GBP, currencyName: nameof(GBP));
        }

        #endregion End GBP            


        #region GTQ

        public double GTQ
        {
            get { return GetValue<double>(GTQProperty); }
            set { SetValue(GTQProperty, value); }
        }
        public static readonly PropertyData GTQProperty = RegisterProperty(nameof(GTQ), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnGTQChanged());

        private void OnGTQChanged()
        {
            this.UpdateCurrency(value: this.GTQ, currencyName: nameof(GTQ));
        }

        #endregion End GTQ            


        #region HKD

        public double HKD
        {
            get { return GetValue<double>(HKDProperty); }
            set { SetValue(HKDProperty, value); }
        }
        public static readonly PropertyData HKDProperty = RegisterProperty(nameof(HKD), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnHKDChanged());

        private void OnHKDChanged()
        {
            this.UpdateCurrency(value: this.HKD, currencyName: nameof(HKD));
        }

        #endregion End HKD            


        #region HRK

        public double HRK
        {
            get { return GetValue<double>(HRKProperty); }
            set { SetValue(HRKProperty, value); }
        }
        public static readonly PropertyData HRKProperty = RegisterProperty(nameof(HRK), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnHRKChanged());

        private void OnHRKChanged()
        {
            this.UpdateCurrency(value: this.HRK, currencyName: nameof(HRK));
        }

        #endregion End HRK            


        #region HUF

        public double HUF
        {
            get { return GetValue<double>(HUFProperty); }
            set { SetValue(HUFProperty, value); }
        }
        public static readonly PropertyData HUFProperty = RegisterProperty(nameof(HUF), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnHUFChanged());

        private void OnHUFChanged()
        {
            this.UpdateCurrency(value: this.HUF, currencyName: nameof(HUF));
        }

        #endregion End HUF            


        #region IDR

        public double IDR
        {
            get { return GetValue<double>(IDRProperty); }
            set { SetValue(IDRProperty, value); }
        }
        public static readonly PropertyData IDRProperty = RegisterProperty(nameof(IDR), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnIDRChanged());

        private void OnIDRChanged()
        {
            this.UpdateCurrency(value: this.IDR, currencyName: nameof(IDR));
        }

        #endregion End IDR            


        #region ILS

        public double ILS
        {
            get { return GetValue<double>(ILSProperty); }
            set { SetValue(ILSProperty, value); }
        }
        public static readonly PropertyData ILSProperty = RegisterProperty(nameof(ILS), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnILSChanged());

        private void OnILSChanged()
        {
            this.UpdateCurrency(value: this.ILS, currencyName: nameof(ILS));
        }

        #endregion End ILS            


        #region INR

        public double INR
        {
            get { return GetValue<double>(INRProperty); }
            set { SetValue(INRProperty, value); }
        }
        public static readonly PropertyData INRProperty = RegisterProperty(nameof(INR), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnINRChanged());

        private void OnINRChanged()
        {
            this.UpdateCurrency(value: this.INR, currencyName: nameof(INR));
        }

        #endregion End INR            


        #region ISK

        public double ISK
        {
            get { return GetValue<double>(ISKProperty); }
            set { SetValue(ISKProperty, value); }
        }
        public static readonly PropertyData ISKProperty = RegisterProperty(nameof(ISK), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnISKChanged());

        private void OnISKChanged()
        {
            this.UpdateCurrency(value: this.ISK, currencyName: nameof(ISK));
        }

        #endregion End ISK            


        #region JPY

        public double JPY
        {
            get { return GetValue<double>(JPYProperty); }
            set { SetValue(JPYProperty, value); }
        }
        public static readonly PropertyData JPYProperty = RegisterProperty(nameof(JPY), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnJPYChanged());

        private void OnJPYChanged()
        {
            this.UpdateCurrency(value: this.JPY, currencyName: nameof(JPY));
        }

        #endregion End JPY            


        #region KRW

        public double KRW
        {
            get { return GetValue<double>(KRWProperty); }
            set { SetValue(KRWProperty, value); }
        }
        public static readonly PropertyData KRWProperty = RegisterProperty(nameof(KRW), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnKRWChanged());

        private void OnKRWChanged()
        {
            this.UpdateCurrency(value: this.KRW, currencyName: nameof(KRW));
        }

        #endregion End KRW            


        #region KZT

        public double KZT
        {
            get { return GetValue<double>(KZTProperty); }
            set { SetValue(KZTProperty, value); }
        }
        public static readonly PropertyData KZTProperty = RegisterProperty(nameof(KZT), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnKZTChanged());

        private void OnKZTChanged()
        {
            this.UpdateCurrency(value: this.KZT, currencyName: nameof(KZT));
        }

        #endregion End KZT            


        #region MXN

        public double MXN
        {
            get { return GetValue<double>(MXNProperty); }
            set { SetValue(MXNProperty, value); }
        }
        public static readonly PropertyData MXNProperty = RegisterProperty(nameof(MXN), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnMXNChanged());

        private void OnMXNChanged()
        {
            this.UpdateCurrency(value: this.MXN, currencyName: nameof(MXN));
        }

        #endregion End MXN            


        #region MYR

        public double MYR
        {
            get { return GetValue<double>(MYRProperty); }
            set { SetValue(MYRProperty, value); }
        }
        public static readonly PropertyData MYRProperty = RegisterProperty(nameof(MYR), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnMYRChanged());

        private void OnMYRChanged()
        {
            this.UpdateCurrency(value: this.MYR, currencyName: nameof(MYR));
        }

        #endregion End MYR            


        #region NOK

        public double NOK
        {
            get { return GetValue<double>(NOKProperty); }
            set { SetValue(NOKProperty, value); }
        }
        public static readonly PropertyData NOKProperty = RegisterProperty(nameof(NOK), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnNOKChanged());

        private void OnNOKChanged()
        {
            this.UpdateCurrency(value: this.NOK, currencyName: nameof(NOK));
        }

        #endregion End NOK            


        #region NZD

        public double NZD
        {
            get { return GetValue<double>(NZDProperty); }
            set { SetValue(NZDProperty, value); }
        }
        public static readonly PropertyData NZDProperty = RegisterProperty(nameof(NZD), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnNZDChanged());

        private void OnNZDChanged()
        {
            this.UpdateCurrency(value: this.NZD, currencyName: nameof(NZD));
        }

        #endregion End NZD            


        #region PAB

        public double PAB
        {
            get { return GetValue<double>(PABProperty); }
            set { SetValue(PABProperty, value); }
        }
        public static readonly PropertyData PABProperty = RegisterProperty(nameof(PAB), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnPABChanged());

        private void OnPABChanged()
        {
            this.UpdateCurrency(value: this.PAB, currencyName: nameof(PAB));
        }

        #endregion End PAB            


        #region PEN

        public double PEN
        {
            get { return GetValue<double>(PENProperty); }
            set { SetValue(PENProperty, value); }
        }
        public static readonly PropertyData PENProperty = RegisterProperty(nameof(PEN), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnPENChanged());

        private void OnPENChanged()
        {
            this.UpdateCurrency(value: this.PEN, currencyName: nameof(PEN));
        }

        #endregion End PEN            


        #region PHP

        public double PHP
        {
            get { return GetValue<double>(PHPProperty); }
            set { SetValue(PHPProperty, value); }
        }
        public static readonly PropertyData PHPProperty = RegisterProperty(nameof(PHP), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnPHPChanged());

        private void OnPHPChanged()
        {
            this.UpdateCurrency(value: this.PHP, currencyName: nameof(PHP));
        }

        #endregion End PHP            


        #region PKR

        public double PKR
        {
            get { return GetValue<double>(PKRProperty); }
            set { SetValue(PKRProperty, value); }
        }
        public static readonly PropertyData PKRProperty = RegisterProperty(nameof(PKR), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnPKRChanged());

        private void OnPKRChanged()
        {
            this.UpdateCurrency(value: this.PKR, currencyName: nameof(PKR));
        }

        #endregion End PKR            


        #region PLN

        public double PLN
        {
            get { return GetValue<double>(PLNProperty); }
            set { SetValue(PLNProperty, value); }
        }
        public static readonly PropertyData PLNProperty = RegisterProperty(nameof(PLN), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnPLNChanged());

        private void OnPLNChanged()
        {
            this.UpdateCurrency(value: this.PLN, currencyName: nameof(PLN));
        }

        #endregion End PLN            


        #region PYG

        public double PYG
        {
            get { return GetValue<double>(PYGProperty); }
            set { SetValue(PYGProperty, value); }
        }
        public static readonly PropertyData PYGProperty = RegisterProperty(nameof(PYG), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnPYGChanged());

        private void OnPYGChanged()
        {
            this.UpdateCurrency(value: this.PYG, currencyName: nameof(PYG));
        }

        #endregion End PYG            


        #region RON

        public double RON
        {
            get { return GetValue<double>(RONProperty); }
            set { SetValue(RONProperty, value); }
        }
        public static readonly PropertyData RONProperty = RegisterProperty(nameof(RON), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnRONChanged());

        private void OnRONChanged()
        {
            this.UpdateCurrency(value: this.RON, currencyName: nameof(RON));
        }

        #endregion End RON            


        #region RUB

        public double RUB
        {
            get { return GetValue<double>(RUBProperty); }
            set { SetValue(RUBProperty, value); }
        }
        public static readonly PropertyData RUBProperty = RegisterProperty(nameof(RUB), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnRUBChanged());

        private void OnRUBChanged()
        {
            this.UpdateCurrency(value: this.RUB, currencyName: nameof(RUB));
        }

        #endregion End RUB            


        #region SAR

        public double SAR
        {
            get { return GetValue<double>(SARProperty); }
            set { SetValue(SARProperty, value); }
        }
        public static readonly PropertyData SARProperty = RegisterProperty(nameof(SAR), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnSARChanged());

        private void OnSARChanged()
        {
            this.UpdateCurrency(value: this.SAR, currencyName: nameof(SAR));
        }

        #endregion End SAR            


        #region SEK

        public double SEK
        {
            get { return GetValue<double>(SEKProperty); }
            set { SetValue(SEKProperty, value); }
        }
        public static readonly PropertyData SEKProperty = RegisterProperty(nameof(SEK), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnSEKChanged());

        private void OnSEKChanged()
        {
            this.UpdateCurrency(value: this.SEK, currencyName: nameof(SEK));
        }

        #endregion End SEK            


        #region SGD

        public double SGD
        {
            get { return GetValue<double>(SGDProperty); }
            set { SetValue(SGDProperty, value); }
        }
        public static readonly PropertyData SGDProperty = RegisterProperty(nameof(SGD), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnSGDChanged());

        private void OnSGDChanged()
        {
            this.UpdateCurrency(value: this.SGD, currencyName: nameof(SGD));
        }

        #endregion End SGD            


        #region THB

        public double THB
        {
            get { return GetValue<double>(THBProperty); }
            set { SetValue(THBProperty, value); }
        }
        public static readonly PropertyData THBProperty = RegisterProperty(nameof(THB), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnTHBChanged());

        private void OnTHBChanged()
        {
            this.UpdateCurrency(value: this.THB, currencyName: nameof(THB));
        }

        #endregion End THB            


        #region TRY

        public double TRY
        {
            get { return GetValue<double>(TRYProperty); }
            set { SetValue(TRYProperty, value); }
        }
        public static readonly PropertyData TRYProperty = RegisterProperty(nameof(TRY), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnTRYChanged());

        private void OnTRYChanged()
        {
            this.UpdateCurrency(value: this.TRY, currencyName: nameof(TRY));
        }

        #endregion End TRY            


        #region TWD

        public double TWD
        {
            get { return GetValue<double>(TWDProperty); }
            set { SetValue(TWDProperty, value); }
        }
        public static readonly PropertyData TWDProperty = RegisterProperty(nameof(TWD), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnTWDChanged());

        private void OnTWDChanged()
        {
            this.UpdateCurrency(value: this.TWD, currencyName: nameof(TWD));
        }

        #endregion End TWD            


        #region UAH

        public double UAH
        {
            get { return GetValue<double>(UAHProperty); }
            set { SetValue(UAHProperty, value); }
        }
        public static readonly PropertyData UAHProperty = RegisterProperty(nameof(UAH), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnUAHChanged());

        private void OnUAHChanged()
        {
            this.UpdateCurrency(value: this.UAH, currencyName: nameof(UAH));
        }

        #endregion End UAH            


        #region USD

        public double USD
        {
            get { return GetValue<double>(USDProperty); }
            set { SetValue(USDProperty, value); }
        }
        public static readonly PropertyData USDProperty = RegisterProperty(nameof(USD), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnUSDChanged());

        private void OnUSDChanged()
        {
            this.UpdateCurrency(value: this.USD, currencyName: nameof(USD));
        }

        #endregion End USD            


        #region UYU

        public double UYU
        {
            get { return GetValue<double>(UYUProperty); }
            set { SetValue(UYUProperty, value); }
        }
        public static readonly PropertyData UYUProperty = RegisterProperty(nameof(UYU), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnUYUChanged());

        private void OnUYUChanged()
        {
            this.UpdateCurrency(value: this.UYU, currencyName: nameof(UYU));
        }

        #endregion End UYU            


        #region ZAR

        public double ZAR
        {
            get { return GetValue<double>(ZARProperty); }
            set { SetValue(ZARProperty, value); }
        }
        public static readonly PropertyData ZARProperty = RegisterProperty(nameof(ZAR), typeof(double), null, (sender, e) => ((ConversionRateModel)sender).OnZARChanged());

        private void OnZARChanged()
        {
            this.UpdateCurrency(value: this.ZAR, currencyName: nameof(ZAR));
        }

        #endregion End ZAR            


        #region CurrenciesList

        public ObservableCollection<BaseCurrencyMode> CurrenciesList
        {
            get { return GetValue<ObservableCollection<BaseCurrencyMode>>(CurrenciesListProperty); }
            set { SetValue(CurrenciesListProperty, value); }
        }
        public static readonly PropertyData CurrenciesListProperty = RegisterProperty(nameof(CurrenciesList), typeof(ObservableCollection<BaseCurrencyMode>), new ObservableCollection<BaseCurrencyMode>());

        #endregion End CurrenciesList

        #endregion


        #region Methods

        #region UpdateCurrency Method

        private void UpdateCurrency(double value, string currencyName)
        {
            var existingCurrency = this.CurrenciesList.Where(w => w.Name == currencyName).FirstOrDefault();

            if (existingCurrency != null)
            {
                this.CurrenciesList.Remove(existingCurrency);

            }

            this.CreateAndAddNewCurrencyObjec(value: value, currencyName: currencyName);

        }

        #endregion End UpdateCurrency Method


        #region CreateNewCurrencyObjec Method

        private void CreateAndAddNewCurrencyObjec(double value, string currencyName)
        {
            var updatedCurrency = new BaseCurrencyMode()
            {
                Name = currencyName,
                Value = value
            };

            this.CurrenciesList.Add(updatedCurrency);
        }

        #endregion End CreateNewCurrencyObjec Method

        #endregion
    }

}


