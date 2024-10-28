using Microsoft.Extensions.Configuration;
using Android.Content;
using Com.Oltio.Liblite.Activity;
using MasterPassPoc.Service;

namespace MasterPassPoc.Platforms.Android
{
    public class MasterPassService : IMasterPassService
    {
        private readonly string _apiKey;
        private readonly string _system;
        private readonly Context _context;

        public MasterPassService(IConfiguration configuration)
        {
            _apiKey = "{{APIKEY}}";
            _system = "TEST";
            _context = MauiApplication.Current.ApplicationContext;
        }

        public void PerformCheckout(string transactionCode)
        {
            Intent intent = new Intent(_context, typeof(LibLiteActivity));
            intent.PutExtra(LibLiteActivity.InApiKey, _apiKey);
            intent.PutExtra(LibLiteActivity.InCode, transactionCode);
            intent.PutExtra(LibLiteActivity.InSystem, _system);
            intent.AddFlags(ActivityFlags.NewTask);

            var currentActivity = Platform.CurrentActivity;
            currentActivity.StartActivityForResult(intent, 101);
        }

        public void PreRegisterUser()
        {
            Intent intent = new Intent(_context, typeof(LibLitePreRegActivity));
            intent.PutExtra(LibLiteActivity.InApiKey, _apiKey);
            intent.PutExtra(LibLiteActivity.InSystem, _system);
            intent.AddFlags(ActivityFlags.NewTask);

            var currentActivity = Platform.CurrentActivity;
            currentActivity.StartActivityForResult(intent, 101);
        }

        public void DisplayWallet()
        {
            Intent intent = new Intent(_context, typeof(LibLiteWalletActivity));
            intent.PutExtra(LibLiteActivity.InApiKey, _apiKey);
            intent.PutExtra(LibLiteActivity.InSystem, _system);
            intent.AddFlags(ActivityFlags.NewTask);

            var currentActivity = Platform.CurrentActivity;
            currentActivity.StartActivityForResult(intent, 101);
        }

        public void PerformTipAnAttendantCheckout(double amount, string transactionCode)
        {
            Intent intent = new Intent(_context, typeof(LibLiteActivity));
            intent.PutExtra(LibLiteActivity.InApiKey, _apiKey);
            intent.PutExtra(LibLiteActivity.InCode, transactionCode);
            intent.PutExtra(LibLiteActivity.InSystem, _system);
            intent.PutExtra(LibLiteActivity.InAmount, amount);
            intent.AddFlags(ActivityFlags.NewTask);

            var currentActivity = Platform.CurrentActivity;
            currentActivity.StartActivityForResult(intent, 101);
        }
    }
}
