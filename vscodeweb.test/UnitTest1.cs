using NUnit.Framework;
using vscodeweb.data.Models;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void CanCreateTodoModel() {
            var todo = new Todos { Id = 1, Description = "test", IsComplete = false };
            Assert.AreEqual(todo,todo);
        }

        [Test]
        public void CanUseContext()
        {
            using (var ctx = new dataContext())
            {
                ctx.Todos.Add(new Todos{Id=1});
                ctx.SaveChanges();
                Assert.AreEqual(1,ctx.Todos.ToList().Count());
            }
        }
    }
}