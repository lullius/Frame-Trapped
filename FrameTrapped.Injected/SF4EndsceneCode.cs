using System;
using System.Runtime.InteropServices;
using EasyHook;
using SlimDX;
using SlimDX.Direct3D9;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Globalization;

namespace FrameTrapped.Injector
{
    public class Main : EasyHook.IEntryPoint
    {
        SF4interface Interface;
        LocalHook EndSceneHooker;

        public Main(RemoteHooking.IContext InContext, String InChannelName)
        {
            Interface = RemoteHooking.IpcConnectClient<SF4interface>(InChannelName);
            Interface.WriteConsole("Dll successfully injected.");
        }
        
        public void Run(RemoteHooking.IContext InContext, String InChannelName)
        {
            Device dev;
            dev = new Device(new Direct3D(), 0, DeviceType.Hardware, IntPtr.Zero, CreateFlags.HardwareVertexProcessing | CreateFlags.PureDevice, new PresentParameters() { BackBufferWidth = 1, BackBufferHeight = 1 });
            IntPtr addy = dev.ComPointer;
            addy = (IntPtr)Marshal.ReadInt32(addy);
            addy = (IntPtr)((int)addy + 0xA8);  //Endscene
            addy = (IntPtr)Marshal.ReadInt32(addy);
            EndSceneHooker = LocalHook.Create((IntPtr)addy, new DEndScene(EndSceneHook), this);
            EndSceneHooker.ThreadACL.SetExclusiveACL(new Int32[] { 0 });

            while (true)
            {
            }
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall,
        CharSet = CharSet.Unicode,
        SetLastError = true)]
        delegate int DEndScene(
            IntPtr Direct3dDevice);
     
        SF4Memory memory = new SF4Memory();
        bool opened = false;
        int framenumber = 0;

        public int EndSceneHook(IntPtr Direct3dDevice)
        {
            using (Device device = Device.FromPointer(Direct3dDevice))
            {
                if (!opened) //Do the first scan.
                {                
                    memory.openSF4Process();
                    memory.runScan();
                    opened = true;
                }

                //   device.SetRenderState(RenderState.Lighting, false);
                //    device.SetRenderState(RenderState.SpecularEnable, false);
                device.SetRenderState(RenderState.CullMode, Cull.None);
                device.SetRenderState(RenderState.AlphaBlendEnable, true);
                device.SetRenderState(RenderState.VertexBlend, VertexBlend.Disable);
                device.SetRenderState(RenderState.SourceBlend, Blend.SourceAlpha);
                device.SetRenderState(RenderState.DestinationBlend, Blend.InverseSourceAlpha);
                device.SetRenderState(RenderState.FillMode, FillMode.Solid);
                device.SetRenderState(RenderState.ColorWriteEnable, 0xF);
                device.SetRenderState(RenderState.MultisampleAntialias, false);



                Vector3 eye = new Vector3(); //Setting up the camera
                eye.X = memory.GetCamX();
                eye.Y = memory.GetCamY();
                eye.Z = memory.GetCamZ();

                Vector3 target = new Vector3();
                target.X = memory.GetCamXp();
                target.Y = memory.GetCamYp();
                target.Z = memory.GetCamZp();

                float zoom = memory.GetCamZoom();

                Vector3 up = new Vector3(0, 1, 0);

                device.SetRenderState(RenderState.Lighting, false); //We don't need light for this...
                device.SetTransform(TransformState.View, Matrix.LookAtLH(eye, target, new Vector3(0, 1, 0)));
                device.SetTransform(TransformState.Projection, Matrix.PerspectiveLH(0.1f * 16 / 9 * zoom + 0.008f, 0.1f * zoom + 0.008f, 0.1F, 100.0F)); //Fix this shit later!
                //Draw everything...



                if (Interface.drawBasic1)
                {
                    drawBasicBoxes(1, device);
                }

                if (Interface.drawBasic2)
                {
                    drawBasicBoxes(2, device);
                }

                if (Interface.drawHit1)
                {
                    DrawHitbox(1, device);
                }

                if (Interface.drawHit2)
                {
                    DrawHitbox(2, device);
                }

                if (Interface.drawGrab1)
                {
                    drawGrabBox(1, device);
                }

                if (Interface.drawGrab2)
                {
                    drawGrabBox(2, device);
                }

                if (Interface.drawProjectile1)
                {
                    drawProjectileBox(1, device);
                }

                if (Interface.drawProjectile2)
                {
                    drawProjectileBox(2, device);
                }

                if (Interface.drawProx1)
                {
                    drawProxBox(1, device);
                }

                if (Interface.drawProx2)
                {
                    drawProxBox(2, device);
                }
                
                
                
                if (Interface.drawInfo)
                {
                    drawInfo(device);
                }
                




                Interface.FrameNumber = memory.GetFrameCount();
            

                using (SlimDX.Direct3D9.Font font = new SlimDX.Direct3D9.Font(device, new System.Drawing.Font(FontFamily.GenericSansSerif, 24)))
                {
                    font.DrawString(null, "Hooked", 20, 20, Color.Maroon);
                    font.DrawString(null, Interface.FrameNumber.ToString(), 20, 40, Color.Maroon);
                }

                return device.EndScene().Code;
            }
        }




        public struct LineVertex
        {
            public Vector3 Position { get; set; }
            public int Color { get; set; }
        }



        public void drawBasicBoxes(int player, Device device) //Draws basic boxes (throw, hurt, physics...)
        {
            byte[] boxes;
            if (player == 1)
            {
                boxes = memory.readMemoryAOBwithBase(0x00688E6C, new int[] { 0x8, 0x2190 }, 25248); //hurtboxes P1             
            }
            else
            {
                boxes = memory.readMemoryAOBwithBase(0x00688E6C, new int[] { 0xc, 0x2190 }, 25248); //P2 0xbc90?
            }

            DrawQuadFromArray(boxes, 0x530, getColor("green"), device);
            DrawQuadFromArray(boxes, 0x5d0, getColor("green"), device);
            DrawQuadFromArray(boxes, 0x350, getColor("green"), device);
            DrawQuadFromArray(boxes, 0x3f0, getColor("green"), device);
            DrawQuadFromArray(boxes, 0x2a10, getColor("green"), device); //Head

            DrawBoxFromArray(boxes, 0x490, getColor("yellow"), device);
            DrawBoxFromArray(boxes, 0x350, getColor("yellow"), device); //There's at least one missing.
            DrawBoxFromArray(boxes, 0x3f0, getColor("yellow"), device);
            // DrawBoxFromArray(testread, 0x2330, getColor("yellow")); should this be here?

            DrawQuadFromArray(boxes, 0x2650, getColor("blue"), device);
            DrawQuadFromArray(boxes, 0x2330, getColor("blue"), device); //There's at least 1 missing!
            DrawQuadFromArray(boxes, 0x25b0, getColor("blue"), device);
            //   DrawQuadFromArray(testread, 0x170, getColor("blue")); //should this be here?


            /*
            if (hurtboxes != null) //These are extra boxes, unknown, broken, empty, missing etc....
            {
                foreach (int i in hurtboxes)
                {
                    DrawQuadFromArray(boxes, i, getColor("green"));
                }
            }

            */
        }

        public void DrawHitbox(int player, Device device) //This draws the HIT(red) boxes of a player
        {
            byte[] hit;
            if (player == 1)
            {
                hit = memory.readMemoryAOBwithBase(0x00688E6C, new int[] { 0x8, 0x134, 0x0, 0x0, 0x0 }, 25248); //hitboxes P1               
            }
            else
            {
                hit = memory.readMemoryAOBwithBase(0x00688E6C, new int[] { 0xc, 0x134, 0x0, 0x0, 0x0 }, 25248);//P2
            }

            //Because of how fireballs and HIT(red)boxes work, 
            //I did this ugly hack. They are either d0 or e0 apart, but you don't know if they start with d0 or e0, so I did both.
            //They are checked later either way (byte 0xac from the fireball-box must be 0x2 for it to display on screen).
            bool d0e0 = false;
            for (int i = 0x0; i <= 0x2420; i += 0xd0)
            {
                if (d0e0)
                {
                    i += 0x10;
                    d0e0 = false;
                }
                else
                {
                    d0e0 = true;
                }
                DrawBoxFromArrayOnHit(hit, i, getColor("red"), device);
            }
            d0e0 = false;
            for (int i = 0xd0; i <= 0x2420; i += 0xd0)
            {
                if (d0e0)
                {
                    i += 0x10;
                    d0e0 = false;
                }
                else
                {
                    d0e0 = true;
                }
                DrawBoxFromArrayOnHit(hit, i, getColor("red"), device);
            }
        }

        public void drawGrabBox(int player, Device device) //Draw grab box
        {
            byte[] grab;
            if (player == 1)
            {
                grab = memory.readMemoryAOBwithBase(0x00688E6C, new int[] { 0x8, 0x138, 0x0, 0x0, 0x0 }, 0xad); //grab box P1               
            }
            else
            {
                grab = memory.readMemoryAOBwithBase(0x00688E6C, new int[] { 0xc, 0x138, 0x0, 0x0, 0x0 }, 0xad); //grab box P2
            }
            DrawBoxFromArrayOnHit(grab, 0x0, getColor("blue"), device);
        }

        public void drawProxBox(int player, Device device) //Draw the proximity box
        {
            byte[] prox;
            if (player == 1)
            {
                prox = memory.readMemoryAOBwithBase(0x00688E6C, new int[] { 0x8, 0x130, 0x0, 0x0, 0x0 }, 0xad); //Proximity box P1         
            }
            else
            {
                prox = memory.readMemoryAOBwithBase(0x0080F0CC, new int[] { 0xc, 0x130, 0x0, 0x0, 0x0 }, 0xad); //P2
            }

            DrawBoxFromArrayOnHit(prox, 0x0, getColor("yellow"), device);
        }

        public void drawProjectileBox(int player, Device device)
        {
            byte[] projectile1;
            byte[] projectile2;
            byte[] projectile3;
            if (player == 1)
            {
                projectile1 = memory.readMemoryAOBwithBase(0x00688E88, new int[] { 0x8, 0x98, 0x0, 0xF8, 0x1b0 }, 0x25000); //P1 fireball
                projectile2 = memory.readMemoryAOBwithBase(0x00688E6C, new int[] { 0x8, 0x138, 0x0, 0x1F8, 0x1b0 }, 0x190); //P1 yogaflame (maybe only 2 boxes?)
                projectile3 = memory.readMemoryAOBwithBase(0x00688E88, new int[] { 0x8, 0x90, 0x0, 0xF8, 0x1b0 }, 0x500); //P1 knives (kunai too!) (maybe only 4 boxes?)               
            }
            else
            {
                projectile1 = memory.readMemoryAOBwithBase(0x00688E88, new int[] { 0xc, 0x98, 0x0, 0xF8, 0x1b0 }, 0x25000); //P2 fireball
                projectile2 = memory.readMemoryAOBwithBase(0x00688E6C, new int[] { 0xc, 0x138, 0x0, 0x1F8, 0x1b0 }, 0x190); //P2 yogaflame (maybe only 2 boxes?)
                projectile3 = memory.readMemoryAOBwithBase(0x00688E88, new int[] { 0xc, 0x90, 0x0, 0xF8, 0x1b0 }, 0x500); //P2 knives (kunai too!) (maybe only 4 boxes?)
            }

            //Because of how fireballs and HIT(red)boxes work, 
            //I did this ugly hack. They are either d0 or e0 apart, but you don't know if they start with d0 or e0, so I did both.
            //They are checked later either way (byte 0xac from the fireball-box must be 0x2 for it to display on screen).
            bool d0e0 = false; //Regular fireball
            for (int i = 0x0; i <= 0x2420; i += 0xd0)
            {
                if (d0e0)
                {
                    i += 0x10;
                    d0e0 = false;
                }
                else
                {
                    d0e0 = true;
                }
                DrawBoxFromArrayOnHit(projectile1, i, getColor("green"), device);
            }

            d0e0 = false;
            for (int i = 0xd0; i <= 0x2420; i += 0xd0)
            {
                if (d0e0)
                {
                    i += 0x10;
                    d0e0 = false;
                }
                else
                {
                    d0e0 = true;
                }
                DrawBoxFromArrayOnHit(projectile1, i, getColor("green"), device);
            }

            d0e0 = false;  //Yoga flame!
            for (int i = 0x0; i <= 0x180; i += 0xd0)
            {
                if (d0e0)
                {
                    i += 0x10;
                    d0e0 = false;
                }
                else
                {
                    d0e0 = true;
                }
                DrawBoxFromArrayOnHit(projectile2, i, getColor("green"), device);
            }
            d0e0 = false;  //Yoga flame!
            for (int i = 0xd0; i <= 0x180; i += 0xd0)
            {
                if (d0e0)
                {
                    i += 0x10;
                    d0e0 = false;
                }
                else
                {
                    d0e0 = true;
                }
                DrawBoxFromArrayOnHit(projectile2, i, getColor("green"), device);
            }

            d0e0 = false;  //Knife/Kunai
            for (int i = 0x0; i <= 0x350; i += 0xd0)
            {
                if (d0e0)
                {
                    i += 0x10;
                    d0e0 = false;
                }
                else
                {
                    d0e0 = true;
                }
                DrawBoxFromArrayOnHit(projectile3, i, getColor("green"), device);
            }
            d0e0 = false;  //Knife/Kunai
            for (int i = 0xd0; i <= 0x350; i += 0xd0)
            {
                if (d0e0)
                {
                    i += 0x10;
                    d0e0 = false;
                }
                else
                {
                    d0e0 = true;
                }
                DrawBoxFromArrayOnHit(projectile3, i, getColor("green"), device);
            }
        }



        public Color getColor(string color) //hahaha, fix this later!
        {
            Color thecolor = new Color();
            if (color == "green")
            {
                thecolor = Color.FromArgb(120, 0, 120, 0);
                return thecolor;
            }
            else if (color == "red")
            {
                thecolor = Color.FromArgb(120, 120, 0, 0);
                return thecolor;
            }
            else if (color == "yellow")
            {
                thecolor = Color.FromArgb(60, 60, 60, 0);
                return thecolor;
            }
            else if (color == "blue")
            {
                thecolor = Color.FromArgb(120, 0, 0, 120);
                return thecolor;
            }
            else
            {
                thecolor = Color.FromArgb(60, 60, 60, 0);
                return thecolor;
            }
        }

        public void DrawLine(float x1, float y1, float z1, float x2, float y2, float z2, Color color, Device device) //Draw simple colored 3d line
        {
            LineVertex[] lineData = new LineVertex[2];

            lineData[0].Position = new Vector3(x1, y1, z1);
            lineData[0].Color = color.ToArgb();
            lineData[1].Position = new Vector3(x2, y2, z2);
            lineData[1].Color = color.ToArgb();

            device.VertexFormat = VertexFormat.Position | VertexFormat.Diffuse;
            device.DrawUserPrimitives<LineVertex>(PrimitiveType.LineList, 0, lineData.Length / 2, lineData);
        }

        public void DrawBox(float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, float x4, float y4, float z4, Color color, Device device) //Draw simple colored filled box
        {
            LineVertex[] lineData = new LineVertex[4];

            lineData[0].Position = new Vector3(x1, y1, z1);
            lineData[0].Color = color.ToArgb();
            lineData[1].Position = new Vector3(x2, y2, z2);
            lineData[1].Color = color.ToArgb();

            lineData[2].Position = new Vector3(x3, y3, z3);
            lineData[2].Color = color.ToArgb();
            lineData[3].Position = new Vector3(x4, y4, z4);
            lineData[3].Color = color.ToArgb();

            device.VertexFormat = VertexFormat.Position | VertexFormat.Diffuse;
            device.DrawUserPrimitives<LineVertex>(PrimitiveType.TriangleFan, 0, lineData.Length / 2, lineData);
        }

        public void DrawQuad(float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, float x4, float y4, float z4, Color color, Device device) //Draw a non-filled box
        {
            DrawLine(x1, y1, z1, x2, y2, z2, color, device);
            DrawLine(x2, y2, z2, x3, y3, z3, color, device);
            DrawLine(x3, y3, z3, x4, y4, z4, color, device);
            DrawLine(x4, y4, z4, x1, y1, z1, color, device);
        }

        public void DrawQuadFromArray(byte[] array, int startindex, Color color, Device device) //Draw a non-filled box from array
        {
            DrawQuad(
                getBoxFromArray(array, startindex).x4,
                getBoxFromArray(array, startindex).y4,
                getBoxFromArray(array, startindex).z4,
                getBoxFromArray(array, startindex).x1,
                getBoxFromArray(array, startindex).y1,
                getBoxFromArray(array, startindex).z1,
                getBoxFromArray(array, startindex).x2,
                getBoxFromArray(array, startindex).y2,
                getBoxFromArray(array, startindex).z2,
                getBoxFromArray(array, startindex).x3,
                getBoxFromArray(array, startindex).y3,
                getBoxFromArray(array, startindex).z3,
                color, device
                );
        }

        public void DrawBoxFromArray(byte[] array, int startindex, Color color, Device device) //Draw a filled box from an array of coordinates
        {
            DrawBox(
                getBoxFromArray(array, startindex).x4,
                getBoxFromArray(array, startindex).y4,
                getBoxFromArray(array, startindex).z4,
                getBoxFromArray(array, startindex).x1,
                getBoxFromArray(array, startindex).y1,
                getBoxFromArray(array, startindex).z1,
                getBoxFromArray(array, startindex).x2,
                getBoxFromArray(array, startindex).y2,
                getBoxFromArray(array, startindex).z2,
                getBoxFromArray(array, startindex).x3,
                getBoxFromArray(array, startindex).y3,
                getBoxFromArray(array, startindex).z3,
                color, device
                );
        }

        public void DrawBoxFromArrayOnHit(byte[] array, int startindex, Color color, Device device) //Draws box from array only if it's active
        {
            if (array[startindex + 0xac] != 0x2) //This byte should be 0x2 when the box is active, but for some reason that is not always the case....
                return;

            DrawBox(
                getBoxFromArray(array, startindex).x4,
                getBoxFromArray(array, startindex).y4,
                getBoxFromArray(array, startindex).z4,
                getBoxFromArray(array, startindex).x1,
                getBoxFromArray(array, startindex).y1,
                getBoxFromArray(array, startindex).z1,
                getBoxFromArray(array, startindex).x2,
                getBoxFromArray(array, startindex).y2,
                getBoxFromArray(array, startindex).z2,
                getBoxFromArray(array, startindex).x3,
                getBoxFromArray(array, startindex).y3,
                getBoxFromArray(array, startindex).z3,
                color, device
                );
        }

        public struct boxpoints    //Struct used in other functions (to store coordinates)
        {
            public float x1;
            public float x2;
            public float y1;
            public float y2;

            public float x3;
            public float x4;
            public float y3;
            public float y4;

            public float z1;
            public float z2;
            public float z3;
            public float z4;
        };

        public boxpoints getBoxFromArray(byte[] array, int startindex)  //Returns a struct with coordinates
        {
            boxpoints hitbox = new boxpoints();


            hitbox.x1 = System.BitConverter.ToSingle(array, startindex);
            hitbox.y1 = System.BitConverter.ToSingle(array, startindex + 0x4);
            hitbox.z1 = System.BitConverter.ToSingle(array, startindex + 0x8);

            hitbox.x2 = System.BitConverter.ToSingle(array, startindex + 0x10);
            hitbox.y2 = System.BitConverter.ToSingle(array, startindex + 0x14);
            hitbox.z2 = System.BitConverter.ToSingle(array, startindex + 0x18);

            hitbox.x3 = System.BitConverter.ToSingle(array, startindex + 0x20);
            hitbox.y3 = System.BitConverter.ToSingle(array, startindex + 0x24);
            hitbox.z3 = System.BitConverter.ToSingle(array, startindex + 0x28);

            hitbox.x4 = System.BitConverter.ToSingle(array, startindex + 0x30);
            hitbox.y4 = System.BitConverter.ToSingle(array, startindex + 0x34);
            hitbox.z4 = System.BitConverter.ToSingle(array, startindex + 0x38);

            return hitbox;
        }
        
        public void drawInfo(Device device)  //These need to be positioned better
        {
            try
            {
                using (SlimDX.Direct3D9.Font font = new SlimDX.Direct3D9.Font(device, new System.Drawing.Font(FontFamily.GenericSansSerif, 24)))
                {
                    //P1
                    font.DrawString(null, memory.getP1Health().ToString(), device.Viewport.Width / 6, device.Viewport.Height / 6, Color.Maroon);
                    font.DrawString(null, memory.getStun(1).ToString(), device.Viewport.Width / 3, device.Viewport.Height / 5, Color.Maroon);
                    font.DrawString(null, memory.getP1UltraMeter().ToString(), device.Viewport.Width / 40, device.Viewport.Height / 6 * 5, Color.Maroon);
                    font.DrawString(null, memory.getP1EXmeter().ToString(), device.Viewport.Width / 3, device.Viewport.Height / 5 * 4, Color.Maroon);

                    font.DrawString(null, "PosX = " + memory.getP1PosX().ToString(), device.Viewport.Width / 6, 30, Color.Maroon);
                    font.DrawString(null, "PosY = " + memory.getP1PosY().ToString(), device.Viewport.Width / 6, 55, Color.Maroon);

                    font.DrawString(null, "Script# = " + memory.playerAnim(1).ToString(), device.Viewport.Width / 40, device.Viewport.Height / 20 * 9, Color.Maroon);
                    font.DrawString(null, "Frame# = " + memory.getAnimFrameP1().ToString(), device.Viewport.Width / 40, device.Viewport.Height / 20 * 10, Color.Maroon);

                    //P2
                    font.DrawString(null, memory.getP2Health().ToString(), (device.Viewport.Width / 9) * 7, device.Viewport.Height / 6, Color.Maroon);
                    font.DrawString(null, memory.getStun(2).ToString(), (device.Viewport.Width / 3) * 2, device.Viewport.Height / 5, Color.Maroon);
                    font.DrawString(null, memory.getP2UltraMeter().ToString(), device.Viewport.Width / 20 * 19, device.Viewport.Height / 6 * 5, Color.Maroon);
                    font.DrawString(null, memory.getP1EXmeter().ToString(), device.Viewport.Width / 8 * 5, device.Viewport.Height / 5 * 4, Color.Maroon);

                    font.DrawString(null, "PosX = " + memory.getP2PosX().ToString(), device.Viewport.Width / 7 * 5, 30, Color.Maroon);
                    font.DrawString(null, "PosY = " + memory.getP2PosY().ToString(), device.Viewport.Width / 7 * 5, 55, Color.Maroon);

                    font.DrawString(null, "Script# = " + memory.playerAnim(2).ToString(), device.Viewport.Width / 40 * 32, device.Viewport.Height / 20 * 9, Color.Maroon);
                    font.DrawString(null, "Frame# = " + memory.getAnimFrameP2().ToString(), device.Viewport.Width / 40 * 32, device.Viewport.Height / 20 * 10, Color.Maroon);

                    //Both
                    font.DrawString(null, "Combo = " + memory.ComboCounter().ToString(), device.Viewport.Width / 20 * 9, 30, Color.Maroon);
                    font.DrawString(null, "Distance = " + memory.getDistance().ToString(), device.Viewport.Width / 20 * 8, device.Viewport.Height / 20 * 18, Color.Maroon);
                    font.DrawString(null, "GameFrames = " + memory.GetFrameCount().ToString(), device.Viewport.Width / 20 * 8, device.Viewport.Height / 20 * 19, Color.Maroon);
                }
            }
            catch
            {

            }
        }
    }

    class CustomVertex
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct PositionColored
        {
            public Vector3 Position;
            public int Color;
            public static readonly VertexFormat format = VertexFormat.Diffuse | VertexFormat.PositionRhw;
        }
    }

}