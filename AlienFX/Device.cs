using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LightFX;

namespace AlienFX {


    class Device {

        public uint Id { get; set; }

        public string Description { get; set; }

        public LFX_DeviceType Type { get; set; }

        public LinkedList<LightingZone> Lights { get; set; }

        public Device(uint id) {
            this.Id = id;
        }

        override
        public String ToString() {
            String erg = "";

            erg += Id + ": " + Description;

            foreach (LightingZone light in Lights) {
                erg += "\n" + light.ToString();
            }

            return erg;
        }
    }
}
