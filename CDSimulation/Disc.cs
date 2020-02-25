using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CDSimulation
{
    class Disc
    {
        public Dictionary<string, int> FileTable { get; set; }
        private byte[] DiscBites { get; set; }

        const int sectorSize = 512;    

        public Disc(int kBites)
        {
            FileTable = new Dictionary<string, int>();
            DiscBites = new byte[kBites*1024];
        }
        public void WriteFile(string fileName)
        {
            string text;
            using (StreamReader streamReader = new StreamReader(fileName, Encoding.ASCII, true))
            {
                text = streamReader.ReadToEnd();
            }

            byte[] bytes = Encoding.ASCII.GetBytes(text);
            Console.WriteLine("Wrote bytes:" + bytes.Length);

            int index = FindEmptySectorFirstByteIndex();
            Console.WriteLine(index);
            if (index != -1) 
            {

                if (CanFit(index,bytes.Length))
                {
                    WriteData(bytes, index);
                    FileTable.Add(fileName, index);
                }
                else 
                {
                    Console.WriteLine(fileName+" NOT WRITTEN!");
                }
            }   
        }

        private bool WriteData(byte[] data,int index)
        {
            try
            {
                Array.Copy(data, 0, DiscBites, index, data.Length);
                Console.WriteLine("Full sectors: " + GetAmountOfFullSectors() + " from " + DiscBites.Length / sectorSize);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        private int FindEmptySectorFirstByteIndex()
        {
            for(int i=0;i< DiscBites.Length; i += sectorSize)
            {
                if (DiscBites[i] == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        private int GetAmountOfFullSectors()
        {
            int counter=0;

            for (int i = 0; i < DiscBites.Length; i += sectorSize)
            {
                if (DiscBites[i] != 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        private bool CanFit(int index, int dataLength)
        {
            for(int i = index; ; i++)
            {
                if (DiscBites[i] != 0)
                {
                    Console.WriteLine("Cannot fit");

                    return false;
                }
                if ((i- index) == dataLength)
                {
                    break;
                }

            }
            Console.WriteLine("Can fit");
            return true;
        }

        public void DeleteFile(string fileName)
        {
            int sectorFirstByteIndex = -1;
            foreach(KeyValuePair<string,int> entry in FileTable)
            {
                if (entry.Key.Equals(fileName))
                {
                    sectorFirstByteIndex = entry.Value;
                }
            }
            if (sectorFirstByteIndex == -1)
            {
                Console.WriteLine("There is no such a file");
            }
            
            for(int i=sectorFirstByteIndex; ; i++)
            {
                if(DiscBites[i]==0 || IsInFileTable(DiscBites[i]))
                {
                    break;
                }
                DiscBites[i] = 0;
            }

            FileTable.Remove(fileName);
        }

        private bool IsInFileTable(int index)
        {
            foreach (KeyValuePair<string, int> entry in FileTable)
            {
                if (entry.Value==index)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetPersentageOfFilling()
        {
            return Convert.ToInt32((Convert.ToDouble(GetAmountOfFullSectors()) / (DiscBites.Length / sectorSize)) * 100);
        }
    }
}
