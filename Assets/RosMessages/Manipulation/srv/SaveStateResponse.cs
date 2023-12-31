//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Manipulation
{
    [Serializable]
    public class SaveStateResponse : Message
    {
        public const string k_RosMessageName = "manipulation_msgs/SaveState";
        public override string RosMessageName => k_RosMessageName;

        public Std.BoolMsg success;

        public SaveStateResponse()
        {
            this.success = new Std.BoolMsg();
        }

        public SaveStateResponse(Std.BoolMsg success)
        {
            this.success = success;
        }

        public static SaveStateResponse Deserialize(MessageDeserializer deserializer) => new SaveStateResponse(deserializer);

        private SaveStateResponse(MessageDeserializer deserializer)
        {
            this.success = Std.BoolMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "SaveStateResponse: " +
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
