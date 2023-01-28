using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUpdate : MonoBehaviour
{
    [SerializeField]
    private Image[] images;

    public void UpdateHealth(float health) {
        for (int index = 0; index < images.Length; index++)
            images[index].gameObject.SetActive(health > index);
    }
}
