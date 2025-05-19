
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Application.Contracts;

public interface ITestService : IApplicationService
{
    string Get();
}