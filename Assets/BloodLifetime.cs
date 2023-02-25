using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodLifetime : MonoBehaviour
{
    private void DestroyBlood() => Destroy(gameObject);
    public void Start() {
        Invoke("DestroyBlood", 2.0f);
    }
}
