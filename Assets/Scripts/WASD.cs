using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WASD : MonoBehaviour
{
    public TextMeshProUGUI  WText;
    public TextMeshProUGUI  AText;
    public TextMeshProUGUI  SText;
    public TextMeshProUGUI  DText;
    
    private Color originalColor;
    public Color highlightColor;
    
    void Start()
    {
        originalColor = WText.color;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            HighlightText(WText);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            HighlightText(AText);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            HighlightText(SText);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            HighlightText(DText);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            ResetTextColor(WText);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            ResetTextColor(AText);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            ResetTextColor(SText);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            ResetTextColor(DText);
        }
    }
    
    void HighlightText(TextMeshProUGUI text)
    {
        text.color = highlightColor;
        text.color = new Color(text.color.r, text.color.g, text.color.b, 1f); // Set the alpha value to 1
    }
    
    void ResetTextColor(TextMeshProUGUI text)
    {
        text.color = originalColor;
    }
}
