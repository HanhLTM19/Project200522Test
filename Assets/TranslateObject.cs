using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateObject : MonoBehaviour
{

    public float maxSpeed;
    public float timeZeroToMax;
    float m_acceleration;
    public float forwardVelocity;

    // Start is called before the first frame update
    void Start()
    {
        m_acceleration = maxSpeed / timeZeroToMax;
        forwardVelocity = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        forwardVelocity += m_acceleration * Time.deltaTime;
        forwardVelocity = Mathf.Min(forwardVelocity, maxSpeed);
        transform.Translate(Vector3.forward * forwardVelocity);
        //transform.SetPositionAndRotation(transform.position, transform.rotation);
        Debug.Log(transform.position);
    }
}
