namespace PearlBookstore.API.Extensions
{
    public static class CompareDateExtension
    {
        public static bool IsAtLeast14DaysEarlierThanToday(this DateOnly earlierDate)
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Today);
            return (today.ToDateTime(TimeOnly.MinValue) - earlierDate.ToDateTime(TimeOnly.MinValue)).Days >= 14;
        }
    }
}
