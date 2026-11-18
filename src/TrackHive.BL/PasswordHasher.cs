using System;
using System.Security.Cryptography;
using System.Text;

namespace TrackHive.BL
{
    public static class PasswordHasher
    {
        private const int Iteraciones = 10000;
        private const int TamSal = 16;
        private const int TamHash = 20;

        public static string Crear(string password)
        {
            byte[] sal = new byte[TamSal];
            using (var rng = RandomNumberGenerator.Create()) { rng.GetBytes(sal); }
            byte[] hash;
            using (var kdf = new Rfc2898DeriveBytes(password, sal, Iteraciones)) { hash = kdf.GetBytes(TamHash); }
            return Iteraciones + ":" + Convert.ToBase64String(sal) + ":" + Convert.ToBase64String(hash);
        }

        public static bool EsProvisional(string almacenado)
        {
            if (almacenado == null || almacenado.Length != 64) return false;
            foreach (char c in almacenado)
            {
                bool hex = (c >= '0' && c <= '9') || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F');
                if (!hex) return false;
            }
            return true;
        }

        public static bool Verificar(string password, string almacenado)
        {
            if (string.IsNullOrEmpty(almacenado)) return false;

            if (EsProvisional(almacenado))
            {
                using (var sha = SHA256.Create())
                {
                    byte[] h = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                    var sb = new StringBuilder();
                    foreach (byte b in h) sb.Append(b.ToString("X2"));
                    return string.Equals(sb.ToString(), almacenado, StringComparison.OrdinalIgnoreCase);
                }
            }

            string[] partes = almacenado.Split(':');
            if (partes.Length != 3) return false;
            int iter;
            if (!int.TryParse(partes[0], out iter)) return false;
            byte[] sal = Convert.FromBase64String(partes[1]);
            byte[] esperado = Convert.FromBase64String(partes[2]);
            byte[] calculado;
            using (var kdf = new Rfc2898DeriveBytes(password, sal, iter)) { calculado = kdf.GetBytes(esperado.Length); }
            int dif = 0;
            for (int i = 0; i < esperado.Length; i++) dif |= esperado[i] ^ calculado[i];
            return dif == 0;
        }
    }
}
