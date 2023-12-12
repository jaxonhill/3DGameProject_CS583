using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float m_Speed = 2000.0f;
    public Transform m_Tip = null;

    private Rigidbody m_Rigidbody = null;
    private bool m_IsStopped = true;
    private Vector3 m_lastPosition = Vector3.zero;

    void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }



    void FixedUpdate()
    {
        if (m_IsStopped) {  return; }

        m_Rigidbody.MoveRotation(Quaternion.LookRotation(m_Rigidbody.velocity, transform.up));

        if(Physics.Linecast(m_lastPosition, m_Tip.position))
        {
            Stop();
        }

        m_lastPosition = m_Tip.position;
    }
    private void Stop()
    {
        m_IsStopped = true;

        m_Rigidbody.isKinematic = true;
        m_Rigidbody.useGravity = false;
    }
    public void Fire(float pullValue)
    {
        m_IsStopped = false;

        transform.parent = null;

        m_Rigidbody.isKinematic = false;
        m_Rigidbody.useGravity = true;

        m_Rigidbody.AddForce(transform.forward * (pullValue * m_Speed));

        Destroy(gameObject, 8.0f);
    }
}
