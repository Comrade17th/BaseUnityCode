using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRotation : MonoBehaviour
{
    [SerializeField] private Vector3 _speeds;

    private void Update(){
        transform.Rotate(_speeds);
    }
}
