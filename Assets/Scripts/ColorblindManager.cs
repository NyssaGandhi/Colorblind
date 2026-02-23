using UnityEngine;

public enum VisionMode 
{ 
    Normal,         // Standard vision
    Protanopia,     // Red-blind
    Deuteranopia,   // Green-blind
    Tritanopia      // Blue-blind
}

public class ColorblindManager : MonoBehaviour
{
    public VisionMode currentMode = VisionMode.Normal;
    public Material colorblindMaterial; 

    public void SetVisionMode(int modeIndex)
    {
        currentMode = (VisionMode)modeIndex;
        UpdateShader();
    }

    private void UpdateShader()
    {
        if (colorblindMaterial != null)
        {
            colorblindMaterial.SetInt("_VisionMode", (int)currentMode);
        }
    }

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (currentMode == VisionMode.Normal || colorblindMaterial == null)
        {
            Graphics.Blit(source, destination);
        }
        else
        {
            Graphics.Blit(source, destination, colorblindMaterial);
        }
    }
}