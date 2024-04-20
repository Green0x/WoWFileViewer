using System.IO.Enumeration;

namespace WoWFileViewer
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            const string filename = "lights.lit";
            BinaryReader bw = new BinaryReader(File.OpenRead(filename));
            UInt32 version = bw.ReadUInt32();
            Int32 lightCount = bw.ReadInt32();
            //Begin lightListData
            //C2iVector
            int m_chunkX = bw.ReadInt32();
            int m_chunkY = bw.ReadInt32();
            //C2iVector
            Int32 m_chunkRadius = bw.ReadInt32();
            //C3Vector - 3 floats x,y,z
            float cordinateX = bw.ReadSingle();
            float cordinateY = bw.ReadSingle();
            float cordinateZ = bw.ReadSingle();
            //C3Vector
            
            Console.WriteLine("Version: {0}", printVersion(version));
            Console.WriteLine("Number of lights: {0}", lightCount);
            Console.WriteLine("m_chunk x: {0}, y: {1}", m_chunkX, m_chunkY);
            Console.WriteLine("m_chunkRadius: {0}", m_chunkRadius);
            Console.WriteLine("Co-ordinates x: {0}, y: {1}, z: {2}", cordinateX, cordinateY, cordinateZ);
        }

        static string printVersion(UInt32 num)
        {
            return num.ToString("X").Remove(1, 6).Insert(1, ".");
        }


    }
}
