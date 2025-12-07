using AutoMapper;
using ComputerStore.Domain.Base;
using ComputerStore.Repository.Repository;
using ComputerStore.Domain.Entity;
using ComputerStore.Repository.Context;
using ComputerStore.Service.Service;
using ComputerStore.Service.Validators;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using System.Text.Json;

namespace ComputerStore.Test
{
    [TestClass]
    public sealed class ServiceTest
    {
        private ServiceCollection services;
        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<ComputerStoreContext>();
            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            services.AddScoped<IBaseService<User>, BaseService<User>>();
            services.AddSingleton(
                new MapperConfiguration(
                    config => { config.CreateMap<User, User>(); },
                    NullLoggerFactory.Instance).CreateMapper()
                );
            return services.BuildServiceProvider();

        }
        [TestMethod]
        public void TestUserService()
        {
            var serviceProvider = ConfigureServices();
            var _userService = serviceProvider.GetService<IBaseService<User>>();

            var user = new User
            {
                Name = "Test2",
                Login = "tomatoma12",
                Password = "Password1@4"

            };
            var result = _userService.Add<User,User,UserValidator>(user);
            Console.WriteLine(JsonSerializer.Serialize(result));
            
        }
    }
}
