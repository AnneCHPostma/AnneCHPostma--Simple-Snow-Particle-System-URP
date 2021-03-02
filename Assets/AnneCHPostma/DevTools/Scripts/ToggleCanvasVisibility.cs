using UnityEngine;

namespace AnneCHPostma.DevTools
{
    [RequireComponent(typeof(GameObject))]
    public class ToggleCanvasVisibility : MonoBehaviour
    {
        [Tooltip("Add a Canvas, which needs a visibility toggle option")]
        [SerializeField]
        private Canvas _canvas = null;

        private void Update()
        {
            if (_canvas == null)
            {
                Debug.LogError("No Canvas found for the ToggleCanvasVisibility script.");

                return;
            }

            // Check to see if the '~' character is pressed
            if (Input.GetKeyDown(KeyCode.BackQuote))
            {
                _canvas.enabled = !_canvas.enabled;
            }
        }
    }
}
