using System.Reflection.Emit;

namespace WF2
{
    public static class Helper
    {
        public static int GetInt(this string sourse, out bool isError)
        {
            int i = 0;
            isError = true;
            if (int.TryParse(sourse, out i))
            {
                return i;
            }
            return 0;
        }
    }
}