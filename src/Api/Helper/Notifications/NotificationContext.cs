using FluentValidation.Results;

namespace Project.Notifications
{
    public class NotificationContext : INotificationContext
    {
        public IReadOnlyCollection<Notification> Notifications => _notifications;
        public bool HasNotifications => _notifications.Any();

        private readonly List<Notification> _notifications;

        public NotificationContext()
        {
            _notifications = new List<Notification>();
        }

		public void AddNotification(string key, string message)
		{
			_notifications.Add(new Notification(key, message));
		}

		public void AddNotification(Notification notification)
		{
			_notifications.Add(notification);
		}

		public void AddNotifications(IReadOnlyCollection<Notification> notifications)
		{
			_notifications.AddRange(notifications);
		}

		public void AddNotifications(IList<Notification> notifications)
		{
			_notifications.AddRange(notifications);
		}

		public void AddNotifications(ICollection<Notification> notifications)
		{
			_notifications.AddRange(notifications);
		}

		public void AddNotifications(ValidationResult validationResult)
		{
			foreach (var error in validationResult.Errors)
			{
				AddNotification(error.ErrorCode, error.ErrorMessage);
			}
		}

		public void ThrowExceptionIfHasAnyNotification(string requestName)
		{
			if (HasNotifications)
				throw new InvalidOperationException($"Failed to execute {requestName} request param: {Notifications.First().Message}. Total notifications: {Notifications.Count}");
		}

        public void ThrowExceptionIfHasAnyNotification()
        {
            if (HasNotifications)
				throw new InvalidOperationException($"Failed to execute mediator request! Message: {Notifications.First().Message}. Total notifications: {Notifications.Count}");
        }
    }
}
