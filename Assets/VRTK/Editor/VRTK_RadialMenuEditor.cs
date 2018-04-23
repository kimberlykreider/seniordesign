<<<<<<< HEAD
namespace VRTK
{
    using UnityEngine;
    using UnityEditor;

    [CustomEditor(typeof(VRTK_RadialMenu))]
    public class VRTK_RadialMenuEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            VRTK_RadialMenu rMenu = (VRTK_RadialMenu)target;
            if (GUILayout.Button("Regenerate Buttons"))
            {
                rMenu.RegenerateButtons();
            }
        }
    }
=======
namespace VRTK
{
    using UnityEngine;
    using UnityEditor;

    [CustomEditor(typeof(VRTK_RadialMenu))]
    public class VRTK_RadialMenuEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            VRTK_RadialMenu rMenu = (VRTK_RadialMenu)target;
            if (GUILayout.Button("Regenerate Buttons"))
            {
                rMenu.RegenerateButtons();
            }
        }
    }
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
}