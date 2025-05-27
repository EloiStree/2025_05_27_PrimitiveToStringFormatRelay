using UnityEngine;
using UnityEngine.Events;

namespace Eloi.StringFormat
{
    public class FormatToolMono_TranformToRelay:MonoBehaviour { 

        public Transform m_targetTransform ;
        public UnityEvent<Vector3> m_position;
        public UnityEvent<Vector3> m_rotationEuler;
        public UnityEvent<Quaternion> m_rotation;
        public UnityEvent<Vector3> m_scale;


        private void Reset()
        {
            m_targetTransform = GetComponent<Transform>();
        }
        public void Update()
        {
            if (m_targetTransform == null) return;
            m_position?.Invoke(m_targetTransform.position);
            m_rotationEuler?.Invoke(m_targetTransform.rotation.eulerAngles);
            m_rotation?.Invoke(m_targetTransform.rotation);
            m_scale?.Invoke(m_targetTransform.localScale);
        }

    }

}