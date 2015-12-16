using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LightFX;

namespace AlienFX
{
    class Light
    {
        uint id;
        String description;
        LFX_ColorStruct color;
        LFX_DeviceType type;
        LFX_Position position;

        public Light(uint id)
        {
            this.id = id;
        }

        public uint getId()
        {
            return id;
        }

        public String getDescription()
        {
            return description;
        }

        public void setDescription(String description)
        {
            this.description = description;
        }

        public LFX_ColorStruct getColor()
        {
            return color;
        }

        public void setColor(byte alpha, byte red, byte green, byte blue)
        {
            this.color = new LFX_ColorStruct(alpha, red, green, blue);
        }

        public void setColor(LFX_ColorStruct color)
        {
            this.color = color;
        }

        public LFX_DeviceType getType()
        {
            return type;
        }

        public void setType(LFX_DeviceType type)
        {
            this.type = type;
        }

        public LFX_Position getPosition()
        {
            return position;
        }

        public void setPosition(LFX_Position position)
        {
            this.position = position;
        }

        public String toString()
        {
            return id.ToString() + ": " + description + ", pos: " + position.ToString() + ", type: " + type.ToString() + ", color: " + color.ToString();
        }
    }
}
