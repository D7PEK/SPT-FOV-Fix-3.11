namespace FOVFix
{
    public class RealismCompat
    {
        public float StanceBlenderTarget => 0f;
        public float StanceBlenderValue => 0f;
        public bool StancesAreEnabled => false;
        public bool DoPatrolStanceAdsSmoothing => false;
        public bool StopCameraMovmentForCollision => false;
        public float CameraMovmentForCollisionSpeed => 1f;
        public bool IsMachinePistol => false;
        public bool RealismAltPistol => false;
        public bool HasShoulderContact => true;
        public bool RealismAltRifle => false;

        public void Update() { }
    }
}
