using System;

namespace Karan.Util
{
    public static class DateTimeUtil
    {
        public static string Now() => DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        public static string Today() => DateTime.Today.ToString("dd/MM/yyyy");
        public static string CurrentTime() => DateTime.Now.ToString("HH:mm:ss");
    }
}