/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

using RosSharp.RosBridgeClient.MessageTypes.Std;
using RosSharp.RosBridgeClient.MessageTypes.Actionlib;

namespace RosSharp.RosBridgeClient.MessageTypes.FollowObject
{
    public class FollowObjectMoveitActionFeedback : ActionFeedback<FollowObjectMoveitFeedback>
    {
        [JsonIgnore]
        public const string RosMessageName = "FollowObject/FollowObjectMoveitActionFeedback";

        public FollowObjectMoveitActionFeedback() : base()
        {
            this.feedback = new FollowObjectMoveitFeedback();
        }

        public FollowObjectMoveitActionFeedback(Header header, GoalStatus status, FollowObjectMoveitFeedback feedback) : base(header, status)
        {
            this.feedback = feedback;
        }
    }
}