﻿#if UNITY_EDITOR

using UnityEngine;
using VRC.Udon;

namespace UdonToolkit {
  [CustomName("Platform Trigger")]
  [ControlledBehaviour(typeof(PlatformTrigger))]
  [HelpURL("https://github.com/orels1/UdonToolkit/wiki/Misc-Behaviours#platform-trigger")]
  [HelpMessage("This behaviour will send specified events on the Start of the world based on the current user platform")]
  public class PlatformTriggerController : UTController {
    [UdonPublic] public bool fireOnStart = true;

    [ListView("Desktop Events")][UdonPublic]
    public UdonBehaviour[] desktopTargets;

    [ListView("Desktop Events")] [Popup(PopupAttribute.PopupSource.UdonBehaviour, "@desktopTargets", true)]
    [UdonPublic]
    public string[] desktopEvents;

    [ListView("VR Events")]
    [UdonPublic]
    public UdonBehaviour[] vrTargets;

    [ListView("VR Events")]
    [Popup(PopupAttribute.PopupSource.UdonBehaviour, "@vrTargets", true)]
    [UdonPublic]
    public string[] vrEvents;

    [Button("Trigger")]
    public void Trigger() {
      if (uB == null) return;
      uB.SendCustomEvent("Trigger");
    }
  }
}
#endif