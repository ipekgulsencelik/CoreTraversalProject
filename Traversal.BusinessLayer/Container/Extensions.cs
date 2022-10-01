using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Abstract;
using Traversal.BusinessLayer.Concrete;
using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.EntityFramework;

namespace Traversal.BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDAL, EFCommentDAL>();

            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDAL, EFDestinationDAL>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDAL, EFAppUserDAL>();

            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDAL, EFReservationDAL>();

            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IGuideDAL, EFGuideDAL>();

            //services.AddScoped<IExcelService, ExcelManager>();
            //services.AddScoped<IPdfService, PdfManager>();
        }
    }
}
