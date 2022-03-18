namespace ProductHistoryBusiness;
public interface IOperationResult
{
    Exception Error { get; }

    string ErrorDetail { get; }

    string ErrorMessage { get; }

    FailureReason FailureReason { get; }

    bool Success { get; }
    IEnumerable<ValidationError> ValidationErrors { get; }
}

public enum FailureReason
{
    None,
    ItemNotFound,
    Forbidden,
    DatabaseError,
    ClientError,
    GenericError,
    BusinessLogic
}

public class ValidationError
{
    public string Name { get; }
    public string Message { get; }
    public ValidationError(string name, string message)
    {
        Name = name[(name.LastIndexOf('.') + 1)..];
        Message = message;
    }
}