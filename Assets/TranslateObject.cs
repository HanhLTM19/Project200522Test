using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateObject : MonoBehaviour
{

    public float maxSpeed;
    public float timeZeroToMax;
    float m_acceleration;
    public float forwardVelocity;
    Vector3 m_translate;
    Quaternion m_rotate;

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
        //transform.Translate(Vector3.forward * forwardVelocity);
        m_translate = transform.position + Vector3.forward * forwardVelocity * Time.deltaTime;
        transform.Rotate(new Vector3 (1, 1, 0) * Time.deltaTime * 40);
        transform.SetPositionAndRotation(m_translate, transform.rotation);
        
        Debug.Log(transform.position);

       
    }
}
