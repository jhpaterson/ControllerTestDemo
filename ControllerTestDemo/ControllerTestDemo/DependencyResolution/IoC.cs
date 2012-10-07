using StructureMap;
namespace ControllerTestDemo {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                             x.For<ControllerTestDemo.Domain.IUserRepository>().
                                 Use<ControllerTestDemo.Data.EF.UserRepository>();
                        });
            return ObjectFactory.Container;
        }
    }
}