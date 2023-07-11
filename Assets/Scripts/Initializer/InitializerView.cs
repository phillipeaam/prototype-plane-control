using Follower;
using Player;
using UnityEngine;

namespace Initializer
{
    public class InitializerView : MonoBehaviour, IInitializer
    {
        [SerializeField] private PlayerView _playerView;
        public IPlayer Player => _playerView;
        
        [SerializeField] private FollowerView _followerView;
        public IFollower Follower => _followerView;

        private void Awake()
        {
            var initializerController = new InitializerController(this);
            initializerController.Initialize();
        }
    }
}