﻿namespace UnityEngine.FrameRecorder.Input
{
    public class CBRenderTextureInputSettings : InputSettings<CBRenderTextureInput>
    {
        public EImageSource source = EImageSource.GameDisplay;
        public EImageDimension m_RenderSize = EImageDimension.Manual;
        public string m_CameraTag;
        public RenderTexture m_SourceRTxtr;
        public bool m_FlipVertical = false;
    }
}
