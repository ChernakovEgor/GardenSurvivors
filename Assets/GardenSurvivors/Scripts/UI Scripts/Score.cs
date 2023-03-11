using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private TextMeshProUGUI _textMesh;
    void Awake()
    {
        _textMesh = GetComponent<TextMeshProUGUI>();
    }

    public void Set(int value) {
        _textMesh.text = $"Score: {value}";
    }
}
