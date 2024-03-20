using Castle.DynamicProxy;
using Core.Extensions;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessAspects.Autofac
{

    //Secured Operation JWT icin.

    //Security icin AOP temel kodu
    //Burada goruldugu gibi Secured Operation methodu Method Interceoption sinifini inherit ediyor.
    //Method Interception virtual olarak bazi methodlari bulunuyor(onBefore,onSuccess gibi.)Bu sinifta ise istedigimiz methodu ezebiliyoruz.
    //Urun eklenmeden once yetki kontrolunun yapilmasi gerekli oldugu icin OnBefore methodunu ezip orda rol bazli kontrol yapiyorum.

    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;

        //Secured Operation constructordan roles talep ediyor.

        public SecuredOperation(string roles)
        {
            _roles = roles.Split(',');
            //Autofac ile olusturmus oldugum servis mimarisine ulasir.
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();

        }

        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            foreach (var role in _roles)
            {
                if (roleClaims.Contains(role))
                {
                    return;
                }
            }
            throw new Exception("Yetkiniz yok.");
        }
    }
}
