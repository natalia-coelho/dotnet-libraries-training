using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_GeradorChavePix
{
    /// <summary>
    /// This class generates a PIX key using a GUID format.
    /// </summary>
    public static class GeradorPix
    {
        /// <summary>
        /// This method returns a random PIX key.
        /// </summary>
        /// <returns>Return a PIX key on String format.</returns>
        public static string GetChavePix()
        {
            return Guid.NewGuid().ToString();
        }
        /// <summary>
        /// Method returns a random list of PIX keys
        /// </summary>
        /// <param name="numeroChaves">Amount of key to be generated.</param>
        /// <returns>returns a list of string format PIX's keys.</returns>
        public static List<string>? GetChavesPix(int numeroChaves)
        {
            if (numeroChaves <= 0)
            {
                return null;
            } 
            else
            {
                var chaves = new List<string>();

                for (int i = 0; i < numeroChaves; i++)
                {
                    chaves.Add(Guid.NewGuid().ToString());
                }
                return chaves;
            }
        }
    }
}
