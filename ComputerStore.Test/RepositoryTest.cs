
using ComputerStore.Domain.Entity;
using ComputerStore.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace ComputerStore.Test
{
    [TestClass]
    public sealed class RepositoryTest
    {
        [TestMethod]
        public void TestUser()
        {
            var op = new DbContextOptionsBuilder<ComputerStoreContext>();
            op.UseMySQL("server=localhost;database=ComputerStore;user=root;password=");
            
            using (var context = new ComputerStoreContext(op.Options))
            {
                Console.WriteLine("Connected");
                var user1 = new User(1, "Heloisa", true, "helolinda1", "Amovc@1aaa");
                var user2 = new User(2, "Caio", true, "amominhanamorada1", "AmoHelo@1aaa");

                context.Users.Add(user1);
                context.Users.Add(user2);
                
                context.SaveChanges();
                Console.WriteLine("Well done!");

                foreach (var cat in context.Users)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cat));

                }

            }

        }
    }
}
