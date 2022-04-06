using System.Runtime.Serialization.Formatters.Binary;


int chislo = int.Parse(Console.ReadLine());
string filename = "text.txt";
File.WriteAllText(filename, "chislo");
BinaryFormatter formatter = new BinaryFormatter();
formatter.Serialize(new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite), chislo);


