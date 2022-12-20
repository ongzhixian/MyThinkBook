namespace MyThinkBook.Web.Services;

public interface ITimeService
{
    void SetTime(DateTime dateTime);

    DateTime GetTime();
}

public class TimeService : ITimeService
{
    private DateTime? dateTime;

    public TimeService()
    {
    }

    public void SetTime(DateTime dateTime)
    {
        this.dateTime = dateTime;
    }

    public DateTime GetTime() {
        return dateTime ?? DateTime.UtcNow;
    }
}
