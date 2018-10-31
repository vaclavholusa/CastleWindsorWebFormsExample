namespace CastleWindsorWebFormsExample
{
    public partial class Default : System.Web.UI.Page
    {
        protected IDateTimeProvider DateTimeProvider { get; }

        public Default(IDateTimeProvider dateTimeProvider)
        {
            DateTimeProvider = dateTimeProvider;
        }
    }
}