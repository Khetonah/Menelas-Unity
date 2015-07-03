using UnityEngine;
using System.Collections;

public class CameraFollowin : MonoBehaviour {

    public float dampTime = 0.15f;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            transform.position = new Vector3(target.position.x, target.position.y, -1);
        }

    }
}
