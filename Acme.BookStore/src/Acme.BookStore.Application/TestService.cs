
using Volo.Abp.Application.Services;
using Acme.BookStore.Application.Contracts;
namespace Acme.BookStore.Application;

public class TestService : ApplicationService, ITestService
{
    public string Get()
    {
        return "hi";
    }
}