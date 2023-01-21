using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Traversal.BusinessLayer.Abstract;
using Traversal.BusinessLayer.Abstract.UnitOfWork;
using Traversal.BusinessLayer.Concrete;
using Traversal.BusinessLayer.Concrete.UnitOfWork;
using Traversal.BusinessLayer.ValidationRules;
using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.EntityFramework;
using Traversal.DataAccessLayer.UnitOfWork;
using Traversal.DTOLayer.DTOs.AnnouncementDTOs;

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

            services.AddScoped<IExcelService, ExcelManager>();
            services.AddScoped<IPdfService, PdfManager>();

            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IContactUsDAL, EFContactUsDAL>();

            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDAL, EFAnnouncementDAL>();

            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IAccountDAL, EFAccountDAL>();

            services.AddScoped<IUnitOfWorkDAL, UnitOfWorkDAL>();
        }

        public static void CustomerValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDTO>, AnnouncementValidator>();
        }
    }
}
