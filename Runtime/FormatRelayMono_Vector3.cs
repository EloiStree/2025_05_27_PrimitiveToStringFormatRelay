using UnityEngine;

namespace Eloi.StringFormat
{

    public class FormatRelayMono_Vector3 : AbstractFormatRelayMono<Vector3>
    {
        private void Reset()
        {
            m_format = "{0:0.00}, {1:0.00}, {2:0.00}";
        }
        public override void BuildString(Vector3 value, out string stringBuild)
        {
            stringBuild = string.Format(m_format, value.x, value.y, value.z);
        }
    }

}