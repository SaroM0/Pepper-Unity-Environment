//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Manipulation
{
    [Serializable]
    public class GoToActionPytoolkitRequest : Message
    {
        public const string k_RosMessageName = "manipulation_msgs/GoToActionPytoolkit";
        public override string RosMessageName => k_RosMessageName;

        public string name;

        public GoToActionPytoolkitRequest()
        {
            this.name = "";
        }

        public GoToActionPytoolkitRequest(string name)
        {
            this.name = name;
        }

        public static GoToActionPytoolkitRequest Deserialize(MessageDeserializer deserializer) => new GoToActionPytoolkitRequest(deserializer);

        private GoToActionPytoolkitRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.name);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.name);
        }

        public override string ToString()
        {
            return "GoToActionPytoolkitRequest: " +
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
