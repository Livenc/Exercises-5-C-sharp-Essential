using System;
namespace Exercise_6
{
	public class Dictionary
	{
        private string[] key = new string[5];
        private string[] value = new string[5];
        private string[] ualang = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; value[0] = "book"; ualang[0] = "книга";
            key[1] = "ручка"; value[1] = "pen"; ualang[1] = "книга";
            key[2] = "солнце"; value[2] = "sun"; ualang[2] = "ручка";
            key[3] = "яблоко"; value[3] = "apple"; ualang[3] = "яблоко";
            key[4] = "стол"; value[4] = "table"; ualang[4] = "стiл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                    if (key[i] == index || value[i] == index || ualang[i] == index)
                        return key[i] + " - " + value[i] + " - " + ualang[i];

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index]+" - " + ualang[index];
                else
                    return "Попытка обращения за пределы массива.";
            }

        }
	}
}

