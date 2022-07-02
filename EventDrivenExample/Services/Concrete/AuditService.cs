using EventDrivenExample.Services.Abstract;

namespace EventDrivenExample.Services.Concrete
{
    public class AuditService : IAuditService
    {
        public void WriteAuditLog(string text)
        {
            Console.WriteLine($"Audit Log : {text}");
        }
    }
}