namespace IBTFull.Models
{
    public class Language
    {
        public Language(string currentLanguage, string returnUrl)
        {
            CurrentLanguage = currentLanguage;
            ReturnUrl = returnUrl;
        }

        public readonly string CurrentLanguage;
        public readonly string ReturnUrl;
    }
}