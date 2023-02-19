using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public Vector3 Velocity;
    public Transform Target;
    
    private float _timer;
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > 1)
        {
            transform.localScale += new Vector3(0.25f, 0.25f, 0.25f);
            _timer = 0;
        }
        Vector3 motion = Velocity * Time.deltaTime;
        transform.position += motion;

        transform.LookAt(Target);
    }

    
}
