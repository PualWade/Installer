using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Installer
{
    class Sender
    {
        RSAParameters rsaPubParams;
        RSAParameters rsaPrivateParams;

        public Sender()
        {
            RSACryptoServiceProvider rsaCSP = new RSACryptoServiceProvider();
            rsaPrivateParams = rsaCSP.ExportParameters(true);
            rsaPubParams = rsaCSP.ExportParameters(false);
        }
        public Sender(byte[] keyD)
        {
            RSAParameters rsaParameters = new RSAParameters();
            rsaParameters.D = keyD;
            rsaPrivateParams = rsaParameters;
            rsaPubParams = rsaParameters;
        }


        public RSAParameters PublicParameters
        {
            get
            {
                return rsaPubParams;
            }
        }

        public byte[] HashAndSign(byte[] encrypted)
        {
            RSACryptoServiceProvider rsaCSP = new RSACryptoServiceProvider();
            SHA1Managed hash = new SHA1Managed();
            byte[] hashedData;

            rsaCSP.ImportParameters(rsaPrivateParams);

            hashedData = hash.ComputeHash(encrypted);
            return rsaCSP.SignHash(hashedData, CryptoConfig.MapNameToOID("SHA1"));
        }

        
        public byte[] EncryptData(RSAParameters rsaParams, byte[] toEncrypt)
        {
            RSACryptoServiceProvider rsaCSP = new RSACryptoServiceProvider();
            
            rsaCSP.ImportParameters(rsaParams);
            return rsaCSP.Encrypt(toEncrypt, false);
        }
    }
}
