using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{

    void Start() {
        transform.rotation = Quaternion.LookRotation(Vector3.zero);
    }
    public Transform player;
    public float pLerp = 0.02f;
    public float rLerp = 0.02f;
    void Update() {
        transform.position = Vector3.Lerp(transform.position, player.position, pLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, player.rotation, rLerp);
    }
}
