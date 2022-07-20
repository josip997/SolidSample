using ArdalisRating.Core.Model;

namespace ArdalisRating.Core.Interfaces
{
    public interface IRater
    {
        void Rate(Policy policy);
    }
}