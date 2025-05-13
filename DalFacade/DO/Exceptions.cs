

using System.Runtime.Serialization;
namespace DO;

[Serializable]
public class DalKeyNotFoundException : Exception {
    public DalKeyNotFoundException(string message):base(message) { }  
}
[Serializable]
public class DalKeyAlreadyExistException : Exception
{
    public DalKeyAlreadyExistException(string message) : base(message) { }
}
[Serializable]
public class DalArgumentNullException : Exception
{
    public DalArgumentNullException(string message) : base(message) { }
}
