namespace EventDrivenExample.Services.Abstract
{
    public interface IAuditService
    {
        void WriteAuditLog(string text);
    }
}