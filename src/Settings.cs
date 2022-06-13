using ModSettings;

namespace StretchArmstrong
{
    internal class SASettings : JsonModSettings
    {
        [Name("Reach Distance Multiplier")]
        [Description("Multiplies the modified pickup range.")]
        [Slider(0f, 5f)]
        public float modifier = 1f;
    }

    internal class Settings
    {
        public static SASettings option;

        public static void onLoad()
        {
            option = new SASettings();
            option.AddToModSettings("Stretch Armstrong Settings", MenuType.Both);
        }
    }
}