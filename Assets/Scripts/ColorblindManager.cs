using UnityEngine;

public enum VisionMode 
{ 
    Normal = 0,
    Protanopia = 1,
    Deuteranopia = 2,
    Tritanopia = 3
}

public class ColorblindManagerURP : MonoBehaviour
{
    [Tooltip("Drop the Material using your Colorblind Shader here")]
    public Material colorblindMaterial; 

    void Start()
    {
        // Ensure the game starts in Normal vision mode
        SetVisionMode(0); 
    }

    // Link your UI Buttons to this method (Pass 0, 1, 2, or 3)
    public void SetVisionMode(int modeIndex)
    {
        if (colorblindMaterial != null)
        {
            // _VisionMode must exactly match the property Reference name in your Shader Graph
            colorblindMaterial.SetInt("_VisionMode", modeIndex);
        }
        else
        {
            Debug.LogWarning("Colorblind Material is not assigned in the Inspector!");
        }
    }
}