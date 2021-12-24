namespace SOLID3.LiskovSubstitution
{
    internal class CameraApp
    {
        public void TakePhoto(Camera camera, bool flashOn = false)
        {
            if (flashOn && !camera.GetType().Equals(typeof(FrontCamera)))
                camera.FlashOn();

            camera.TakePhoto();
        }
    }
}
