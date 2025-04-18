using UnityEngine;

namespace Udacity.GameDevelopment.PlatformerGame.Game_Help
{
    /// <summary>
    /// This is an optional behaviour for any object.
    ///
    /// Add this to a GameObject in the Scene and it will
    /// hover (slowly up and down) in the air.
    ///
    /// Learning Opportunity: Add a new SerializedField
    /// with a new value to further modify the behaviour
    /// of the movement (e.g. horizontal movement)
    /// </summary>
    public class HoverBehaviour : MonoBehaviour
    {
        //  Fields ----------------------------------------
        [Range(0.1f, 1f)]
        [SerializeField] 
        private float _amplitude = .01f;

        [Range(1,10)]
        [SerializeField] 
        private float _frequency = 5;

        //  Unity Methods ---------------------------------
        private void Update ()
        {
            Vector2 position = transform.position;
            position.y += Mathf.Sin(Time.time * _frequency) * _amplitude;
            transform.position = position;
        }
    }
}