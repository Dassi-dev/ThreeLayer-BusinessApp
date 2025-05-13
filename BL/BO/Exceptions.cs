
namespace BO;

[Serializable]
public class BlKeyNotFoundException : Exception//מפתח לא קיים
{
    public BlKeyNotFoundException(string message) : base(message) { }
    public BlKeyNotFoundException(string message, Exception innerException) : base(message,innerException) { }

}
[Serializable]
public class BlKeyAlreadyExistException : Exception// קיים כבר מפתח זהה
{
    public BlKeyAlreadyExistException(string message) : base(message) { }
    public BlKeyAlreadyExistException(string message, Exception innerException) : base(message, innerException) { }
}
[Serializable]
public class BlArgumentNullException : Exception//כאשר מפעילים פונקציה על ארגומנט -אובייקט =null .
{
    public BlArgumentNullException(string message) : base(message) { }
    public BlArgumentNullException(string message, Exception innerException) : base(message,innerException) { }
}
public class BlOutOfStockException : Exception//אזל מהמלאי.
{
    public BlOutOfStockException(string message) : base(message) { }
    public BlOutOfStockException(string message, Exception innerException) : base(message, innerException) { }
}

