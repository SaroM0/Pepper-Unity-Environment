//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Manipulation
{
    [Serializable]
    public class GoToPoseResponse : Message
    {
        public const string k_RosMessageName = "manipulation_msgs/GoToPose";
        public override string RosMessageName => k_RosMessageName;

        public Std.BoolMsg success;

        public GoToPoseResponse()
        {
            this.success = new Std.BoolMsg();
        }

        public GoToPoseResponse(Std.BoolMsg success)
        {
            this.success = success;
        }

        public static GoToPoseResponse Deserialize(MessageDeserializer deserializer) => new GoToPoseResponse(deserializer);

        private GoToPoseResponse(MessageDeserializer deserializer)
        {
            this.success = Std.BoolMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "GoToPoseResponse: " +
            "\nsuccess: " + success.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize, MessageSubtopic.Response);
        }
    }
}
