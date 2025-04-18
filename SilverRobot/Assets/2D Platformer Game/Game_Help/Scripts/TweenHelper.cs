using System.Threading.Tasks;
using UnityEngine;

namespace Udacity.GameDevelopment.PlatformerGame.Game_Help
{
    /// <summary>
    /// Common helper methods for programmatically
    /// animating the properties of GameObjects.
    ///
    /// This provides nice visual polish to the game.
    ///
    /// NOTE: This is advanced code, and out of the scope of the course.
    /// </summary>
    public static class TweenHelper
    {
        public static async Task SetScaleAsync(Transform transform, Vector3 fromScale, Vector3 toScale, float durationInSeconds)
        {
            float elapsed = 0;

            while (elapsed < durationInSeconds)
            {
                elapsed += Time.deltaTime;
                float progress = elapsed / durationInSeconds;

                transform.localScale = Vector3.Lerp(fromScale, toScale, progress);

                // Await until the next frame
                await Task.Yield();

                // Check if the GameObject has been destroyed during the await
                if (transform == null)
                    return;
            }

            transform.localScale = toScale;
        }
    }
}