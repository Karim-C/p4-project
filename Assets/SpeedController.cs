using System.Collections;
using System.Collections.Generic;
using Hover.Core.Items.Types;
using UnityEngine;

public class SpeedController : MonoBehaviour {

    public GameObject slider;
    public GameObject headMountedRig;

    private HoverItemDataSlider hoverItemDataSlider;
    private SamplePlayerController samplePlayerController;

    // Use this for initialization
    void Start () {
        hoverItemDataSlider = slider.GetComponent<HoverItemDataSlider>();
        samplePlayerController = headMountedRig.GetComponent<SamplePlayerController>();
        ResetPlayerMovementSpeed();

    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("" + hoverItemDataSlider.Value);
        //Debug.Log("" + samplePlayerController.Acceleration);
        samplePlayerController.Acceleration = hoverItemDataSlider.Value;
    }

    public void ResetPlayerMovementSpeed()
    {
        hoverItemDataSlider.Value = 0.3f;
    }
}
