using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LightFX;

namespace AlienFX {
    class Device {
        uint id;
        String description;
        LFX_DeviceType type;
        LinkedList<Light> lights;

        public Device(uint id) {
            this.id = id;
        }

        public uint getId() {
            return id;
        }

        public String getDescription() {
            return description;
        }

        public void setDescription(String description) {
            this.description = description;
        }

        public LFX_DeviceType getType() {
            return type;
        }

        public void setType(LFX_DeviceType type) {
            this.type = type;
        }

        public LinkedList<Light> getLights() {
            return lights;
        }

        public void setLights(LinkedList<Light> lights) {
            this.lights = lights;
        }

        public String toString() {
            String erg = "";

            erg += id + ": " + description;

            foreach (Light light in lights) {
                erg += "\n" + light.toString();
            }

            return erg;
        }
    }
}
