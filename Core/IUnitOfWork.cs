using System;

namespace Mvc5_Boilerplate.Core
{
    public interface IUnitOfWork : IDisposable
    {
        //Add Concrete repositories here example
        //IPersonRepository People { get; }
        int Complete();
    }
}