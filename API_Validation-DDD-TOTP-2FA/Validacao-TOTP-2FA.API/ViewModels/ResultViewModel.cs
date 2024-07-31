namespace Validacao_TOTP_2FA.API.ViewModels
{
    public class ResultViewModel
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public dynamic Data { get; set; } //dynamic é tipo flexivel
    }
}
