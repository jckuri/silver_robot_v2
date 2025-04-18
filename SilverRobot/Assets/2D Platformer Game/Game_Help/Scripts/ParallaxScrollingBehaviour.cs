using UnityEngine;

namespace Udacity.GameDevelopment.PlatformerGame.Game_Help
{
    /// <summary>
    /// This is an optional behaviour for any object.
    ///
    /// Add this to a GameObject in the Scene and it will
    /// move in coordination with the camera to create a sense
    /// of visual depth in the game world while scrolling.
    ///
    /// Learning Opportunity: Add a new Sprite of any type
    /// to the scene and add this behaviour. Then tweak
    /// the serialized values using the inspector to
    /// experiment with different results.
    /// </summary>
    public class ParallaxScrollingBehaviour : MonoBehaviour
    {
        
        //  Fields ----------------------------------------
        [SerializeField]
        private Camera _camera;
        
        [Range(0.1f, 1f)]
        [SerializeField]
        private float _relativeSpeed;

        
        //  Unity Methods ---------------------------------
        private void Update()
        {
            transform.position = new Vector2(
                _camera.transform.position.x * _relativeSpeed, 
                _camera.transform.position.y * _relativeSpeed);
        }
    }
}