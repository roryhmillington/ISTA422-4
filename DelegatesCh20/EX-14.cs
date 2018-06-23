using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace PasswordCracker

{

    void forceCrack(char hash, int passLength, int maxPassLength)

    

    {

        int i, j, k, l, m, n, o, p, q, r;

        char string1[maxPassLength + 1];

        char alphanum[63] =

            "ABCDEFGHIJKLMNOPQRSTUVWXYZ"



            "abcdefghijklmnopqrstuvwxyz"



            "0123456789";



        for (i = 0; i <= sizeof(string1); i++)

        {

            string1[i] = '\0';

        }

        if (passLength < maxPassLength) // 1 Length 

            for (i = 0; i < strlen(alphanum); i++)

            {    // For every alphanumerical value

                string1[0] = alphanum[i];

                checkPass(hash, string1);       // Checks the string

            }

        passLength++;

        printf("Finished passwords of length %d\n", passLength);

        if (passLength < maxPassLength) // 2 Length

            for (i = 0; i < strlen(alphanum); i++)

            {

                string1[0] = alphanum[i];

                for (j = 0; j < strlen(alphanum); j++)

                {

                    string1[1] = alphanum[j];

                    checkPass(hash, string1);

                }

            }

        passLength++;

        printf("Finished passwords of length %d\n", passLength);

        if (passLength < maxPassLength) // 3 Length

            for (i = 0; i < strlen(alphanum); i++)

            {

                string1[0] = alphanum[i];

                for (j = 0; j < strlen(alphanum); j++)

                {

                    string1[1] = alphanum[j];

                    for (k = 0; k < strlen(alphanum); k++)

                    {

                        string1[2] = alphanum[k];

                        checkPass(hash, string1);

                    }

                }

            }



    }

}