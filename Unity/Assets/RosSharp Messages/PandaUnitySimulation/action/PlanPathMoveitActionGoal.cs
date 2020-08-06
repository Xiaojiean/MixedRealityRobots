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

namespace RosSharp.RosBridgeClient.MessageTypes.PandaUnitySimulation
{
    public class PlanPathMoveitActionGoal : ActionGoal<PlanPathMoveitGoal>
    {
        [JsonIgnore]
        public const string RosMessageName = "panda_unity_simulation/PlanPathMoveitActionGoal";

        public PlanPathMoveitActionGoal() : base()
        {
            this.goal = new PlanPathMoveitGoal();
        }

        public PlanPathMoveitActionGoal(Header header, GoalID goal_id, PlanPathMoveitGoal goal) : base(header, goal_id)
        {
            this.goal = goal;
        }
    }
}