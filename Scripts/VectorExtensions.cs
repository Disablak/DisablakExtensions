using UnityEngine;


namespace DisablakExtensions
{

    public static class VectorExtensions
    {
        #region Vector3 Set
        public static Vector3 SetX(this Vector3 data, float x)
            => new Vector3(x, data.y, data.z);

        public static Vector3 SetY(this Vector3 data, float y)
            => new Vector3(data.x, y, data.z);

        public static Vector3 SetZ(this Vector3 data, float z)
            => new Vector3(data.x, data.y, z);
        #endregion

        #region Vector2 Set
        public static Vector2 SetX(this Vector2 data, float x)
            => new Vector2(x, data.y);

        public static Vector2 SetY(this Vector2 data, float y)
            => new Vector2(data.x, y);

        public static Vector3 SetZ(this Vector2 data, float z)
            => new Vector3(data.x, data.y, z);
        #endregion

        #region Vector 3 Plus
        public static Vector3 PlusX(this Vector3 data, float x)
            => new Vector3(data.x + x, data.y, data.z);

        public static Vector3 PlusY(this Vector3 data, float y)
            => new Vector3(data.x, data.y + y, data.z);

        public static Vector3 PlusZ(this Vector3 data, float z)
            => new Vector3(data.x, data.y, data.z + z);

        public static Vector3 PlusX(this Vector2 data, float x)
            => new Vector3(data.x + x, data.y, 0.0f);

        public static Vector3 PlusY(this Vector2 data, float y)
            => new Vector3(data.x, data.y + y, 0.0f);
        #endregion

        #region Distance
        public static float DistanceTo(this Vector3 from, Vector3 to)
            => Vector3.Distance(from, to);

        public static float DistanceTo(this Vector2 from, Vector2 to)
            => Vector2.Distance(from, to);
        #endregion
    }
}