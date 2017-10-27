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

        public CommandsService commandService;
        public CoordinatesTransformationService coordinatesTransformationService;

        private ServicesSingleton() { }

        public static ServicesSingleton getInstance()
        {
            if (_instance == null)
            {
                return new ServicesSingleton();
            }
            return _instance;
        }
    }
}

