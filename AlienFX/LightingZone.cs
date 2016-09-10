using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LightFX;

namespace AlienFX {

    /// <summary>
    /// Light abstraction for a single AlienFX Zone
    /// </summary>
    class LightingZone {

    public static readonly string DESCRIPTION_KEYBOARD_LEFT = "Keyboard Left";
    public static readonly string DESCRIPTION_KEYBOARD_MIDDLE_LEFT = "Keyboard Middle Left";
    public static readonly string DESCRIPTION_KEYBOARD_MIDDLE_RIGHT = "Keyboard Middle Right";
    public static readonly string DESCRIPTION_KEYBOARD_RIGHT = "Keyboard Right";

    public static readonly string DESCRIPTION_LOGO = "Logo";

    /// <summary>
    /// ID of this Light
    /// </summary>
    public uint Id {get; }

        /// <summary>
        /// A text description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The current color of this light
        /// </summary>
        public LFX_ColorStruct Color { get; set; }

        /// <summary>
        /// The type of this light
        /// </summary>
        public LFX_DeviceType Type { get; set; }

        /// <summary>
        /// The positioning of this light
        /// </summary>
        public LFX_Position Position { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id"></param>
        public LightingZone(uint id) {
            this.Id = id;
        }

        public void SetColor(byte alpha, byte red, byte green, byte blue) {
            this.Color = new LFX_ColorStruct(alpha, red, green, blue);
        }

        override
        public String ToString() {
            return Id.ToString() + ": " + Description + ", pos: " + Position.ToString() + ", type: " + Type.ToString() + ", color: " + Color.ToString();
        }
    }
}
