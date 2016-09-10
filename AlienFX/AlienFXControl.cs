using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using LightFX;

namespace AlienFX {
    class AlienFXControl {

        private readonly Object _lockObject;

        private LightFXController lightFX;

        private LinkedList<Device> devices;

        public AlienFXControl() {
            _lockObject = new Object();
            try {
                lightFX = new LightFXController();
            } catch (Exception e) {
                Console.WriteLine("Error loading AlienFX Library: " + e.Message);
            }

            devices = new LinkedList<Device>();
        }

        public bool Initialize() {
            var result = lightFX.LFX_Initialize();
            if (result == LFX_Result.LFX_Success) {
                lightFX.LFX_Reset();
                uint numDevs;
                lightFX.LFX_GetNumDevices(out numDevs);

                for (uint devIndex = 0; devIndex < numDevs; devIndex++) {
                    Device device = new Device(devIndex);
                    devices.AddLast(device);

                    uint numLights;
                    lightFX.LFX_GetNumLights(devIndex, out numLights);

                    LinkedList<LightingZone> lights = new LinkedList<LightingZone>();
                    for (uint lightIndex = 0; lightIndex < numLights; lightIndex++) {
                        LFX_ColorStruct currentColor;
                        lightFX.LFX_GetLightColor(devIndex, lightIndex, out currentColor);
                        LightingZone newLight = new LightingZone(lightIndex);
                        newLight.Color = currentColor;
                        lights.AddLast(newLight);

                    }

                    device.Lights = lights;
                }

                for (uint devIndex = 0; devIndex < numDevs; devIndex++) {
                    StringBuilder devDescription;
                    LFX_DeviceType type;

                    result = lightFX.LFX_GetDeviceDescription(devIndex, out devDescription, 255, out type);
                    if (result != LFX_Result.LFX_Success)
                        continue;

                    Device currentDevice = devices.ElementAt((int)devIndex);
                    currentDevice.Description = devDescription.ToString();
                    currentDevice.Type = type;

                    uint numLights;
                    lightFX.LFX_GetNumLights(devIndex, out numLights);
                    for (uint lightIndex = 0; lightIndex < numLights; lightIndex++) {
                        LightingZone currentLight = currentDevice.Lights.ElementAt((int)lightIndex);

                        StringBuilder description;
                        result = lightFX.LFX_GetLightDescription(devIndex, lightIndex, out description, 255);
                        if (result != LFX_Result.LFX_Success)
                            continue;
                        currentLight.Description = description.ToString();

                        LFX_ColorStruct color;
                        result = lightFX.LFX_GetLightColor(devIndex, lightIndex, out color);
                        if (result != LFX_Result.LFX_Success)
                            continue;
                        currentLight.Color = color;

                        LFX_Position position;
                        result = lightFX.LFX_GetLightLocation(devIndex, lightIndex, out position);
                        if (result != LFX_Result.LFX_Success)
                            continue;
                        currentLight.Position = position;
                    }
                }
                return true;


            } else {
                switch (result) {
                    case LFX_Result.LFX_Error_NoDevs:
                        Console.WriteLine("There is no AlienFX device available.");
                        break;
                    default:
                        Console.WriteLine("There was an error initializing the AlienFX device.");
                        break;
                }
                return false;
            }
        }

        public void SetColor(KeyboardColorSet colorSet) {
            lock (_lockObject) {
                if (lightFX != null) {
                    foreach (Device device in devices) {
                        foreach (LightingZone light in device.Lights) {
                            if (light.Description == LightingZone.DESCRIPTION_KEYBOARD_LEFT) {
                                lightFX.LFX_SetLightColor(device.Id, light.Id, colorSet.Left);
                            } else if (light.Description == LightingZone.DESCRIPTION_KEYBOARD_MIDDLE_LEFT) {
                                lightFX.LFX_SetLightColor(device.Id, light.Id, colorSet.MiddleLeft);
                            } else if (light.Description == LightingZone.DESCRIPTION_KEYBOARD_MIDDLE_RIGHT) {
                                lightFX.LFX_SetLightColor(device.Id, light.Id, colorSet.MiddleRight);
                            } else if (light.Description == LightingZone.DESCRIPTION_KEYBOARD_RIGHT) {
                                lightFX.LFX_SetLightColor(device.Id, light.Id, colorSet.Right);
                            } else if (light.Description == LightingZone.DESCRIPTION_LOGO) {
                                byte red = (byte)(((int)colorSet.MiddleLeft.red + (int)colorSet.MiddleRight.red) / 2);
                                byte green = (byte)(((int)colorSet.MiddleLeft.green + (int)colorSet.MiddleRight.green) / 2);
                                byte blue = (byte)(((int)colorSet.MiddleLeft.blue + (int)colorSet.MiddleRight.blue) / 2);
                                lightFX.LFX_SetLightColor(device.Id, light.Id, new LFX_ColorStruct(255, red, green, blue));
                            }
                            //else if (light.getDescription() == "Left Speaker")
                            //{
                            //}
                            //else if (light.getDescription() == "Right Speaker")
                            //{
                            //}
                        }

                    }
                    lightFX.LFX_Update();
                }
            }
        }

        public void Release() {
            lock (_lockObject) {
                if (lightFX != null) {
                    lightFX.LFX_Reset();
                    lightFX.LFX_Release();
                    lightFX = null;
                }
            }
        }
    }
}
