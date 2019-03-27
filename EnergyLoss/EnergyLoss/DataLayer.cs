using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    static class DataLayer
    {/*
        public static void SaveToFile(Mechanics mech)
        {

            string save = $"Save.txt";
            try
            {
                if (!File.Exists(save))
                {
                    File.Create(save).Close();
                }

                TextWriter writer = new StreamWriter(save);
                writer.WriteLine($"{mech.NumOfPlayers}\t{mech.FieldSize}\t{mech.WinNumber}\t{mech.CurrentRow}\t{mech.CurrentCollumn}\t{mech.Turn}");
                for (int i = 0; i < mech.FieldSize; i++)
                {
                    for (int j = 0; j < mech.FieldSize; j++)
                    {
                        writer.Write($"{mech.Field[i, j]} ");
                    }
                    writer.Write("\n");
                }
                writer.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected Error Happend\n" +
                    $"Error Info:{e.Message}");
            }
        }
        */
        public static Dictionary<string,double> LoadFromFile()
        {
            Dictionary<string, double> mapOfMaterial = new Dictionary<string, double>();
            string save = "Save.txt";
            try
            {
                if (!File.Exists(save))
                {

                    File.Create(save).Close();

                }                
                string[] splitLine;
                string[] lines = File.ReadAllLines(save);

                for (int i = 0; i < lines.Length; i++)

                {                    
                    splitLine = lines[i].Split('\t');
                    String nazov = splitLine[0];
                    Double lambda = Convert.ToDouble(splitLine[1]);
                    mapOfMaterial[nazov] = lambda;
                }
                return mapOfMaterial;


            }
            catch (Exception e)
            {

                Debug.Write($"Unexpected Error Happend\n" +
                                    $"Error Info:{e.Message}");
                return null;
            }

        }
        
    }
}
