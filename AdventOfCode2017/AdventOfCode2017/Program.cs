using AdventOfCode2017.Assignments;
using StructureMap;

namespace AdventOfCode2017
{
    public class Program
    {
        static void Main(string[] args)
        {
            var container = new Container(c => {
                RegisterDependencies(c);
            });

            var runner = container.GetInstance<IAssignmentRunner>();

            runner.RunnAll();
        }

        private static void RegisterDependencies(ConfigurationExpression c)
        {
            c.For<IAssignmentRunner>().Use<AssignmentRunner>();
            c.For<IDecemberFirst>().Use<DecemberFirst>();
            c.For<IDecemberSecond>().Use<DecemberSecond>();
        }
    }
}
