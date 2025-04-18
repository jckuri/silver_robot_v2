using UnityEngine;

namespace Udacity.GameDevelopment.PlatformerGame.Game_Help
{
    /// <summary>
    /// Common helper methods for checking GameObject
    /// properties in exceptional cases
    ///
    /// NOTE: This is advanced code, and out of the scope of the course.
    /// </summary>
    public static class GameObjectHelper
    {
        public static void DestroySafe(GameObject gameObject)
        {
            if (!GameObjectIsNull(gameObject))
            {
                GameObject.Destroy(gameObject);
            }
        }
        
        private static bool GameObjectIsNull(GameObject gameObject)
        {
            return object.Equals(gameObject, null) || 
                   gameObject == null || 
                   gameObject.transform == null;
        }
    }
}