using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using LightFX;

namespace AlienFX {
    class AlienFXControl {
        private readonly Object _lockObject;
        LightFXController lightFX;
        LinkedList<Device> devices;

        public AlienFXControl() {
            _lockObject = new Object();
            try {
                lightFX = new LightFXController();
            } catch (Exception e) {
                Console.WriteLine("Error loading AlienFX Library!");
            }

            devices = new LinkedList<Device>();
        }

        public bool initialize() {
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

                    LinkedList<Light> lights = new LinkedList<Light>();
                    for (uint lightIndex = 0; lightIndex < numLights; lightIndex++) {
                        LFX_ColorStruct currentColor;
                        lightFX.LFX_GetLightColor(devIndex, lightIndex, out currentColor);
                        Light newLight = new Light(lightIndex);
                        newLight.setColor(currentColor);
                        lights.AddLast(newLight);

                    }

                    device.setLights(lights);
                }

                for (uint devIndex = 0; devIndex < numDevs; devIndex++) {
                    StringBuilder devDescription;
                    LFX_DeviceType type;

                    result = lightFX.LFX_GetDeviceDescription(devIndex, out devDescription, 255, out type);
                    if (result != LFX_Result.LFX_Success)
                        continue;

                    Device currentDevice = devices.ElementAt((int)devIndex);
                    currentDevice.setDescription(devDescription.ToString());
                    currentDevice.setType(type);

                    uint numLights;
                    lightFX.LFX_GetNumLights(devIndex, out numLights);
                    for (uint lightIndex = 0; lightIndex < numLights; lightIndex++) {
                        Light currentLight = currentDevice.getLights().ElementAt((int)lightIndex);

                        StringBuilder description;
                        result = lightFX.LFX_GetLightDescription(devIndex, lightIndex, out description, 255);
                        if (result != LFX_Result.LFX_Success)
                            continue;
                        currentLight.setDescription(description.ToString());

                        LFX_ColorStruct color;
                        result = lightFX.LFX_GetLightColor(devIndex, lightIndex, out color);
                        if (result != LFX_Result.LFX_Success)
                            continue;
                        currentLight.setColor(color);

                        LFX_Position position;
                        result = lightFX.LFX_GetLightLocation(devIndex, lightIndex, out position);
                        if (result != LFX_Result.LFX_Success)
                            continue;
                        currentLight.setPosition(position);
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

        public void setColor(KeyboardColorSet colorSet) {
            lock (_lockObject) {
                if (lightFX != null) {
                    foreach (Device device in devices) {
                        foreach (Light light in device.getLights()) {
                            if (light.getDescription() == "Keyboard Left") {
                                lightFX.LFX_SetLightColor(device.getId(), light.getId(), colorSet.left);
                            } else if (light.getDescription() == "Keyboard Middle Left") {
                                lightFX.LFX_SetLightColor(device.getId(), light.getId(), colorSet.middleLeft);
                            } else if (light.getDescription() == "Keyboard Middle Right") {
                                lightFX.LFX_SetLightColor(device.getId(), light.getId(), colorSet.middleRight);
                            } else if (light.getDescription() == "Keyboard Right") {
                                lightFX.LFX_SetLightColor(device.getId(), light.getId(), colorSet.right);
                            } else if (light.getDescription() == "Logo") {
                                byte red = (byte)(((int)colorSet.middleLeft.red + (int)colorSet.middleRight.red) / 2);
                                byte green = (byte)(((int)colorSet.middleLeft.green + (int)colorSet.middleRight.green) / 2);
                                byte blue = (byte)(((int)colorSet.middleLeft.blue + (int)colorSet.middleRight.blue) / 2);
                                lightFX.LFX_SetLightColor(device.getId(), light.getId(), new LFX_ColorStruct(255, red, green, blue));
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

        public void release() {
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
