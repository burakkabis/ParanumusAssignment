using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{


    //Autofac bize hem IoC altyapisi saglar hem de AOP yapmamizi saglayayan bir teknolojidir.
    public class AutofacBusinessModule : Module
    {
        //Burada uygulama ayaga kalktiginda Ilgili soyut servislerin somut siniflari olusturuluyor.

        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            //Burada suan EfProductDal ile calisiyiorum.Yani entityframework ile calisiyorum.
            //Eger inMemory de calismak istersem sadece yapmam gereken EfProductDal yazmak yerone InMemoryProductDal yazmam yeterli.
            //Boylelikle hicbir katmana ,hicbir sinifa mudahele etmeden veri tabanimi degistirmis oluyorum.
            builder.RegisterType<InMemoryProductDal>().As<IProductDal>().SingleInstance();

           


            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();


        }
    }
}
