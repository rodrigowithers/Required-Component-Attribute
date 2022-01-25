using UnityEngine;

namespace RequiredFieldAttribute
{
    public enum FieldColor
    {
        Red,
        Green,
        Blue,
        Magenta,
        Cyan,
        Yellow
    }

    public class RequiredField : PropertyAttribute
    {
        public Color Color { get; }

        public RequiredField(FieldColor color = FieldColor.Red)
        {
            switch (color)
            {
                case FieldColor.Red:
                    Color=Color.red;
                    break;
                case FieldColor.Green:
                    Color=Color.green;
                    break;
                case FieldColor.Blue:
                    Color=Color.blue;
                    break;
                case FieldColor.Magenta:
                    Color=Color.magenta;
                    break;
                case FieldColor.Cyan:
                    Color=Color.cyan;
                    break;
                case FieldColor.Yellow:
                    Color=Color.yellow;
                    break;
            }
        }

        public RequiredField(Color color)
        {
            Color = color;
        }
    }
}