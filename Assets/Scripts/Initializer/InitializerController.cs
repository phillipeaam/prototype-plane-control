using System.Collections.Generic;
using Base;
using Follower;
using Player;

namespace Initializer
{
    public class InitializerController : IController
    {
        private readonly List<IController> _controllers = new();
        
        public InitializerController(IInitializer initializer)
        {
            _controllers = new()
            {
                new PlayerController(initializer.Player),
                new FollowerController(initializer.Follower)
            };
        }

        public void Initialize()
        {
            foreach (var controller in _controllers)
            {
                controller.Initialize();
            }
        }

        public void Dispose()
        {
            foreach (var controller in _controllers)
            {
                controller.Dispose();
            }
        }
    }
}