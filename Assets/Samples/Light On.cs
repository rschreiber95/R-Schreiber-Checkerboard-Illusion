using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;


public class LightOn : MonoBehaviour
{

    public Light myLight;
    private UnityEngine.XR.InputDevice device;

    void Start()
    {
    }
    private void Update()
    {
        var leftHandDevices = new List<UnityEngine.XR.InputDevice>();
        var desiredCharacteristics = UnityEngine.XR.InputDeviceCharacteristics.HeldInHand | UnityEngine.XR.InputDeviceCharacteristics.Controller;
        UnityEngine.XR.InputDevices.GetDevicesWithCharacteristics(desiredCharacteristics, leftHandDevices);

        if (leftHandDevices.Count == 1)
        {
            device = leftHandDevices[0];
        }

        float triggerValue;
        if (device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.trigger, out triggerValue))
        {
            Debug.Log("Trigger Button is pressed.");
            myLight.enabled = false;
        }
    }
    //private void OnTriggerEnter()
    // {
   


 }
    
    

