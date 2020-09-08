/*===============================================================================
Copyright (c) 2017 PTC Inc. All Rights Reserved.

Vuforia is a trademark of PTC Inc., registered in the United States and other 
countries.
===============================================================================*/
using UnityEngine;
using UnityEngine.UI;

public class FrameQualityMeter : MonoBehaviour
{
    public Button button;

    public void SetQuality(Vuforia.ImageTargetBuilder.FrameQuality quality)
    {
        switch (quality)
        {
            case (Vuforia.ImageTargetBuilder.FrameQuality.FRAME_QUALITY_NONE):
                button.image.color = new Color(1.0f, 0.0f, 0.0f, 0.25f);
                break;
            case (Vuforia.ImageTargetBuilder.FrameQuality.FRAME_QUALITY_LOW):
                button.image.color = new Color(1.0f, 0.0f, 0.0f, 0.25f);
                break;
            case (Vuforia.ImageTargetBuilder.FrameQuality.FRAME_QUALITY_MEDIUM):
                 button.image.color = new Color(0.0f, 0.5f, 0.5f, 0.5f);
                break;
            case (Vuforia.ImageTargetBuilder.FrameQuality.FRAME_QUALITY_HIGH):
                button.image.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                break;
        }
    }
}
