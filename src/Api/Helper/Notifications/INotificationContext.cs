using FluentValidation.Results;

namespace Project.Notifications
{
    public interface INotificationContext
    {
        IReadOnlyCollection<Notification> Notifications { get; }
        bool HasNotifications { get; }

        void AddNotification(string key, string message);

    }
}
