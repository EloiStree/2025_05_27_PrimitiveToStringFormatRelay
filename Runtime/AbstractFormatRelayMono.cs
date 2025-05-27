using UnityEngine;
using UnityEngine.Events;

namespace Eloi.StringFormat
{

    public abstract class AbstractFormatRelayMono<T> : MonoBehaviour
    {
        
        public string m_format = "{0:0.00}, {1:0.00}, {2:0.00}";
        public string m_lastPushedValue = "";
        public UnityEvent<string> m_onPushed;
        public void PushIn(T value)
        {
            BuildString(value, out string stringBuild);
            PushBuildString(stringBuild);
        }
        public void PushBuildString(string value)
        {
            m_lastPushedValue = value;
            m_onPushed?.Invoke(value);
        }
        public virtual void BuildString(T value, out string stringBuild) {
            stringBuild = string.Format(m_format, value);
        }

        public virtual void GetDefaultFortmatAtReset(out string formatAtReset) {

            formatAtReset = "{0}";
        }
    }

}