namespace MasterPassPoc.Service
{
    public interface IMasterPassService
    {
        void PerformCheckout(string transactionCode);
        void PreRegisterUser();
        void DisplayWallet();
        void PerformTipAnAttendantCheckout(double amount, string transactionCode);
    }
}