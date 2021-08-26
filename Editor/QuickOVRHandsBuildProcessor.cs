using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

namespace QuickVR
{
    class QuickOVRHandsBuildProcessor : IPreprocessBuildWithReport
    {
        public int callbackOrder { get { return 0; } }
        public void OnPreprocessBuild(BuildReport report)
        {
            //Debug.Log("MyCustomBuildProcessor.OnPreprocessBuild for target " + report.summary.platform + " at path " + report.summary.outputPath);
            OVRProjectConfig ovrConfig = OVRProjectConfig.GetProjectConfig();
            if (ovrConfig.handTrackingSupport != OVRProjectConfig.HandTrackingSupport.ControllersAndHands)
            {
                ovrConfig.handTrackingSupport = OVRProjectConfig.HandTrackingSupport.ControllersAndHands;
                OVRProjectConfig.CommitProjectConfig(ovrConfig);
            }
        }
    }

}
