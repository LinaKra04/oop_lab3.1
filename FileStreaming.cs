using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using People;

namespace IO_stream
{
    public class FileStreaming
    {
        public int count = 0;
        public static int size = 50;
        public string[] DB = new string[size];

        public void Counter()
        {
            for (int i = 0; i < size; ++i)
            {
                if (DB[i] != null)
                {
                    ++count;
                }
            }
        }

        public void AddAStudent(Student entity) // add a Student entity method
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "oop3.1.txt";
            DB[count] = entity.ToString();
            FileStream destFile = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(destFile);
            writer.WriteLine(DB[count]);

            writer.Close();
            destFile.Close();
            Counter();
        }

        public void AddADoctor(Doctor entity) // add a Doctor entity method
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "oop3.1.txt";
            DB[count] = entity.ToString();
            FileStream destFile = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(destFile);
            writer.WriteLine(DB[count]);

            writer.Close();
            destFile.Close();
            Counter();
        }

        public void AddAMechanic(Mechanic entity) // add a Mechanic entity method
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "oop3.1.txt";
            DB[count] = entity.ToString();
            FileStream destFile = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(destFile);
            writer.WriteLine(DB[count]);

            writer.Close();
            destFile.Close();
            Counter();
        }

        public void RemoveEntity(int index) // remove entity method
        {
            DB[index] = null;
        }

        public void ShowDataBase() // show DB method
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "oop3.1.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            foreach (String line in lines)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}

