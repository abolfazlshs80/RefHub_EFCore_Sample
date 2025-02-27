namespace RefHub_EFCore_Sample.Exception
{

    public class ValidateModelException : System.Exception
    {
        public ValidateModelException()
        {
        }

        public ValidateModelException(string message)
            : base(message)
        {
        }

        public ValidateModelException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }

}
