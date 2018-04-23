<<<<<<< HEAD
namespace VRTK.Examples.PanelMenu
{
    using UnityEngine;

    /// <summary>
    /// Demo component for Panel Menu example scene.
    /// </summary>
    /// <example>
    /// See the demo scene for a complete example: [ 038_Controls_Panel_Menu ]
    /// </example>
    public class PanelMenuDemoSphere : MonoBehaviour
    {
        private readonly Color[] colors =
        {
        Color.black,
        Color.blue,
        Color.cyan,
        Color.gray,
        Color.green,
        Color.magenta,
        Color.red,
        Color.white,
        Color.yellow,
        Color.black
    };

        public void UpdateSliderValue(float value)
        {
            GetComponent<MeshRenderer>().materials[0].color = colors[(int)(value - 1)];
        }
    }
=======
namespace VRTK.Examples.PanelMenu
{
    using UnityEngine;

    /// <summary>
    /// Demo component for Panel Menu example scene.
    /// </summary>
    /// <example>
    /// See the demo scene for a complete example: [ 038_Controls_Panel_Menu ]
    /// </example>
    public class PanelMenuDemoSphere : MonoBehaviour
    {
        private readonly Color[] colors =
        {
        Color.black,
        Color.blue,
        Color.cyan,
        Color.gray,
        Color.green,
        Color.magenta,
        Color.red,
        Color.white,
        Color.yellow,
        Color.black
    };

        public void UpdateSliderValue(float value)
        {
            GetComponent<MeshRenderer>().materials[0].color = colors[(int)(value - 1)];
        }
    }
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
}