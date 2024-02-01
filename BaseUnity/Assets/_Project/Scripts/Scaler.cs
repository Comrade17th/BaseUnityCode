using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _scaleSpeed;

    private void Update(){
        Vector3 newScale = transform.localScale + _scaleSpeed;
        transform.localScale = newScale;
    }
}
