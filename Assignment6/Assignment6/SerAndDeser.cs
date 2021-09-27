using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment6
{
    class SerAndDeser
    {
        static void Main()
        {
            SerAndDeser serAndDeser = new SerAndDeser();
            serAndDeser.DoSerialization();
            Console.WriteLine("Object is Serialized Successfully");
            serAndDeser.DoDeserialization();
            Console.ReadLine();
        }

        public void DoSerialization()
        {
            try
            {
               Product product = new Product {ProCode = 100, ProName = "LG", Category = "Tv" };
                FileInfo fileInfo = new FileInfo("product.dat");
                using (FileStream fileStream = fileInfo.Open(FileMode.Create))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(fileStream, product);
                    fileStream.Close();
                }

            }
            catch (SerializationException ex) { }
        }

        public void DoDeserialization()
        {
            try
            {
                Product product = new Product();
                FileInfo fileInfo = new FileInfo("product.dat");
                using (FileStream fileStream = fileInfo.Open(FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    product = (Product)binaryFormatter.Deserialize(fileStream);
                    Console.WriteLine($"Code={product.ProCode}\nName={product.ProName}\nCategory={product.Category}");
                    fileStream.Close();
                }

            }
            catch (Exception ex)
            {
            }
        }
    }
}

