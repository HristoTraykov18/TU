using System;

namespace FileEditor
{
    class BytesList
    {
        byte[] list;
        public void AddRange(byte[] range, int count)
        {
            if (count == 0)
                return;
            if (list == null)
            {
                list = new byte[count];
                for (int i = 0; i < count; i++)
                    list[i] = range[i];
            }
            else
            {
                byte[] newArray = new byte[list.Length + range.Length];
                for (int i = 0; i < list.Length; i++)
                    newArray[i] = list[i];
                for (int i = 0; i < range.Length; i++)
                    newArray[list.Length + i] = range[i];
                list = newArray;
            }
        }
        public byte[] ToArray()
        {
            return list;
        }
    }
}
