using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelFileToText
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "C:\\Users\\research\\Documents\\Trunk\\Code\\Recognition\\Settings\\DC Models\\Grouping_all_Gate.model";
            java.io.File file = new java.io.File(filename);
            java.io.InputStream inputStream = new java.io.FileInputStream(file);
            java.io.ObjectInputStream objectInputStream = new java.io.ObjectInputStream(inputStream);

            weka.classifiers.meta.AdaBoostM1 classifier = 
                (weka.classifiers.meta.AdaBoostM1)(objectInputStream.readObject());

            string classifierText = classifier.toString();
            classifierText = classifierText.Replace("\n", "\r\n");
            System.IO.StreamWriter writer = new System.IO.StreamWriter("grouper.txt");
            writer.Write(classifierText);
            writer.Close();
        }
    }
}
