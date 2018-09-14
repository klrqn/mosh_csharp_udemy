using System;

namespace composition
{


    public class Installer
    {   
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("We are installing the application.");
        }
    }

///

    public class DbMigrator
    {
        private readonly Logger _logger; // "composition" uses Logger

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are Migrating ....");
        }
    }

///

    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var DbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            DbMigrator.Migrate();

            installer.Install();
        }
    }
}
