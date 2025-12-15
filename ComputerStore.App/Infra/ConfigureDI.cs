using AutoMapper;
using ComputerStore.App.ViewModel;

using ComputerStore.App.Others;
using ComputerStore.Domain.Base;
using ComputerStore.Domain.Entity;
using ComputerStore.Repository.Context;
using ComputerStore.Repository.Repository;
using ComputerStore.Service.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using System.Net.NetworkInformation;
using ComputerStore.App.Others;
using ComputerStore.App.Register;


namespace ComputerStore.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection services;
        public static IServiceProvider? serviceProvider;

        public static void ConfigureServices()
        {
            // data base config
            var dbConfigFile = "Config/DbConfig.txt";
            var strCon = File.ReadAllText(dbConfigFile);
            services = new ServiceCollection();
            services.AddDbContext<ComputerStoreContext>(
                options =>
                {
                    options.LogTo(Console.WriteLine);
                    options.UseMySQL(strCon);
                }
            );

            #region Repositories

            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            services.AddScoped<IBaseRepository<Client>, BaseRepository<Client>>();
            services.AddScoped<IBaseRepository<Supplier>, BaseRepository<Supplier>>();
            services.AddScoped<IBaseRepository<ProductOrService>, BaseRepository<ProductOrService>>();
            services.AddScoped<IBaseRepository<Ticket>, BaseRepository<Ticket>>();
            services.AddScoped<IBaseRepository<Sale>, BaseRepository<Sale>>();
            services.AddScoped<IBaseRepository<TicketUser>, BaseRepository<TicketUser>>();

            #endregion

            #region Services

            services.AddScoped<IBaseService<User>, BaseService<User>>();
            services.AddScoped<IBaseService<Client>, BaseService<Client>>();
            services.AddScoped<IBaseService<Supplier>, BaseService<Supplier>>();
            services.AddScoped<IBaseService<ProductOrService>, BaseService<ProductOrService>>();
            services.AddScoped<IBaseService<Ticket>, BaseService<Ticket>>();
            services.AddScoped<IBaseService<Sale>, BaseService<Sale>>();
            services.AddScoped<IBaseService<TicketUser>, BaseService<TicketUser>>();

            #endregion

            #region Forms
            services.AddTransient<LoginForm, LoginForm>();
            services.AddTransient<UserRegister, UserRegister>();
            services.AddTransient<ClientRegister, ClientRegister>();
            services.AddTransient<SupplierRegister, SupplierRegister>();
            services.AddTransient<ServiceRegister, ServiceRegister>();
            services.AddTransient<TicketRegister, TicketRegister>();

            #endregion

            services.AddSingleton(
                new MapperConfiguration(
                    config => {
                        config.CreateMap<User, UserViewModel>()
                        .ReverseMap();
                        config.CreateMap<Supplier, SupplierViewModel>()
                        .ReverseMap();
                        config.CreateMap<Client, ClientViewModel>()
                        .ReverseMap();
                        config.CreateMap<Ticket, TicketViewModel>()
                        .ReverseMap();
                        config.CreateMap<ProductOrService, ProductOrServiceViewModel>()
                        .ForMember(c => c.Supplier, opt => opt.MapFrom(src => src.Supplier))
                        .ReverseMap();
                    },
                    NullLoggerFactory.Instance).CreateMapper()
                );
            serviceProvider = services.BuildServiceProvider();

        }
    }
}
