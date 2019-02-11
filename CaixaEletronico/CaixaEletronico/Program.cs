using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            var valorCedula = new int[] 
                { 0, 2, 5, 10, 20, 50, 100};
            var qtdCedula = new int[7];
            qtdCedula[0] = 0;
            int combinacoes = 0;
            int q1 = 0;
            int q2 = 0;
            int q3 = 0;
            int q4 = 0;
            int q5 = 0;
            System.Console.WriteLine("Quanto você gostaria de sacar?");
            var valor = int.Parse(System.Console.ReadLine());
            for (int i = 1; i < 6; i++)
            {
                System.Console.WriteLine("Quantas notas de " +
                    "{0} estão disponíveis?", valorCedula[i]);
                qtdCedula[i] = int.Parse(System.Console.ReadLine());
            }

            #region Fores
            for (int i1 = 0; i1 < 6; i1++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    for (int i3 = 0; i3 < 6; i3++)
                    {
                        for (int i4 = 0; i4 < 6; i4++)
                        {
                            for (int i5 = 0; i5 < 6; i5++)
                            {

                                var n1 = valorCedula[1];
                                var n2 = valorCedula[2];
                                var n3 = valorCedula[3];
                                var n4 = valorCedula[4];
                                var n5 = valorCedula[5];

                                var soma5tipos =
                                    n1 * q1 +
                                    n2 * q2 +
                                    n3 * q3 +
                                    n4 * q4 +
                                    n5 * q5;

                                if (soma5tipos == valor)
                                {
                                    combinacoes++;
                                }

                                if (q5 != qtdCedula[i5])
                                {
                                    q5++;
                                    i5--;
                                }
                                else
                                    q5 = 0;
                            }
                            if (q4 != qtdCedula[i4])
                            {
                                q4++;
                                i4--;
                            }
                            else
                                q4 = 0;
                        }
                        if (q3 != qtdCedula[i3])
                        {
                            q3++;
                            i3--;
                        }
                        else
                            q3 = 0;
                    }
                    if (q2 != qtdCedula[i2])
                    {
                        q2++;
                        i2--;
                    }
                    else
                        q2 = 0;
                }
                if (q1 != qtdCedula[i1])
                {
                    q1++;
                    i1--;
                }
                else
                    q1 = 0;
            }
            #endregion
            
        }
    }
}

