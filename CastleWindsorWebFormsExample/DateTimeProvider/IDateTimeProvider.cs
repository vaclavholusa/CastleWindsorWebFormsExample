using System;

namespace CastleWindsorWebFormsExample
{
    public interface IDateTimeProvider
    {
        DateTime Now { get; }
    }
}