using Bomberman_1.services;
using BomberManProject.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberManProject.Singleton
{
    class ServicesSingleton
    {
        private static ServicesSingleton _instance;

        public CommandsService commandService = new CommandsService();
        public CoordinatesTransformationService coordinatesTransformationService;


        private ServicesSingleton() { }

        public static ServicesSingleton getInstance()
        {
            Console.WriteLine("singleton veiki.");
            if (_instance == null)
            {
                return new ServicesSingleton();
            }
            return _instance;
        }
    }
}

