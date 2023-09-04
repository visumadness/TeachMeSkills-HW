using E1.NewFolder;
using E2.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2.ProgramBuilder
{
    internal class ServiceBuildLogger
    {

        private readonly ILogger _logger;
        private readonly BaseBuilder _builder;
        private int _i = 0;

        public ServiceBuildLogger(ILogger logger, BaseBuilder builder)
        {
            _logger = logger ?? throw new ArgumentNullException();
            _builder = builder;
        }

        public void DoThings()
        {
            _logger.Log($"{nameof(DoThings)} started: i = {_i}");
            _i++;
            _logger.Log($"{nameof(DoThings)} finished: i = {_i}");
        }

        public void BuildHouse()
        {
            _builder. HouseBuild();
        }
    }
}
