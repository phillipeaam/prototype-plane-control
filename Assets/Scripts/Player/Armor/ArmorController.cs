using Base;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Player.Armor
{
    public class ArmorController : IController
    {
        private readonly IArmor _armor;
        
        public ArmorController(IArmor armor)
        {
            _armor = armor;
        }

        public void Initialize()
        {
            _armor.OnCollision += ResetScene;
        }

        public void Dispose()
        {
            _armor.OnCollision -= ResetScene;
        }
        
        private void ResetScene(Collision other)
        {
            if (other == null)
                return;
            
            // reset the scene if the player collides with anything
            var activeScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(activeScene.buildIndex);
        }
    }
}