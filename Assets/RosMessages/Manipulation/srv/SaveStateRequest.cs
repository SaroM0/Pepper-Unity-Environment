//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Manipulation
{
    [Serializable]
    public class SaveStateRequest : Message
    {
        public const string k_RosMessageName = "manipulation_msgs/SaveState";
        public override string RosMessageName => k_RosMessageName;

        public Std.StringMsg name;

        public SaveStateRequest()
        {
            this.name = new Std.StringMsg();
        }

        public SaveStateRequest(Std.StringMsg name)
        {
            this.name = name;
        }

        public static SaveStateRequest Deserialize(MessageDeserializer deserializer) => new SaveStateRequest(deserializer);

        private SaveStateRequest(MessageDeserializer deserializer)
        {
            this.name = Std.StringMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.name);
        }

        public override string ToString()
        {
            return "SaveStateRequest: " +
            "\nname: " + name.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
