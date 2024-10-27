using Microsoft.Extensions.Configuration;
using Android.Content;
using Com.Oltio.Liblite.Activity;
using MasterPassPoc.Service;

namespace MasterPassPoc.Platforms.Android
{
    public class MasterPassService : IMasterPassService
    {
        #region Fields

        private readonly IConfigurationManager _configurationManager;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MasterPassService"/> class.
        /// </summary>
        public MasterPassService(IConfigurationManager configurationManager)
        {
            _configurationManager = configurationManager;
        }

        #endregion

        public void PerformCheckout(string transactionCode)
        {
            var context = MauiApplication.Current.ApplicationContext;

            var apiKey = "{{ApiKey}}";
            var system = "{{SystemValue}}";
            Intent intent = new Intent(context, typeof(LibLiteActivity));
            intent.PutExtra(LibLiteActivity.InApiKey, apiKey);
            intent.PutExtra(LibLiteActivity.InCode, transactionCode);
            intent.PutExtra(LibLiteActivity.InSystem, system);

            context.StartActivity(intent);
        }

        public void PreRegisterUser()
        {
            var context = MauiApplication.Current.ApplicationContext;

            var apiKey = "{{ApiKey}}";
            var system = "{{SystemValue}}";

            Intent intent = new Intent(context, typeof(LibLitePreRegActivity));
            intent.PutExtra(LibLiteActivity.InApiKey, apiKey);
            intent.PutExtra(LibLiteActivity.InSystem, system);

            context.StartActivity(intent);
        }

        public void DisplayWallet()
        {
            var context = MauiApplication.Current.ApplicationContext;

            var apiKey = "{{ApiKey}}";
            var system = "{{SystemValue}}";

            Intent intent = new Intent(context, typeof(LibLiteWalletActivity));
            intent.PutExtra(LibLiteActivity.InApiKey, apiKey);
            intent.PutExtra(LibLiteActivity.InSystem, system);

            context.StartActivity(intent);
        }

        public void PerformTipAnAttendantCheckout(double amount, string transactionCode)
        {
            var context = MauiApplication.Current.ApplicationContext;

            var apiKey = "{{ApiKey}}";
            var system = "{{SystemValue}}";

            Intent intent = new Intent(context, typeof(LibLiteActivity));
            intent.PutExtra(LibLiteActivity.InApiKey, apiKey);
            intent.PutExtra(LibLiteActivity.InCode, transactionCode);
            intent.PutExtra(LibLiteActivity.InSystem, system);
            intent.PutExtra(LibLiteActivity.InAmount, amount);

            context.StartActivity(intent);
        }
    }
}
