using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System.Collections.ObjectModel;

namespace AlienFX {
    class ScreenControl : Form {
        Microsoft.DirectX.Direct3D.Device device;
        Surface surface;

        Collection<long> LeftPos;
        Collection<long> MiddleLeftPos;
        Collection<long> MiddlRightPos;
        Collection<long> RightPos;

        KeyboardColorSet averageColorSet;
        GraphicsStream graphicsStream;

        public ScreenControl() {
            PresentParameters present_params = new PresentParameters();
            present_params.Windowed = true;
            present_params.SwapEffect = SwapEffect.Discard;
            device = new Microsoft.DirectX.Direct3D.Device(0, DeviceType.Hardware, this,
                    CreateFlags.SoftwareVertexProcessing, present_params);
        }

        public void CalculatePixels(int startX, int stopX, int startY, int stopY, int stepsX, int stepsY) {
            LeftPos = new Collection<long>();
            MiddleLeftPos = new Collection<long>();
            MiddlRightPos = new Collection<long>();
            RightPos = new Collection<long>();

            averageColorSet = new KeyboardColorSet();

            int sizeX = Screen.PrimaryScreen.Bounds.Width;
            int sizeY = Screen.PrimaryScreen.Bounds.Height;

            int width = (stopX - startX);
            int height = (stopY - startY);

            int BytePerPixel = 4;

            long x, y;
            long pos;

            // left stripe
            for (x = startX; x < startX + width / 4; x += stepsX) {
                for (y = startY; y < stopY; y += stepsY) {
                    pos = (y * sizeX + x) * BytePerPixel;
                    LeftPos.Add(pos);
                }
            }

            // middleleft stripe
            for (x = startX + width / 4; x < startX + width / 2; x += stepsX) {
                for (y = startY; y < stopY; y += stepsY) {
                    pos = (y * sizeX + x) * BytePerPixel;
                    MiddleLeftPos.Add(pos);
                }
            }

            // middleright stripe
            for (x = startX + width / 2; x < startX + width / 4 * 3; x += stepsX) {
                for (y = startY; y < stopY; y += stepsY) {
                    pos = (y * sizeX + x) * BytePerPixel;
                    MiddlRightPos.Add(pos);
                }
            }

            // right stripe
            for (x = startX + width / 4 * 3; x < stopX; x += stepsX) {
                for (y = startY; y < stopY; y += stepsY) {
                    pos = (y * sizeX + x) * BytePerPixel;
                    RightPos.Add(pos);
                }
            }

        }

        public void CalculatePixels(int stepsX, int stepsY) {
            CalculatePixels(0, Screen.PrimaryScreen.Bounds.Width, 0, Screen.PrimaryScreen.Bounds.Height, stepsX, stepsY);
        }
        public void calculatePixels() {
            CalculatePixels(0, Screen.PrimaryScreen.Bounds.Width, 0, Screen.PrimaryScreen.Bounds.Height, 1, 1);
        }

        public KeyboardColorSet CalcAverageColor() {
            // capture Screen
            surface = device.CreateOffscreenPlainSurface(Screen.PrimaryScreen.Bounds.Width,
                Screen.PrimaryScreen.Bounds.Height, Format.A8R8G8B8, Pool.Scratch);
            device.GetFrontBufferData(0, surface);

            graphicsStream = surface.LockRectangle(LockFlags.None);

            averageColorSet.Left = avcs(graphicsStream, LeftPos);
            averageColorSet.MiddleLeft = avcs(graphicsStream, MiddleLeftPos);
            averageColorSet.MiddleRight = avcs(graphicsStream, MiddlRightPos);
            averageColorSet.Right = avcs(graphicsStream, RightPos);

            // graphicsStream.Close();
            // graphicsStream.Dispose();
            surface.UnlockRectangle();
            // surface.ReleaseGraphics();
            surface.Dispose();

            return averageColorSet;
        }

        private LightFX.LFX_ColorStruct avcs(GraphicsStream stream, Collection<long> positions) {
            byte[] bu = new byte[4];
            int r = 0;
            int g = 0;
            int b = 0;
            int i = 0;

            foreach (long pos in positions) {
                stream.Position = pos;
                stream.Read(bu, 0, 4);
                r += bu[2];
                g += bu[1];
                b += bu[0];
                i++;
            }

            return new LightFX.LFX_ColorStruct(255, (byte)(r / i), (byte)(g / i), (byte)(b / i));
        }

    }
}
