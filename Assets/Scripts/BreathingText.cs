using UnityEngine;
using TMPro;

public class BreathingText : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float breathSpeed = 2f;
    public float minAlpha = 0.1f;
    public float maxAlpha = 1f;
    
    void Update()
    {
        // Calculate breathing effect using sine wave
        float alpha = Mathf.Lerp(minAlpha, maxAlpha, (Mathf.Sin(Time.time * breathSpeed) + 1f) / 2f);
        
        // Apply alpha to text color
        Color newColor = text.color;
        newColor.a = alpha;
        text.color = newColor;
    }
}