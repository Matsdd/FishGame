using UnityEngine;
using UnityEngine.UI;

public class FishImageScript : MonoBehaviour
{
    public void SetFishSprite(Sprite fishSprite)
    {
        // Set the sprite of the Image component dynamically
        Image fishImage = GetComponent<Image>();
        if (fishImage != null)
        {
            fishImage.sprite = fishSprite;
        }
        else
        {
            Debug.LogError("Image component not found.");
        }
    }
}
