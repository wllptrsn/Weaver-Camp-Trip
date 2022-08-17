using UnityEngine;
// Import Cinemachine Framework to write an ext component which we'll attach to the Cinemachine Virtual Camera
using Cinemachine;
// Components that hook into Cinemachine's processing pipeline must inherit from Cinemachine's extension.
public class RoundCameraPos : CinemachineExtension
{
    // The pixels per unit are displaying 32 pixels in one world unit.
    public float PixelsPerUnit = 32;
    /*This method is required by all classes which inherit from CinemachineExtension.
    It's called by Cinemachine after the confiner is done processing*/
    protected override void PostPipelineStageCallback(
        CinemachineVirtualCameraBase vcam,
        CinemachineCore.Stage stage, ref CameraState state,
        float deltaTime)
/*The cinematic Virtual Camera has a post-processing pipeline consisting of
several stages. We perform this check to see what stage of the camera's post-processing we're in.
If we're in the "Body" stage then we're permitted to set the Virtual Camera's position in space*/
{
if (stage == CinemachineCore.Stage.Body)
{
    Vector3 pos = state.FinalPosition;
    /*Call the Rounding method we used (following) to round the posirion,
    and then to create a new Vector with the results. This will be our new, pixel-
    bounded position.*/
    Vector3 pos2 = new Vector3(Round(pos.x),Round(pos.y),pos.z);
    //Set the VC's new position to difference between the old position and the new rounded position that we just calculated.
    state.PositionCorrection += pos2 - pos;
}
}
//9zs method that rounds the input value. We used this method to make sure the camera always stays on a pixel position.
float Round(float x)
    {
    return Mathf.Round(x * PixelsPerUnit) / PixelsPerUnit;
    }
}

