namespace AddressBook
{
    public class AddressBookConsts
    {
        public const string LocalizationSourceName = "AddressBook";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;
        
        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public const string DefaultPassPhrase = "42c659fa4c364c709591e0a63b9ddbaf";
    }
}
