using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Mathematics;

namespace Bright.Serialization
{
    public static class ByteBufExtensions
    {
        public static void WriteUnityVector2(this ByteBuf buf,  float2 v)
        {
            buf.WriteFloat(v.x);
            buf.WriteFloat(v.y);
        }

        public static float2 ReadUnityVector2(this ByteBuf buf)
        {
            return new float2(buf.ReadFloat(), buf.ReadFloat());
        }

        public static void WriteUnityVector3(this ByteBuf buf, float3 v)
        {
            buf.WriteFloat(v.x);
            buf.WriteFloat(v.y);
            buf.WriteFloat(v.z);
        }

        public static float3 ReadUnityVector3(this ByteBuf buf)
        {
            return new float3(buf.ReadFloat(), buf.ReadFloat(), buf.ReadFloat());
        }

        public static void WriteUnityVector4(this ByteBuf buf, float4 v)
        {
            buf.WriteFloat(v.x);
            buf.WriteFloat(v.y);
            buf.WriteFloat(v.z);
            buf.WriteFloat(v.w);
        }

        public static float4 ReadUnityVector4(this ByteBuf buf)
        {
            return new float4(buf.ReadFloat(), buf.ReadFloat(), buf.ReadFloat(), buf.ReadFloat());
        }
    }
}
