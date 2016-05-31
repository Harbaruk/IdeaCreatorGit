using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IdeaCreator.Models.Abstract;
using IdeaCreator.Models.Concrete;

namespace IdeaCreator.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IUserRepository>().To<UserRepository>();
            kernel.Bind<IIdeasRepository>().To<IdeaRepository>();
            kernel.Bind<IVotingRepository>().To<VotingRepository>();
            kernel.Bind<ICommentRepository>().To<CommentRepository>();
        }
    }
}