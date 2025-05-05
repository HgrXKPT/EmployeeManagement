namespace EmployeeManagement.Utils.Exceptions
{
    public class ExistingDataInDatabaseException : Exception
    {
        public ExistingDataInDatabaseException(string mensagem) : base(mensagem) { }
    }
}
