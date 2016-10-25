using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace Demo2Entity
{
    public class EncryptionDecryption
    {
        public EncryptionDecryption()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        //private static string keyString = "552F79D3-1F36-48ab-934C-4629C2274D43";
        //private const string strTamperProofKey = "astkvsnanvpi";
        //public static string TamperProofStringEncode(string strValue, string strKey)
        //{
        //    System.Security.Cryptography.MACTripleDES mac3des = new System.Security.Cryptography.MACTripleDES();
        //    System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        //    mac3des.Key = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(strKey));
        //    return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(strValue)) + System.Convert.ToChar("-") + System.Convert.ToBase64String(mac3des.ComputeHash(System.Text.Encoding.UTF8.GetBytes(strValue)));
        //}

        //public static string TamperProofStringDecode(string strValue, string strKey)
        //{
        //    String strDataValue = "";
        //    String strCalcHash = "";
        //    strValue = strValue.Trim();
        //    strValue = strValue.Replace(" ", "+");

        //    System.Security.Cryptography.MACTripleDES mac3des = new System.Security.Cryptography.MACTripleDES();
        //    System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        //    mac3des.Key = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(strKey));

        //    try
        //    {
        //        strDataValue = System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(strValue.Split(System.Convert.ToChar("-"))[0]));

        //        strCalcHash = System.Text.Encoding.UTF8.GetString(mac3des.ComputeHash(System.Text.Encoding.UTF8.GetBytes(strDataValue)));
        //    }
        //    catch
        //    {
        //        throw new ArgumentException("Invalid TamperProofString");
        //    }
        //    return strDataValue;
        //}

        ///// <summary>
        ///// Get Encrpted Value of Passed value
        ///// </summary>
        ///// <param name="value"></param>
        ///// <returns></returns>
        ///// <remarks></remarks>
        //public static string GetEncrypt(string value)
        //{
        //    if (string.IsNullOrEmpty(value)) return value;
        //    return TamperProofStringEncode(value, strTamperProofKey);
        //    //return Encrypt(keyString, value);
        //}

        ///// <summary>
        ///// Get Decrypted value of passed encrypted string
        ///// </summary>
        ///// <param name="value"></param>
        ///// <returns></returns>
        ///// <remarks></remarks>
        //public static string GetDecrypt(string value)
        //{
        //    if (string.IsNullOrEmpty(value)) return value;
        //    return TamperProofStringDecode(value, strTamperProofKey);
        //    //return Decrypt(keyString, value);
        //}

        ///// <summary>
        ///// Encrypt value
        ///// </summary>
        ///// <param name="strKey"></param>
        ///// <param name="strData"></param>
        ///// <returns></returns>
        ///// <remarks></remarks>
        //private static string Encrypt(string Passphrase, string Message)
        //{
        //    byte[] Results;
        //    System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

        //    // Step 1. We hash the passphrase using MD5
        //    // We use the MD5 hash generator as the result is a 128 bit byte array
        //    // which is a valid length for the TripleDES encoder we use below

        //    MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
        //    byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));

        //    // Step 2. Create a new TripleDESCryptoServiceProvider object
        //    TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

        //    // Step 3. Setup the encoder
        //    TDESAlgorithm.Key = TDESKey;
        //    TDESAlgorithm.Mode = CipherMode.ECB;
        //    TDESAlgorithm.Padding = PaddingMode.PKCS7;

        //    // Step 4. Convert the input string to a byte[]
        //    byte[] DataToEncrypt = UTF8.GetBytes(Message);

        //    // Step 5. Attempt to encrypt the string
        //    try
        //    {
        //        ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
        //        Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
        //    }
        //    finally
        //    {
        //        // Clear the TripleDes and Hashprovider services of any sensitive information
        //        TDESAlgorithm.Clear();
        //        HashProvider.Clear();
        //    }

        //    // Step 6. Return the encrypted string as a base64 encoded string
        //    return Convert.ToBase64String(Results);
        //}

        ///// <summary>
        ///// decrypt value
        ///// </summary>
        ///// <param name="strKey"></param>
        ///// <param name="strData"></param>
        ///// <returns></returns>
        ///// <remarks></remarks>
        //private static string Decrypt(string Passphrase, string Message)
        //{
        //    byte[] Results;
        //    System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

        //    // Step 1. We hash the passphrase using MD5
        //    // We use the MD5 hash generator as the result is a 128 bit byte array
        //    // which is a valid length for the TripleDES encoder we use below

        //    MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
        //    byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));

        //    // Step 2. Create a new TripleDESCryptoServiceProvider object
        //    TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

        //    // Step 3. Setup the decoder
        //    TDESAlgorithm.Key = TDESKey;
        //    TDESAlgorithm.Mode = CipherMode.ECB;
        //    TDESAlgorithm.Padding = PaddingMode.PKCS7;

        //    // Step 4. Convert the input string to a byte[]
        //    byte[] DataToDecrypt = Convert.FromBase64String(Message);

        //    // Step 5. Attempt to decrypt the string
        //    try
        //    {
        //        ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
        //        Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
        //    }
        //    catch
        //    {
        //        return "";
        //    }
        //    finally
        //    {
        //        // Clear the TripleDes and Hashprovider services of any sensitive information
        //        TDESAlgorithm.Clear();
        //        HashProvider.Clear();
        //    }

        //    // Step 6. Return the decrypted string in UTF8 format
        //    return UTF8.GetString(Results);
        //}
        
        #region Encryption

        private static string Key = "j6u1l4#q2w0%";

        public static string Encode(string strToEncode)
        {
            try
            {
                TripleDES des = CreateDES();
                ICryptoTransform ct = des.CreateEncryptor();
                byte[] input = Encoding.Unicode.GetBytes(strToEncode);
                return Convert.ToBase64String(ct.TransformFinalBlock(input, 0, input.Length)).Replace("/", "[@]");
            }
            catch
            {
                return string.Empty;
            }
        }


        public static string Decode(string strToDecode)
        {
            try
            {
                strToDecode = strToDecode.Replace("[@]", "/");
                byte[] b = Convert.FromBase64String(strToDecode);
                TripleDES des = CreateDES();
                ICryptoTransform ct = des.CreateDecryptor();
                byte[] output = ct.TransformFinalBlock(b, 0, b.Length);
                return Encoding.Unicode.GetString(output);
            }
            catch
            {
                return string.Empty;
            }
        }


        static TripleDES CreateDES()
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            TripleDES des = new TripleDESCryptoServiceProvider();
            des.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(Key));
            des.IV = new byte[des.BlockSize / 8];
            return des;
        }



        #endregion


        #region Serialize and Deserialize

        /// <summary>
        /// Serializes an object to Xml as a string.
        /// </summary>
        /// <typeparam name="T">Datatype T.</typeparam>
        /// <param name="ToSerialize">Object of type T to be serialized.</param>
        /// <returns>Xml string of serialized type T object.</returns>
        public static string SerializeToXmlString<T>(T ToSerialize)
        {
            string xmlstream = String.Empty;

            using (MemoryStream memstream = new MemoryStream())
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                XmlTextWriter xmlWriter = new XmlTextWriter(memstream, Encoding.UTF8);

                xmlSerializer.Serialize(xmlWriter, ToSerialize);
                xmlstream = UTF8ByteArrayToString(((MemoryStream)xmlWriter.BaseStream).ToArray());
            }

            return xmlstream;
        }

        /// <summary>
        /// Deserializes Xml string of type T.
        /// </summary>
        /// <typeparam name="T">Datatype T.</typeparam>
        /// <param name="XmlString">Input Xml string from which to read.</param>
        /// <returns>Returns rehydrated object of type T.</returns>
        public static T DeserializeXmlString<T>(string XmlString)
        {
            T tempObject = default(T);

            using (MemoryStream memoryStream = new MemoryStream(StringToUTF8ByteArray(XmlString)))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);

                tempObject = (T)xs.Deserialize(memoryStream);
            }

            return tempObject;
        }

        // Convert Array to String
        public static String UTF8ByteArrayToString(Byte[] ArrBytes)
        { return new UTF8Encoding().GetString(ArrBytes); }

        // Convert String to Array
        public static Byte[] StringToUTF8ByteArray(String XmlString)
        { return new UTF8Encoding().GetBytes(XmlString); }


        //public static string SerializeObject(Object obj)
        //{
        //    XmlSerializer ser = new XmlSerializer(obj.GetType());
        //    System.Text.StringBuilder sb = new System.Text.StringBuilder();
        //    System.IO.StringWriter writer = new System.IO.StringWriter(sb);
        //    ser.Serialize(writer, obj);
        //    XmlDocument doc = new XmlDocument();
        //    doc.LoadXml(sb.ToString());
        //    string xml = doc.InnerXml;
        //    return xml;
        //}

        //public static object DeSerializeAnObject(string xml, Type objType)
        //{
        //    XmlDocument doc = new XmlDocument();
        //    doc.LoadXml(xml);
        //    XmlNodeReader reader = new XmlNodeReader(doc.DocumentElement);
        //    XmlSerializer ser = new XmlSerializer(objType);
        //    object obj = ser.Deserialize(reader);
        //    return obj;
        //}

        #endregion
    }
}