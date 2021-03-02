using UnityEngine;

namespace AnneCHPostma.DevTools
{
    public class QuitApplication : MonoBehaviour
    {
        private void Update()
        {
            // Check to see if the ESCape character is pressed
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }
}
