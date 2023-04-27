using FluentValidation;
using MediatR;
using Project.ErrorCodes;
using Project.Notifications;

namespace Project.Api.Helpers
{
    public class ValidationBehavoir<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        private readonly INotificationContext notificationContext;
        private readonly IEnumerable<IValidator> validators;

        public ValidationBehavoir(
            INotificationContext notificationContext,
            IEnumerable<IValidator<TRequest>> validators)
        {
            this.notificationContext = notificationContext;
            this.validators = validators;
        }

        public async Task<TResponse> Handle(
            TRequest request,
            CancellationToken cancellationToken,
            RequestHandlerDelegate<TResponse> next)
        {
            var requestToValidate = new ValidationContext<TRequest>(request);

            var failures = validators
                .Select(v => v.Validate(requestToValidate))
                .SelectMany(result => result.Errors)
                .Where(f => f != null)
                .ToList();

            if (failures.Any())
            {
                foreach (var error in failures)
                {
                    notificationContext.AddNotification(GenericErrorCodes.INPUT_VALIDATION, error.ErrorMessage);
                }

                return default;
            }

            return await next();
        }
    }
}
