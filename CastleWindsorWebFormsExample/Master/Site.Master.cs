namespace CastleWindsorWebFormsExample
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected IDateTimeProvider DateTimeProvider { get; }

        public Site(IDateTimeProvider dateTimeProvider)
        {
            DateTimeProvider = dateTimeProvider;
        }
    }
}