using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;


    public class movePlayer : MonoBehaviour
    {
        public float m_Speed = 12f;
        private PhotonView PV;
        Rigidbody rb;
        private string m_MovementAxisName;
        private string m_ZoomAxisName;
        private string m_TurnAxisName;
        private Rigidbody m_Rigidbody;
        private float m_MovementInputValue;
        private float m_ZoomInputValue;
        private float m_TurnInputValue;

        private void Start()
        {
            m_Rigidbody = GetComponent<Rigidbody>();
            PV = GetComponent<PhotonView>();
            m_ZoomAxisName = "Mouse ScrollWheel";
            m_MovementAxisName = "Vertical";
            m_TurnAxisName = "Horizontal";
            m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        }

    

    void Awake()
    {

        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        m_ZoomInputValue = Input.GetAxis(m_ZoomAxisName);
        m_MovementInputValue = Input.GetAxis(m_MovementAxisName);
        m_TurnInputValue = Input.GetAxis(m_TurnAxisName);

    }




    private void FixedUpdate()
    {
        if (PV.IsMine)
        {
            if(transform.position.y > 1.6 && transform.position.y < 7.3)
            {
                Zoom();
            }
            else if (transform.position.y < 7.3)
            {
                m_Rigidbody.MovePosition(m_Rigidbody.position + new Vector3(0,0.01f,0));
            }
            else
            {
                m_Rigidbody.MovePosition(m_Rigidbody.position - new Vector3(0, 0.01f, 0));
            }



            if(transform.position.x > -1.5 && transform.position.x < 4.9)
            {
                Turn();
            }
            else if (transform.position.x < 4.9)
            {
                m_Rigidbody.MovePosition(m_Rigidbody.position + new Vector3(0.01f, 0, 0));
            }
            else
            {
                m_Rigidbody.MovePosition(m_Rigidbody.position - new Vector3(0.01f, 0, 0));
            }



            if (transform.position.z > -4.0 && transform.position.z < 4.0)
            {
                Move();
            }
            else if (transform.position.z < 4.0)
            {
                m_Rigidbody.MovePosition(m_Rigidbody.position + new Vector3(0, 0, 0.01f));
            }
            else
            {
                m_Rigidbody.MovePosition(m_Rigidbody.position - new Vector3(0, 0, 0.01f));
            }


        }
    }

    //1.6 7.3
        private void Zoom()
        {
            Vector3 movement = transform.forward * m_ZoomInputValue * m_Speed * Time.deltaTime;

            m_Rigidbody.MovePosition(m_Rigidbody.position + movement);
        }
        private void Turn()
        {
            Vector3 movement = transform.right * m_TurnInputValue * m_Speed * Time.deltaTime;

            m_Rigidbody.MovePosition(m_Rigidbody.position + movement);

        }
        private void Move()
        {
            Vector3 movement = transform.up * m_MovementInputValue * m_Speed * Time.deltaTime;

            m_Rigidbody.MovePosition(m_Rigidbody.position + movement);

        }

}

