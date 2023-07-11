using Follower;
using Player;

namespace Initializer
{
    public interface IInitializer
    {
        IPlayer Player{ get; }
        IFollower Follower { get; }
    }
}