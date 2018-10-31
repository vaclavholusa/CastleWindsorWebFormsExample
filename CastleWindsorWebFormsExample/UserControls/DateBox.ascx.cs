using System;

namespace CastleWindsorWebFormsExample.UserControls
{
    public partial class DateBox : System.Web.UI.UserControl
    {
        protected IDateTimeProvider DateTimeProvider { get; }

        public DateBox(IDateTimeProvider dateTimeProvider)
        {
            DateTimeProvider = dateTimeProvider;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}